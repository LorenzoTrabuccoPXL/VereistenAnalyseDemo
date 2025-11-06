namespace VereistenanalyseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string password;

            do
            {
                Console.Write("Naam: ");
                name = Console.ReadLine();
            } while (name.Length >= 12);
            do
            {
                Console.Write("Geef je wachtwoord in: ");
                password = Console.ReadLine();
            } while (password.Length >= 12 && char.IsUpper(password[0]) && password.Length < 6);

            




        }
    }
}
