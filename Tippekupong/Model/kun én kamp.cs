namespace Tippekupong.Model
{
    public class kun_én_kamp
    {
        private int homeGoals = 0;
        private int awayGoals = 0;
        private bool matchIsRunning = true;
        private string bet;
        public void Run()
        {
            StartGame();
            while (matchIsRunning) NextTick();
            EndOfGmae();
        }

        private void StartGame()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            bet = Console.ReadLine().ToUpper();
        }


        private void NextTick()
        {
            Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            string userInput = Console.ReadLine().ToUpper();
            matchIsRunning = userInput != "X";
            if (userInput == "H") homeGoals++;
            else if (userInput == "B") awayGoals++;
            Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
        }
        private void EndOfGmae()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }

    /*
    Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
    var bet = Console.ReadLine();
    var homeGoals = 0;
    var awayGoals = 0;
    var matchIsRunning = true;
    while (matchIsRunning)
    {
        Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
        var command = Console.ReadLine();
        matchIsRunning = command != "X";
        if (command == "H") homeGoals++;
        else if (command == "B") awayGoals++;
        Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
    }

    var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
    var isBetCorrect = bet.Contains(result);
    var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
    Console.WriteLine($"Du tippet {isBetCorrectText}"); 
     
     */
}
