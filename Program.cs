using System;

namespace HomeTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Alik", "Gafarov");
            Console.WriteLine("Login:");

            user.resultu = Console.ReadLine();

            Console.WriteLine("Password:");
            user.resulta = Console.ReadLine();

        }
    }
    class Human
    {
        public string Name;
        public string Surname;

        public Human(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
    class User:Human
    { 
        private string Username;
        public string resultu
        {

            get
            {
                return Username;
            }
            set
            {

                if (value.Length > 6)
                {
                    Username = value;

                    {
                        Console.WriteLine("Giris Ugurludur");
                    }

                }
                else
                {
                    Console.WriteLine("Wrong Data!");
                }
            }
            
        }
        private string Password;
        public string resulta
        {
            get
            {
                return Password;
            }
            set
            {

                if (value.Length > 6)
                {
                    Password = value;
                    {
                        Console.WriteLine("Giris Ugurludur");
                    }

                }
                else
                {
                    Console.WriteLine("Wrong Data!");
           
                }

            }
        }
        //public string getinfo()
        //{
        //    return $"Name: {Name} Surname: {Surname}";
        //}

        public User(string name,string surname):base(name,surname)
        {
           
        }
    }
    class Admin
    {
        private string Username;
        public string resulta
        {

            get
            {
                return Username;
            }
            set
            {

                if (value.Length > 6)
                {
                    Username = value;
                    {
                        Console.WriteLine("Giris Ugurludur");
                    }

                }
                else
                {
                    Console.WriteLine("Wrong Data!");
                }

            }
        }
        private string Password;






    }
}
