using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Independent_work__diner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void listBox_first_dish_SelectedValueChanged(object sender, EventArgs e)
        {
            label_price_first.Text = string.Empty;
            foreach (var item in listBox_first_dish.SelectedItems)
            {

               
            }
        }

        private void textBox_first_dish_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
