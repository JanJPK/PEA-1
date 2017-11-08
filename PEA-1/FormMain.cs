using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEA_1.Salesman;
using PEA_1.Utility;

namespace PEA_1
{
    public partial class FormMain : Form
    {
        #region Zmienne

        // Lista zawierająca dane wejściowe.
        public List<int> InputList { get; private set; }

        // Algorytmy, ich zegary i dane.
        private SalesmanData salesmanData;

        private SalesmanDynamic salesmanDynamic;
        private SalesmanGenetic salesmanGenetic;
        private SalesmanLocalSearch salesmanLocalSearch;

        //private Clock salesmanDynamicClock;
        //private Clock salesmanGeneticClock;
        //private Clock salesmanLocalSearchClock;

        // Repetycja.
        private int repeat;

        #endregion

        public FormMain()
        {
            InitializeComponent();

            //textBoxLoadDataFilename.Text = "tsp_6_2";
            //radioButtonLoadDataSalesman.Checked = true;

            checkBoxSalesmanDynamic.Checked = true;
            //checkBoxSalesmanLocalSearch.Checked = true;
            //checkBoxSalesmanGenetic.Checked = true;

            textBoxLoadDataFilename.Text = "tsp_w";

            textBoxDataGeneratorSize.Text = "100";

            repeat = 1;
            textBoxRepeatCurrent.Text = repeat.ToString();
        }

        #region Eventy WinForms
        //
        //
        // Start komiwojażera.
        private void buttonSalesman_Click(object sender, EventArgs e)
        {
            if (salesmanData != null)
            {
                if (checkBoxSalesmanDynamic.Checked)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        salesmanDynamic = new SalesmanDynamic(salesmanData);
                        //salesmanDynamicClock = new Clock(salesmanDynamic);
                        //salesmanDynamicClock.Start();
                        salesmanDynamic.Start();
                        //salesmanDynamicClock.Stop();
                    }
                    //salesmanDynamicClock.End();
                    //textBoxSalesmanDynamic.Text = salesmanDynamicClock.Average().ToString();
                }

                //if (checkBoxSalesmanLocalSearch.Checked)
                //{
                //    for (int i = 0; i < repeat; i++)
                //    {
                //        salesmanLocalSearch = new SalesmanLocalSearch(salesmanData);
                //        salesmanLocalSearchClock = new Clock(salesmanLocalSearch);
                //        salesmanLocalSearchClock.Start();
                //        salesmanLocalSearch.Work();
                //        salesmanLocalSearchClock.Stop();
                //    }
                //    salesmanLocalSearchClock.End();
                //    textBoxSalesmanLocalSearch.Text = salesmanLocalSearchClock.Average().ToString();
                //}

                //if (checkBoxSalesmanGenetic.Checked)
                //{
                //    for (int i = 0; i < repeat; i++)
                //    {
                //        salesmanGenetic = new SalesmanGenetic(salesmanData);
                //        salesmanGeneticClock = new Clock(salesmanGenetic);
                //        salesmanGeneticClock.Start();
                //        salesmanGenetic.Work();
                //        salesmanGeneticClock.Stop();
                //    }
                //    salesmanGeneticClock.End();
                //    textBoxSalesmanGenetic.Text = salesmanGeneticClock.Average().ToString();
                //}
            }
            else
            {
                MessageBox.Show("Dane nie zostały wczytane!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - Dynamic.
        private void buttonSalesmanDynamic_Click(object sender, EventArgs e)
        {
            if (salesmanDynamic != null)
            {
                FormDisplay fD = new FormDisplay(salesmanDynamic.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - poszukiwane lokalne.
        private void buttonSalesmanLocalSearch_Click(object sender, EventArgs e)
        {
            if (salesmanLocalSearch != null)
            {
                FormDisplay fD = new FormDisplay(salesmanLocalSearch.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wyniku komiwojażera - Genetyczny.
        private void buttonSalesmanGenetic_Click(object sender, EventArgs e)
        {
            if (salesmanGenetic != null)
            {
                FormDisplay fD = new FormDisplay(salesmanGenetic.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        // Wyświetlanie wszystkich wyników - komiwjoażer.
        private void buttonSalesmanAll_Click(object sender, EventArgs e)
        {
            if (salesmanDynamic != null)
            {
                FormDisplay fD = new FormDisplay(salesmanDynamic.ToString());
                fD.Show();
            }
            if (salesmanLocalSearch != null)
            {
                FormDisplay fD = new FormDisplay(salesmanLocalSearch.ToString());
                fD.Show();
            }
            if (salesmanGenetic != null)
            {
                FormDisplay fD = new FormDisplay(salesmanGenetic.ToString());
                fD.Show();
            }
        }
        //
        //
        // Wczytywanie danych.
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            ReadFile(textBoxLoadDataFilename.Text);
            salesmanData = new SalesmanData(InputList);
        }
        //
        //
        // Wyświetlanie wczytanych danych.
        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            FormDisplay fD = new FormDisplay(salesmanData.ToString());
            fD.Show();
        }
        //
        //
        // Zmiana koloru textBox z nazwą pliku przy zmianie tekstu.
        private void textBoxLoadDataFilename_TextChanged(object sender, EventArgs e)
        {
            textBoxLoadDataFilename.BackColor = SystemColors.Window;
        }
        //
        //
        // Tworzenie danych.
        private void buttonDataGenerator_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(textBoxDataGeneratorSize.Text, out size))
            {
                MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesmanData = null;
                return;
            }

            salesmanData = new SalesmanData(DataGenerator.Salesman(size));
            textBoxLoadDataFilename.BackColor = Color.MediumAquamarine;
            textBoxLoadDataFilename.Text = "RANDOM";
        }
        //
        //
        // Zmiana mnożnika
        private void buttonRepeatChange_Click(object sender, EventArgs e)
        {
            int repeatNew;
            if (!int.TryParse(textBoxRepeatNew.Text, out repeatNew))
            {
                MessageBox.Show("Nieprawidłowy mnożnik", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputList = null;
                return;
            }
            repeat = repeatNew;
            textBoxRepeatCurrent.Text = repeat.ToString();
            textBoxRepeatNew.Text = "";
        }
        #endregion

        #region Funkcje
        //
        //
        // Wczytywanie z pliku.
        private void ReadFile(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@".\" + filename + ".txt"))
                {
                    //  ASCII   symbol
                    //  48      0
                    //  57      9
                    InputList = new List<int>();
                    int amount = 0;
                    while (!sr.EndOfStream)
                    {
                        string number = "";
                        int character = sr.Read();
                        while (character >= 48 && character <= 57)
                        {
                            number += (char)character;
                            character = sr.Read();
                        }

                        if (number != "")
                        {
                            int intNumber;
                            if (!int.TryParse(number, out intNumber))
                            {
                                MessageBox.Show("Nieprawidłowa liczba", "Błąd",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                InputList = null;
                                return;
                            }
                            InputList.Add(intNumber);
                        }

                    }

                    // Plik załadowany -> zielony kolor.
                    textBoxLoadDataFilename.BackColor = Color.MediumAquamarine;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Plik nie został załadowany -> czerwony kolor.
                this.BackColor = Color.MediumVioletRed;
                throw;
            }
        }
        #endregion

    }
}
