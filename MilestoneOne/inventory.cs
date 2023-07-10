using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program Name: inventory.cs
//Author: Easten Elefson
//Date: 09/07/2023

namespace MilestoneOne
{
    public partial class inventorySystemForm : Form
    {
        public inventorySystemForm()
        {
            InitializeComponent();
        }

        private void inventorySystemForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddInventoryItem_Click(object sender, EventArgs e)
        {
            //Two lines of code to be able to access addInventoryItem from the original form.
            //Tip: don't hide the original form otherwise you have to delete the *projectName*.exe from the debug file :/ that took me a while to figure out.
            addInventoryItem addInventoryItem = new addInventoryItem();
            addInventoryItem.ShowDialog();
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Upon clicking the display inventory button this will use the displayItems() method in inventoryManager to display the inventory.
        private void displayInventory_Click(object sender, EventArgs e)
        {
            //Clear the inventory so that there are no duplicates.
            inventoryListBox.Items.Clear();
            //Use the displayItems() method to return an array of strings, each value representing an inventory item.
            string[] items = inventoryManager.displayItems();
            //Loop through the returned array to display the inventory items. I wanted to do this in the displayItems method but I couldnt access the listBox from the inventoryManager class. 
            //I just couldnt figure out a way to use the inventoryManager class to actually change the inventory form, so the actual printing is done by this method. 
            for(int i = 0; i < inventoryManager.inventory.Count(); i++)
            {
                inventoryListBox.Items.Add(items[i]);
            }

        }


        //When this button is clicked, get the index from the user and delete the inventory item at the index. 
        private void buttonRemoveInventoryItem_Click(object sender, EventArgs e)
        {
            //Get the user input
            int index;
            int.TryParse(indexRemoveTextBox.Text, out index);

            //Remove the item at index 'index'
            inventoryManager.removeItem(index);
        }

        //When this button is clicked, get the item index the user wishes to modify, and then the amount the user wishes to modify it by. 
        private void increaseStockButton_Click(object sender, EventArgs e)
        {
            //Get user input
            int index;
            int.TryParse(restockIndexTextBox.Text, out index);
            int amount;
            int.TryParse(amountStockTextBox.Text, out amount);

            //Call the restockItem method
            inventoryManager.restockItem(index, amount);
        }

        //When this button is clicked, simply call the searchItem method. 
        private void searchButton_Click(object sender, EventArgs e)
        {
            inventoryManager.searchItem(searchNameTextBox.Text, searchSizeTextBox.Text);
        }
    }

    public class inventoryManager
    {
        //Create a public list that contains the inventory items. A list is used rather than an array to be able to dynamically add new items. 
        public static List<inventoryItem> inventory = new List<inventoryItem>();

        //Very simple method that adds an item created in addInventoryItem.cs to the inventory list.
        public static void AddItem(inventoryItem item)
        {
            inventory.Add(item);
        }


        //This method, because I couldn't figure out how to make the method change a listBox, just creates a list of strings.
        //Each string contains all of the information about an inventory item. The array is then returned.
        public static string[] displayItems()
        {

            //Creat the array
            string[] inventoryString = new string[100];
            //Loop through the inventory.
            for (int i = 0; i < inventory.Count(); i++)
            {
                //Make a long string that contains all relevent information about an item. 
                inventoryString[i] += "Index: " + i + " Name: " + inventory[i].getName().ToString() + " Size: " + inventory[i].getSize().ToString() + " Lubes: " + inventory[i].getLubes().ToString() + " Coating: " + inventory[i].getCoating().ToString() + " Logo: " + inventory[i].getLogo().ToString() + " Stickered: " + inventory[i].getStickered().ToString() + " Count: " + inventory[i].getCount().ToString();
            }
            //Return the array.
            return inventoryString;

        }

        //Very simple method that uses the list method RemoveAt to remove an item from the list at index 'index', which is provided by the user. 
        public static void removeItem(int index)
        {
            inventory.RemoveAt(index);
        }


        //Very simple method that increments the count value of an item at a given index by a user-defined amount. 
        public static void restockItem(int index, int increment)
        {
            inventory[index].count += increment;
        }


        //Searches for an inventory item based on the name or size entered by the user. 
        public static void searchItem(string name, string size)
        {
            //Loop through the inventory array.
            for(int i = 0; i < inventory.Count(); i++)
            {
                //If either the name or the size matches show the name of the possible item and its index to the user. 
                if (inventory[i].getName() == name || inventory[i].getSize() == size)
                {
                    MessageBox.Show("Found: " + inventory[i].getName() + " at index: " + i);
                }
            }
        }
    }


    public class inventoryItem
    {
        //Initialize class variables. 
        string name;
        string size;
        bool stickered;
        string lubes;
        string coating;
        string logo;
        public int count;


        //Constructor to initalize object with correct values. 
        public inventoryItem(string name, string size, bool stickered, string lubes, string coating, string logo, int count)
        {
            this.name = name;
            this.size = size;
            this.stickered = stickered;
            this.lubes = lubes;
            this.coating = coating;
            this.logo = logo;
            this.count = count;
        }

        //This printitem function is intented to return all of the values of the object at the same time in a single string.
        public string printItem()
        {
            return "Name: " + this.name + " \nSize: " + this.size + " \nStickered: " + this.stickered.ToString() + " \nLubes: " + this.lubes + " \nCoating: " + this.coating + " \nLogo: " + this.logo;
        }

        //Since this.name is a private variable, being able to return this.name could be helpful in the future. 
        public string getName()
        {
            return this.name;
        }
        //Since this.size is a private variable, being able to return this.size could be helpful in the future. 
        public string getSize()
        {
            return this.size;
        }
        //Since this.stickered is a private variable, being able to return this.stickered could be helpful in the future. 
        public bool getStickered()
        {
            return this.stickered;
        }
        //Since this.coating is a private variable, being able to return this.coating could be helpful in the future. 
        public string getCoating()
        {
            return this.coating;
        }
        //Since this.logo is a private variable, being able to return this.logo could be helpful in the future. 
        public string getLogo()
        {
            return this.logo;
        }
        //Since this.lubes is a private variable, being able to return this.lubes could be helpful in the future.
        public string getLubes()
        {
            return this.lubes;
        }
        //For consistency, even though this variable is public, I created this method. 
        public int getCount()
        {
            return this.count;
        }
    }
}
