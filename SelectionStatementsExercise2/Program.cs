namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject???");

            string subject = Console.ReadLine().ToLower();

            switch(subject)
            {
                case "history":
                    Console.WriteLine("History.. ok ill wlow it.");
                    break;

                case "math":
                    Console.WriteLine("Math is cool.");
                    break;
                
                case "science":
                    Console.WriteLine("science is the best.");
                        break;

                case "english":
                    Console.WriteLine("English is a subject");
                    break;

                case "physics":
                    Console.WriteLine("Physics is also my favorite.");
                    break;

                default:
                    Console.WriteLine("Not an option");
                    break;


            }
        }
    }
}