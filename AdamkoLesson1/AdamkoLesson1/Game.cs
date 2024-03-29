﻿namespace AdamkoLesson1
{
    public class Game
    {
        public Game(List<Player> players, bool isSingle, int maxPlayersCount)
        {
            if (isSingle && players.Count != 1)
            {
                throw new ArgumentException("Single player can be played only with 1 player.");
            }

            if (!isSingle && players.Count < 2)
            {
                throw new ArgumentException("Multi player can be played at least with 2 players.");
            }

            Players = players;
            IsSingle = isSingle;
            MaxPlayersCount = maxPlayersCount;
        }

        

        public List<Player> Players { get; }
        public bool IsSingle { get; }
        public int MaxPlayersCount { get; }
        public bool IsGameRunning { get; private set; }

       
        public void Start()
        {
            IsGameRunning = true;

            int currentPlayerIndex = 0;

            while (Players.All(x => x.Health > 0))
            {
             Player currentPlayer = Players[currentPlayerIndex];

            currentPlayer.DecreaeseHealth(int stamina, int fist, int lightAttack, int heavyAttack, int criticalChanceFist, int criticalChanceLA, int criticalChanceHA, string userChoice);
            currentPlayerIndex = (currentPlayerIndex + 1) % Players.Count;
            }

            IsGameRunning = false;
        }

        public void AddPlayer(Player player)
        {
            if (IsSingle)
            {
                throw (new ArgumentException("You can not add more player in case of Single player"));
            }

            if (Players.Count >= MaxPlayersCount)
            {
                throw (new ArgumentException("Max player count reached."));
            }

            if (IsGameRunning)
            {
                throw (new ArgumentException("Player can be added only in case game is not started."));
            }

            Players.Add(player);
        }
    }
}
