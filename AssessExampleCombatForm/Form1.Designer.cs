namespace AssessExampleCombatForm
{
    partial class Form1
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
            this.CreatedCharacters = new System.Windows.Forms.ListBox();
            this.AddSelectedToA = new System.Windows.Forms.Button();
            this.AddSelectedToB = new System.Windows.Forms.Button();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.StatTextBox = new System.Windows.Forms.RichTextBox();
            this.PartyATestBox = new System.Windows.Forms.RichTextBox();
            this.PartyBTestBox = new System.Windows.Forms.RichTextBox();
            this.CharacterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatedCharacters
            // 
            this.CreatedCharacters.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreatedCharacters.FormattingEnabled = true;
            this.CreatedCharacters.Location = new System.Drawing.Point(29, 12);
            this.CreatedCharacters.Name = "CreatedCharacters";
            this.CreatedCharacters.Size = new System.Drawing.Size(120, 95);
            this.CreatedCharacters.Sorted = true;
            this.CreatedCharacters.TabIndex = 0;
            this.CreatedCharacters.SelectedIndexChanged += new System.EventHandler(this.UpdateSelected);
            // 
            // AddSelectedToA
            // 
            this.AddSelectedToA.Location = new System.Drawing.Point(193, 158);
            this.AddSelectedToA.Name = "AddSelectedToA";
            this.AddSelectedToA.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToA.TabIndex = 3;
            this.AddSelectedToA.Text = "PartyA";
            this.AddSelectedToA.UseVisualStyleBackColor = true;
            this.AddSelectedToA.Click += new System.EventHandler(this.AddToParty);
            // 
            // AddSelectedToB
            // 
            this.AddSelectedToB.Location = new System.Drawing.Point(324, 158);
            this.AddSelectedToB.Name = "AddSelectedToB";
            this.AddSelectedToB.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToB.TabIndex = 4;
            this.AddSelectedToB.Text = "PartyB";
            this.AddSelectedToB.UseVisualStyleBackColor = true;
            this.AddSelectedToB.Click += new System.EventHandler(this.AddToParty);
            // 
            // CreateCharacterButton
            // 
            this.CreateCharacterButton.Location = new System.Drawing.Point(12, 113);
            this.CreateCharacterButton.Name = "CreateCharacterButton";
            this.CreateCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCharacterButton.TabIndex = 8;
            this.CreateCharacterButton.Text = "Create";
            this.CreateCharacterButton.UseVisualStyleBackColor = true;
            this.CreateCharacterButton.Click += new System.EventHandler(this.CreateCharacterButton_Click);
            // 
            // LoadCharacterButton
            // 
            this.LoadCharacterButton.Location = new System.Drawing.Point(93, 113);
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.LoadCharacterButton.TabIndex = 9;
            this.LoadCharacterButton.Text = "Load";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            this.LoadCharacterButton.Visible = false;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(261, 291);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 10;
            this.StartGame.Text = "Play";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Visible = false;
            this.StartGame.Click += new System.EventHandler(this.StartFight);
            // 
            // StatTextBox
            // 
            this.StatTextBox.Location = new System.Drawing.Point(208, 11);
            this.StatTextBox.Name = "StatTextBox";
            this.StatTextBox.ReadOnly = true;
            this.StatTextBox.Size = new System.Drawing.Size(188, 125);
            this.StatTextBox.TabIndex = 19;
            this.StatTextBox.Text = "";
            // 
            // PartyATestBox
            // 
            this.PartyATestBox.Location = new System.Drawing.Point(193, 187);
            this.PartyATestBox.Name = "PartyATestBox";
            this.PartyATestBox.ReadOnly = true;
            this.PartyATestBox.Size = new System.Drawing.Size(100, 96);
            this.PartyATestBox.TabIndex = 21;
            this.PartyATestBox.Text = "";
            // 
            // PartyBTestBox
            // 
            this.PartyBTestBox.Location = new System.Drawing.Point(299, 187);
            this.PartyBTestBox.Name = "PartyBTestBox";
            this.PartyBTestBox.ReadOnly = true;
            this.PartyBTestBox.Size = new System.Drawing.Size(100, 96);
            this.PartyBTestBox.TabIndex = 22;
            this.PartyBTestBox.Text = "";
            // 
            // CharacterImage
            // 
            this.CharacterImage.BackColor = System.Drawing.Color.Transparent;
            this.CharacterImage.Image = global::AssessExampleCombatForm.Properties.Resources.Cloud_gif;
            this.CharacterImage.Location = new System.Drawing.Point(12, 142);
            this.CharacterImage.Name = "CharacterImage";
            this.CharacterImage.Size = new System.Drawing.Size(175, 172);
            this.CharacterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterImage.TabIndex = 15;
            this.CharacterImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 336);
            this.Controls.Add(this.PartyBTestBox);
            this.Controls.Add(this.PartyATestBox);
            this.Controls.Add(this.StatTextBox);
            this.Controls.Add(this.CharacterImage);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.AddSelectedToB);
            this.Controls.Add(this.AddSelectedToA);
            this.Controls.Add(this.CreatedCharacters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CreatedCharacters;
        private System.Windows.Forms.Button AddSelectedToA;
        private System.Windows.Forms.Button AddSelectedToB;
        private System.Windows.Forms.Button CreateCharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.PictureBox CharacterImage;
        private System.Windows.Forms.RichTextBox StatTextBox;
        private System.Windows.Forms.RichTextBox PartyATestBox;
        private System.Windows.Forms.RichTextBox PartyBTestBox;
    }
}

