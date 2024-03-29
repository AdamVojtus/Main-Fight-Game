﻿using System.Reflection.Metadata;

namespace AdamkoLesson1
{
    public class Player
    {
        public Player(string firstName, string lastName, int yearOfBirth, int health, int stamina)
        {
            if(firstName.Length < 3)
            {
                throw new ArgumentException("First Name must have at least 3 chars.");
            }
            FirstName = firstName;

            if (lastName.Length <= 3)
            {
                throw new ArgumentException("Last Name must have at least 3 chars.");
            }
            LastName = lastName;

            CheckYearOfBirth(yearOfBirth);
            YearOfBirth = yearOfBirth;

            if (health <= 0)
            {
                throw new ArgumentException("Health must be greater than 0.");
            }
            Health = health;

            if (Stamina <= 0 )
            {
                throw new ArgumentException("Stamina must be greater than 0.");
            }
            Stamina = stamina;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int YearOfBirth { get; private set; }
        public int Health { get; private set; }
        public int Stamina { get; private set;  }
        public int heavyAttack { get; private set; }
        public int lightAttack { get; private set; }
        public int fist { get; private set; }
        public int criticalChanceFist { get; private set; }
        public int criticalChanceLA { get; private set; }
        public int criticalChanceHA { get; private set; }
        public int dodgeChance { get; private set; }

        private static Random random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static int GetRandomNumber(params int[] numbers)
        {
            int index = random.Next(0, numbers.Length);
            return numbers[index];
        }

        public void DecreaeseHealth(int stamina, int fist, int lightAttack, int heavyAttack, int criticalChanceFist, int criticalChanceLA, int criticalChanceHA, string userChoice)
        {
            if(Health <= 0)
            {
                throw new ArgumentException("You are already dead!");
            }

            if(Stamina <= 0)
            {
                throw new ArgumentException("You dont have enough power to challenge your opponent!");
            }
                fist = 1;
                lightAttack = 2;
                heavyAttack = 4;

                criticalChanceFist = GetRandomNumber(1, 2, 3, 4);
                criticalChanceLA = GetRandomNumber(1, 2, 3, 4, 5);
                criticalChanceHA = GetRandomNumber(1, 2, 3, 4, 5, 6, 7, 8);
            
                Console.WriteLine("Please choose your attack option : 1. Fist 2. Light Attack 3. Heavy Attack");
                var userAttackChoice = Console.ReadLine();

                if(userChoice == "1")
                {
                    if(criticalChanceFist == 1)
                    {
                        Health -= fist + 1;
                         Stamina -= 1;
                         
                         Console.WriteLine("You have used your fist and dealt 2 damage with critical!");
                    }
                    else
                    {
                        Health -= fist;
                        Stamina -= 1;
                        
                        Console.WriteLine("You have used your fist and dealt 1 damage without critical!");
                    }

                if(userChoice == "2")
                {
                    if(criticalChanceLA == 4)
                    {
                         Health -= lightAttack + 2;
                         Stamina -= 3;
                         
                         Console.WriteLine("You have used your light attack weapon and dealt 6 damage with critical!");
                    }
                    else
                    {
                        Health -= lightAttack;
                        Stamina -= 3;
                        
                        Console.WriteLine("You have used your light attack weapon and dealt 2 damage without critical!");
                    }

                }

                if(userChoice == "3")
                {
                    if(criticalChanceHA == 3)
                    {
                         Health -= heavyAttack + 11;
                         Stamina -= 5;
                         
                         Console.WriteLine("You have have a big luck my friend! You have crushed him to the ground!");
                    }
                    else
                    {
                        Health -= heavyAttack;
                        Stamina -= 5;
                        
                        Console.WriteLine("You have used your heavy attack weapon and dealt 4!");
                    }
                }

            }
            
        }

        public void Dodge(int stamina, int health, string userChoice, int criticalChanceFist, int criticalChanceLA, int criticalChanceHA)
         {
            if(criticalChanceFist == 1) 
            {
                Console.WriteLine("Your opponent attacked with fist, had luck and dealt 2 damage with critical! Do you want to dodge? If yes than press 1 if not press 2");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4);
                    stamina -= 1;
                    health -= 1;
                }
                else
                {
                    health -= 2;
                    if(stamina == 10)
                    {
                        stamina += 0;
                    }
                    else
                    {
                        stamina += 1;
                    }
                }
            }
            else if(criticalChanceFist == 2)
            {
                Console.WriteLine("Your opponent attacked with fist, and dealt 1 damage without critical! Do you want to dodge? If yes than press 1 if not press 2");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4);
                    stamina -= 1;
                }
                else
                {
                    health -= 0;
                    if(stamina == 10)
                    {
                        stamina += 0;
                    }
                    else
                    {
                        stamina += 1;
                    }
                }
            }
            if(criticalChanceLA == 1)
            {
                Console.WriteLine("Your opponent attacked with light weapon and dealt 2 damage with critical! Do you want to dodge this attack? Yes for 1, No for 2");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4,5);
                    if(dodgeChance == 1)
                    {
                        health -=1;
                        stamina -=1;
                    }
                }
                else
                {
                    health  -= 3;
                    stamina += 2;
                }
            }
            if(criticalChanceLA == 2)
            {
                Console.WriteLine("Your opponent attacked with light weapon and dealth 2 damage without critical! Do you wwant to dodge this attack? 1 for Yes, 2 for No");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4,5);
                    if(dodgeChance == 1)
                    {
                        health -= 1;
                        stamina -= 1;    
                    }
                    else
                    {
                        health -= 2;
                        stamina += 1;
                    }
                }
            }
            if(criticalChanceHA == 1)
            {
                Console.WriteLine("Your opponent attacked with heavy weapon and dealt 4 damage with critical! Do you wwant to dodge this attack? 1 for Yes, 2 for No");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4,5,6,7,8,9,10);
                    if(dodgeChance == 1)
                    {
                        health -= 15;
                        Console.WriteLine("This attack was too powerful and cannot be dodged!");    
                    }
                    else
                    {
                        health -= 15;
                        stamina += 5;
                    }
                }
            }
            if(criticalChanceHA == 2)
            {
                Console.WriteLine("");
                var userDodgeInput = Console.ReadLine();

                if(userDodgeInput == "1")
                {
                    dodgeChance = GetRandomNumber(1,2,3,4,5,6,7,8,9,10);
                    if(dodgeChance == 1)
                    {
                        health -= 3;
                        stamina += 3;
                    }
                    else
                    {
                        health -= 4;
                        stamina += 2;
                    }
                }
            }

         }

        public void IncreeeseHealth(int value)
        {           
            Health += value;
        }

        public void ChangeYearOfBirth(int yearOfBirth)
        {
            CheckYearOfBirth(yearOfBirth);
            YearOfBirth = yearOfBirth;
        }

        public bool IsFirstNameValid()
        {
            if(FirstName.Length > 3)
            {
                return true;
            }

            return false;
        }

        private void CheckYearOfBirth(int yearOfBirth)
        {
            if (YearOfBirth == yearOfBirth)
            {
                throw new ArgumentException("Year can not be changed to same year as is already in the system");
            }

            if (yearOfBirth <= 0)
            {
                throw new ArgumentException("Year must be greater than 1950");
            }
        }
    }
}
