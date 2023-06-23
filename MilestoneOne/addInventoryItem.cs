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

        private void addItemButton_Click(object sender, EventArgs e)
        {
            
            bool stickered;
            string name = createNameTextBox.Text;
            string size = createSizeTextBox.Text;

            if (createStickeredRadioYes.Checked)
            {
                stickered = true;
            }
            else
            {
                stickered = false;
            }
            string lubes = createLubesTextBox.Text;
            string coating = createCoatingTextBox.Text;
            string logo = createLogoTextBox.Text;


            inventoryItem newItem = new inventoryItem(name, size, stickered, lubes, coating, logo);
            yourItemTextBox.Text = newItem.printItem();
        }
    }
    class inventoryItem
    {
        
        string name;
        string size;
        bool stickered;
        string lubes;
        string coating;
        string logo;


        public inventoryItem(string name, string size, bool stickered, string lubes, string coating, string logo)
        {
            this.name = name;
            this.size = size;
            this.stickered = stickered;
            this.lubes = lubes;
            this.coating = coating;
            this.logo = logo;
        }

        public string printItem()
        {
            return "Name: " + this.name + "Size: " + this.size + "Stickered: " + this.stickered.ToString() + "Lubes: " + this.lubes + "Coating: " + this.coating + "Logo: " + this.logo;
        }
        public string getName()
        {
            return this.name;
        }

        public string getSize()
        {
            return this.size;
        }

        public bool getStickered()
        {
            return this.stickered;
        }

        public string getCoating()
        {
            return this.coating;
        }

        public string getLogo()
        {
            return this.logo;
        }
    }

}
