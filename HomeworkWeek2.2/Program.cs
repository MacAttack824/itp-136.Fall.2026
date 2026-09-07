namespace HomeworkWeek2._2
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            // declare variable for patient name
            string patientName;
            // program begins with appointment of patient
            WriteLine("who is being seen today");
            // ask user for patient name
            patientName = ReadLine();
            // greet patient
            WriteLine("welcome: " + patientName);


        }
    }
}
