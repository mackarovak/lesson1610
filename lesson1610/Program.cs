using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace lesson1610
{
    abstract class ObjectsofUniverse
    {
        private string nameofobject;
        public int Dimensionradius { get; set; }
        public string Namesofobject { get; set; }
        public ObjectsofUniverse (string nameofobject)
        {
            Namesofobject = nameofobject ;
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
        public void AnythingaboutUniverse()
        {
            Console.WriteLine("Не имеющее строгого определения понятие в астрономии и философии. Оно делится на две принципиально отличающиеся сущности: умозрительную и материальную, доступную наблюдениям в настоящее время или в обозримом будущем");
        }
    }
    class Planetass : ObjectsofUniverse
    {
        public int Position { get {return Position; } set { Position = value; } }
        public Planetass(string nameofobject, int position)
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
        public string Brightness { get { return Brightness; } set { Brightness = value; } }
        public string Colour { get { return Colour; } set { Colour = value; } }
        public Stars(string brightness, string colour, string nameofobject)
            : base(nameofobject)
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
        public void BooksofStars()
        {
            Console.WriteLine("{«Суперобъекты. Звезды размером с город»} \n {«Разведка далеких планет»} \n {«Космос Эйнштейна»}");
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
                return;
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
            static void Main(string[] args)
            {
                var text = new StreamReader("Universe.txt");
                var Planets = new Dictionary<int, Planetass>();
                int countplanets = 0;
                while (text.ReadLine() != null)
                {
                    countplanets++;
                }
                text = new StreamReader("Universe.txt");
                for (int i = 1; i <= countplanets; i++)
                {
                    string[] prikolnenkotemp = text.ReadLine().Split();
                    string bright = prikolnenkotemp[0];
                    string  colour= prikolnenkotemp[1];
                    string name = prikolnenkotemp[2];
                    Planets.Add(i,new Planetass(bright,colour,name));
                }
                string radius = Console.ReadLine();
                string satellites = Console.ReadLine();
                Satellite satellite = new Satellite(radius, satellites);
                Stars star = new Stars("0,14", "белый", "Вега");
                Planetass planeta = new Planetass("Земля", 4);
            }
        }
    }
}
