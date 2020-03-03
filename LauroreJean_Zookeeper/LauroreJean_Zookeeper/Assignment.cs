using System;
using System.Collections.Generic;

namespace LauroreJean_Zookeeper
{
    interface ITrainable
    {
        Dictionary<string, string> Behaviors { get; set; }
        string Perform(string signal);
        string Train(string signal, string behavior);
    }

    public class Assignment:ITrainable
    {
        public Dictionary<string, string> Behaviors { get; set; }
        private Menu _myMenu;

        public Assignment()
        {
            _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
            _myMenu.Title = "Welcome to the Zoo";
            _myMenu.Display();
            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("\nPlease enter your selection: ");
            if (choice < 1 || choice > 7)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Selection();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Pigeon();
                        break;

                    case 2:
                        Dog();
                        break;

                    case 3:
                        Parrots();
                        break;

                    case 4:
                        Raccoon();
                        break;

                    case 5:
                        Bat();
                        break;

                    case 6:
                        Opossum();
                        break;

                    case 7:
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        
        public void Pigeon()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Pigeon");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Pigeon p = new Pigeon("signal", "behavior", "pigeon", 4, "corn");

            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Pigeon();
            }
            else if (choice == 1)
            {
                string b = Validation.ValidateString("\nWhat new behavior are you training the animal to do?");
                string s = Validation.ValidateString("\nWhat signal will you use to ask the animal to perfom this new behavior?");

                p.Signal = s;
                p.Behavior = b;

                //Behaviors.Add(s, b);

                Console.WriteLine($"The Pigeon learned to {b} when you make the {s}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Pigeon();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{p.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Pigeon();
            }
            else if (choice == 3)
            {
                if (p is ITrainable)
                {
                    Console.WriteLine($"{p.Perform(p.Signal)}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Pigeon();
                }
                else
                {
                    Console.WriteLine("The pigeon does not know this signal");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Pigeon();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{p.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Pigeon();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }

        public void Dog()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Dog");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Dog d = new Dog("food", 4, "");
            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Dog();
            }
            else if (choice == 1)
            {
                string b = Validation.ValidateString("\nWhat new behavior are you training the animal to do?");
                string s = Validation.ValidateString("\nWhat signal will you use to ask the animal to perfom this new behavior?");

                d.Signal = s;
                d.Behavior = b;

                //Behaviors.Add(s, b);

                Console.WriteLine($"The Dog learned to {b} when you make the {s}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Dog();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{d.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Pigeon();
            }
            else if (choice == 3)
            {
                if (d is ITrainable)
                {
                    Console.WriteLine($"{d.Perform(d.Signal)}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Dog();
                }
                else
                {
                    Console.WriteLine("The dog does not know this signal");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Dog();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{d.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Dog();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }


        public void Parrots()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Parrot");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Parrots p = new Parrots("food", 4, "treat");

            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Parrots();
            }
            else if (choice == 1)
            {
                string b = Validation.ValidateString("\nWhat new behavior are you training the animal to do?");
                string s = Validation.ValidateString("\nWhat signal will you use to ask the animal to perfom this new behavior?");

                p.Signal = s;
                p.Behavior = b;

                //Behaviors.Add(s, b);

                Console.WriteLine($"The Parrot learned to {b} when you make the {s}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Parrots();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{p.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Parrots();
            }
            else if (choice == 3)
            {
                if (p is ITrainable)
                {
                    Console.WriteLine($"{p.Perform(p.Signal)}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Parrots();
                }
                else
                {
                    Console.WriteLine("The parrot does not know this signal");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    Parrots();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{p.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Parrots();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }


        public void Raccoon()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Raccoon");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Raccoon r = new Raccoon("worms", 4, "treat");

            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Raccoon();
            }
            else if (choice == 1)
            {
                

                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Raccoon();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{r.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Raccoon();
            }
            else if (choice == 3)
            {

                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Raccoon();
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{r.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Raccoon();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }


        public void Bat()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Bat");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Bat b = new Bat("food", 4, "treat");

            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Bat();
            }
            else if (choice == 1)
            {

                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Bat();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{b.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Bat();
            }
            else if (choice == 3)
            {

                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Bat();
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{b.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Bat();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }


        public void Opossum()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================");
            Console.WriteLine("You have selected a Opossum");
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nWhat would you like to do with the selected animal?");

            Console.WriteLine("1. Train the animal in a new behavior.");
            Console.WriteLine("2. Feed the animal a treat.");
            Console.WriteLine("3. Signal to the animal to perform a behavior.");
            Console.WriteLine("4. listen to the animal make a noise");
            Console.WriteLine("5. Select a different animal.");

            Opossum o = new Opossum("food", 4, "treat");

            int choice = Validation.ValidateInt("\nPlease select one: ");

            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Opossum();
            }
            else if (choice == 1)
            {
                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Opossum();
            }
            else if (choice == 2)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"{o.Eat()}");
                Console.WriteLine("---------------------");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Opossum();
            }
            else if (choice == 3)
            {

                Console.WriteLine($"The animal you selected is not a trainable animal. Please select a different activity or exit to select a different animal.”");                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Opossum();
            }
            else if (choice == 4)
            {
                Console.WriteLine($"{o.MakeNoise()}");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

                Opossum();
            }
            else if (choice == 5)
            {
                _myMenu = new Menu("Pigeon (Trainable)", "Dog (Trainable)", "Parrots (Trainable)", "Raccoon", "Bat", "Opossum", "Exit");
                _myMenu.Title = "Welcome to the Zoo";
                _myMenu.Display();
                Selection();
            }

        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using my Zoo application. GoodBye!");
        }

        public string Perform(string signal)
        {
            return signal;
        }

        public string Train(string signal, string behavior)
        {
            return $"{behavior} {signal}";
        }
    }

}