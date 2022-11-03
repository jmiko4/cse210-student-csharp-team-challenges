
namespace Unit04.Game.Casting{

    public class Clock{

        private int _timer;
        private int _tickCount;
        public Clock(){
            _timer = 60;
            _tickCount = 0;
        }

        public void Tick(){
            _tickCount++;
            if (_tickCount == 12){
                _tickCount = 0;
                _timer--;
            }
        }

        public string GetTimer(){
            if (_timer <= 0){
                string lost = "game over";
                return (lost);
            }
            else{return _timer.ToString();}
        }

        


    }


}