using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Airo auto = new Airo("Аэромобиль");
            Pyatna pyatno = new Pyatna("пятна");
            
            Console.WriteLine("{0} {1} {2} {3}",auto.name, auto.heightSpeed(), pyatno.name, pyatno.prostupat());
    
            Console.ReadKey();
        }
    }

    public class Airo
    {
        public string name { get; set; }

        public Airo(string name)
        {
            this.name = name;
        }

        public string heightSpeed()
        {
            return ", со скоростью, превышающей R17, вынес их по стальному туннелю на хмурую поверхность Магратеи, объятую мглистыми предрассветными сумерками.";
        }


    }

    public class Pyatna
    {
        public string name { get; set; }

        public Pyatna(string name)
        {
            this.name = name;
        }

        public string prostupat()
        {
            return "Сквозь тьму уже проступали пятна призрачного серого света.";
        }

    }

}
