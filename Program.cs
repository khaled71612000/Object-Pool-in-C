using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTask03
{
     class Program
    {
        static void Main(string[] args)
        {
            ParticlePool bullet = new ParticlePool();
            bullet.create(100, 100, 2 , 2 , 2000);
            int i = 4100;
            while (i > 0)
            {
                bullet.moving();
                Console.WriteLine(bullet.ToString());
                i--;
            }

            Console.ReadLine();
        }
    }
}
