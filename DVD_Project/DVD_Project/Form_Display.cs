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
using DVD_Lib;

namespace DVD_Project
{
    public partial class Form_Display : Form
    {
        private List<DVD> loadAll = new List<DVD>();
        private ListViewItem line;
        public DVD selected;
        public Form_Display()
        {
            InitializeComponent();
        }

        private void Form_Display_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            initial_Data();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initial_Data()
        {
            loadAll = GetDVD();

            listView_DVD.Columns.Add("ID", 50);
            listView_DVD.Columns.Add("Name", 150);
            listView_DVD.Columns.Add("Category", 100);
            listView_DVD.Columns.Add("Quantity_In_Stock", 100);


            for (int i = 0; i < loadAll.Count; i++)
            {
                line = new ListViewItem(loadAll[i].ID.ToString());
                line.SubItems.Add(loadAll[i].Name);
                line.SubItems.Add(loadAll[i].Category);
                line.SubItems.Add(loadAll[i].Quantity_In_Stock.ToString());
                listView_DVD.Items.Add(line);

                if (i % 2 == 0)
                    listView_DVD.Items[i].BackColor = base.BackColor;
                else
                    listView_DVD.Items[i].BackColor = Color.White;
            }

        }

        private void Columns_OnSelected(object sender, EventArgs e)
        {
            if (listView_DVD.SelectedItems.Count == 1)
            {
                selected = new DVD(int.Parse(listView_DVD.SelectedItems[0].Text.ToString()),
                    listView_DVD.SelectedItems[0].SubItems[1].Text,
                    listView_DVD.SelectedItems[0].SubItems[2].Text,
                    int.Parse(listView_DVD.SelectedItems[0].SubItems[3].Text));
            }
            else if (listView_DVD.SelectedItems.Count == 0)
            {
                selected = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Add form_Add = new Form_Add();
            form_Add.ShowDialog();
            listView_DVD.Clear();
            initial_Data();
            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("Please select the row that you want to delete.");
            }
            else
            {
                this.Hide();
                Form_Edit form_Edit = new Form_Edit(selected.ID, selected.Name, selected.Category, selected.Quantity_In_Stock);
                form_Edit.ShowDialog();
                this.Show();
            }

            listView_DVD.Clear();
            initial_Data();
            selected = null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(selected == null)
            {
                MessageBox.Show("Please select the row that you want to delete.");
            }
            else
            {
                DeleteDVD(selected.ID, selected.Name, selected.Category, selected.Quantity_In_Stock);
            }
            listView_DVD.Clear();
            initial_Data();
            selected = null;
        }
    }
}
