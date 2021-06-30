using System;
using System.Text;

public class Kata
{
    public static string ToWeirdCase(string s)
    {
        string[] words = s.Split(' ');
        StringBuilder stringBuilder = new StringBuilder("", s.Length);
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (j % 2 == 0)
                {
                    stringBuilder.Append(char.ToUpper(s[j]));
                }
                else
                {
                    stringBuilder.Append(char.ToLower(s[j]));
                }
            }
            if (i != words.Length-1)
            {
                stringBuilder.Append(' ');
            }

        }
        return stringBuilder.ToString();
    }
}