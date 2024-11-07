using lab4.Models;

namespace lab4.Builders
{
    public abstract class BreadBuilder
    {
        protected Bread _bread;

        public void CreateNewBread()
        {
            _bread = new Bread();
        }

        public Bread GetBread() => _bread;

        public abstract void SetBreadType();
        public abstract void SetSize(BreadSize size);
        public abstract void SetFilling(Filling filling);
    }
}
