using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            /* MagicBall ball2 = new MagicBall();
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(ball2.generateAnswer("friend").getText());
                }*/
            while (true)
            {
               
                MagicBall ball = new MagicBall();
                Console.WriteLine("Write down a question that's on your mind and then press ENTER");
                string thought = Console.ReadLine();
                Answer answer = ball.generateAnswer(thought);
                Console.WriteLine(answer.getText());
                Console.WriteLine("Press Y to play again!");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                {
                    break;
                }
                
            }
        }

        private static Answer GetAnswer(MagicBall ball, string thought)
        {
            return ball.generateAnswer(thought);
        }
    }
}

