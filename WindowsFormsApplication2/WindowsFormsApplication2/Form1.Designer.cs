namespace WindowsFormsApplication2
{
    partial class AnimeListForm
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
            this.animeList = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.selectionField = new System.Windows.Forms.TextBox();
            this.countField = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animeList
            // 
            this.animeList.BackColor = System.Drawing.Color.White;
            this.animeList.FormattingEnabled = true;
            this.animeList.Location = new System.Drawing.Point(21, 75);
            this.animeList.Name = "animeList";
            this.animeList.Size = new System.Drawing.Size(183, 147);
            this.animeList.TabIndex = 0;
            this.animeList.SelectedIndexChanged += new System.EventHandler(this.animeList_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(42, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Anime List";
            // 
            // fillButton
            // 
            this.fillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fillButton.Location = new System.Drawing.Point(231, 75);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(231, 157);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(231, 199);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(27, 249);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(54, 13);
            this.selectionLabel.TabIndex = 5;
            this.selectionLabel.Text = "Selection:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(27, 276);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Count:";
            // 
            // selectionField
            // 
            this.selectionField.Location = new System.Drawing.Point(87, 246);
            this.selectionField.Name = "selectionField";
            this.selectionField.ReadOnly = true;
            this.selectionField.BackColor = System.Drawing.SystemColors.Window;
            this.selectionField.Size = new System.Drawing.Size(100, 20);
            this.selectionField.TabIndex = 7;
            // 
            // countField
            // 
            this.countField.Location = new System.Drawing.Point(87, 273);
            this.countField.Name = "countField";
            this.countField.ReadOnly = true;
            this.countField.BackColor = BackColor = System.Drawing.SystemColors.Window;
            this.countField.Size = new System.Drawing.Size(100, 20);
            this.countField.TabIndex = 8;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(231, 117);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 9;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(30, 314);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AnimeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.HatsuneMikuBg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(626, 353);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.countField);
            this.Controls.Add(this.selectionField);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.animeList);
            this.Name = "AnimeListForm";
            this.Text = "Your Anime List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox animeList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox selectionField;
        private System.Windows.Forms.TextBox countField;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button closeButton;
    }
}

