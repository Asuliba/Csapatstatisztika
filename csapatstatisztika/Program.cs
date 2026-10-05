namespace csapatstatisztika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Béla", "kapus", 1);
            ConsoleView consoleView = new ConsoleView();
            consoleView.ShowPlayer(player1);
            consoleView.ShowMessage("Message");

        }
    }
}
