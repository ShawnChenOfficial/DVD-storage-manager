using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Lib
{
    public class DVD
    {

        public int ID { get; set; }
        public string Name{ get; set; }
        public string Category { get; set; }
        public int Quantity_In_Stock { get; set; }


        public DVD(int id, string name, string category, int quantity_in_stock)
        {
            this.ID = id;
            this.Name = name;
            this.Category = category;
            this.Quantity_In_Stock = quantity_in_stock;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", ID, Name, Category, Quantity_In_Stock);
        }

    }
}
