namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            var r = new Random();
            var favNumber = 12;
            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());


            if (userInput > favNumber)
            {
                Console.WriteLine("Wrong guess again!");
            }
            else if (favNumber > userInput)
            {
                Console.WriteLine("Nice try, guess agian!");
            }
            else
            {

                Console.WriteLine("CORRECT!");
            }

            
            
            



            
          
        }
    }
}
