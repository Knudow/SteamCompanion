namespace SteamCompanion
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.textUserName = new System.Windows.Forms.TextBox();
            this.getAllGames = new System.Windows.Forms.Button();
            this.game_title = new System.Windows.Forms.Label();
            this.listbox_categories = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox_tags = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listbox_games = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCategoriesAndTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getBothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCategoriesAndTagsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getImagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGamesWithoutDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGamesWithoutImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNewGames = new System.Windows.Forms.Button();
            this.textGameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(76, 32);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(258, 20);
            this.textUserName.TabIndex = 0;
            // 
            // getAllGames
            // 
            this.getAllGames.Location = new System.Drawing.Point(340, 30);
            this.getAllGames.Name = "getAllGames";
            this.getAllGames.Size = new System.Drawing.Size(100, 23);
            this.getAllGames.TabIndex = 1;
            this.getAllGames.Text = "Get all games";
            this.getAllGames.UseVisualStyleBackColor = true;
            this.getAllGames.Click += new System.EventHandler(this.getAllGames_Click);
            // 
            // game_title
            // 
            this.game_title.AutoSize = true;
            this.game_title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_title.Location = new System.Drawing.Point(544, 32);
            this.game_title.Name = "game_title";
            this.game_title.Size = new System.Drawing.Size(137, 29);
            this.game_title.TabIndex = 3;
            this.game_title.Text = "Game title";
            // 
            // listbox_categories
            // 
            this.listbox_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_categories.FormattingEnabled = true;
            this.listbox_categories.Location = new System.Drawing.Point(12, 81);
            this.listbox_categories.Name = "listbox_categories";
            this.listbox_categories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox_categories.Size = new System.Drawing.Size(120, 459);
            this.listbox_categories.Sorted = true;
            this.listbox_categories.TabIndex = 4;
            this.listbox_categories.SelectedIndexChanged += new System.EventHandler(this.listbox_categories_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(549, 73);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(300, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categories";
            // 
            // listbox_tags
            // 
            this.listbox_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_tags.FormattingEnabled = true;
            this.listbox_tags.Location = new System.Drawing.Point(138, 81);
            this.listbox_tags.Name = "listbox_tags";
            this.listbox_tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox_tags.Size = new System.Drawing.Size(120, 459);
            this.listbox_tags.Sorted = true;
            this.listbox_tags.TabIndex = 8;
            this.listbox_tags.SelectedIndexChanged += new System.EventHandler(this.listbox_tags_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tags";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Games";
            // 
            // listbox_games
            // 
            this.listbox_games.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_games.FormattingEnabled = true;
            this.listbox_games.Location = new System.Drawing.Point(264, 81);
            this.listbox_games.Name = "listbox_games";
            this.listbox_games.Size = new System.Drawing.Size(279, 459);
            this.listbox_games.Sorted = true;
            this.listbox_games.TabIndex = 10;
            this.listbox_games.SelectedIndexChanged += new System.EventHandler(this.listbox_games_SelectedIndexChanged);
            this.listbox_games.DoubleClick += new System.EventHandler(this.listbox_games_DoubleClick);
            this.listbox_games.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listbox_games_KeyDown);
            this.listbox_games.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listbox_games_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameDataToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1414, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProfileToolStripMenuItem,
            this.loadProfileToolStripMenuItem,
            this.autosaveloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "Profile";
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveProfileToolStripMenuItem.Text = "Save profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadProfileToolStripMenuItem.Text = "Load profile";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // autosaveloadToolStripMenuItem
            // 
            this.autosaveloadToolStripMenuItem.CheckOnClick = true;
            this.autosaveloadToolStripMenuItem.Name = "autosaveloadToolStripMenuItem";
            this.autosaveloadToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.autosaveloadToolStripMenuItem.Text = "Autosave/load";
            // 
            // gameDataToolStripMenuItem
            // 
            this.gameDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedGameToolStripMenuItem,
            this.allGamesToolStripMenuItem});
            this.gameDataToolStripMenuItem.Name = "gameDataToolStripMenuItem";
            this.gameDataToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.gameDataToolStripMenuItem.Text = "Game data";
            // 
            // selectedGameToolStripMenuItem
            // 
            this.selectedGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCategoriesAndTagsToolStripMenuItem,
            this.getImagesToolStripMenuItem,
            this.getBothToolStripMenuItem});
            this.selectedGameToolStripMenuItem.Name = "selectedGameToolStripMenuItem";
            this.selectedGameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.selectedGameToolStripMenuItem.Text = "Selected game";
            // 
            // getCategoriesAndTagsToolStripMenuItem
            // 
            this.getCategoriesAndTagsToolStripMenuItem.Name = "getCategoriesAndTagsToolStripMenuItem";
            this.getCategoriesAndTagsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getCategoriesAndTagsToolStripMenuItem.Text = "Get categories and tags";
            this.getCategoriesAndTagsToolStripMenuItem.Click += new System.EventHandler(this.getCategoriesAndTagsToolStripMenuItem_Click);
            // 
            // getImagesToolStripMenuItem
            // 
            this.getImagesToolStripMenuItem.Name = "getImagesToolStripMenuItem";
            this.getImagesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getImagesToolStripMenuItem.Text = "Get images";
            this.getImagesToolStripMenuItem.Click += new System.EventHandler(this.getImagesToolStripMenuItem_Click);
            // 
            // getBothToolStripMenuItem
            // 
            this.getBothToolStripMenuItem.Name = "getBothToolStripMenuItem";
            this.getBothToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getBothToolStripMenuItem.Text = "Get both";
            this.getBothToolStripMenuItem.Click += new System.EventHandler(this.getBothToolStripMenuItem_Click);
            // 
            // allGamesToolStripMenuItem
            // 
            this.allGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCategoriesAndTagsToolStripMenuItem1,
            this.getImagesToolStripMenuItem1,
            this.getAllToolStripMenuItem});
            this.allGamesToolStripMenuItem.Name = "allGamesToolStripMenuItem";
            this.allGamesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.allGamesToolStripMenuItem.Text = "All games";
            // 
            // getCategoriesAndTagsToolStripMenuItem1
            // 
            this.getCategoriesAndTagsToolStripMenuItem1.Name = "getCategoriesAndTagsToolStripMenuItem1";
            this.getCategoriesAndTagsToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.getCategoriesAndTagsToolStripMenuItem1.Text = "Get categories and tags";
            this.getCategoriesAndTagsToolStripMenuItem1.Click += new System.EventHandler(this.getCategoriesAndTagsToolStripMenuItem1_Click);
            // 
            // getImagesToolStripMenuItem1
            // 
            this.getImagesToolStripMenuItem1.Name = "getImagesToolStripMenuItem1";
            this.getImagesToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.getImagesToolStripMenuItem1.Text = "Get images";
            this.getImagesToolStripMenuItem1.Click += new System.EventHandler(this.getImagesToolStripMenuItem1_Click);
            // 
            // getAllToolStripMenuItem
            // 
            this.getAllToolStripMenuItem.Name = "getAllToolStripMenuItem";
            this.getAllToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.getAllToolStripMenuItem.Text = "Get all";
            this.getAllToolStripMenuItem.Click += new System.EventHandler(this.getAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGamesWithoutDataToolStripMenuItem,
            this.showGamesWithoutImagesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // showGamesWithoutDataToolStripMenuItem
            // 
            this.showGamesWithoutDataToolStripMenuItem.Name = "showGamesWithoutDataToolStripMenuItem";
            this.showGamesWithoutDataToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.showGamesWithoutDataToolStripMenuItem.Text = "Show games without data";
            this.showGamesWithoutDataToolStripMenuItem.Click += new System.EventHandler(this.showGamesWithoutDataToolStripMenuItem_Click);
            // 
            // showGamesWithoutImagesToolStripMenuItem
            // 
            this.showGamesWithoutImagesToolStripMenuItem.Name = "showGamesWithoutImagesToolStripMenuItem";
            this.showGamesWithoutImagesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.showGamesWithoutImagesToolStripMenuItem.Text = "Show games without images";
            this.showGamesWithoutImagesToolStripMenuItem.Click += new System.EventHandler(this.showGamesWithoutImagesToolStripMenuItem_Click);
            // 
            // getNewGames
            // 
            this.getNewGames.Location = new System.Drawing.Point(443, 30);
            this.getNewGames.Name = "getNewGames";
            this.getNewGames.Size = new System.Drawing.Size(100, 23);
            this.getNewGames.TabIndex = 13;
            this.getNewGames.Text = "Update game list";
            this.getNewGames.UseVisualStyleBackColor = true;
            this.getNewGames.Click += new System.EventHandler(this.getNewGames_Click);
            // 
            // textGameFilter
            // 
            this.textGameFilter.Location = new System.Drawing.Point(307, 56);
            this.textGameFilter.Name = "textGameFilter";
            this.textGameFilter.Size = new System.Drawing.Size(236, 20);
            this.textGameFilter.TabIndex = 14;
            this.textGameFilter.TextChanged += new System.EventHandler(this.textGameFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1414, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 19);
            this.toolStripStatusLabel1.Text = "Categories";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 19);
            this.toolStripStatusLabel2.Text = "Tags";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(47, 19);
            this.toolStripStatusLabel3.Text = "Games";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGameFilter);
            this.Controls.Add(this.getNewGames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listbox_games);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listbox_tags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listbox_categories);
            this.Controls.Add(this.game_title);
            this.Controls.Add(this.getAllGames);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "SteamCompanion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button getAllGames;
        private System.Windows.Forms.Label game_title;
        private System.Windows.Forms.ListBox listbox_categories;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_tags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listbox_games;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCategoriesAndTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getBothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCategoriesAndTagsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getImagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGamesWithoutDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGamesWithoutImagesToolStripMenuItem;
        private System.Windows.Forms.Button getNewGames;
        private System.Windows.Forms.TextBox textGameFilter;
        private System.Windows.Forms.ToolStripMenuItem autosaveloadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

