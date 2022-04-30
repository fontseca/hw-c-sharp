using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FourthPractice.Practices
{
    class Runner
    {
        private double _totalDistanceRun;
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        private double CalculateSpeed() =>  this._totalDistanceRun / this.TotalSecondsRun;
       
        override
        public string ToString() => $"{Math.Round(this.CalculateSpeed(), 2)} m/s";

        public double TotalSecondsRun
        {
            get => this.Minutes * 60 + this.Seconds;
        }
        

        public Runner(double totalDistance)
        {
            _totalDistanceRun = totalDistance;
        }
    }

    internal class Practice2
    {
        public void Start()
        {
            try
            {
                string runnersData;
                bool isInputValid;
                double totalDistance = 1500;
                var runnersList = new List<Runner>();
                Match match;

                do
                {
                    Write("Total distance: (1500 m) ");
                    string distance = ReadLine();

                    // if total distance is ignored then use default amount
                    totalDistance = distance.Equals("") ? 1500 : Convert.ToDouble(distance);

                    WriteLine("(<minutes>, <seconds>)[, ...], (0, 0)");
                    Write("Runners input: ");
                    runnersData = ReadLine();

                    if (!(isInputValid = Regex.IsMatch(runnersData, @"^(?:\((?:\d(?:\.\d)?)+, (?:\d(?:\.\d)?)+\), )+(?:\(0, 0\))$")))
                    {
                        Clear();
                        WriteLine("Format is not valid. Try again.");
                    }
                } while (!isInputValid);

                // get the groups and generate the runners
                match = Regex.Match(runnersData, @"\((\d+(?:\.\d+)?)+, (\d+(?:\.\d+)?)+\)");
                while (match.Success)
                {
                    var first = match.Groups[1].Value;
                    var second = match.Groups[2].Value;

                    if (first.Equals("0") && second.Equals("0")) break;
                    runnersList.Add(new Runner(totalDistance) { Minutes = double.Parse(first), Seconds = double.Parse(second) });
                    match = match.NextMatch();
                }

                // Print runners data
                Clear();
                WriteLine("Speeds ({0} m):\n", totalDistance);
                for (int i = 0; i < runnersList.Count; i++) WriteLine($"Runner #{i + 1}: {runnersList[i]} (Ran {runnersList[i].TotalSecondsRun} seg)");
                WriteLine("");

            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
