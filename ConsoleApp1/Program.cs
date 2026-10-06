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
        ThisIsNotABoolean = true;
        while (ThisIsNotABoolean == true)
        {
            Console.WriteLine("гнейс - Do you want to go for a drink? Y/N");
            string YesOrNo = Console.ReadLine();
            YesOrNo = YesOrNo.ToLower();
            if (YesOrNo == "y")
            {
                //Make Micro Transactions here (Done, ber om ursäkt för mängden IF satser)
                Console.WriteLine("Розовый кварц - Vodka - 5£ - Type Q to buy");
                Console.WriteLine("пемза - Cooler Vodka - 6£ - Type W to buy");
                Console.WriteLine("пирит - Devils Heartexploding Brain Numbing Extravaganza - 8£ - Type E to buy");
                Console.WriteLine("диабаз - Decide not to buy anything - Type R to retreat"); //This is the "Do you want to reconsider" option
                string Alcoholic = Console.ReadLine();
                Alcoholic = Alcoholic.ToLower();
                if (Alcoholic == "q")
                {
                    bool BooleanThisIs = true;
                    while (BooleanThisIs == true)
                    {
                        Console.WriteLine("How many bottles of Vodka would you like to buy? Type 1-3 (Amount recommended for health reasons)");
                        string VodkaAmount = Console.ReadLine();
                        if (int.TryParse(VodkaAmount, out int AmountOfVodkaButInt))
                        {
                            if (AmountOfVodkaButInt * 5 <= Wallet)
                            {
                                Console.Clear();
                                Console.WriteLine("You've bought some vodka!.. Only for it to shatter on the floor after you accidentally collide with a fat man.");
                                Wallet = Wallet - AmountOfVodkaButInt * 5;
                                Console.WriteLine($"Current balance: {Wallet}");
                                Console.ReadLine();
                                BooleanThisIs = false;
                            }
                            else if (AmountOfVodkaButInt * 5 > Wallet)
                            {
                                Console.Clear();
                                Console.WriteLine("You're too poor for this!");
                                Console.WriteLine($"Current balance: {Wallet}");
                                Console.ReadLine();
                                BooleanThisIs = false;
                            }
                        }
                        //     if (VodkaAmount == "1" && Wallet >= 5)
                        //         {
                        //             Console.Clear();
                        //             Console.WriteLine("You bought a bottle of vodka and dropped it without ever getting a sip, causing the bottle to shatter.");
                        //             Wallet = Wallet - 5;
                        //             Console.WriteLine($"Current balance: {Wallet}");
                        //             Console.ReadLine();
                        //             BooleanThisIs = false;
                        //         }
                        //         else if (VodkaAmount == "2" || VodkaAmount == "3")
                        //         {
                        //             Console.ReadLine();
                        //             if (VodkaAmount == "2" && Wallet >= 10)
                        //             {
                        //                 Wallet = Wallet - 10;
                        //                 Console.Clear();
                        //                 Console.WriteLine($"You bought {VodkaAmount} vodka bottles however both fell over and shattered, leaving you with nothing.");
                        //                 Console.WriteLine($"Current balance: {Wallet}");
                        //                 Console.ReadLine();
                        //                 BooleanThisIs = false;
                        //             }
                        //             else if (VodkaAmount == "3" && Wallet >= 15)
                        //             {
                        //                 Wallet = Wallet - 15;
                        //                 Console.Clear();
                        //                 Console.WriteLine($"You bought {VodkaAmount} vodka bottles however both fell over and shattered, leaving you with nothing.");
                        //                 Console.WriteLine($"Current balance: {Wallet}");
                        //                 Console.ReadLine();
                        //                 BooleanThisIs = false;
                        //             }
                        //         }
                        //         else
                        //         {
                        //             Console.WriteLine("You were tossed out of the bar.");
                        //             Console.ReadLine();
                        //             BooleanThisIs = false;
                        //         }
                        // }
                    }
                }
                else if (Alcoholic == "w")
                {
                     bool BooleanThisIs = true;
                    while (BooleanThisIs == true)
                    {
                        Console.WriteLine("How many bottles of Cooler Vodka would you like to buy? Type 1-3 (Amount recommended for health reasons)");
                        string CoolerVodkaAmount = Console.ReadLine();
                        if (int.TryParse(CoolerVodkaAmount, out int AmountOfCoolerVodkaButInt))
                        {
                            if (AmountOfCoolerVodkaButInt * 6 <= Wallet)
                            {
                                Console.Clear();
                                Console.WriteLine("You've bought some cooler vodka!.. Only for it all to fly away, deeming you unfit to hold it.");
                                Wallet = Wallet - AmountOfCoolerVodkaButInt * 6;
                                Console.WriteLine($"Current balance: {Wallet}");
                                Console.ReadLine();
                                BooleanThisIs = false;
                            }
                            else if (AmountOfCoolerVodkaButInt * 6 > Wallet)
                            {
                                Console.Clear();
                                Console.WriteLine("You're too poor for this!");
                                Console.WriteLine($"Current balance: {Wallet}");
                                Console.ReadLine();
                                BooleanThisIs = false;
                            }
                        }
                    }
                    // bool BooleanThisIsNot = true;
                        // while (BooleanThisIsNot == true)
                        // {
                        //     Console.WriteLine("How many bottles of Cooler Vodka would you like to buy? Type 1-3 (Amount limited for health reasons)");
                        //     string CoolerVodkaAmount = Console.ReadLine();
                        //     if (CoolerVodkaAmount == "1" && Wallet >= 6)
                        //     {
                        //         Console.Clear();
                        //         Console.WriteLine("You bought a bottle of cooler vodka, however it deemed you unfit and flew away.");
                        //         Wallet = Wallet - 6;
                        //         Console.WriteLine($"Current balance: {Wallet}");
                        //         Console.ReadLine();
                        //         BooleanThisIsNot = false;
                        //     }
                        //     else if (CoolerVodkaAmount == "2" || CoolerVodkaAmount == "3")
                        //     {
                        //         Console.ReadLine();
                        //         if (CoolerVodkaAmount == "2" && Wallet >= 12)
                        //         {
                        //             Wallet = Wallet - 12;
                        //             Console.Clear();
                        //             Console.WriteLine($"You bought {CoolerVodkaAmount} cooler vodka bottles however both flew away, leaving you with nothing.");
                        //             Console.WriteLine($"Current balance: {Wallet}");
                        //             Console.ReadLine();
                        //             BooleanThisIsNot = false;
                        //         }
                        //         else if (CoolerVodkaAmount == "3" && Wallet >= 18)
                        //         {
                        //             Wallet = Wallet - 18;
                        //             Console.Clear();
                        //             Console.WriteLine($"You bought {CoolerVodkaAmount} vodka bottles however both flew away, leaving you with nothing.");
                        //             Console.WriteLine($"Current balance: {Wallet}");
                        //             Console.ReadLine();
                        //             BooleanThisIsNot = false;
                        //         }
                        //     }
                        //     else
                        //     {
                        //         Console.WriteLine("You were tossed out of the bar.");
                        //         Console.ReadLine();
                        //         BooleanThisIsNot = false;
                        //     }
                        // }
                    }
                else if (Alcoholic == "e")
                {
                    if (Wallet >= 8)
                    {
                        Console.WriteLine("For safety reasons you're only allowed to buy one glass.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Why would you buy this? Well, regardless, you die a very painful death after just one drop.");
                        Console.ReadLine();
                        ThisIsABoolean = false;
                        ThisIsNotABoolean = false;
                    }
                }
                    else if (Alcoholic == "r")
                    {
                        Console.Clear();
                        Console.WriteLine("Being the wise man you are you decide to retreat from the bar.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                    }
            }
            else if (YesOrNo == "n")
            {
                //Romanian steals wallet, insert long dialogue
                Console.WriteLine("You choose to play it safe, huh? Walking away from the casino, you decide to head home.");
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

                ThisIsNotABoolean = false;
                ThisIsABoolean = false;
            }
            Console.Clear();
        }
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