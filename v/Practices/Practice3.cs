using static System.Console;
using System.Collections.Generic;

namespace FifthPractice.Practices
{
    internal class Practice3
    {
        public void Start()
        {
            string itemName = "";
            double itePrice = 0;
            int itemAmount = 0;
            double total = 0;
            var map = new Dictionary<string, double>();

            while (true)
            {
                Clear();
                WriteLine("Type '0' to exit.");

                Write("Item #{0}: ", map.Count + 1);
                itemName = ReadLine();

                if (itemName.Equals("0")) break;

                Clear();
                Write("Item amount: ");
                itemAmount = int.Parse(ReadLine());

                if (itemAmount < 0) continue;

                Clear();
                Write("Item price: ");
                itePrice = double.Parse(ReadLine());

                if (itePrice < 0) continue;

                total = itePrice * itemAmount;
                map.Add(itemName, total);
            }

            total = 0;

            WriteLine("\n\nINVOICE:\n");
            foreach (string key in map.Keys)
            {
                WriteLine("Item:\t{0}\t\tAmout:\t${1}", key, map[key]);
                total += map[key];
            }

            WriteLine("\nTotal:\t${0}\n", total);
        }
    }
}
