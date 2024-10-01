using System.ComponentModel.Design;

namespace KonsolApp
{
    public class LoginSystem
    {
        public void system()
        {
            while (true)
            {
                ShowMenu();
            }
        }
        private string username;
        private string password;
        public void ShowMenu() //Overvejet at implementere 3 menuer GuestMenu, WorkerMenu og MainMenu
        {
            Console.WriteLine("Vælg en af følgende");
            Console.WriteLine("1. Login som gæst");
            Console.WriteLine("2. Login som medarbejder");
            Console.WriteLine("3. Logud");
            string userInput = Console.ReadLine();
            Console.Clear();

            if (userInput == "1")
            {
                LoginGuest();
            }
            else if (userInput == "2")
            {
                LoginWorker();
            }
            else if (userInput == "3")
            {
                Logout();
            }

            else
            {
                Console.WriteLine("Forkert indtastning, prøv igen");
            }
        }

        public void LoginGuest()
        {
            Console.WriteLine("Brugernavn");
            username = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Kodeord");
            password = Console.ReadLine();
            Console.Clear();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (CheckCredentials(username, password))
                {
                    DisplayWelcomeMessage(username);
                }
                else
                {
                    Console.WriteLine("Forkert Login, prøv igen");
                }
            }
            else
            {
                ValidateInput(username, password);
            }
        }

        public void LoginWorker()
        {
            Console.WriteLine("Brugernavn");
            username = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Password");
            password = Console.ReadLine();
            Console.Clear();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (CheckCredentials(username, password))
                {
                    DisplayWelcomeMessage(username);
                }
                else
                {
                    Console.WriteLine($"Forkert Login, prøv igen \n ");
                }
            }
            else
            {
                ValidateInput(username, password);
            }
        }


        public void Logout()
        {
            Console.WriteLine($"Du er nu logged ud \n ");
            System.Environment.Exit(0);
        }

        public bool ValidateInput(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Brugernavn og password kan ikke være tom " +
                    "\n");
                return false;
            }

            return true;
        }

        //public string GetUserType() { } Medarbejder / Gæst

        private bool CheckCredentials(string username, string password)
        {
            string validUsername = "Michael";
            string validPassword = "Random123";
            return username == validUsername && password == validPassword;
        }

        private void DisplayWelcomeMessage(string username)
        {

            DateTime now = DateTime.Now;

            string Konverterettid = now.ToString("");

            Console.WriteLine($"Velkommen til Hydac {username}, logged in {Konverterettid} \n");
        }

        //private string RetrieveGuestData() { }
        //private string RetrieveWorkerData() { }

        private void LogActivity(string userType, string activity) { }
    }
}

