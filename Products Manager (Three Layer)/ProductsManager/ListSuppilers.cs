using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace ProductsManager
{
    public partial class ListSuppilers : Form
    {
        DataOutControl DOC = new DataOutControl();
        public ListSuppilers()
        {
            InitializeComponent();
        }
        public void activeData(){
            dataGV.DataSource = DOC.SelectData("NHA_CC");
        }
        private void ListSuppilers_Load(object sender, EventArgs e)
        {
            activeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
