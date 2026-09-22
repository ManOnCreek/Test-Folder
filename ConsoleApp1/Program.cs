//Console.WriteLine("Hello, World!(Console.WriteLine)");
//Projekt Slot-Machine deez Kappa!
// int Slot1 = 1;
// int Slot2 = 2;
// int Slot3 = 3;

int Wallet = 20;
int PullIt = 5;

string Slotty1 = "Cabbage";
string Slotty2 = "Tomato";
string Slotty3 = "Kartoffel";
string Slotty4 = "Sauerkraut";
string SuspiciouslyFancyLookingSchmuck = "Jackpot?!";

Boolean ThisIsABoolean = true;
Boolean ThisIsNotABoolean = false;

while (ThisIsABoolean == true)
{
    //p
    Console.WriteLine("Уголь - Would you like to spend your hard earned money on slots? Y/N ");
    Console.WriteLine($"Кварц - Insert money: {PullIt}£");
    Console.WriteLine($"латтит - Current balance: {Wallet}£");

    string Gamba = Console.ReadLine();
    Gamba = Gamba.ToLower();

    if (Gamba == "y" && Wallet > 0)
    {
        Wallet = Wallet - PullIt;
        int Slot1 = Random.Shared.Next(1, 6);
        int Slot2 = Random.Shared.Next(1, 6);
        int Slot3 = Random.Shared.Next(1, 6);
        //This is to draw out the slots
        if (Slot1 == 1)
        {
            Console.Write($"||{Slotty1}||");
        }
        else if (Slot1 == 2)
        {
            Console.Write($"||{Slotty2}||");
        }
        else if (Slot1 == 3)
        {
            Console.Write($"||{Slotty3}||");
        }
        else if (Slot1 == 4)
        {
            Console.Write($"||{Slotty4}||");
        }
        else if (Slot1 == 5)
        {
            Console.Write($"||{SuspiciouslyFancyLookingSchmuck}||");
        }
        if (Slot2 == 1)
        {
            Console.Write($"||{Slotty1}||");
        }
        else if (Slot2 == 2)
        {
            Console.Write($"||{Slotty2}||");
        }
        else if (Slot2 == 3)
        {
            Console.Write($"||{Slotty3}||");
        }
        else if (Slot2 == 4)
        {
            Console.Write($"||{Slotty4}||");
        }
        else if (Slot2 == 5)
        {
            Console.Write($"||{SuspiciouslyFancyLookingSchmuck}||");
        }
        if (Slot3 == 1) //WriteLine istället för write eftersom den är sist. Varför? WriteLINE, avslutar linen.
        {
            Console.WriteLine($"||{Slotty1}||");
        }
        else if (Slot3 == 2)
        {
            Console.WriteLine($"||{Slotty2}||");
        }
        else if (Slot3 == 3)
        {
            Console.WriteLine($"||{Slotty3}||");
        }
        else if (Slot3 == 4)
        {
            Console.WriteLine($"||{Slotty4}||");
        }
        else if (Slot3 == 5)
        {
            Console.WriteLine($"||{SuspiciouslyFancyLookingSchmuck}||");
        }

        //This is to calculate wins if there are any
        if (Slot1 == 1 && Slot1 == Slot2 && Slot1 == Slot3)
        {
            //Minor win insert with Cabbages
            Console.WriteLine("Обсидиан - Congratz, you just won 10£!");
            Wallet = Wallet + 10;
        }
        else if (Slot1 == 2 && Slot1 == Slot2 && Slot1 == Slot3)
        {
            //Minor win with Tomatoes
            Console.WriteLine("Обсидиан - Congratz, you just won 15£!");
            Wallet = Wallet + 15;
        }
        else if (Slot1 == 3 && Slot1 == Slot2 && Slot1 == Slot3)
        {
            //Minor win mit Kartoffeln
            Console.WriteLine("Обсидиан - Congratz, you just won 20£!");
            Wallet = Wallet + 20;
        }
        else if (Slot1 == 4 && Slot1 == Slot2 && Slot1 == Slot3)
        {
            //Win with Sauerkraut!
            Console.WriteLine("Обсидиан - Congratz, you just won 25£!");
            Wallet = Wallet + 25;
        }
        else if (Slot1 == 5 && Slot1 == Slot2 && Slot1 == Slot3)
        {
            //Hold up, you just hit the JACKPOOOOOOTT????!!
            Console.WriteLine("Обсидиан - Congratz, you just hit the jackpot and won 50£!");
            Wallet = Wallet + 50;
        }
        else
        {
            //Insert loss sloppy here.
            Console.WriteLine("Закончились минералы - Wow, what a loser! Can't even pull a lever properly.");
            Console.WriteLine("");
        }

    }
    else if (Gamba == "n")
    {
        //Romanian steals wallet, insert long dialogue
        Console.WriteLine("You choose not to gamble today, huh? Walking away from the casino, you decide to head home.");
        Console.ReadLine();
        Console.WriteLine("On your way home you picture your children smiling, finally getting to have dinner with you.");
        Console.ReadLine();
        Console.WriteLine("While walking, however, things take a drastic turn...");
        Console.ReadLine();
        Console.WriteLine("A wild Romanian appears and snatches your wallet before you can even process what's happening!");
        Console.ReadLine();
        Console.WriteLine("You run to catch up to them but fail miserably, realizing how big of a failure you are.");
        Console.ReadLine();
        Console.WriteLine("Coming to the conclusion that it must be a sign from God, you decide not to go home tonight...");
        Console.ReadLine();
        Console.WriteLine("Instead you lay down in a dark alley where you then freeze to death, alone, leaving your children to starve at home.");
        Console.ReadLine();

        Console.Clear();
        ThisIsABoolean = false;
        
    }
    else if (Wallet == 0)
    {
        Console.WriteLine("You know this is rigged against you, right?");
        Console.ReadLine();
        Console.WriteLine("Welp, sucks to suck pal. See you on your next salary!");
        Console.ReadLine();
        ThisIsABoolean = false;
    }
    else
    {
        Console.Clear();
    }
}