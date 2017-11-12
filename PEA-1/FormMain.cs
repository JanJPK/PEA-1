using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PEA_1.Salesman;
using PEA_1.Utility;

namespace PEA_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            tests = new List<Test>();

            folder = new SourceFolder();
            folder.ProcessDirectory();
            folder.PopulateFilenameList();
            comboBoxLoadDataFilenames.DataSource = folder.Filenames;
            comboBoxLoadDataFilenames.DropDownStyle = ComboBoxStyle.DropDownList;

            checkBoxSalesmanBnB.Checked = true;
            //checkBoxSalesmanLocalSearch.Checked = true;
            //checkBoxSalesmanGenetic.Checked = true;
        }

        #region Zmienne

        // Lista zawierająca dane wejściowe.
        public List<int> InputList { get; private set; }

        // Algorytmy, i ich dane.
        private SalesmanData salesmanData;

        private SalesmanGenetic salesmanGenetic;
        private SalesmanLocalSearch salesmanLocalSearch;
        private SalesmanBnB salesmanBnB;

        // AutoTest.
        private readonly List<Test> tests;

        // Przetwarzanie folderu z exe.
        private readonly SourceFolder folder;

        #endregion

        #region Eventy WinForms

        /// <summary>
        ///     Start komiwojażera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalesman_Click(object sender, EventArgs e)
        {
            if (salesmanData != null)
            {
                if (checkBoxSalesmanBnB.Checked)
                {
                    salesmanBnB = new SalesmanBnB(salesmanData);
                    Clock.Start();
                    salesmanBnB.Start();
                    textBoxSalesmanBnB.Text = Clock.StopAndReturn().ToString();
                }
            }
            else
            {
                MessageBox.Show("Dane nie zostały wczytane!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Wyświetlanie wyniku komiwojażera - BnB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalesmanBnB_Click(object sender, EventArgs e)
        {
            if (salesmanBnB != null)
            {
                FormDisplay fD = new FormDisplay(salesmanBnB.ToString());
                fD.Show();
            }
            else
            {
                MessageBox.Show("Nie ma czego wyświetlać!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Wyświetlanie wyniku komiwojażera - poszukiwane lokalne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     Wyświetlanie wyniku komiwojażera - Genetyczny.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///     Wyświetlanie wszystkich wyników - komiwjoażer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalesmanAll_Click(object sender, EventArgs e)
        {
            if (salesmanBnB != null)
            {
                FormDisplay fD = new FormDisplay(salesmanBnB.ToString());
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

        /// <summary>
        ///     Wczytywanie danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            ReadFile(folder.FilePaths[comboBoxLoadDataFilenames.SelectedIndex]);
            salesmanData = new SalesmanData(InputList);
        }

        /// <summary>
        ///     Wyświetlanie wczytanych danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplayData_Click(object sender, EventArgs e)
        {
            FormDisplay fD = new FormDisplay(salesmanData.ToString());
            fD.Show();
        }

        /// <summary>
        ///     Zmiana koloru przycisku gdy zmieniamy wybrany plik w comboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLoadDataFilenames_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLoadData.BackColor = SystemColors.Control;
        }

        /// <summary>
        ///     Dodaj Test do listy zadań.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAutoAddTest_Click(object sender, EventArgs e)
        {
            Test test = new Test(textBoxAutoTestData.Text);
            tests.Add(test);
            textBoxAutoPlannedTests.AppendText(test + Environment.NewLine);
        }

        /// <summary>
        ///     Uruchm AutoTester.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAutoStart_Click(object sender, EventArgs e)
        {
            AutoTester.ExportToTxt(AutoTester.Multiple(tests, this));
            tests.Clear();
            textBoxAutoPlannedTests.Clear();
        }

        #endregion

        #region Funkcje

        /// <summary>
        ///     Wczytywanie z pliku.
        /// </summary>
        /// <param name="filepath"></param>
        private void ReadFile(string filepath)
        {
            try
            {
                //using (StreamReader sr = new StreamReader(@".\" + filename + ".txt"))
                using (StreamReader sr = new StreamReader(filepath))
                {
                    //  ASCII   symbol
                    //  48      0
                    //  57      9
                    InputList = new List<int>();
                    while (!sr.EndOfStream)
                    {
                        string number = "";
                        int character = sr.Read();
                        while (character >= 48 && character <= 57)
                        {
                            number += (char) character;
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
                    buttonLoadData.BackColor = Color.MediumAquamarine;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Plik nie został załadowany -> czerwony kolor.
                buttonLoadData.BackColor = Color.MediumVioletRed;
                throw;
            }
        }

        /// <summary>
        ///     Wyświetlanie postępu testowania.
        /// </summary>
        /// <param name="message">Wiadomość od AutoTester.</param>
        public void ShowProgress(string message)
        {
            textBoxAutoProgress.Text = message;
        }

        #endregion
    }
}