using System;
using System.Text.RegularExpressions;

namespace task_2
{
    internal class Program
    {
        static void Main()
        {
            Output("The user with the nickname koala757677 this month left 3 times more comments than the user with the nickname croco181dile181920 4 months ago");
            Output("The winner of the contest username123 scored 150 points, surpassing runner-up name456 by 30 points.");
            Output("Model X12 released this year sold 10,000 units more than the previous model Y34 last year.");
            Output("During the conference, speakerA45 presented 3 keynotes, while speakerB67 presented 2.");
            Output("The user abc789 uploaded 25 photos this month, which is 5 more than the user xyz123 uploaded last month.");
            Output("In 2023, the project alpha5 achieved 20 milestones, doubling the accomplishments of project beta8.");
            Output("Employee id245 completed 8 tasks today, whereas employee id678 completed 6.");
            Output("The game levelA3 requires 10 coins to unlock, while levelB4 needs 15 coins.");
        }

        static int CountWords(string sentence)
        {
            string pattern = @"\b[a-zA-Z]+\b";
        
            MatchCollection matches = Regex.Matches(sentence, pattern);
        
            return matches.Count;
        }

        static void Output(string sentence)
        {
            Console.WriteLine($"Number of words in sentence: '{sentence}' : {CountWords(sentence)}");
        }
    }
}