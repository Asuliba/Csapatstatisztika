using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csapatstatisztika
{
    public class Player
    {
        private string _name;
        private string _position;
        private int _number;

        private int gamesPlayed;
        private int totalPoints;


        public int GamesPlayed { get { return gamesPlayed; }}
        public int TotalPoints { get { return totalPoints; }}


        public string Name { get { return _name; } set { _name = value; } }
        public string Position { get { return _position; } set { _position = value; } }
        public int Number { get { return _number; }
            set
            {
                if(_number > 0 && _number < 99)
                {
                    _number = value;
                }
                else
                {
                    _number = 0;
                }
            }
        }

        public static int Count = 0;

        public Player(string name, string position, int number)
        {
            _name = name;
            _position = position;
            _number = number;
            Count++;
        }

        public bool AddGame(int points)
        {
            if(points < 0)
            {
                return false;
            }
            else
            {
                gamesPlayed++;
                totalPoints += points;
                return true;
            }
        }

        public double AveragePoints()
        {
            if(totalPoints < 0)
            {
                return 0;
            }
            else
            {
                return totalPoints / gamesPlayed;
            }
        }

        public string GetDescription()
        {
            return $"#{_number} {_name} ({_position}), átlag: {Math.Round(AveragePoints(),1)} pont";
        }

    }
}
