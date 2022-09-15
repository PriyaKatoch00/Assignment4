using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Building
    {
        public string capacity;
        public string dimension;
        public int floorno;
        public string flatdate;
        public string villadate;


        public Building(string capacity, string dimension, int floorno, string flatdate, string villadate)
        {
            this.capacity = capacity;
            this.dimension = dimension;
            this.floorno = floorno;
            this.flatdate = flatdate;
            this.villadate = villadate;
        }
        public void flatshow()
        {
            Console.WriteLine("Capacity of flat " + capacity);
            Console.WriteLine("Dimension of flat " + dimension);
            Console.WriteLine("FloorNo " + floorno);

        }
        public void flatcomp()
        {
            Console.WriteLine("Completion Date" + flatdate);
        }
        public void villashow()
        {
            Console.WriteLine("Capcity of villa " + capacity);
            Console.WriteLine("Dimesion of villa" + dimension);
            Console.WriteLine("Land dimesion of villa " + dimension);

        }
        public void villacomp()
        {
            Console.WriteLine("Completion Date " + villadate);
        }
        static void Main()
        {
            char f = 'f';
            char v = 'v';
            char type;
            string capacity;
            string dimension;
            int floorno;
            string flatdate;
            string villadate;
            Console.WriteLine("Enter type of flat/villa (F/V)");
            type = Console.ReadLine()[0];
            Console.WriteLine("Enter capacity");
            capacity = Console.ReadLine();
            Console.WriteLine("Enter dimension");
            dimension = Console.ReadLine();
            floorno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Completion Date");
            flatdate = Console.ReadLine();
            Console.WriteLine("Enter villadate");
            villadate = Console.ReadLine();
            Building b1 = new Building(capacity, dimension, floorno, flatdate, villadate);
            if (type == f)
            {
                b1.flatshow();
                b1.flatcomp();
            }
            else if (type == v)
            {
                b1.villashow();
                b1.villacomp();
            }


        }
    
    }
}
