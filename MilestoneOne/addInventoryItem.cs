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

            //create the new object with information collected from previous variables. 
            inventoryItem newItem = new inventoryItem(name, size, stickered, lubes, coating, logo);
            //print the value of newItem to verify that the correct values were assigned. 
            yourItemTextBox.Text = newItem.printItem();
        }
    }
    class inventoryItem
    {
        //Initialize class variables. 
        string name;
        string size;
        bool stickered;
        string lubes;
        string coating;
        string logo;

        //Constructor to initalize object with correct values. 
        public inventoryItem(string name, string size, bool stickered, string lubes, string coating, string logo)
        {
            this.name = name;
            this.size = size;
            this.stickered = stickered;
            this.lubes = lubes;
            this.coating = coating;
            this.logo = logo;
        }

        //This printitem function is intented to return all of the values of the object at the same time in a single string.
        public string printItem()
        {
            return "Name: " + this.name + " \nSize: " + this.size + " \nStickered: " + this.stickered.ToString() + " \nLubes: " + this.lubes + " \nCoating: " + this.coating + " \nLogo: " + this.logo;
        }

        //Since this.name is a private variable, being able to return this.name could be helpfull in the future. 
        public string getName()
        {
            return this.name;
        }
        //Since this.size is a private variable, being able to return this.size could be helpfull in the future. 
        public string getSize()
        {
            return this.size;
        }
        //Since this.stickered is a private variable, being able to return this.stickered could be helpfull in the future. 
        public bool getStickered()
        {
            return this.stickered;
        }
        //Since this.coating is a private variable, being able to return this.coating could be helpfull in the future. 
        public string getCoating()
        {
            return this.coating;
        }
        //Since this.logo is a private variable, being able to return this.logo could be helpfull in the future. 
        public string getLogo()
        {
            return this.logo;
        }
    }

}
