
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BuyanovaVI.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string res = "";
            foreach (string word in words)
            {
                if (word.Length < 2)
                {
                    res = $"{res}{word} ";
                }
                else
                {
                    char lastLetter = word[word.Length - 1];
                    string restOfWord = word.Substring(0, word.Length - 1);
                    string modifiedWord = lastLetter + restOfWord;
                    res = $"{res}{modifiedWord} ";
                }
            }
            return res.Remove(res.Length - 1);
        }
    }
}

