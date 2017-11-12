using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PEA_1.Salesman;

namespace PEA_1.Utility
{
    public static class AutoTester
    {
        private static int testsExported = 0;

        /// <summary>
        /// Przyjmuje listę kilku testów i zwraca dla każdego wynik.
        /// </summary>
        /// <param name="tests">Testy do wykonania.</param>
        /// <param name="form">Referencja do interfejsu (potrzebne do wyświetlania informacji o postępach).</param>
        /// <returns>Wyniki testów.</returns>
        public static IEnumerable<TestResult> Multiple(List<Test> tests, FormMain form)
        {
            form.ShowProgress("Start pracy. Ilość zadań: " + tests.Count());
            List<TestResult> testResults = new List<TestResult>();

            foreach (Test test in tests)
            {
                TestResult testResult = new TestResult(test);
                for (int i = 0; i < test.TestAmount; i++)
                {
                    SalesmanData data =
                        new SalesmanData(DataGenerator.Salesman(test.CityAmount, test.LowerBound, test.UpperBound));
                    SalesmanBnB salesman = new SalesmanBnB(data);

                    Clock.Start();
                    salesman.Start();
                    double time = Clock.StopAndReturn();

                    testResult.Times.Add(time);
                    form.ShowProgress("Zadanie " + (tests.IndexOf(test) + 1) + "; wykonane testy: " + (i + 1) + " z " +
                                      test.TestAmount);
                }
                form.ShowProgress("Wykonane zadania: " + (tests.IndexOf(test) + 1) + " z " + tests.Count);
                testResults.Add(testResult);
            }

            return testResults;
        }

        /// <summary>
        /// Pojedynczy test.
        /// </summary>
        /// <param name="test"></param>
        /// <returns>Uśredniony wynik.</returns>
        public static double Single(Test test)
        {
            List<double> times = new List<double>();
            for (int i = 0; i < test.TestAmount; i++)
            {
                SalesmanData data =
                    new SalesmanData(DataGenerator.Salesman(test.CityAmount, test.LowerBound, test.UpperBound));
                SalesmanBnB salesman = new SalesmanBnB(data);

                Clock.Start();
                salesman.Start();
                double time = Clock.StopAndReturn();
                times.Add(time);
            }

            return times.Average();
        }

        /// <summary>
        /// Export wyników testu do pliku .txt.
        /// </summary>
        /// <param name="testResults">Wyniki testu.</param>
        public static void ExportToTxt(IEnumerable<TestResult> testResults)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Od;Do;Ilosc;Powtorzenia;Czas" + Environment.NewLine);
            foreach (TestResult testResult in testResults)
            {
                foreach (double time in testResult.Times)
                {
                    sb.Append(testResult.Test.LowerBound + ";" + testResult.Test.UpperBound + ";" +
                              testResult.Test.CityAmount + ";" + testResult.Test.TestAmount + ";" +
                              time + Environment.NewLine);
                }
            }


            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "results_" + testsExported + ".txt");
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(sb.ToString());
            }

            testsExported++;
        }
    }

    /// <summary>
    /// Zawiera dane dla generatora macierzy + informację o ilości powtórzeń.
    /// </summary>
    public class Test
    {

        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
        public int CityAmount { get; set; }
        public int TestAmount { get; set; }

        public Test(string data)
        {
            string[] splitData = data.Split(';');
            LowerBound = Int32.Parse(splitData[0]);
            UpperBound = Int32.Parse(splitData[1]);
            CityAmount = Int32.Parse(splitData[2]);
            TestAmount = Int32.Parse(splitData[3]);
        }

        public override string ToString()
        {
            return "[<" + LowerBound + ", " + UpperBound + ">, " + CityAmount + " miasta ] x " + TestAmount;
        }
    }

    /// <summary>
    /// Zawiera Test (parametry testu) + wyniki (każda iteracja oddzielnie).
    /// </summary>
    public class TestResult
    {
        public Test Test { get; set; }
        public List<double> Times { get; set; }

        public TestResult(Test test)
        {
            Test = test;
            Times = new List<double>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
