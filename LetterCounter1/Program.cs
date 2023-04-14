namespace LetterCounter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Write a word: ");
                string str = Console.ReadLine();

                while (str.Length > 0)
                {
                    Console.Write(str[0] + " = ");
                    int counter = 0;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[0] == str[j])
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine(counter);
                    str = str.Replace(str[0].ToString(), string.Empty);
                }

                Console.ReadLine();
        }
    }
}