using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Program Name: addInventoryItem.cs
//Author: Easten Elefson
//Date: 09/07/2023

namespace MilestoneOne
{
    public partial class addInventoryItem : Form
    {
        public addInventoryItem()
        {
            InitializeComponent();
        }

        private void addInventoryItem_Load(object sender, EventArgs e)
        {

        }

        //This button function is ran when the user wants to add a new item to the inventory after entering values into the text boxes. 
        private void addItemButton_Click(object sender, EventArgs e)
        {
            //Initialize stickered in order to avoid errors while assigning values in an if/else structure.
            bool stickered;
            //Create name and size based of off information in text boxes. 
            string name = createNameTextBox.Text;
            string size = createSizeTextBox.Text;

            //If/else logic to assign a bool value to stickered based on selected radio button.
            if (createStickeredRadioYes.Checked)
            {
                stickered = true;
            }
            else
            {
                stickered = false;
            }

            //create lubes, coating, and logo based of off information in text boxes. 
            string lubes = createLubesTextBox.Text;
            string coating = createCoatingTextBox.Text;
            string logo = createLogoTextBox.Text;
            int count;
            int.TryParse(createCountTextBox.Text, out count);
            //create the new object with information collected from previous variables. 
            inventoryItem newItem = new inventoryItem(name, size, stickered, lubes, coating, logo, count);
            //print the value of newItem to verify that the correct values were assigned. 
            yourItemTextBox.Text = newItem.printItem();
            inventoryManager.AddItem(newItem);

        }


        //Method to close the form and return to the original form
        private void closeFormButton_Click(object sender, EventArgs e)
        {
            addInventoryItem.ActiveForm.Close();
        }
    }

}
