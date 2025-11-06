namespace VereistenanalyseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            string inputPassword;
            string name;
            string password;
            int numberOfTries = 0;
            do
            {
                Console.Write("Naam: ");
                inputName = Console.ReadLine();
            } while (inputName.Length >= 12);
            do
            {
                Console.Write("Geef je wachtwoord in: ");
                inputPassword = Console.ReadLine();
            } while (inputPassword.Length >= 12 && char.IsUpper(inputPassword[0]) && inputPassword.Length < 6);

            do
            {
                numberOfTries++;
                Console.Write("Login naam: ");
                name = Console.ReadLine();
                Console.Write("Geef je wachtwoord in: ");
                password = Console.ReadLine();
                if (inputName != name || inputPassword != password)
                    Console.WriteLine("login naam en paswoord komen niet overeen");
            } while ((inputName != name || inputPassword != password) && numberOfTries < 3);




        }
    }
}
