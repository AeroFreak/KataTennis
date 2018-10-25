using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis
{
    class KataTennisGame
    {
        private String player1;
        private int player1score;

        private String player2;
        private int player2score;

        private Random rnd = new Random();

        private Boolean winner = false;

        public KataTennisGame(String _player1, String _player2)
        {
            this.player1 = _player1;
            this.player2 = _player2;
            this.player1score = 0;
            this.player2score = 0;
            this.winner = false;
        }

        public Boolean AWinner()
        {
            return winner;
        }

        public void randomScore()
        {
            int random = rnd.Next(1, 5);
            if (random >= 3)
                player1scores();
            else
                player2scores();
        }

        private String strScore(int playerScore)
        {
            switch (playerScore)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                case 4:
                    return "Advantage";
                default:
                    return "Error getting score";
            }
        }
        public String getGlobalScore()
        {
            if (player1score >= 4 && player1score >= player2score + 2)
            {
                this.winner = true;
                return player1 + " wins!";
            }
            if (player2score >= 4 && player2score >= player1score + 2)
            {
                this.winner = true;
                return player2 + " wins!";
            }
            if (player1score >= 4 && player1score == player2score + 1)
                return player1 + " advantage!";
            if (player2score >= 4 && player2score == player1score + 1)
                return player2 + " advantage!";
            if (player1score >= 3 && player2score == player1score)
                return "Deuce!";

            return player1 + " " + strScore(this.player1score) + " / " + player2 + " " + strScore(this.player2score);
        }

        public void player1scores()
        {
            this.player1score++;
            Console.WriteLine(player1 + " scores!");
        }
        public void player2scores()
        {
            this.player2score++;
            Console.WriteLine(player2 + " scores!");
        }
    }
}
