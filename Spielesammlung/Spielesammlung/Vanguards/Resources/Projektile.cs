using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Vanguards.Resources
{
    class Projektile
    {
        private bool _hostile;
        private int _posX;
        private int _posY;
        private int _velocity=5;
        private int _flightTime=0;

        public Projektile(bool hostile, int posX, int posY, int velocity)
        {
            Hostile = hostile;
            PosX = posX;
            PosY = posY;
            Velocity = velocity;
        }

        public bool Hostile { get => _hostile; set => _hostile = value; }
        public int PosX { get => _posX; set => _posX = value+100; }
        public int PosY { get => _posY; set => _posY = value+50; }
        public int Velocity { get => _velocity; set => _velocity = value; }
        public int FlightTime { get => _flightTime; set => _flightTime = value; }
    }
}
