using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsForProject
{
    public class Daryn
    {
        string Name { get; set; }
        int Age { get; set; }
        private Daryn()
        {
            Name = "Daryn";
            Age = 16;
        }
        static Daryn daryn;
        public static Daryn GetDaryn()
        {
            if (daryn == null)
                daryn = new Daryn();
            return daryn;
        }
        public void InformationAboutDaryn()
        {
            Console.WriteLine($"{Name} - {Age}");
        }
    }
}
