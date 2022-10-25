using System;
using System.Collections.Generic;

namespace _05_jumper.Game{

    public class TerminalService{

        // used to display the jumper
        public TerminalService() {}

        public void DisplayJumper(List<String> jumper) {
            for (int i = 0; i <jumper.Count; i++) {
                Console.WriteLine(jumper[i]);
            }

        }



    }



}