using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Priority_Queue;

namespace PEA_1.Salesman
{
    internal class SalesmanBnB
    {
        // Dane wczytane z pliku lub wygenerowane.
        private readonly SalesmanData data;

        // Optymalna droga.
        private string path;

        // Skrócona droga.
        private string shortPath;

        // Optymalny dystans.
        private int finalDistance;

        // Macierz po przekształceniu M[x,x] = Int32.MaxValue
        private readonly int[,] matrix;

        // Rozmiar macierzy.
        private readonly int size;
        
        /// <summary>
        ///     Konstruktor przyjmujący dane i przetwarza je - ten algorytm potrzebuje Int32.MaxValue na głównej przekątnej zamiast 0.
        /// </summary>
        /// <param name="data">Obiekt zawierający dane (macierz + rozmiar).</param>
        public SalesmanBnB(SalesmanData data)
        {
            this.data = data;
            matrix = (int[,]) data.Matrix.Clone();
            size = data.Size;
            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = int.MaxValue;
            }
        }

        /// <summary>
        ///     Start algorytmu
        /// </summary>
        public void Start()
        {
            SimplePriorityQueue<Node> queue = new SimplePriorityQueue<Node>();

            // Korzeń drzewa trafia na początek kolejki.
            Node root = new Node(matrix, new List<Tuple<int, int>>(), -1, 0, 0);
            SetLowerBound(root);
            queue.Enqueue(root, root.LowerBound);

            bool leafReached = false;
            while (queue.Count > 0 && !leafReached)
            {
                Node poppedNode = queue.Dequeue();

                if (poppedNode.Level == size - 1)
                {
                    // Doszliśmy do liścia => tworzymy połączenie z miastem startowym.
                    poppedNode.Path.Add(new Tuple<int, int>(poppedNode.ID, 0));
                    GeneratePath(poppedNode);
                    finalDistance = poppedNode.LowerBound;
                    leafReached = true;
                }
                else
                {
                    // Przetwarzamy każde dziecko danego węzła.
                    for (int i = 0; i < poppedNode.Matrix.GetLength(0); i++)
                    {
                        if (poppedNode.Matrix[poppedNode.ID, i] != int.MaxValue)
                        {
                            Node child = new Node(poppedNode.Matrix, poppedNode.Path, poppedNode.ID, i,
                                poppedNode.Level + 1);
                            SetLowerBound(child);
                            child.LowerBound += poppedNode.LowerBound + poppedNode.Matrix[poppedNode.ID, i];
                            queue.Enqueue(child, child.LowerBound);
                        }
                    }
                }
            }
        }

        #region Wyznaczanie LB
        /// <summary>
        ///     Wyliczenie LB dla danego miasta.
        /// </summary>
        /// <param name="node">Zadane miasto.</param>
        private void SetLowerBound(Node node)
        {
            int a = ReduceRow(node);
            int b = ReduceColumn(node);
            node.LowerBound = a + b;
        }

        /// <summary>
        ///     Tworzy tablicę wypełnioną Int32.MaxValue o zadanej wielkości.
        /// </summary>
        /// <param name="size">Rozmiar tablicy.</param>
        /// <returns>Tablica wypełniona In32.MaxValue.</returns>
        private int[] Int32MaxValueArray(int size)
        {
            List<int> minValues = new List<int>();
            for (int i = 0; i < size; i++)
            {
                minValues.Add(int.MaxValue);
            }
            return minValues.ToArray();
        }

        /// <summary>
        ///     Wyznaczanie i odejmowanie minimum dla każego rzędu.
        /// </summary>
        /// <param name="node">Zadane miasto.</param>
        /// <returns>Suma minimum.</returns>
        private int ReduceRow(Node node)
        {
            int totalReduced = 0;
            int[] minValues = Int32MaxValueArray(size);

            // Poszukiwanie najmniejszych wartości w wierszach.
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (node.Matrix[i, j] < minValues[i])
                    {
                        minValues[i] = node.Matrix[i, j];
                    }
                }
            }

            // Sumowanie znalezionych minimum.
            foreach (int i in minValues)
            {
                if (i != int.MaxValue)
                {
                    totalReduced += i;
                }
            }

            // Odejmowanie.
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (node.Matrix[i, j] != int.MaxValue && minValues[i] != int.MaxValue)
                    {
                        node.Matrix[i, j] -= minValues[i];
                    }
                }
            }

            return totalReduced;
        }

        /// <summary>
        ///     Wyznaczanie i odejmowanie minimum dla każej kolumny.
        /// </summary>
        /// <param name="node">Zadane miasto.</param>
        /// <returns>Suma minimum.</returns>
        private int ReduceColumn(Node node)
        {
            int totalReduced = 0;
            int[] minValues = Int32MaxValueArray(node.Matrix.GetLength(1));

            // Poszukiwanie najmniejszych wartości w kolumnach.
            for (int i = 0; i < node.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < node.Matrix.GetLength(1); j++)
                {
                    if (node.Matrix[j, i] < minValues[i])
                    {
                        minValues[i] = node.Matrix[j, i];
                    }
                }
            }

            // Sumowanie znalezionych minimum.
            foreach (int i in minValues)
            {
                if (i != int.MaxValue)
                {
                    totalReduced += i;
                }
            }

            // Odejmowanie.
            for (int i = 0; i < node.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < node.Matrix.GetLength(1); j++)
                {
                    if (node.Matrix[j, i] != int.MaxValue && minValues[i] != int.MaxValue)
                    {
                        node.Matrix[j, i] -= minValues[i];
                    }
                }
            }

            return totalReduced;
        }
        #endregion

        #region Konwersja wyniku do string i wypisywanie
        /// <summary>
        ///     Na potrzeby zapisu wyników do pliku.
        /// </summary>
        /// <returns>Typ algorytmu.</returns>
        public string Type()
        {
            return "bnb";
        }

        /// <summary>
        ///     Konwertowanie ścieżki do string.
        /// </summary>
        /// <param name="leaf">Liść drzewa.</param>
        private void GeneratePath(Node leaf)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            foreach (Tuple<int, int> tuple in leaf.Path)
            {
                sb1.Append(tuple.Item1 + " -> " + tuple.Item2 + " | " + data.Matrix[tuple.Item1, tuple.Item2] + Environment.NewLine );
                sb2.Append(tuple.Item1 + " -> ");
            }
            sb2.Append(leaf.Path.Last().Item2);
            path = sb1.ToString();
            shortPath = sb2.ToString();
        }

        /// <summary>
        ///     Override do wypisywania
        /// </summary>
        /// <returns>Wynik w formie tekstowej.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Problem komiwojażera - algorytm B&B." + Environment.NewLine);
            sb.Append("Suma wag: " + finalDistance + Environment.NewLine);
            sb.Append("Droga: " + Environment.NewLine + path + Environment.NewLine + shortPath);
            return sb.ToString();
        }
        #endregion
    }

    /// <summary>
    ///     Węzeł drzewa.
    /// </summary>
    internal class Node
    {
        // Macierz bez zbędnych wierszy i kolumn.
        public int[,] Matrix { get; set; }

        // Przechowuje ścieżkę.
        public List<Tuple<int, int>> Path { get; set; }

        // Miasto.
        public int ID { get; set; }

        // Koszt.
        public int LowerBound { get; set; }

        // Poziom drzewa.
        public int Level { get; set; }

        public Node(int[,] matrix, List<Tuple<int, int>> path, int start, int destination, int level)
        {
            Matrix = (int[,]) matrix.Clone();
            Path = new List<Tuple<int, int>>(path);
            Level = level;
            ID = destination;

            if (Level > 0)
            {
                Path.Add(new Tuple<int, int>(start, destination));

                // Wiersz i oraz kolumna j = Int32.MaxValue
                for (int k = 0; k < Matrix.GetLength(0); k++)
                {
                    Matrix[start, k] = int.MaxValue;
                    Matrix[k, destination] = int.MaxValue;
                }
            }

            // [j, start]
            Matrix[destination, 0] = int.MaxValue;
        }
    }
}
