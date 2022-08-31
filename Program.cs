
using Mastermind;

class Caller
{
    public static void Main(string[] args)
    {   
        Gamestate gamestate = new Gamestate();
        int tries = 10;
        string userInput = "";
        //for testing purposes, this prints the answer key if uncommented
       
        /* Console.Write("Answer Key: ");
        foreach (int number in gamestate.answerNumbers) {
            Console.Write(number);
        
        }
       */
        Console.WriteLine();
        while (tries != 0) {
            while (!gamestate.CheckForValidAnswer(userInput))
            {
                Console.WriteLine("Please enter your four digit guess");
                userInput = Console.ReadLine();
            }
            
            gamestate.AnswerCheck(userInput);

            if (gamestate.isWon) 
            {
                Console.WriteLine("Correct! The player wins!");
                break;
            }
            userInput = "";
            tries --;
            if (tries == 0)
            {
                Console.WriteLine("Thats 10 tries! The player lost. The answer was " + string.Join("", gamestate.answerNumbers));
            }
        }

      
        


    }
}
