using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace Magic8Ball
{
    public class MagicBall
    {
        static HashSet<string> setOfWords = new HashSet<string> { };

        public MagicBall()
        {
            // This initialiser stores the 100 most commonly used nouns in the English language as per the URL below.
            var url = "https://www.wordexample.com/list/most-common-nouns-english";
            var web = new HtmlWeb();

            var doc = web.Load(url);
            //*[@id="wordexample-word-list"]/table


            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//div[@id='wordexample-word-list']//tr//td"))
            {
                string value = node.InnerText.Trim(); // Trim is needed to get rid of random XML junk.
                setOfWords.Add(value);
                
                
            }



        }

        public Answer generateAnswer(string thought)
        {
            Answer answer = new Answer();
            // Answer will depend on DateTime, google search amounts and whether or not it includes pizza
            if (isItEarly())
            {
                answer.setYes(); // If the day is still young we are full of optimism!
                return answer;
            }
            if (isPizza(thought))
            {
                answer.setYes();
                return answer; // Pizza is good.
            }
            // Check if input included a word that is common in English
            DateTime currentTime = DateTime.Now;

            foreach (string word in thought.Split(" ")) {
                // Console.WriteLine("Word is : " + word);
                // Console.WriteLine(setOfWords.Contains(word));
                    if (word.Length >= 4 && setOfWords.Contains(word)) {
                   
                        answer.setYes();
                }

            }
            return answer;
        }

        private static bool isItEarly()
        {
            return (DateTime.Now.Hour <= 11);
        }

        private static bool isPizza(string thought)
        {
            return (thought.ToUpper().Contains("PIZZA"));
        }
    }
}


