using System;

class Program
{
    public static void Main()
    {
        Console.Write("Please input a word : ");
        string value = Console.ReadLine();
        Console.Write("Please say how many places to shift: ");
        int shift = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine( "Your origional word was : " + value);
        Console.Write( "Your encrypted is : " + Caesar(value, shift));
        Console.ReadLine();
    }

    public static string Caesar(string value, int shift)
    {

        char[] buffer = value.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            // Letter.
            char letter = buffer[i];
            // Add shift to all.
            letter = (char)(letter + shift);

            // Subtract 26 on overflow.
            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            // Add 26 on underflow.
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }
            // Store.
            buffer[i] = letter;
        }
        return new string(buffer);

    }
  
}

