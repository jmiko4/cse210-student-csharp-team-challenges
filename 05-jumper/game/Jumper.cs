using System;
using System.Collections.Generic;

namespace _05_jumper.Game{

    public class Jumper{
        //Creates the Jumper object
        private List<string> _jumper = new List<string>();
        public Jumper(){
            _jumper.Add(@"  ___  ");
            _jumper.Add(@" /___\ ");
            _jumper.Add(@" \   / ");
            _jumper.Add(@"  \ / ");
            _jumper.Add(@"   0  ");
            _jumper.Add(@"  /|\  ");
            _jumper.Add(@"  / \  ");
            _jumper.Add("");
            _jumper.Add(@"^^^^^^^");
        }

        public List<string> GetJumper(){
            return _jumper;
        }

        public List<string> RemoveLine(){
            _jumper.RemoveAt(0);
            return _jumper;
        }


    }



}