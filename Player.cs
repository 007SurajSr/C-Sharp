using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string Name = "Suraj";
        
        
        private int health = 24;
         public int gethealth ()
            { 
            return health; 
            }
       
        
        public void setHealth (int h)
        {
            
            health = h;
        }
    }
}
