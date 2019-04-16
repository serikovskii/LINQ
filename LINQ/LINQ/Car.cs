using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LINQ 
{
    public class Car : Entity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public virtual Mark Mark { get; set; }

    }
}