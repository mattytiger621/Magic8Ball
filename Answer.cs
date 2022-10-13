using System;
using System.Threading;

namespace Magic8Ball
{
    public class Answer
    {
        bool finalAnswer = false;

        public void setYes()
        {
            finalAnswer = true;
        }
        public string getText()
        {
            addRandomness();
            wasteUsersTime();
            if (finalAnswer)
            {
                return "Signs point to... yes!";
            } else
            {
                return "Signs point to... no!";
            }
        }

        private void addRandomness()
        {
            Random rnd = new Random();
            if (rnd.Next(100) % 15 == 0) {
                Console.WriteLine("Randomness strikes again!");
                finalAnswer = !finalAnswer;
            }
        }

        private void wasteUsersTime()
        {
            Console.WriteLine("Calculating... 3");
            Thread.Sleep(90);
            Console.WriteLine("Calculating... 2");
            Thread.Sleep(90);
            Console.WriteLine("Calculating... 1");
            Thread.Sleep(290);
        }
    }




}