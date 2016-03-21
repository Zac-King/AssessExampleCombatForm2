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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CreatedCharacters = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatRadial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddSelectedToA = new System.Windows.Forms.Button();
            this.AddSelectedToB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatRadial)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 151);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StatRadial
            // 
            this.StatRadial.BackColor = System.Drawing.Color.LightSlateGray;
            chartArea2.Name = "ChartArea1";
            this.StatRadial.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StatRadial.Legends.Add(legend2);
            this.StatRadial.Location = new System.Drawing.Point(12, 113);
            this.StatRadial.Name = "StatRadial";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StatRadial.Series.Add(series2);
            this.StatRadial.Size = new System.Drawing.Size(266, 185);
            this.StatRadial.TabIndex = 2;
            this.StatRadial.Text = "chart1";
            // 
            // AddSelectedToA
            // 
            this.AddSelectedToA.Location = new System.Drawing.Point(285, 170);
            this.AddSelectedToA.Name = "AddSelectedToA";
            this.AddSelectedToA.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToA.TabIndex = 3;
            this.AddSelectedToA.Text = "PartyA";
            this.AddSelectedToA.UseVisualStyleBackColor = true;
            // 
            // AddSelectedToB
            // 
            this.AddSelectedToB.Location = new System.Drawing.Point(394, 169);
            this.AddSelectedToB.Name = "AddSelectedToB";
            this.AddSelectedToB.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToB.TabIndex = 4;
            this.AddSelectedToB.Text = "PartyB";
            this.AddSelectedToB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 98);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 198);
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
            this.StartGame.Location = new System.Drawing.Point(169, 304);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 10;
            this.StartGame.Text = "Play";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddSelectedToB);
            this.Controls.Add(this.AddSelectedToA);
            this.Controls.Add(this.StatRadial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreatedCharacters);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatRadial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CreatedCharacters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatRadial;
        private System.Windows.Forms.Button AddSelectedToA;
        private System.Windows.Forms.Button AddSelectedToB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CreateCharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.Button StartGame;
    }
}

