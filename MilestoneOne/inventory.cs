using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneOne
{
    public partial class inventorySystemForm : Form
    {
        public inventorySystemForm()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inventorySystemForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddInventoryItem_Click(object sender, EventArgs e)
        {
            addInventoryItem addInventoryItem = new addInventoryItem();
            addInventoryItem.ShowDialog();
        }
    }
}
