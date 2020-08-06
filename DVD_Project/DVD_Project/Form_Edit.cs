using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVD_Lib.DBOperation;

namespace DVD_Project
{
    public partial class Form_Edit : Form
    {
        private int id;
        private string name;
        private string category;
        private int quantity_in_stock;
        public Form_Edit(int id, string name, string category, int quantity_in_stock)
        {
            InitializeComponent();

            this.id = id;
            this.name = name;
            this.category = category;
            this.quantity_in_stock = quantity_in_stock;
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            textName.Text = name;
            textCategory.Text = category;
            textQuantity_In_Stock.Text = quantity_in_stock.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UpdateDVD(id, textName.Text, textCategory.Text, int.Parse(textQuantity_In_Stock.Text));
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
