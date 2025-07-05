using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class MountainBike:Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight, int cadence, int speed, int gear): base(cadence, speed, gear)
        {
            this.seatHeight = seatHeight;
        }
        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
        public int GetCadence()
        {
            return cadence;
        }
        public int GetSpeed()

        { return speed; }
        public void GetShow()
        {
            ShowAll();
        }
    }
}
