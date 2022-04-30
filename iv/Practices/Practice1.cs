using static System.Console;

namespace FourthPractice.Practices
{
    internal class Practice1
    {
        public void Start()
        {
            Clear();
            WriteLine("Series:");
            for (int i = 4; i <= 400; i += 4) Write(i != 400 ? $"{i}, " : $"{i}\n\n");
        }
    }
}
