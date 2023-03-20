
namespace Tippekupong.Model
{
    internal class Tippekupong___12_kamper
    {
        private kun_én_kamp[] matches;


        public Tippekupong___12_kamper()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
            string[] bets = Console.ReadLine().ToUpper().Split(',');

            matches = new kun_én_kamp[bets.Length];
            for (var i = 0; i < bets.Length; i++)
            {
                matches[i] = new kun_én_kamp(bets[i]);
            }
            game();
        }

        public void game()
        {
            foreach (var match in matches)
            {
                match.Run();
            }
            endOfGame();
        }

        private void endOfGame()
        {
            int correctCount = 0;
            foreach (var match in matches)
            {
                if (match.isBetCorrect) correctCount++;
            }
            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}

/*
Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");
var betsText = Console.ReadLine();
var bets = betsText.Split(',');
var matches = new Match[12];
for (var i = 0; i < 12; i++)
{
    matches[i] = new Match(bets[i]);

    while (true)
    {
        Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
        var command = Console.ReadLine();
        if (command == "X") break;
        var matchNo = Convert.ToInt32(command);
        Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
        var team = Console.ReadLine();
        var selectedIndex = matchNo - 1;
        var selectedMatch = matches[selectedIndex];
        selectedMatch.AddGoal(team == "H");
        var correctCount = 0;
        for (var index = 0; index < matches.Length; index++)
        {
            var match = matches[index];
            var mathNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
        }

        Console.WriteLine($"Du har {correctCount} rette.");
    }
*/