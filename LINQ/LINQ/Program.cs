using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AutolotContext())
            {
                var markWithT = from mark 
                                in context.Marks 
                                where mark.Name.ToLower().Contains("t")
                                select mark;
                var cars = markWithT.Where(x => x.Cars.Count > 0).FirstOrDefault();

                var name = "Oleg";
                int count = name.GetCount();
            }
        }
    }
}
