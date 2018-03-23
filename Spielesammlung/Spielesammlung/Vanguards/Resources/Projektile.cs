using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int _velocity = 5;
        private int _flightTime = 0;
        private bool visible;
        private Bitmap projectileBit = Resources.greenProjectile;

        public bool Hostile
        {
            get
            {
                return _hostile;
            }

            set
            {
                _hostile = value;
            }
        }

        public int PosX
        {
            get
            {
                return _posX;
            }

            set
            {
                _posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _posY;
            }

            set
            {
                _posY = value;
            }
        }

        public int Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                _velocity = value;
            }
        }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }

            set
            {
                _flightTime = value;
            }
        }

        public bool Visible
        {
            get
            {
                return visible;
            }

            set
            {
                visible = value;
            }
        }

        public Bitmap ProjectileBit
        {
            get
            {
                return projectileBit;
            }

            set
            {
                projectileBit = value;
            }
        }

        public Projektile(bool hostile, bool visible, int posX, int posY, int velocity)
        {
            Hostile = hostile;
            PosX = posX;
            PosY = posY;
            Velocity = velocity;
            this.Visible = visible;
        }


    }

}