using System;

class abstractClasses {
  public static void Main (string[] args) {
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());
        }
    }
    abstract class Figure
    {
        public abstract int Perimeter();        
    }
    class Rectangle : Figure
    {
        public int width;
        public int height;
        public int perimeter;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override int Perimeter(){
            perimeter = 2*width + 2*height;
            return perimeter;    
        }
        //override Perimeter method for rectangle
        
    }
    class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;
        public int perimeter;
        public Triangle(int s1, int s2, int s3)
        {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        public override int Perimeter(){
            perimeter = side1 + side2 + side3;
            return perimeter;
        }        
        //override Perimeter method for triangle      
  }
