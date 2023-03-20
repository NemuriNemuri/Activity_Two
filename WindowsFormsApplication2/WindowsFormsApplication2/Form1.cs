using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AnimeListForm : Form
    {
        public AnimeListForm()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            animeList.Items.Add("One piece");
            animeList.Items.Add("Naruto");
            animeList.Items.Add("Bleach");
            animeList.Items.Add("Dragon Ball Z");
            animeList.Items.Add("Fullmetal Alchemist: Brotherhood");
            animeList.Items.Add("Fairy Tail");
            animeList.Items.Add("Soul Eater");
            animeList.Items.Add("K-on!");
            animeList.Items.Add("Bocchi the Rock!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            animeList.Sorted = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear all items
            animeList.Items.Clear();
            // clear selection field
            selectionField.Text = "";
            // set countField to 0
            if (!string.IsNullOrEmpty(countField.Text))
                countField.Text = "0";
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            countField.Text = Convert.ToString(animeList.Items.Count);
        }

        private void animeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionField.Text = animeList.Text;
        }

    }
}
