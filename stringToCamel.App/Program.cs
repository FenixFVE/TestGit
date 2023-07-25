
using System.Text;

namespace strtingToCamel.App;

public class Program
{
    public static string ToCamelCase(string str)
    {
        var tempOut = new StringBuilder(str.Length);
        var tempstring = str.Split("_");
        for (int i = 0; i < tempstring.Length; i++)
        {
            if (i == 0)
            {
                tempOut.Append(char.ToLower(tempstring[i][0]));
            }
            else
            {
                tempOut.Append(char.ToUpper(tempstring[i][0]));
            }
            tempOut.Append(tempstring[i].Substring(1));
        }
        return tempOut.ToString();
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to convert");

        string? userInput = Console.ReadLine();

        if (userInput == null)
        {
            return;
        }

        Console.WriteLine(ToCamelCase(userInput));
    }
}