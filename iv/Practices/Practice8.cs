using System;
using System.ComponentModel;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FourthPractice.Practices
{
    public class LetterToMatch
    {
        public string Letter { get; set; }
        public int Index { get; set; }
    }

    public class SecretWord
    {
        public string Secret { get; set; }
        public List<LetterToMatch> Letters;
        public void ShowLetter(int index)
        {
            string tmpSecret = "";
            int tmpIndex = 0;
            string tmpLetter = "";

            foreach (LetterToMatch l in Letters)
                if (l.Index == index)
                {
                    // future assert: remove 'l' from 'Letters'
                    tmpIndex = l.Index;
                    tmpLetter = l.Letter;
                }
            // replace _ with match
            for (int i = 0; i < Secret.Length; ++i)
                tmpSecret += i == tmpIndex ? tmpLetter : Secret[i].ToString();
            Secret = tmpSecret;
        }
    }

    internal class Practice8
    {
        private static readonly HttpClient client = new HttpClient();
        public void Start()
        {
            try
            {
                string again = "";
                do
                {
                    // start game
                    Clear();
                    string randomAnimal = GetRandomWord();
                    SecretWord s = GetSecretWord(randomAnimal);
                    string c;
                    int att = s.Letters.Count;

                    do
                    {
                        Clear();
                        WriteLine($"You have {att} attempts.\n");
                        WriteLine(s.Secret);

                        if (s.Secret.Contains("_"))
                        {
                            Write("> ");
                            c = ReadLine();
                            c = c.Trim().Equals("") ? "" : c[0].ToString();
                        } else
                        {
                            WriteLine("You Win!!");
                            break;
                        }

                        // if match, then replace _ with match
                        if (s.Letters.Exists(l => l.Letter.Equals(c)))
                        {
                            s.ShowLetter(s.Letters.Find(l => l.Letter.Equals(c)).Index);
                            continue;
                        }

                        att--;
                    } while (att > 0);

                    if (att == 0)
                        WriteLine("Game Over.");

                    Write("Play again [Y/n]?: ");
                    again = ReadLine();
                } while (again.Equals("y"));
            } catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        private string GetRandomWord()
        {
            Write("Getting random animal... ");
            HttpResponseMessage res = client.GetAsync("https://random-animal-api.herokuapp.com/animal?lang=es").Result;
            res.EnsureSuccessStatusCode();
            string animal = res.Content.ReadAsStringAsync().Result;
            WriteLine("Done");
            WriteLine(animal);
            var match = Regex.Match(animal, @"([\wáéíóú-]+)");
            if (match.Success)
                match = match.NextMatch();
            animal = match.Success ? match.Groups[1].Value : "elephant";
            return animal;
        }

        private SecretWord GetSecretWord(string word)
        {
            SecretWord s = new SecretWord();
            Random random = new Random();
            string secret = "";
            int len = word.Length;
            int hide = len / 2;
            int[] indexes = new int[hide];

            // generate the random numbers to hide letters
            for (int i = 0; i < hide; i++)
            {
                var r = random.Next(len);
                if (indexes.Contains(r)) // don't continue until you have a new random number
                {
                    i--;
                    continue;
                }
                indexes[i] = r;
            }

            // hide indexed letters
            for (int i = 0; i < len; i++)
                if (indexes.Contains(i))
                    secret += "_";
                else secret += word[i];

            s.Secret = secret;
            s.Letters = new List<LetterToMatch>();

            foreach (int i in indexes)
                s.Letters.Add(new LetterToMatch() { Letter = word[i].ToString(), Index = i });
            return s;
        }
    }
}
