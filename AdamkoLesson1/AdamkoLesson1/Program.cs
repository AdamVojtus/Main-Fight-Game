using AdamkoLesson1;

var player1 = new Player("Anton", "Sutiak", 1983, 20, 10);
var player2 = new Player("Adam", "Vojtus", 2008, 20, 10);

var listOfPlayers = new List<Player>
{
    player1, 
    player2,
};

var game = new Game(listOfPlayers, false, 10);

var newPlayer = new Player("Jon", "Snow", 1800, 20, 10);
game.AddPlayer(newPlayer);

game.Start();

while (game.IsGameRunning)
{
     Console.WriteLine("Score of players are:");
            foreach (var player in game.Players)
            {
                Console.WriteLine($"{player.FirstName} {player.LastName}: Health - {player.Health}, Stamina - {player.Stamina}");
            }

            // Wait for a short duration before checking game state again
            System.Threading.Thread.Sleep(1000);
}

Console.WriteLine("Game over!");
Console.ReadLine();

