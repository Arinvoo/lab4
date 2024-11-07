using lab4.Builders;
using lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Director
{
    public class Bakery
    {
        private BreadBuilder _builder;

        public void SetBuilder(BreadBuilder builder)
        {
            _builder = builder;
        }

        public void BakeBread(BreadSize size, Filling filling)
        {
            _builder.CreateNewBread();
            _builder.SetBreadType();
            _builder.SetSize(size);
            _builder.SetFilling(filling);
        }
    }
}
