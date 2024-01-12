using System;
public class Exercise16
{
    public static void Main()
    {
        string username, password;
        int k = 0;
        Console.Write("N.B. : Username & Password are :etian and 1234\n");
        Console.Write("_______________________________________________\n\n");

        do
        {
            Console.Write("Input a username: ");
            username = Console.ReadLine();

            Console.Write("Input a password: ");
            password = Console.ReadLine();

            if (username != "etian" || password != "1234")
            {
                Console.Write("\nUsername or password are incorect. You have two more attempts.\n\n");
                k++;
            }
            else
                k = 1;
            
        }
        while ((username != "etian" || password != "1234") && (k != 3));

        Console.Write("_______________________________________________\n\n");

        if (k == 3)
            Console.Write("\nSorry! Try again later!\n\n");
        else
            Console.Write("\nYou logged in successfully!\n\n");
    }
}

