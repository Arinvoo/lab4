using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Builders
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetBreadType()
        {
            _bread.Type = "Rye Bread";
        }

        public override void SetSize(BreadSize size)
        {
            _bread.Size = size;
        }

        public override void SetFilling(Filling filling)
        {
            _bread.Filling = filling;
        }
    }
}
