using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind;

public class Gamestate
{
    public List<int> answerNumbers = new List<int>();
    public bool isWon = false;
    //public List<char> winCondition = new List<char>();
    //public List<char> correctNumbers = new List<char>();
    Random rnd = new Random();
        
    public Gamestate()
    {
        CreateAnswer();
    }
    //generates the answer key for the player to guess (no duplicates)
    public void CreateAnswer() 
    { 
        for(int i = 0; answerNumbers.Count < 4; i++){
            int randomNumber = rnd.Next(1,7);
            if (!answerNumbers.Contains(randomNumber)){
                answerNumbers.Add(randomNumber);
            }
        }    

    }
    //checks for userinput and makes sure it is in the correct format
    public bool CheckForValidAnswer(string userAnswer)
    {
        if (userAnswer.Length != 4)
        {
            return false;
        }
        for (int i = 0; i < userAnswer.Length; i++)
        {
            if (!Char.IsDigit(userAnswer[i]))
            {
                return false;
            }
        }

        return true;
    }

    public void AnswerCheck(string userAnswer) {
        List<char> winCondition = new List<char>();
        List<char> correctNumbers = new List<char>();
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {

                if (answerNumbers[i] == Char.GetNumericValue(userAnswer[i]))
                {
                    winCondition.Add('+');
                    
                    break;
                }
                else if (answerNumbers[i] == Char.GetNumericValue(userAnswer[j]))
                {
                    correctNumbers.Add('-');
                    
                }

            
            
            }
        
        }
        Console.Write(string.Join("", winCondition));
        Console.Write(string.Join("", correctNumbers));
        Console.WriteLine();
        if (winCondition.Count == 4) 
        {
            isWon = true;
        }

    }

}   

