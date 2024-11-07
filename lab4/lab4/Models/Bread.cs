using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class Bread
    {
        public string Type { get; set; }
        public BreadSize Size { get; set; }
        public Filling Filling { get; set; }
    }
}
