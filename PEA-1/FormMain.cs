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
        #region Zmienne

        // Lista zawierająca dane wejściowe.
        public List<int> InputList { get; private set; }

        // Algorytmy, i ich dane.
        private SalesmanData salesmanData;
        private SalesmanDynamic salesmanDynamic;
        private SalesmanGenetic salesmanGenetic;
        private SalesmanLocalSearch salesmanLocalSearch;

        // AutoTest.
        private List<Test> tests; 

        // Przetwarzanie folderu z exe.
        private readonly SourceFolder folder;

        // Repetycja.
        private int repeat;

        #endregion

        public FormMain()
        {
            InitializeComponent();

            tests = new List<Test>();

            folder = new SourceFolder();
            folder.ProcessDirectory();
            folder.PopulateFilenameList();
            comboBoxLoadDataFilenames.DataSource = folder.Filenames;
            comboBoxLoadDataFilenames.DropDownStyle = ComboBoxStyle.DropDownList;

            checkBoxSalesmanDynamic.Checked = true;
            //checkBoxSalesmanLocalSearch.Checked = true;
            //checkBoxSalesmanGenetic.Checked = true;

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
                        salesmanDynamic.Start();
                    }
                }
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
            ReadFile(folder.FilePaths[comboBoxLoadDataFilenames.SelectedIndex]);
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
            //textBoxLoadDataFilename.BackColor = Color.MediumAquamarine;
            //textBoxLoadDataFilename.Text = "RANDOM";
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

        #endregion

        private void comboBoxLoadDataFilenames_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonLoadData.BackColor = SystemColors.Control;
        }

        public void ShowProgress(string message)
        {
            textBoxAutoProgress.Text = message;
        }

        private void buttonAutoAddTest_Click(object sender, EventArgs e)
        {
            Test test = new Test(textBoxAutoTestData.Text);
            tests.Add(test);
            textBoxAutoPlannedTests.AppendText(test + Environment.NewLine);
        }

        private void buttonAutoStart_Click(object sender, EventArgs e)
        {
            AutoTester.ExportToTxt(AutoTester.Multiple(tests, this));
            tests.Clear();
            textBoxAutoPlannedTests.Clear();
        }
    }

}
