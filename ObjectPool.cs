using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTask03
{
    public class Particle
    {
       public int limit;
       public double x, y, Xvel, Yvel;
        public void start(double x, double y, double xvol, double yvol, int wall)
        {
            this.x = x;
            this.y = y;
            Xvel = xvol;
            Yvel = yvol;
            limit = wall;
        }

        public void move()
        {
            if (!inUse()) return;

            limit -=1;
            this.x += Xvel;
            this.y += Yvel;
        }

      public  bool inUse()  {
            return limit > 0; 
        }
    }


    class ParticlePool
    {
        public Particle[] particles = new Particle[100];
        public void create(double x, double y, double xvol, double yvol, int wall) {
            for (int i = 0; i< 100; i++)
            {
                particles[i] = new Particle();
                if (!particles[i].inUse())
                {
                    particles[i].start(x,y, xvol, yvol, wall);
                    return;
                }
            }
        }

        public void moving()
        {
                particles[0].move();

        }

        public override string ToString()
        {
            return ($"Bullet pos on on X is {particles[0].x} and Bullet pos on Y is {particles[0].y}");
            
        }

    }
    
}
