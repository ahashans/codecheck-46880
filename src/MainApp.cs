using System;

public class MainApp
{
    static public void Main (string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
           string output = String.Format("Hello {1}!", i, args[i]);
           Console.WriteLine(output);
        }
    }
}
