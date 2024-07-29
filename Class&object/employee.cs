using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_object
{
    public class employee
    {
        public int Id = 0;
        public string name = "";
        public int basic_salry = 0;


        public void input()
        {
            Console.WriteLine("enter the id");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name");
            name = Console.ReadLine();

            Console.WriteLine("enter the basic salry");
            basic_salry = Convert.ToInt32(Console.ReadLine());
            
           

           
        }

        public void output()
        {
           int  HRA = basic_salry / 2;
           int  da = basic_salry / 10;
            int total_salry = basic_salry + HRA + da;
           int inhand = total_salry - (total_salry / 10);


        Console.WriteLine("id " + Id);
        Console.WriteLine("name " + name);

         Console.WriteLine("total salry");
        Console.WriteLine(total_salry);

        Console.WriteLine("inhand salry");
        Console.WriteLine(inhand);
        }
    }
}
