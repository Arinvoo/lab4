using lab4.Builders;
using lab4.Director;
using lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {
        private Bakery _bakery;

        public MainForm()
        {
            InitializeComponent();
            _bakery = new Bakery();
        }

        private void btnBakeWheatBread_Click(object sender, EventArgs e)
        {
            var builder = new WheatBreadBuilder();
            _bakery.SetBuilder(builder);
            _bakery.BakeBread(BreadSize.Large, Filling.Cheese);
            Bread bread = builder.GetBread();
            DisplayBreadInfo(bread);
        }

        private void btnBakeRyeBread_Click(object sender, EventArgs e)
        {
            var builder = new RyeBreadBuilder();
            _bakery.SetBuilder(builder);
            _bakery.BakeBread(BreadSize.Small, Filling.Ham);
            Bread bread = builder.GetBread();
            DisplayBreadInfo(bread);
        }

        private void DisplayBreadInfo(Bread bread)
        {
            lblBreadType.Text = $"Type: {bread.Type}";
            lblBreadSize.Text = $"Size: {bread.Size}";
            lblFilling.Text = $"Filling: {bread.Filling}";
        }
    }
}
