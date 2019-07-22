using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script
{
    class Vehicle
    {
        public Vehicle() { }
        public Vehicle(int canJumpTimes,float speed) { CanJumpTimes = canJumpTimes; Speed = speed; }
        
        public int CanJumpTimes{ set; get; }
        public float Speed { set; get; }
    }
}
