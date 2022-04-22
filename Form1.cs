using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.ShowDialog();
        }

        private void FindCarButton_Click(object sender, EventArgs e)
        {
            FindCar findCar = new FindCar();
            findCar.ShowDialog();
        }

        private void ReserveCarButton_Click(object sender, EventArgs e)
        {
            Reservecar reservecar = new Reservecar();
            reservecar.ShowDialog();
        }
    }
}
