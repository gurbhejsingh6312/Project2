using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russianroulletegun
{
    public class Roullete
    {
        public int load; // Variable to hold the position of the bullet at the time of loading bullet in chamber
        public int spin_Bullet; // variable to hold position of the bullet after spinning the chamber
        public int Total_Fire = 6;//sets the total number of fire
        public int Point_Away = 2;//set the number of chances to shoot away bullet

        public int Bulleteloop(int MissedBullet)
        {
            if (MissedBullet == 6)
            {
                MissedBullet = 1;
            }
            else
            {
                MissedBullet++;
            }
            return MissedBullet;
        }
    }
}
