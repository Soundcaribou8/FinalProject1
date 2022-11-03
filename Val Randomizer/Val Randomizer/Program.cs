 using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class ValRandomizer
{
    public static void Main()
    {
        string agent = "";
        int character;
        Random random = new Random();
    Reroll:
        character = random.Next(1, 21);
        switch (character)
        {
            case 1:
                agent = "Sova ";
                break;
            case 2:
                agent = "Phoenix ";
                break;
            case 3:
                agent = "Reyna ";
                break;
            case 4:
                agent = "Omen";
                break;
            case 5:
                agent = "Skye";
                break;
            case 6:
                agent = "Fade";
                break;
            case 7:
                agent = "Astra";
                break;
            case 8:
                agent = "Breach";
                break;
            case 9:
                agent = "Yoru";
                break;
            case 10:
                agent = "Harbor";
                break;
            case 11:
                agent = "Neon";
                break;
            case 12:
                agent = "Cypher";
                break;
            case 13:
                agent = "Raze";
                break;
            case 14:
                agent = "KillJoy";
                break;
            case 15:
                agent = "Kay/O";
                break;
            case 16:
                agent = "Jett";
                break;
            case 17:
                agent = "Viper";
                break;
            case 18:
                agent = "Sage";
                break;
            case 19:
                agent = "Brimstone";
                break;
            case 20:
                agent = "Chamber";
                break;

        }
        bool acceptableresponce = false;
        Console.WriteLine("Your agent is, " + agent + ", Do you want to reroll, 1 for Yes or  2 for No? ");
        int input = 0;


        while (acceptableresponce == false)
        {
        wasted:
            string response = Console.ReadLine();
            input = Int32.Parse(response);
            if (input == 1)
            {
                acceptableresponce = true;
                goto Reroll;
            }
            else if (input == 2)
            {
                acceptableresponce = true;
                Console.WriteLine(" Your Agent is, " + agent);
            }
            else
            {
                acceptableresponce = false;
                Console.WriteLine(" Please enter 1 or 2 ");
                goto wasted;
            }

            Weapon(); 
        }
    }
    public static void Weapon()
    {
        Console.WriteLine();
        string weapon = "";
        int Weapon;
        Random random = new Random();
        RerollW:
        Weapon = random.Next(1, 18);
        switch (Weapon)
        {
            case 1:
                weapon = " Classic ";
                break;
            case 2:
                weapon = " Shorty ";
                break;
            case 3:
                weapon = " Frenzy ";
                break;
            case 4:
                weapon = " Ghost ";
                break;
            case 5:
                weapon = " Sheriff ";
                break;
            case 6:
                weapon = " Stinger ";
                break;
            case 7:
                weapon = " Spectre ";
                break;
            case 8:
                weapon = " Bucky ";
                break;
            case 9:
                weapon = " Judge ";
                break;
            case 10:
                weapon = " BullDog ";
                break;
            case 11:
                weapon = " Guardian ";
                break;
            case 12:
                weapon = " Phantom ";
                break;
            case 13:
                weapon = " Vandal ";
                break;
            case 14:
                weapon = " Marshal ";
                break;
            case 15:
                weapon = " Operator ";
                break;
            case 16:
                weapon = " Ares ";
                break;
            case 17:
                weapon = " Odin ";
                break;
        }
        bool acceptableresponce = false;
        Console.WriteLine("Your Weapon is, " + weapon + ", Do you want to reroll, 1 for Yes or  2 for No? ");
        int input = 0;

        while (acceptableresponce == false)
        {
        wastedW:
            string response = Console.ReadLine();
            input = Int32.Parse(response);
            if (input == 1)
            {
                acceptableresponce = true;
                goto RerollW;
            }
            else if (input == 2)
            {
                acceptableresponce = true;
                Console.WriteLine(" Your Weapon is, " + weapon);
            }
            else
            {
                acceptableresponce = false;
                Console.WriteLine(" Please enter 1 or 2 ");
                goto wastedW;
            }
        }
    }
}
