using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class structsPractice1
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;
       
        public Cuboid(int x, int y, int z){
            this.length = x;
            this.width = y;
            this.height = z;            
        }
        public int Volume () {
            return (length * width * height);
        }
        public int Perimeter () {
            return (4*(length + width + height));
        }       
    }
