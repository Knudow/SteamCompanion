using SteamCompanion.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SteamCompanion
{
    public struct Game
    {
        public string name;
        public string id;
        public List<string> tags;
        public List<string> genres;

        public override string ToString()
        {
            return name;
        }
    }

    public partial class MainWindow : Form
    {
        private int img_index;
        private List<Game> games;
        private List<Image> game_images;
        private Dictionary<String, List<Game>> games_by_genre;
        private Dictionary<String, List<Game>> games_by_tag;
        private List<int> ids;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void load(Game game)
        {
            //We add the game's tags to the main list of tags
            //We also add the game to the Tag/Games dictionary
            if (game.tags != null)
            {
                foreach (String tag in game.tags)
                {
                    if (!listbox_tags.Items.Contains(tag))
                    {
                        listbox_tags.Items.Add(tag);
                    }

                    if (games_by_tag.ContainsKey(tag))
                    {
                        games_by_tag[tag].Add(game);
                    }
                    else
                    {
                        games_by_tag.Add(tag, new List<Game>());
                        games_by_tag[tag].Add(game);
                    }
                }
            }

            //We do the same with genres/categories
            if (game.genres != null)
            {
                foreach (String cat in game.genres)
                {
                    if (!listbox_categories.Items.Contains(cat))
                    {
                        listbox_categories.Items.Add(cat);
                    }

                    if (games_by_genre.ContainsKey(cat))
                    {
                        games_by_genre[cat].Add(game);
                    }
                    else
                    {
                        games_by_genre.Add(cat, new List<Game>());
                        games_by_genre[cat].Add(game);
                    }
                }
            }

            //We add the game's ID to the list of all IDs
            ids.Add(Int32.Parse(game.id));

            //Update status bar
            toolStripStatusLabel1.Text = games_by_genre.Count + " Categories";
            toolStripStatusLabel2.Text = games_by_tag.Count + " Tags";
            toolStripStatusLabel3.Text = games.Count + " Games";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img_index = 0;
            games = new List<Game>();
            game_images = new List<Image>();
            games_by_genre = new Dictionary<string, List<Game>>();
            games_by_tag = new Dictionary<string, List<Game>>();
            ids = new List<int>();

            listbox_games.DataSource = games;

            // Set window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            // If autosave is checked, we load the autosave file
            autosaveloadToolStripMenuItem.Checked = Settings.Default.autosave;
            if(autosaveloadToolStripMenuItem.Checked)
            {
                if(File.Exists("autosave.xml"))
                {
                    loadProfile("autosave.xml");
                }
            }
        }

        private void getAllGames_Click(object sender, EventArgs e)
        {
            //We get all the user's games
            if (!String.IsNullOrEmpty(textUserName.Text))
            {
                //Check user profile and obtain all games and ids
                WebClient x = new WebClient();
                x.Encoding = Encoding.UTF8;
                x.Headers.Add(HttpRequestHeader.Cookie, "birthtime=-2208959999");

                string source = x.DownloadString("http://steamcommunity.com/id/" + textUserName.Text + "/games/?tab=all");
                MatchCollection matches = Regex.Matches(source, "appid\":(\\d+),\"name\":\"(.*?)\",\"logo", RegexOptions.IgnoreCase);

                games.Clear();
                listbox_categories.Items.Clear();
                listbox_tags.Items.Clear();

                games_by_genre.Clear();
                games_by_tag.Clear();

                //For each result, we create a game with the obtained name and ID and add it to the list
                if (matches.Count > 0)
                {
                    foreach (Match ma in matches)
                    {
                        Game aux_game = new Game();
                        aux_game.id = WebUtility.HtmlDecode(ma.Groups[1].Value.Trim());;
                        aux_game.name = WebUtility.HtmlDecode(ma.Groups[2].Value.Trim());
                        //Because some games have unicode characters, we look for \u followed by 4 characters and convert that into a single character
                        Regex rx = new Regex(@"\\[uU]([0-9A-Fa-f]{4})");
                        aux_game.name = rx.Replace(aux_game.name, match => ((char)Int32.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
                        games.Add(aux_game);
                        load(aux_game);
                    }
                }
                //We update all the listboxes in the form
                listbox_games.DataSource = null;
                generate_list();
            }
        }

        private void getNewGames_Click(object sender, EventArgs e)
        {
            //Like getAllGames, but we check if the game already exists using the list of IDs
            if (!String.IsNullOrEmpty(textUserName.Text))
            {
                WebClient x = new WebClient();
                x.Headers.Add(HttpRequestHeader.Cookie, "birthtime=-2208959999");

                string source = x.DownloadString("http://steamcommunity.com/id/" + textUserName.Text + "/games/?tab=all");
                MatchCollection matches = Regex.Matches(source, "appid\":(\\d+),\"name\":\"(.*?)\",\"logo", RegexOptions.IgnoreCase);

                if (matches.Count > 0)
                {
                    foreach (Match ma in matches)
                    {
                        Game aux_game = new Game();
                        aux_game.id = WebUtility.HtmlDecode(ma.Groups[1].Value.Trim());;
                        aux_game.name = WebUtility.HtmlDecode(ma.Groups[2].Value.Trim());
                        //Because some games have unicode characters, we look for \u followed by 4 characters and convert that into a single character
                        Regex rx = new Regex(@"\\[uU]([0-9A-Fa-f]{4})");
                        aux_game.name = rx.Replace(aux_game.name, match => ((char)Int32.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
                        if (ids.Contains(Int32.Parse(aux_game.id)))
                        {
                            Console.Write("Game " + aux_game.name + " (" + aux_game.id + ") already exists\n");
                        }
                        else
                        {
                            //If it doesn't exist, we ask the user if they want to add the game to the list
                            Console.Write("New game found: " + aux_game.name + "(" + aux_game.id + ")\n");
                            DialogResult dialogResult = MessageBox.Show("Do you want to add " + aux_game.name + " (" + aux_game.id + ") to the list?", "New game found", MessageBoxButtons.YesNoCancel);
                            switch(dialogResult)
                            {
                                case DialogResult.Cancel:
                                        return;
                                case DialogResult.Yes:
                                    Console.Write("    Adding game to list\n");
                                    games.Add(aux_game);
                                    load(aux_game);
                                    break;
                                case DialogResult.No:
                                    Console.Write("    Skipping game\n");
                                    break;
                            }
                        }
                    }
                    //We update all the listboxes in the form
                    listbox_games.DataSource = null;
                    generate_list();
                }
            }
        }

        private Game get_tags_genres(String id)
        {
            //We load the game's store page and get the name, genres and tags
            WebClient x = new WebClient();
            x.Headers.Add(HttpRequestHeader.Cookie, "birthtime=-2208959999");

            string source = x.DownloadString("http://store.steampowered.com/app/" + id + "/?snr=1_4_4__131");

            Match match = Regex.Match(source, "<div class=\"apphub_AppName\">(.+)</div>", RegexOptions.IgnoreCase);
            string title = match.Groups[1].Value;

            Game aux_game;

            aux_game.name = title;
            aux_game.id = id;
            Console.Write("Processing data for " + aux_game.name + " with ID: " + aux_game.id + "\n");
            aux_game.genres = new List<string>();
            aux_game.tags = new List<string>();

            Regex regTags = new Regex("<a[^>]*class=\\\"app_tag\\\"[^>]*>([^<]*)</a>", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            //We add each found tag to the game
            MatchCollection matches = regTags.Matches(source);
            if (matches.Count > 0)
            {
                foreach (Match ma in matches)
                {
                    string tag = WebUtility.HtmlDecode(ma.Groups[1].Value.Trim());;
                    if (!string.IsNullOrWhiteSpace(tag))
                    {
                        aux_game.tags.Add(tag);
                    }
                }
            }

            string regexp = "\"description\":\"(.*?)\"";
            source = x.DownloadString("http://store.steampowered.com/api/appdetails/?appids=" + id);

            //We add each found genre to the game
            matches = Regex.Matches(source, regexp);
            if (matches.Count > 0)
            {
                foreach (Match ma in matches)
                {
                    string genre = WebUtility.HtmlDecode(ma.Groups[1].Value.Trim());;
                    if (!string.IsNullOrWhiteSpace(genre))
                    {
                        aux_game.genres.Add(genre);
                    }
                }
            }

            return aux_game;
        }

        private void get_images(String id)
        {
            WebClient x = new WebClient();
            x.Headers.Add(HttpRequestHeader.Cookie, "birthtime=-2208959999");

            string source = x.DownloadString("http://store.steampowered.com/app/" + id + "/?snr=1_4_4__131");

            Console.Write("Processing images for game " + id + "\n");
            MatchCollection matches = Regex.Matches(source, "screenshotid=\"(.+)\" target");
            int downloaded = 0;
            if (matches.Count > 0)
            {
                //We open the game's store page and get all the screenshots
                string photoPath = "Screens/" + id + "/";
                System.IO.DirectoryInfo newFolder = new System.IO.DirectoryInfo(photoPath);
                if (!newFolder.Exists)
                {
                    newFolder.Create();
                }
                //We download each screenshot to the game's directory
                foreach (Match ma in matches)
                {
                    if (ma.Success)
                    {
                        string captura = ma.Groups[1].Value;
                        if (!File.Exists(photoPath + "/" + captura))
                        {
                            try
                            {
                                x.DownloadFile("http://cdn.akamai.steamstatic.com/steam/apps/" + id + "/" + captura, photoPath + "/" + captura);
                                Console.Write("   Downloading image " + captura + "\n");
                                downloaded++;
                            }
                            catch (WebException ex)
                            {
                                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                                    if ((ex.Response as HttpWebResponse).StatusCode == HttpStatusCode.NotFound)
                                    {
                                        Console.Write("   Error downloading image " + captura + "\n");
                                        downloaded--;
                                    }
                            }
                        }
                    }
                }
            }
            //Sometimes the game is removed from the store, so we use the Steam api to get the pictures, as they are still on the server
            if (downloaded <= 0)
            {
                source = x.DownloadString("http://store.steampowered.com/api/appdetails/?appids=" + id);

                //steam_appid":3200
                string regex = "steam_appid\":(\\d+)";
                Match match = Regex.Match(source, regex);
                string other_id = match.Groups[1].Value;

                regex = "path_full.*?apps\\\\/\\d+\\\\/(.+?)\\..+?\\.jpg";
                matches = Regex.Matches(source, regex);
                if (matches.Count > 0)
                {
                    string photoPath = "Screens/" + id + "/";
                    System.IO.DirectoryInfo newFolder = new System.IO.DirectoryInfo(photoPath);
                    if (!newFolder.Exists)
                    {
                        newFolder.Create();
                    }
                    foreach (Match ma in matches)
                    {
                        if (ma.Success)
                        {
                            string captura = ma.Groups[1].Value + ".jpg";
                            if (!File.Exists(photoPath + "/" + captura))
                            {
                                try
                                {
                                    x.DownloadFile("http://cdn.akamai.steamstatic.com/steam/apps/" + other_id + "/" + captura, photoPath + "/" + captura);
                                }
                                catch (WebException ex)
                                {
                                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                                        if ((ex.Response as HttpWebResponse).StatusCode == HttpStatusCode.NotFound)
                                            Console.Write("   Error downloading image " + captura + "\n");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void listbox_games_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (listbox_games.SelectedItems.Count > 0)
            {
                switch (e.KeyCode)
                {
                    //If the user presses right we show the next image from the selected game
                    case System.Windows.Forms.Keys.Right:
                        if (game_images.Count > 0)
                        {
                            img_index++;
                            if (img_index >= game_images.Count)
                                img_index = 0;
                            pictureBox1.Image = game_images[img_index];
                        }
                        break;

                    //Left selects a random game
                    case System.Windows.Forms.Keys.Left:
                        Random rnd = new Random();
                        listbox_games.SelectedIndex = rnd.Next(0, listbox_games.Items.Count);
                        break;

                    //Enter launches the game
                    case System.Windows.Forms.Keys.Enter:
                        Process.Start("steam://run/" + ((Game)listbox_games.SelectedItem).id);
                        break;

                    //Delete removes the game from the list and all the images, asking the user first for confirmation
                    case System.Windows.Forms.Keys.Delete:
                        DialogResult dialogResult = MessageBox.Show("Do you want to delete " + ((Game)listbox_games.SelectedItem).name + " and all its screens?", "Delete confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //We unload the images so they are not in use and we can delete them
                            foreach (Image i in game_images)
                            {
                                i.Dispose();
                            }
                            game_images.Clear();
                            pictureBox1.Image = null;
                            games.Remove(((Game)listbox_games.SelectedItem));
                            if (Directory.Exists("Screens/" + ((Game)listbox_games.SelectedItem).id + "/"))
                                Directory.Delete("Screens/" + ((Game)listbox_games.SelectedItem).id + "/", true);
                            listbox_games.DataSource = null;
                            generate_list();
                        }
                        break;

                    //Space opens the screens directory for the game so the user can add his/her own screenshots
                    case System.Windows.Forms.Keys.Space:
                        if (!Directory.Exists("Screens/" + ((Game)listbox_games.SelectedItem).id + "/"))
                            Directory.CreateDirectory("Screens/" + ((Game)listbox_games.SelectedItem).id + "/");
                        Process.Start(AppDomain.CurrentDomain.BaseDirectory + "/Screens/" + ((Game)listbox_games.SelectedItem).id + "/");
                        break;
                }
            }
        }

        private void listbox_games_KeyDown(object sender, KeyEventArgs e)
        {
            //We "mark" the right and left keys as handled so they don't jump to the next/previous item on the listbox
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Right:
                    e.Handled = true;
                    break;

                case System.Windows.Forms.Keys.Left:
                    e.Handled = true;
                    break;
            }
        }

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We ask the user for a file and save the profile on that file
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.Filter = "XML file|*.xml";
            saveFileDialog1.Title = "Save the Profile File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                saveProfile(saveFileDialog1.FileName);
            }
        }

        private void saveProfile(string file)
        {
            // Create a new XmlSerializer instance with the type of the test class
            XmlSerializer SerializerObj = new XmlSerializer(typeof(List<Game>));

            // Create a new file stream to write the serialized object to a file
            TextWriter WriteFileStream = new StreamWriter(file);

            //We save the whole games list
            SerializerObj.Serialize(WriteFileStream, games);

            // Cleanup
            WriteFileStream.Close();
        }

        private void loadProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We ask the user for a file and load the profile on that file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "XML file|*.xml";
            openFileDialog1.Title = "Load the Profile File";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                loadProfile(openFileDialog1.FileName);
            }
        }

        private void loadProfile(string file)
        {
            games.Clear();
            listbox_categories.Items.Clear();
            listbox_tags.Items.Clear();

            games_by_genre.Clear();
            games_by_tag.Clear();

            //Create a new file stream for reading the XML file
            FileStream ReadFileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer SerializerObj = new XmlSerializer(typeof(List<Game>));

            //Load the object saved above by using the Deserialize function
            games = (List<Game>)SerializerObj.Deserialize(ReadFileStream);

            //Cleanup
            ReadFileStream.Close();

            //We load each game
            foreach (Game g in games)
            {
                load(g);
            }

            listbox_games.DataSource = games;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We save the settings and the profile if the autosave option is marked

            // Copy window location to app settings
            Settings.Default.WindowLocation = this.Location;

            Settings.Default.autosave = autosaveloadToolStripMenuItem.Checked;

            // Save settings
            Settings.Default.Save();

            if (autosaveloadToolStripMenuItem.Checked)
            {
                    saveProfile("autosave.xml");
            }
        }

        private void getCategoriesAndTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listbox_games.SelectedItems.Count > 0)
            {
                Game aux_game = get_tags_genres(((Game)listbox_games.SelectedItem).id);
                if (!aux_game.name.Equals(""))
                {
                    games.Remove(((Game)listbox_games.SelectedItem));
                    listbox_games.DataSource = null;
                    games.Add(aux_game);
                    load(aux_game);
                    generate_list();
                    listbox_games.SelectedIndex = listbox_games.Items.IndexOf(aux_game);
                }
                else
                {
                    Game orig = ((Game)listbox_games.SelectedItem);
                    orig.tags = aux_game.tags;
                    orig.genres = aux_game.genres;

                    games.Remove(((Game)listbox_games.SelectedItem));
                    listbox_games.DataSource = null;
                    games.Add(orig);
                    load(orig);
                    generate_list();
                    listbox_games.SelectedIndex = listbox_games.Items.IndexOf(orig);
                }

                listbox_games.DataSource = null;
                generate_list();
            }
        }

        private void getImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listbox_games.SelectedItems.Count > 0)
            {
                string id = ((Game)listbox_games.SelectedItem).id;
                get_images(id);
                if (game_images.Count > 0)
                {
                    Random rnd = new Random();
                    img_index = rnd.Next(0, game_images.Count);
                    pictureBox1.Image = game_images[img_index];
                }
            }
        }

        private void getBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listbox_games.SelectedItems.Count > 0)
            {
                Game aux_game = get_tags_genres(((Game)listbox_games.SelectedItem).id);
                if (!aux_game.name.Equals(""))
                {
                    games.Remove(((Game)listbox_games.SelectedItem));
                    listbox_games.DataSource = null;
                    games.Add(aux_game);
                    get_images(aux_game.id);
                    load(aux_game);
                    listbox_games.SelectedIndex = listbox_games.Items.IndexOf(aux_game);
                }
                listbox_games.DataSource = null;
                generate_list();
            }
        }

        private void getCategoriesAndTagsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Game g in listbox_games.Items)
            {
                Game aux_game = get_tags_genres(g.id);
                if (!aux_game.name.Equals(""))
                {
                    games.Remove(g);
                    games.Add(aux_game);
                }
                else
                {
                    Game orig = g;
                    orig.tags = aux_game.tags;
                    orig.genres = aux_game.genres;

                    games.Remove(g);
                    games.Add(orig);
                }
            }

            listbox_games.DataSource = null;

            foreach (Game g in games)
            {
                load(g);
            }

            generate_list();

            listbox_games.SelectedIndex = 0;
        }
        private void getImagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Game g in listbox_games.Items)
            {
                string id = g.id;
                get_images(id);
            }
            listbox_games.SelectedIndex = 0;
        }

        private void getAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Game g in listbox_games.Items)
            {
                Game aux_game = get_tags_genres(g.id);
                if (!aux_game.name.Equals(""))
                {
                    games.Remove(g);
                    games.Add(aux_game);
                }
                else
                {
                    Game orig = g;
                    orig.tags = aux_game.tags;
                    orig.genres = aux_game.genres;

                    games.Remove(g);
                    games.Add(orig);
                }
            }

            listbox_games.DataSource = null;
            generate_list();

            foreach (Game g in listbox_games.Items)
            {
                get_images(g.id);
                load(g);
            }

            listbox_games.SelectedIndex = 0;
        }

        private void showGamesWithoutImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Game> no_img_games = new List<Game>();
            foreach (Game g in games)
            {
                string path = "Screens/" + g.id + "/";

                if (Directory.Exists(path))
                {
                    if (Directory.GetFiles(path).Length == 0 && Directory.GetDirectories(path).Length == 0)
                    {
                        no_img_games.Add(g);
                    }
                }
                else
                {
                    no_img_games.Add(g);
                }
            }
            if (no_img_games.Count > 0)
            {
                listbox_games.DataSource = null;
                listbox_games.DataSource = no_img_games;
            }
        }

        private void showGamesWithoutDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Game> no_data_games = new List<Game>();
            foreach (Game g in games)
            {
                if (g.tags.Count <= 0 && g.genres.Count <= 0)
                    no_data_games.Add(g);
            }
            if (no_data_games.Count > 0)
            {
                listbox_games.DataSource = null;
                listbox_games.DataSource = no_data_games;
            }
        }

        private void listbox_games_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_games.SelectedItems.Count > 0)
            {
                //When we change the selected game, we load the new game's images and unload the previous ones
                game_title.Text = ((Game)listbox_games.SelectedItem).name;
                img_index = 0;
                String id = ((Game)listbox_games.SelectedItem).id;
                pictureBox1.Image = null;
                if (game_images.Count > 0)
                {
                    foreach (Image i in game_images)
                        i.Dispose();
                }
                game_images.Clear();
                if (Directory.Exists("Screens\\" + id))
                {
                    foreach (string file in Directory.EnumerateFiles("Screens\\" + id, "*.jpg"))
                    {
                        Image aux = Image.FromFile(file);
                        game_images.Add(aux);
                    }
                }
                if (game_images.Count > 0)
                {
                    Random rnd = new Random();
                    img_index = rnd.Next(0, game_images.Count);
                    pictureBox1.Image = game_images[img_index];
                }
            }
        }

        private void listbox_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            generate_list();
        }

        private void listbox_tags_SelectedIndexChanged(object sender, EventArgs e)
        {
            generate_list();
        }

        private void generate_list()
        {
            //The new list starts as the whole game list
            List<Game> gamelistaux = games;

            //Using the dictionary for each tag->games and genre->games, we interesect all the list and we get a list with only the selected genres and tags
            if (listbox_categories.SelectedIndices.Count > 0)
            {
                foreach (String s in listbox_categories.SelectedItems)
                    gamelistaux = gamelistaux.Intersect(games_by_genre[s]).ToList();
            }
            if (listbox_tags.SelectedIndices.Count > 0)
            {
                foreach (String s in listbox_tags.SelectedItems)
                    gamelistaux = gamelistaux.Intersect(games_by_tag[s]).ToList();
            }

            //From that list, we filter all the games that don't contain the string written on the textbox on their title
            if(!String.IsNullOrEmpty(textGameFilter.Text))
            {
                List<Game> filtered_list = new List<Game>();
                foreach (Game g in gamelistaux)
                {
                    if (g.name.ToUpper().Contains(textGameFilter.Text.ToUpper()))
                        filtered_list.Add(g);
                }
                gamelistaux = filtered_list;
            }

            //Then we make the listbox show the obtained games
            listbox_games.DataSource = null;
            listbox_games.DataSource = gamelistaux;

            //Update status bar
            toolStripStatusLabel1.Text = games_by_genre.Count + " Categories";
            toolStripStatusLabel2.Text = games_by_tag.Count + " Tags";
            toolStripStatusLabel3.Text = games.Count + " Games";
        }

        private void listbox_games_DoubleClick(object sender, EventArgs e)
        {
            //When the user double clicks on a game, we load the tags/categories editor with the selected game
            int index = this.listbox_games.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Game j = (Game)listbox_games.Items[index];
                //We send the mouse position so the tag editor opens at that position
                GameData form = new GameData(Cursor.Position.X, Cursor.Position.Y);
                form.g = j;
                form.genres = listbox_categories.Items.Cast<String>().ToList();
                form.tags = listbox_tags.Items.Cast<String>().ToList();

                DialogResult res = form.ShowDialog();
                //If the user pressed Save, we save the new modified game
                if (res == DialogResult.OK)
                {
                    foreach (string s in j.genres)
                    {
                        games_by_genre[s].Remove(j);
                    }
                    foreach (string s in j.tags)
                    {
                        games_by_tag[s].Remove(j);
                    }
                    games.Remove(j);
                    listbox_games.DataSource = null;
                    j = form.g;
                    games.Add(j);
                    load(j);
                    generate_list();
                }
            }
        }

        private void textGameFilter_TextChanged(object sender, EventArgs e)
        {
            generate_list();
        }
    }
}