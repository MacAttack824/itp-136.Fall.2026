namespace module._9.CW._2
{
    using static System.Console;
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Jordan", "Gretzky"};
            double[] quiz = new double[3];
            double[] test = new double[3];
            double[] assignment = new double[3];

            for (int x = 0; x < names.Length; x++)
            {
                WriteLine("Please enter the quiz average for {0}", names[x]);
                quiz[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the test average for {0}", names[x]);
                test[x] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the assignment average for {0}", names[x]);
                assignment[x] = Convert.ToDouble(ReadLine());
            }

            WriteLine("{0,11}{1,10}{2,10}{3,15}", "Names", "Quiz", "Test", "Assignment");

            for (int y = 0; y < names.Length; y++)
            {
            WriteLine("{0,11}{1,10}{2,10}{3,15}", names[y], quiz[y], test[y], assignment[y]);
            }

            int i = 0;

            foreach (var name in names)
            {
                double avg;

                avg = (quiz[i] + test[i] + assignment[i]) / 3;

                WriteLine("{0,15},{1,15}", name, avg.ToString("F2"));

                i++;
            }
            double m = quiz.Max();

            int p = Array.IndexOf(quiz, m);

            WriteLine(names[p] + " has the highest quiz grade");

            Array.Sort(names);

            WriteLine(names[0] + " " + names[1] + " " + names[2]);

            ReadKey();
        }
    }
}
