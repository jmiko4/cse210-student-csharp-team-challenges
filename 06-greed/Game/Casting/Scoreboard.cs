using System.Collections.Generic;


namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A scoreboard.</para>
    /// <para>Keeps track of the scoreboard
    /// </para>
    /// </summary>
    public class Scoreboard
    {


        private int _points;

        public Scoreboard(){
            _points = 600;
        }

        public int GetPoints(){
            return _points;
        }

        public void AddPoint(){
            _points++;
        }

        public void RemovePoint(){
            _points--;
        }



    }
}