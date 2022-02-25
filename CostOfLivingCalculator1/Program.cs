using System;
using System.Collections.Generic;

namespace CostOfLivingCalculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gonna need some initialized variables here to work with:
            decimal grandTotal = 0;
            //1
            decimal rentTotal = 0;
            //2
            decimal allUtiliTotal = 0;
            decimal WatAndElectrTotal = 0;
            decimal HeatTotal = 0;
            decimal InternetTotal = 0;
            //3
            decimal gasTotal = 0;
            //4
            decimal allFoodTotal = 0;
            decimal foodTotal = 0;
            decimal nonFoodTotal = 0;
            //5
            decimal takeOutTotal = 0;

            //doesn't need initial value declared because only called inside function
            //- not hardcoded into program flow
            decimal amount;
            decimal n;
            //allows you to use 'by day/week' switch for multiple pathways
            decimal tempTotal = 0;
            //these do the same for their respective switches
            int days = 0;
            string month = "";

            bool flag = true;



            //you can expand this out from groceries to cost of living in general(rent, utilities, etc)
            Console.WriteLine("Adam's Cost of Living Calculator\r");
            Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-\n");


            //entry-point
            Console.WriteLine("Alright, where shall we start?");

            do
            {
                Console.WriteLine("\t1 - rent");
                Console.WriteLine("\t2 - utilities");
                Console.WriteLine("\t3 - gas");
                Console.WriteLine("\t4 - groceries");
                Console.WriteLine("\t5 - take-out");
                Console.WriteLine("\t6 - all");
                SelectorValidation();
                //after selection is validated, you need to determine which one to call

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\nNice and simple! How much do you spend on rent each month?.");
                        Console.WriteLine("Type amount you wish to add, then press Enter.");
                        rentTotal += TotalGenerator(rentTotal);
                        tempTotal = rentTotal;
                        Console.WriteLine("\n The total amount you have entered is: $" + rentTotal);
                        break;
                    case 2:
                        Console.WriteLine("\nOk, which utilites would you like to calculate?");
                        Console.WriteLine("\t 1 - All Utilities");
                        Console.WriteLine("\t 2 - Water and Electricity");
                        Console.WriteLine("\t 3 - Heating");
                        Console.WriteLine("\t 4 - Internet");
                        UtilitiesSelectorValidation();

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("\nUnderstood, now let's determine the monthly total for all utilities.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                allUtiliTotal += TotalGenerator(allUtiliTotal);
                                tempTotal = allUtiliTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + allUtiliTotal);
                                break;

                            case 2:
                                Console.WriteLine("\nFirst, let's determine the monthly total for water and electricity.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                WatAndElectrTotal += TotalGenerator(WatAndElectrTotal);
                                tempTotal += WatAndElectrTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + WatAndElectrTotal);
                                break;
                            case 3:
                                Console.WriteLine("\nGot it. Next, let's determine the monthly total for your heating.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                HeatTotal += TotalGenerator(HeatTotal);
                                tempTotal = HeatTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + HeatTotal);
                                break;
                            case 4:
                                Console.WriteLine("\nGot it. Next, let's determine the monthly total for your internet.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                InternetTotal += TotalGenerator(InternetTotal);
                                tempTotal = InternetTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + InternetTotal);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nSimple enough. Now, let's figure out your monthly total for gas.");
                        Console.WriteLine("Type amount you wish to add, then press Enter.");
                        gasTotal += TotalGenerator(gasTotal);
                        tempTotal = gasTotal;
                        Console.WriteLine("\n The total amount you have entered is: $" + gasTotal);
                        break;
                    case 4:
                        Console.WriteLine("\nOk, which groceries would you like to calculate?");
                        Console.WriteLine("\t 1 - all groceries");
                        Console.WriteLine("\t 2 - food groceries");
                        Console.WriteLine("\t 3 - non-food groceries");
                        GrocerySelectorValidation();

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("\nUnderstood, now let's determine the monthly total for all of your groceries.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                allFoodTotal += TotalGenerator(allFoodTotal);
                                tempTotal = allFoodTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + allFoodTotal);
                                break;

                            case 2:
                                Console.WriteLine("\nFirst, let's determine the monthly total for your food groceries.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                foodTotal += TotalGenerator(foodTotal);
                                tempTotal += foodTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + foodTotal);
                                break;
                            case 3:
                                Console.WriteLine("\nGot it. Next, let's determine the monthly total for your non-food groceries.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                nonFoodTotal += TotalGenerator(nonFoodTotal);
                                tempTotal = nonFoodTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + nonFoodTotal);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nOk. Well, let's figure out how much you spent on take-out this month.");
                        Console.WriteLine("Type amount you wish to add, then press Enter.");
                        takeOutTotal += TotalGenerator(takeOutTotal);
                        tempTotal = takeOutTotal;
                        Console.WriteLine("\n The total amount you have entered is: $" + takeOutTotal);
                        break;
                    case 6:
                        Console.WriteLine("\nOk. Let's put it all together.");
                        Console.WriteLine("First, do you wish to add up your own grand total,");
                        Console.WriteLine("or use existing ones to calculate a grand toal?");
                        Console.WriteLine("\t1 - new grand total");
                        Console.WriteLine("\t2 - add existing totals together");
                        Console.WriteLine("\nYour decision?");
                        UnitSelectorValidation();

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("\nOk. Well then, let's figure out your grand total.");
                                Console.WriteLine("Type amount you wish to add, then press Enter.");
                                grandTotal += TotalGenerator(grandTotal);
                                tempTotal = grandTotal;
                                Console.WriteLine("\n The total amount you have entered is: $" + grandTotal);
                                break;
                            case 2:
                                Console.WriteLine("\nAlright! The moment has finally come to put it all together.");
                                grandTotal =
                                     //1
                                     rentTotal +
                                     //2
                                     allUtiliTotal +
                                     WatAndElectrTotal +
                                     HeatTotal +
                                     InternetTotal +
                                     //3
                                     gasTotal +
                                     //4
                                     allFoodTotal +
                                     foodTotal +
                                     nonFoodTotal +
                                     //5
                                     takeOutTotal;

                                tempTotal = grandTotal;
                                Console.WriteLine("\n Your grand total is: $" + grandTotal);
                                break;
                        }
                        break;
                }

                //determine which month:
                Console.WriteLine("\nNow, for which month would you like to calculate?");
                Console.WriteLine("\t jan - January");
                Console.WriteLine("\t feb - February");
                Console.WriteLine("\t mar - March");
                Console.WriteLine("\t apr - April");
                Console.WriteLine("\t may - May");
                Console.WriteLine("\t jun - June");
                Console.WriteLine("\t jul - July");
                Console.WriteLine("\t aug - August");
                Console.WriteLine("\t sep - September");
                Console.WriteLine("\t oct - October");
                Console.WriteLine("\t nov - November");
                Console.WriteLine("\t dec - December\n");
                Console.WriteLine("Type key(ex: jan, feb, mar, etc.), then press Enter");
                MonthSelectorValidation();

                switch (month)
                {
                    case "jan":
                        days = 31;
                        break;
                    case "feb":
                        days = 28;
                        break;
                    case "mar":
                        days = 31;
                        break;
                    case "apr":
                        days = 30;
                        break;
                    case "may":
                        days = 31;
                        break;
                    case "jun":
                        days = 30;
                        break;
                    case "jul":
                        days = 31;
                        break;
                    case "aug":
                        days = 31;
                        break;
                    case "sep":
                        days = 30;
                        break;
                    case "oct":
                        days = 31;
                        break;
                    case "nov":
                        days = 30;
                        break;
                    case "dec":
                        days = 31;
                        break;
                }

                //determine calculation:
                Console.WriteLine("\nDo you want to know much was spent by week or by day?");
                Console.WriteLine("\t1 - By week");
                Console.WriteLine("\t2 - By day");
                Console.WriteLine("\nYour decision?");
                UnitSelectorValidation();


                switch (n)
                {
                    case 1:
                        Console.WriteLine("\nYour cost was $" + Math.Round(tempTotal / 4, 2) + " per week.\n");
                        tempTotal = 0;
                        break;
                    case 2:
                        Console.WriteLine($"\nYour cost was $" + Math.Round(tempTotal / days, 2) + " per day.\n");
                        tempTotal = 0;
                        break;
                }




                Console.WriteLine("Do you wish to calculate other totals?");
                Console.WriteLine("Type 'yes' or 'no', then press Enter.");
                CalculatorCircuit();
                Console.WriteLine();
                Console.WriteLine();

            } while (flag == true);


            //the functions:
            decimal SelectorValidation()
            {
                bool temp = false;
                string input = Console.ReadLine();

                do
                {
                    if (!decimal.TryParse(input, out n))
                    {
                        Console.WriteLine("That's not even a number...Try Again.");
                        input = Console.ReadLine();
                    }
                    else if (n < 1 || n > 6)
                    {
                        Console.WriteLine("I don't see that number on this list, do you? Try Again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        temp = true;
                    }

                } while (temp == false);
                return n;
            }


            decimal UtilitiesSelectorValidation()
            {
                bool temp = false;
                string input = Console.ReadLine();

                do
                {
                    if (!decimal.TryParse(input, out n))
                    {
                        Console.WriteLine("That's not even a number...Try Again.");
                        input = Console.ReadLine();
                    }
                    else if (n < 1 || n > 4)
                    {
                        Console.WriteLine("I don't see that number on this list, do you? Try Again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        temp = true;
                    }

                } while (temp == false);
                return n;
            }

            decimal GrocerySelectorValidation()
            {
                bool temp = false;
                string input = Console.ReadLine();

                do
                {
                    if (!decimal.TryParse(input, out n))
                    {
                        Console.WriteLine("Come now, I know you are better than that...Try Again.");
                        input = Console.ReadLine();
                    }
                    else if (n < 1 || n > 3)
                    {
                        Console.WriteLine("Let's see, there's '1', '2', '3' *shakes head* Try Again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        temp = true;
                    }

                } while (temp == false);
                return n;
            }

            string MonthSelectorValidation()
            {
                bool temp = true;
                string input = Console.ReadLine();
                List<string> options = new List<string>()
                            {
                                "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"
                            };
                do
                {
                    if (options.Contains(input))
                    {
                        month = input;
                        temp = false;
                    }
                    else
                    {
                        Console.WriteLine("I don't see that key on this list...Try Again.");
                        input = Console.ReadLine();
                    }

                } while (temp == true);
                return month;
            }

            decimal UnitSelectorValidation()
            {
                bool temp = false;
                string input = Console.ReadLine();

                do
                {
                    if (!decimal.TryParse(input, out n))
                    {
                        Console.WriteLine("Nope...Try Again.");
                        input = Console.ReadLine();
                    }
                    else if (n < 1 || n > 2)
                    {
                        Console.WriteLine("Yeah, that's not an option...Try Again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        temp = true;
                    }

                } while (temp == false);
                return n;
            }


            decimal TotalGenerator(decimal param)
            {
                string input = "";
                string a = Console.ReadLine();

                do
                {
                    if (decimal.TryParse(a, out amount))
                    {
                        static bool ConfirmTwoDecimalPlaces(decimal amount)
                        {
                            decimal value = amount * 100;
                            return value == Math.Floor(value);
                        }

                        if (ConfirmTwoDecimalPlaces(amount))
                        {
                            param += amount;
                            Console.WriteLine("\nWould you like to add more to the amount?");
                            Console.WriteLine("If so, type the amount, then press Enter.");
                            Console.WriteLine("  Additional Commands:");
                            Console.WriteLine("   reset - If you have added the wrong amount and wish to restart");
                            Console.WriteLine("   done- When are you finished totalling");
                            a = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("You got a little carried away with your decimals. Try Again...");
                            a = Console.ReadLine();
                        }
                       
                    }
                    else if (a == "reset")
                    {
                        param = 0;
                        Console.WriteLine("\nLet's start again");
                        Console.WriteLine("Type the amount you wish to add, then press Enter.");
                        a = Console.ReadLine();
                    }
                    else if (a == "done")
                    {
                        input = a;
                    }
                    else
                    {
                        Console.WriteLine("What are you doing? Try Again...");
                        a = Console.ReadLine();
                    }
                } while (input != "done");

                return param;
            }


            bool CalculatorCircuit()
            {
                string input = Console.ReadLine();
                bool check = true;
                do
                {
                    if (input == "no")
                    {
                        check = false;
                        flag = false;
                    }
                    else if (input != "yes")
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        check = false;
                    }
                } while (check);
                return flag;
            }
        }
    }
}
