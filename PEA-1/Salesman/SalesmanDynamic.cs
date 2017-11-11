using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEA_1.Salesman
{
    // https://en.wikipedia.org/wiki/Held%E2%80%93Karp_algorithm
    internal class SalesmanDynamic : ISalesman
    {
        // Lista miast.
        private readonly List<int> cities;

        // Dane wczytane z pliku lub wygenerowane.
        private readonly SalesmanData data;

        // Koszt ściezki.
        private int finalDistance;

        // Wybrana ścieżka.
        private readonly List<int> path;

        /// <summary>
        ///     Konstruktor przyjmujący dane i wypełniający listę cities liczbami z zakresu [0, data.Size].
        /// </summary>
        /// <param name="data">Obiekt zawierający dane (macierz + rozmiar).</param>
        public SalesmanDynamic(SalesmanData data)
        {
            this.data = data;
            path = new List<int>();
            cities = new List<int>();
            for (int i = 0; i < data.Size; i++)
            {
                cities.Add(i);
            }
        }

        /// <summary>
        ///     Start algorytmu
        /// </summary>
        public void Start()
        {
            int startingCity = cities[0];

            // HashSet<int> set to S[] z g(x, S[]).
            HashSet<int> set = new HashSet<int>(cities);
            // Pierwsze miasto usunięte z listy; zostanie ono parametrem x dla pierwszego wywołania.
            set.Remove(startingCity);

            // Wywołanie głównej metody rekurencyjnej.
            Node root = new Node();
            finalDistance = Recursion(startingCity, set, root);

            // Przetwarzanie obiektów Node i tworzenie ścieżki.
            path.Add(startingCity);
            FindPath(root);
        }

        /// <summary>
        ///     Rekurencyjne rozwiązywanie problemu.
        /// </summary>
        /// <param name="startingCity">Parametr x w g(x, S[]).</param>
        /// <param name="set">Zestaw S w g(x, S[]).</param>
        /// <param name="node">Dodatkowy obiekt który pozwoli odwtorzyć ścieżkę.</param>
        /// <returns></returns>
        private int Recursion(int startingCity, HashSet<int> set, Node node)
        {
            int bestDistance;
            if (set.Count > 0)
            {
                bestDistance = int.MaxValue;
                node.Children = new Node[set.Count];
                int bestCity = 0;
                int i = 0;

                // Przykład: Recursion(a, set[b, c])
                // i = 0 => currentCity = b
                // currentDistance = data.Matrix[a, b] + Recursion(b, set[c])
                // Matematycznie:    c(ab)             + g(b, {c})
                foreach (var currentCity in set)
                {
                    node.Children[i] = new Node(currentCity);

                    // Zestaw pomniejszony o aktualnie przetwarzanie miasto.
                    HashSet<int> nextSet = new HashSet<int>(set);
                    nextSet.Remove(currentCity);

                    // Nowy dystans.
                    //int currentDistance = Recursion(currentCity, nextSet, node.Children[i]) + data.Matrix[startingCity, currentCity];
                    int a = Recursion(currentCity, nextSet, node.Children[i]);
                    int b = data.Matrix[startingCity, currentCity];
                    int currentDistance = a + b;

                    if (bestDistance > currentDistance)
                    {
                        bestDistance = currentDistance;
                        bestCity = i;
                    }

                    i++;
                }

                node.Children[bestCity].Selected = true;
            }
            else
            {
                // Przypadek w którym następuje powrót do miasta startowego - set został opróżniony.
                bestDistance = data.Matrix[startingCity, 0];
                node.Children = new[] {new Node(cities[0], true)};
            }
            return bestDistance;
        }

        /// <summary>
        ///     Funkcja wypełniająca tablice zawierającą optymalną ścieżkę.
        /// </summary>
        /// <param name="node">Obecnie przetwarzany węzeł.</param>
        private void FindPath(Node node)
        {
            if (node.Children != null)
            {
                foreach (Node child in node.Children)
                {
                    if (child.Selected)
                    {
                        path.Add(child.ID);
                        FindPath(child);
                    }
                }
            }
        }

        /// <summary>
        ///     Na potrzeby zapisu wyników do pliku.
        /// </summary>
        /// <returns>Typ algorytmu.</returns>
        public string Type()
        {
            return "dynamic";
        }

        /// <summary>
        ///     Override do wypisywania
        /// </summary>
        /// <returns>Wynik w formie tekstowej.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - algorytm dynamiczny." + Environment.NewLine);
            sb.Append("Suma wag: " + finalDistance + Environment.NewLine);
            sb.Append("Droga: " + Environment.NewLine);
            StringBuilder fullPath = new StringBuilder();
            for (int i = 0; i < path.Count - 1; i++)
            {
                fullPath.Append(path[i] + " -> ");
                sb.Append(path[i] + " -> " + path[i + 1] + " / " + data.Matrix[path[i], path[i + 1]] +
                          Environment.NewLine);
            }
            fullPath.Append(path.Last());
            sb.Append(Environment.NewLine + fullPath);

            return sb.ToString();
        }
    }

    /// <summary>
    ///     Obiekty pozwalające odnaleźć ścieżkę po zakończeniu obliczeń.
    /// </summary>
    internal class Node
    {
        public int ID { get; set; }
        public bool Selected { get; set; }
        public Node[] Children { get; set; }

        public Node(int id, bool selected = false)
        {
            ID = id;
            Selected = selected;
        }

        public Node()
        {
        }

        public override string ToString()
        {
            return "ID: " + ID + " Selected: " + Selected + " Children.Count: " + Children.Length + " " +
                   Environment.NewLine +
                   Children;
        }
    }
}