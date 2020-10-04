using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Rodgers
{
    public partial class AddQuote : Form
    {
  
        public AddQuote()
        {
            InitializeComponent();
        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainmenu = (MainMenu)Tag;
            viewMainmenu.Show();
            Close();
        }

        private void addWidthBox_MouseClick(object sender, MouseEventArgs e)
        {
            addWidthBox.BackColor = default(Color);
        }

        private void addDepthBox_MouseClick(object sender, MouseEventArgs e)
        {
            addDepthBox.BackColor = default(Color);
        }

        /*public void sumDeskSize(object sender, MouseEventArgs e)
        {
            int totalSquared = Int32.Parse(addWidthBox.Text) * Int32.Parse(addDepthBox.Text);
            totalSquaredLabel.Text = totalSquared.ToString;
        }*/


        private void addWidthBox_Validating(object sender, CancelEventArgs e)
        {
            int checkValue;
            if (!int.TryParse(addWidthBox.Text, out checkValue))
            {
                addWidthBox.BackColor = Color.Red;
            }
            if (checkValue > 96 || checkValue < 24)
            {
                addWidthBox.BackColor = Color.Red;
            }
        }

        private void addDepthBox_Validating(object sender, CancelEventArgs e)
        {
            int checkValue;
            if (!int.TryParse(addDepthBox.Text, out checkValue))
            {
                addDepthBox.BackColor = Color.Red;
            }
            if (checkValue > 96 || checkValue < 24)
            {
                addDepthBox.BackColor = Color.Red;
            }

        }
        private void checkedListDrawers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListDrawers.Items.Count; ++i)
                if (i != e.Index) checkedListDrawers.SetItemChecked(i, false);
        }
        private void checkedListMaterial_ItemCheck(object sender, ItemCheckEventArgs e)
        {

           for (int i = 0; i < checkedListMaterial.Items.Count; ++i)
               if (i != e.Index) checkedListMaterial.SetItemChecked(i, false);
        }

        private void checkedListRush_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checkedListRush.Items.Count; ++i)
                if (i != e.Index) checkedListRush.SetItemChecked(i, false);
        }

        /* public void determineMaterial(object sender, CancelEventArgs e)
         {
             int materialCost;
             string material;


             switch (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing())
             {
                 case "Laminate":
                     materialCost = 100;
                     break;
                 case "Oak":
                     materialCost = 200;
                     break;
                 case "Pine":
                     materialCost = 50;
                     break;
                 case "Rosewood":
                     materialCost = 300;
                     break;
                 case "Veneer":
                     materialCost = 125;
                     break;
             }
         }*/

        private void button1_Click(object sender, EventArgs e)
        {
            int deskSurfaceArea = Int32.Parse(addWidthBox.Text) * Int32.Parse(addDepthBox.Text);
            int baseDeskPrice;
            int materialCost;
            int rushPrice;
            int drawerPrice;

            if (deskSurfaceArea > 1000)
            {
                int temp = (deskSurfaceArea - 1000);
                baseDeskPrice = 200 + temp; 
            }
            else
            {
               baseDeskPrice = 200;
            }

            /*switch (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing())
            {
                case "Laminate":
                    materialCost = 100;
                    break;
                case "Oak":
                    materialCost = 200;
                    break;
                case "Pine":
                    materialCost = 50;
                    break;
                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;
            }*/

            if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "1")
                drawerPrice = 50;
            else if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "2")
                drawerPrice = 100;
            else if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "3")
                drawerPrice = 150;
            else if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "4")
                drawerPrice = 200;
            else if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "5")
                drawerPrice = 250;
            else if (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "6")
                drawerPrice = 300;
            else// (checkedListDrawers.Items[checkedListDrawers.SelectedIndex].ToStr‌​ing() == "2")
                drawerPrice = 350;

            if (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing() == "Laminate")
                materialCost = 100;
            else if (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing() == "Oak")
                materialCost = 200;
            else if (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing() == "Pine")
                materialCost = 50;
            else if (checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing() == "Rosewood")
                materialCost = 300;
            else //(checkedListMaterial.Items[checkedListMaterial.SelectedIndex].ToStr‌​ing() == "Veneer")
                materialCost = 125;

            if (checkedListRush.Items[checkedListRush.SelectedIndex].ToStr‌​ing() == "Rushed - 3 Days")
            {
                if (deskSurfaceArea < 1000)
                    rushPrice = 60;
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    rushPrice = 70;
                else
                    rushPrice = 80;
            }
            else if (checkedListRush.Items[checkedListRush.SelectedIndex].ToStr‌​ing() == "Express - 5 Days")
            {
                if (deskSurfaceArea < 1000)
                    rushPrice = 40;
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    rushPrice = 50;
                else
                    rushPrice = 60;
            }
            else if (checkedListRush.Items[checkedListRush.SelectedIndex].ToStr‌​ing() == "Expidited - 7 Days")
            {
                if (deskSurfaceArea < 1000)
                    rushPrice = 30;
                else if (deskSurfaceArea >= 1000 && deskSurfaceArea <= 2000)
                    rushPrice = 35;
                else
                    rushPrice = 40;
            }
            else //(checkedListRush.Items[checkedListRush.SelectedIndex].ToStr‌​ing() == "Free Shipping - 14 Days")
                rushPrice = 0;


            int tCost = materialCost + baseDeskPrice + rushPrice + drawerPrice;

            totalPriceLabel.Text = "$" + tCost.ToString();
        }
        public class Quote
        {


        }
        private void acceptQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
