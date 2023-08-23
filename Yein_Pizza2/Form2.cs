using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Yein An 301316062
namespace Yein_Pizza2
{
    public partial class Form2 : Form
    {
        private List<Order> OrderList;
        public Form2(List<Order> OrderList)
        {
            InitializeComponent();
            this.OrderList = OrderList;
            this.gridOders.DataSource=typeof(List<Order>);
            this.gridOders.DataSource=this.OrderList;

        }

    }
}
