using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one greeting statement
            String messageOne = "Hello World!";
            String messageTwo = "I am Spartacus";

            //Part two set initial Spartacus attributes
            int ageOne = 35;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.0284606f;
            float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            bool isGodLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            /*
            //Part three display variable Values
            Console.WriteLine(messageOne);
            Console.WriteLine(messageTwo);

            //Part four mathematical operator bool and char examples
            Console.WriteLine(ageOne + ageTwo);//Addition example
            Console.WriteLine(heightOne - heightTwo);//Subtraction example
            Console.WriteLine(weightOne * weightTwo);//Multiplication example
            Console.WriteLine(isGodLikeOne);//boolean example
            Console.WriteLine(genderMale);//Character example

            //Part five variable reassignment
            ageTwo = 70;
            heightTwo = 35.12345f;
            weightTwo = -429.1234573f;

            //Part six mathematical operator examples
            Console.WriteLine(ageOne + ageTwo); 
            Console.WriteLine(heightOne + heightTwo); 
            Console.WriteLine(weightOne * weightTwo);
            Console.WriteLine(ageTwo / ageOne);
            Console.WriteLine(ageTwo % ageOne);
            Console.WriteLine(ageThree / ageOne);
            Console.WriteLine(ageThree % ageOne);

            //Part seven increment and decrement operator examples
            ageTwo = ageTwo + 1;
            Console.WriteLine(ageTwo);
            ageTwo++;
            Console.WriteLine(ageTwo);
            ageTwo--;
            Console.WriteLine(ageTwo);

            //Part eight concatination example
            Console.WriteLine(messageOne + " " + messageTwo + ".");
            Console.WriteLine("I am " + ageOne + " years old and yes it's " + isGodLikeOne + " I am godlike.");
            Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");

            //Part Nine Indexing Example
            Console.WriteLine("I am {0} years old, and yes its {1} I am godlike.", ageOne, isGodLikeOne);
            Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);
            

            //Part ten String equality examples
            Console.WriteLine(messageTwo.Equals(messageOne));
            Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //String formatting example
            String myGreeting = "Hey";
            Console.WriteLine(myGreeting.ToUpper());
            Console.WriteLine(myGreeting.ToLower());
            Console.WriteLine(myGreeting);

            //String Readline examples
            

            Console.WriteLine("Enter a color please: ");
            String color = Console.ReadLine();

            if(color.ToLower().Equals("red"))
            {
                Console.WriteLine("Roses can be red. Also, lillies.");
            } else { Console.WriteLine("You should have picked red.");
                 }
            

            //String Length Examples 
            int messOneLength = messageOne.Length;
            int messTwoLength = messageTwo.Length;

            Console.WriteLine("The length of MessageOne is: " + messageOne.Length);
            Console.WriteLine("The length of MessageTwo is: " + messageTwo.Length);
            Console.WriteLine("The length of MessageOne is: " + messOneLength);
            Console.WriteLine("The length of MessageOne is: " + messTwoLength);
            

            //Part Eleven IF Statements...

            String city1 = "Vesuvius";
            String city2= "Nola";
            String city3 = "Nuceria";
            int city1Distance, city2Distance, city3Distance;

            Console.WriteLine("What is the distance to {0}?", city1);
            city1Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the distance to " + city2 + "?");
            city2Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Waht is the distance to Nuceria?");
            city3Distance = int.Parse(Console.ReadLine());

            if ((city1Distance <= 125) && (city1Distance < city2Distance) && (city1Distance < city3Distance)) {
                Console.WriteLine("We will march to vesuvius");
            }
            if ((city2Distance <= 125) && (city2Distance < city1Distance) && (city2Distance < city3Distance))
            {
                Console.WriteLine("We will march to Nola");
            }
            if ((city3Distance <= 125) && (city3Distance < city1Distance) && (city3Distance < city2Distance))
            {
                Console.WriteLine("We will march to Nuceria");
            }

            Console.WriteLine("What is your rank?");
            string rank = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            

            //Part 12 conditional examples

            Console.WriteLine("What is your rank soldier?");
            string rank1 = Console.ReadLine();

            Console.WriteLine("What is your age soldier?");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your job soldier?");
            string job = Console.ReadLine();

            if ((rank1 == "officer") || (age1 <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            }
            else if ((job == "cook") || (age1 <= 26))
            {
                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            }
            else
            {
                Console.WriteLine("Sorry you are staying home.");
            }
            
            switch (job)
            {
                case "infantry":
                    Console.Write("You will carry a sword");
                    break;
                case "archers":
                    Console.WriteLine("You will carry a bow and arrow");
                    break;
                case "supply":
                    Console.WriteLine("You will carry pots and pans");
                    break;
                case "specialist":
                    Console.WriteLine("You will operate the catapault");
                    break;
                default:
                    Console.WriteLine("You will ride horseback");
                    break;
            }
            
            
            // Part Thirteen Array Examples
            string[] foodList = new string[5];
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";
            
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList [2], foodList[3], foodList[4]);

                        int[] foodAmount = new int[5] { 1000, 100, 2000, 10000, 1500 };
                        Console.WriteLine(foodList[0] + ": " + foodAmount[0] + ", " + foodList[1] + ": " + foodAmount[1] + ", " + foodList[2] + ": " + foodAmount[2] + ", " + foodList[3] + ": " + foodAmount [3] + ", " + foodList[4] + ": " + foodAmount[4]);

                        Console.WriteLine(foodList.Length);

                        string[] elements = messageTwo.Split(' ');
                        Console.WriteLine(elements[0]);
                        Console.WriteLine(elements[1]);
                        Console.WriteLine(elements[2]);

                        string myName = "Sue";
                        char[] letters = myName.ToCharArray();
                        Console.Write(letters[0]);
                        Console.Write(letters[1]);
                        Console.Write(letters[2]);

                        string[] mom = new string[3];
                        mom[0] = "nice";
                        mom[1] = "helpful";
                        mom[2] = "funny";

                        Console.WriteLine("My mom has the qualities of {0}, {1}, and {2}.", mom[0], mom[1], mom[2]);

                        //Part 15 Loops

                        //  While Loop
                        string action = " ";
                        while (action != "exit")
                        {
                            Console.WriteLine("What is your rank soldier?");
                            string rank = Console.ReadLine();

                            Console.WriteLine("What is your age soldier?");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is your job soldier?");
                            string job = Console.ReadLine();

                            if ((rank == "officer") || (age <= 26))
                            {
                                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                            }
                            else if ((job == "cook") || (age >= 26))
                            {
                                Console.WriteLine("My army has to eat. Pack your pots and pans");
                            }
                            else
                            {
                                Console.WriteLine("Sorry you are staying home.");
                            }
                            Console.WriteLine("Add another? Type exit to quit");
                            action = Console.ReadLine();
                        }

                        //Do while Loop

                        string action2 = " ";
                        do
                        {
                            Console.WriteLine("What is your rank soldier?");
                            string rank = Console.ReadLine();

                            Console.WriteLine("What is your age soldier?");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is your job soldier?");
                            string job = Console.ReadLine();

                            if ((rank == "officer") || (age <= 26))
                            {
                                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
                            }
                            else if ((job == "cook") || (age >= 26))
                            {
                                Console.WriteLine("My army has to eat. Pack your pots and pans");
                            }
                            else
                            {
                                Console.WriteLine("Sorry you are staying home.");
                            }
                            Console.WriteLine("Add another? Type exit to quit");
                            action = Console.ReadLine();
                        } while (action2 != "exit");
                        

            //For Loops
            // for (setup; test expression; increment) { 
            // } 
            // for (int i = 0; i < foodList.Length; i++) {
            // }

            for (int i = 0; i < foodList.Length; i++) {
                Console.WriteLine(i);
                */
        }
    }
}

            

            