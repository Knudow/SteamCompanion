using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamCompanion
{
    public partial class GameData : Form
    {
        public Game g { get; set; }
        public List<String> genres { get; set; }
        public List<String> tags { get; set; }

        private int desiredStartLocationX;
        private int desiredStartLocationY;

        public GameData(int x, int y)
           : this()
        {
            //We save the desired window position
            this.desiredStartLocationX = x;
            this.desiredStartLocationY = y;

            Load += new EventHandler(GameData_Load);
        }

        public GameData()
        {
            InitializeComponent();
        }

        private void GameData_Load(object sender, EventArgs e)
        {
            //We set the listboxes sources
            this.SetDesktopLocation(desiredStartLocationX, desiredStartLocationY);
            this.Text = g.name;
            listbox_categories.DataSource = genres;
            listbox_tags.DataSource = tags;

            listbox_categories.ClearSelected();
            listbox_tags.ClearSelected();

            //We select the tags/categories that the selected game has
            foreach (String s in g.genres)
            {
                listbox_categories.SetSelected(listbox_categories.FindStringExact(s), true);
            }

            foreach (String s in g.tags)
            {
                listbox_tags.SetSelected(listbox_tags.FindStringExact(s), true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the user saves, we create a new game with all the selected genres and tags
            Game g2 = g;
            g2.genres = listbox_categories.SelectedItems.Cast<String>().ToList();
            g2.tags = listbox_tags.SelectedItems.Cast<String>().ToList();

            g = g2;
        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(text_genre.Text))
            {
                if(!genres.Contains(text_genre.Text))
                {
                    genres.Add(text_genre.Text);
                    listbox_categories.DataSource = null;
                    listbox_categories.DataSource = genres;
                    foreach (String s in g.genres)
                    {
                        listbox_categories.SetSelected(listbox_categories.FindStringExact(s), true);
                    }
                }
            }
        }

        private void add_tag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(text_tag.Text))
            {
                if (!tags.Contains(text_tag.Text))
                {
                    tags.Add(text_tag.Text);
                    listbox_tags.DataSource = null;
                    listbox_tags.DataSource = tags;
                    foreach (String s in g.tags)
                    {
                        listbox_tags.SetSelected(listbox_tags.FindStringExact(s), true);
                    }
                }
            }
        }
    }
}
