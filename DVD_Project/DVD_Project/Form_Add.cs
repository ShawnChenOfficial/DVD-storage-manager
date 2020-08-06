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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            AddDVD(textName.Text, textCategory.Text, int.Parse(textQuantity.Text));
            MessageBox.Show("Success!");
            this.Close();
        }

    }
}
