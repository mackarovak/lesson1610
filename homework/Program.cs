using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Building
    {
        private int Height;
        private int Numberoffloors;
        private int Numberofapartments;
        private int Numberofentrances;
        private readonly int uniqnumber;
        private static int UniqueNumber = 0;
        public Building()
        {
            UniqueNumber+= 1;
            uniqnumber = UniqueNumber;
        }
        public int Floorheight()
        {
            return Height/Numberoffloors;
        }
        public int Numberofapartmentsintheentrance()
        {
            return Numberofapartments/Numberofentrances;
        }
        public int Numberofapartmentsperfloor()
        {
            int number = Numberofapartmentsintheentrance();
            return number/Height;
        }
    }   
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            int colichestvopod=building.Floorheight();
            int colichestvocvartir = building.Numberofapartmentsintheentrance();
            int colichestvocvartirinetazh = building.Numberofapartmentsperfloor();
            Console.WriteLine("{0};{1};{2}",colichestvopod,colichestvocvartir,colichestvocvartirinetazh);
        }
            
    }
}
