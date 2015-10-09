namespace SteamCompanion
{
    partial class GameData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameData));
            this.label4 = new System.Windows.Forms.Label();
            this.listbox_tags = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox_categories = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add_genre = new System.Windows.Forms.Button();
            this.add_tag = new System.Windows.Forms.Button();
            this.text_genre = new System.Windows.Forms.TextBox();
            this.text_tag = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tags";
            // 
            // listbox_tags
            // 
            this.listbox_tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_tags.FormattingEnabled = true;
            this.listbox_tags.Location = new System.Drawing.Point(133, 54);
            this.listbox_tags.Name = "listbox_tags";
            this.listbox_tags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox_tags.Size = new System.Drawing.Size(120, 524);
            this.listbox_tags.Sorted = true;
            this.listbox_tags.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Categories";
            // 
            // listbox_categories
            // 
            this.listbox_categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listbox_categories.FormattingEnabled = true;
            this.listbox_categories.Location = new System.Drawing.Point(7, 54);
            this.listbox_categories.Name = "listbox_categories";
            this.listbox_categories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listbox_categories.Size = new System.Drawing.Size(120, 524);
            this.listbox_categories.Sorted = true;
            this.listbox_categories.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(269, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_genre
            // 
            this.add_genre.Location = new System.Drawing.Point(103, 25);
            this.add_genre.Name = "add_genre";
            this.add_genre.Size = new System.Drawing.Size(23, 23);
            this.add_genre.TabIndex = 17;
            this.add_genre.Text = "+";
            this.add_genre.UseVisualStyleBackColor = true;
            this.add_genre.Click += new System.EventHandler(this.add_genre_Click);
            // 
            // add_tag
            // 
            this.add_tag.Location = new System.Drawing.Point(230, 25);
            this.add_tag.Name = "add_tag";
            this.add_tag.Size = new System.Drawing.Size(23, 23);
            this.add_tag.TabIndex = 18;
            this.add_tag.Text = "+";
            this.add_tag.UseVisualStyleBackColor = true;
            this.add_tag.Click += new System.EventHandler(this.add_tag_Click);
            // 
            // text_genre
            // 
            this.text_genre.Location = new System.Drawing.Point(7, 27);
            this.text_genre.Name = "text_genre";
            this.text_genre.Size = new System.Drawing.Size(90, 20);
            this.text_genre.TabIndex = 19;
            // 
            // text_tag
            // 
            this.text_tag.Location = new System.Drawing.Point(134, 27);
            this.text_tag.Name = "text_tag";
            this.text_tag.Size = new System.Drawing.Size(90, 20);
            this.text_tag.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(269, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GameData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 586);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_tag);
            this.Controls.Add(this.text_genre);
            this.Controls.Add(this.add_tag);
            this.Controls.Add(this.add_genre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listbox_tags);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox_categories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 1080);
            this.MinimumSize = new System.Drawing.Size(420, 625);
            this.Name = "GameData";
            this.Text = "GameData";
            this.Load += new System.EventHandler(this.GameData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbox_tags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_categories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_genre;
        private System.Windows.Forms.Button add_tag;
        private System.Windows.Forms.TextBox text_genre;
        private System.Windows.Forms.TextBox text_tag;
        private System.Windows.Forms.Button button2;
    }
}