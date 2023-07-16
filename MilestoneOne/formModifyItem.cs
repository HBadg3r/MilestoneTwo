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
    public partial class formModifyItem : Form
    {
        public formModifyItem()
        {
            InitializeComponent();
        }

        //This button function is ran when the user wants to add a new item to the inventory after entering values into the text boxes.
        private void addItemButton_Click(object sender, EventArgs e)
        {
            //Initialize stickered in order to avoid errors while assigning values in an if/else structure.
            bool stickered;
            //Create name and size based of off information in text boxes. 
            string name = textBoxName.Text;
            string size = textBoxSize.Text;

            //If/else logic to assign a bool value to stickered based on selected radio button.
            if (radioStickeredYes.Checked)
            {
                stickered = true;
            }
            else
            {
                stickered = false;
            }

            //create lubes, coating, logo, and index based of off information in text boxes. 
            string lubes = textBoxLubes.Text;
            string coating = textBoxCoating.Text;
            string logo = textBoxLogo.Text;
            int count;
            int.TryParse(textBoxCount.Text, out count);
            int index;
            int.TryParse(textBoxIndex.Text, out index);
            //print the value of newItem to verify that the correct values were assigned. 
            textBoxYourItem.Text = inventoryManager.inventory[index].printItem();
            inventoryManager.modifyItem(index, name, size, stickered, lubes, coating, logo, count);
        }

        //Close the form upon close form button being clicked.
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            formModifyItem.ActiveForm.Close();
        }


        //method to populate the form whenever an index value is entered
        private void populateForm(int index)
        {
            //If the index entered by the user is out of range, this catches it. 
            try { textBoxName.Text = inventoryManager.inventory[index].getName(); }
            catch
            {
                MessageBox.Show("Invalid Input");
                return;
            }

            //Set all of the text boxes to contain the correct value for the inventory item at inventory[index]
            textBoxSize.Text = inventoryManager.inventory[index].getSize();
            textBoxLubes.Text = inventoryManager.inventory[index].getLubes();
            textBoxCoating.Text = inventoryManager.inventory[index].getCoating();
            textBoxLogo.Text = inventoryManager.inventory[index].getLogo();
            textBoxCount.Text = inventoryManager.inventory[index].getCount().ToString();

            //Check the correct radio button based on the stickered value of inventory[index]
            if (inventoryManager.inventory[index].getStickered())
            {
                radioStickeredYes.Checked = true;
            }
            else
            {
                radioStickeredNo.Checked = true;
            }
        }

        private void formModifyItem_Load(object sender, EventArgs e)
        {
            
        }

        //When the index text box changes (the user inputs an index), poplate the form with the correct values for the user to change. 
        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            int index;
            int.TryParse(textBoxIndex.Text, out index);
            populateForm(index);
        }
    }
}
