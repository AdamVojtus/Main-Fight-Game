namespace AdamkoLesson1
{
    public class Player
    {
        public Player(string firstName, string lastName, int yearOfBirth, int health)
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

        public void DecreaeseHealth(int stamina, int fist, int lightAttack, int heavyAttack, int criticalChanceFist, int criticalChanceLA, int criticalChanceHA)
        {
            if(Health <= 0)
            {
                throw new ArgumentException("You are already dead!");
            }

            if(Stamina <= 0)
            {
                throw new ArgumentException("You dont have enough power to challenge your opponent!");
            }

            if( )

                Console.WriteLine("Please choose your attack option : 1. Fist 2. Light Attack 3. Heavy Attack");

                fist = 1;
                lightAttack = 2;
                heavyAttack = 4;

                criticalChancefist = Random(1, 2);

                if(criticalChance == 2)
                {
                    Health -= damage + 2;
                    Stamina -= 2;

                }
                else
                {
                    Health -= damage;
                    Stamina -= 2;
                }

            }
            
        }

        private int Random(int v1, int v2)
        {
            throw new NotImplementedException();
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
