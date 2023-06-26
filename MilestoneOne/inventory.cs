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
            //Two lines of code to be able to access addInventoryItem from the original form.
            //Tip: don't hide the original form otherwise you have to delete the *projectName*.exe from the debug file :/ that took me a while to figure out
            addInventoryItem addInventoryItem = new addInventoryItem();
            addInventoryItem.ShowDialog();
        }
    }
}
