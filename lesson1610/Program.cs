using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1610
{
    abstract class ObjectsofUniverse
    {
        private string nameofobject;
        public double dimensionradius ;
        public int Dimensionradius { get; set; }
        public string Namesofobject { get; set; }
        public ObjectsofUniverse (string nameofobject,int dimensionradius)
        {
            Namesofobject = nameofobject ;
            Dimensionradius = dimensionradius;
        }
        public void Display()
        {
            Console.WriteLine(Namesofobject);
        }
        public void Print()
        {
            Console.WriteLine("Работаем,девачки");
        }
        public void Printname()
        {
            Console.WriteLine(Dimensionradius);
        }
        public double Dimension()
        {
            return Math.PI * dimensionradius * dimensionradius;
        }
    }
    class Planetas : ObjectsofUniverse
    {
        public int Position { get {return Position; } set { Position = value; } }
        public Planetas(string nameofobject, int position)
            : base(nameofobject)
        {
            Position = position;
        }
        public void Display1()
        {
            Console.WriteLine(Position);
        }
        public void Printim()
        {
            Console.WriteLine(Namesofobject,Position);
        }
        public void Idonotknow()
        {
            int position1 = Position * 4 * 6 * 7 / 9;
            Console.WriteLine(position1);
        }
        public string Iamtired()
        {
            return "Position" + Position;
        }
    }
    class Stars : ObjectsofUniverse
    {
        public string Brightness { get { return Brightness; } set {Brightness=value; } }
        public string Colour { get { return Colour; } set { Colour = value; } }
        public Stars(string brightness, string colour,string nameofobject)
            :base(nameofobject)
        {
            Brightness = brightness;
            Colour = colour;
        }
        public void Colours()
        {
            Console.WriteLine(Colour);
        }
        public void Prined()
        {
            Console.WriteLine("тутутутутуту");
        }
        public void Zvezda()
        {
            Console.WriteLine(Namesofobject);
        }
        public double Dimensionss()
        {
            return Math.PI * dimensionradius * dimensionradius;
        }
    }
    class Satellite : ObjectsofUniverse
    {
        public string Orbitradius { get { return Orbitradius; } set { Orbitradius = value; } }
        public Satellite(string radius, string nameofobject)
            : base(nameofobject)
        {
            Orbitradius = radius;
        }
        public void Mainn()
        {
            return ;
        }
        public void PrintY()
        {
            Console.WriteLine("i have no imagination");
        }
        public void Object()
        {
            Console.WriteLine(Orbitradius);
        }
        public string dimen()
        {
            if (Orbitradius.Equals(5))
            {
                return Orbitradius;
            }
            return "Не круто";
        }
        public void Proposition()
        {
            Console.WriteLine("Ураа,всеее");
        }
    }
    class Program
    {
        static void Main ( string[] args)
        {
            Satellite satellite = new Satellite("1815 км","спутник Юпитера-Ио");
            Stars star = new Stars("0,14", "белый","Вега");
            Planetas planeta = new Planetas("Земля", 4);
        }

    }
}
