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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatedCharacters
            // 
            this.CreatedCharacters.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreatedCharacters.FormattingEnabled = true;
            this.CreatedCharacters.Location = new System.Drawing.Point(12, 12);
            this.CreatedCharacters.Name = "CreatedCharacters";
            this.CreatedCharacters.Size = new System.Drawing.Size(120, 95);
            this.CreatedCharacters.Sorted = true;
            this.CreatedCharacters.TabIndex = 0;
            // 
            // AddSelectedToA
            // 
            this.AddSelectedToA.Location = new System.Drawing.Point(12, 135);
            this.AddSelectedToA.Name = "AddSelectedToA";
            this.AddSelectedToA.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToA.TabIndex = 3;
            this.AddSelectedToA.Text = "PartyA";
            this.AddSelectedToA.UseVisualStyleBackColor = true;
            // 
            // AddSelectedToB
            // 
            this.AddSelectedToB.Location = new System.Drawing.Point(125, 135);
            this.AddSelectedToB.Name = "AddSelectedToB";
            this.AddSelectedToB.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToB.TabIndex = 4;
            this.AddSelectedToB.Text = "PartyB";
            this.AddSelectedToB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 98);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 98);
            this.textBox2.TabIndex = 7;
            // 
            // CreateCharacterButton
            // 
            this.CreateCharacterButton.Location = new System.Drawing.Point(169, 29);
            this.CreateCharacterButton.Name = "CreateCharacterButton";
            this.CreateCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCharacterButton.TabIndex = 8;
            this.CreateCharacterButton.Text = "Create";
            this.CreateCharacterButton.UseVisualStyleBackColor = true;
            this.CreateCharacterButton.Click += new System.EventHandler(this.CreateCharacterButton_Click);
            // 
            // LoadCharacterButton
            // 
            this.LoadCharacterButton.Location = new System.Drawing.Point(169, 68);
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.LoadCharacterButton.TabIndex = 9;
            this.LoadCharacterButton.Text = "Load";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(68, 267);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 10;
            this.StartGame.Text = "Play";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QuickTest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddSelectedToB);
            this.Controls.Add(this.AddSelectedToA);
            this.Controls.Add(this.CreatedCharacters);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CreatedCharacters;
        private System.Windows.Forms.Button AddSelectedToA;
        private System.Windows.Forms.Button AddSelectedToB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CreateCharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button button1;
    }
}

