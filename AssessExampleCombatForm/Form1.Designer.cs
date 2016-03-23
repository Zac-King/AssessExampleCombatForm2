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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CreatedCharacters = new System.Windows.Forms.ListBox();
            this.AddSelectedToA = new System.Windows.Forms.Button();
            this.AddSelectedToB = new System.Windows.Forms.Button();
            this.PartyATestBox = new System.Windows.Forms.TextBox();
            this.PartyBTextBox = new System.Windows.Forms.TextBox();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.CharacterStatChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CharacterImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStatChart)).BeginInit();
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
            // 
            // AddSelectedToA
            // 
            this.AddSelectedToA.Location = new System.Drawing.Point(205, 159);
            this.AddSelectedToA.Name = "AddSelectedToA";
            this.AddSelectedToA.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToA.TabIndex = 3;
            this.AddSelectedToA.Text = "PartyA";
            this.AddSelectedToA.UseVisualStyleBackColor = true;
            // 
            // AddSelectedToB
            // 
            this.AddSelectedToB.Location = new System.Drawing.Point(318, 159);
            this.AddSelectedToB.Name = "AddSelectedToB";
            this.AddSelectedToB.Size = new System.Drawing.Size(75, 23);
            this.AddSelectedToB.TabIndex = 4;
            this.AddSelectedToB.Text = "PartyB";
            this.AddSelectedToB.UseVisualStyleBackColor = true;
            // 
            // PartyATestBox
            // 
            this.PartyATestBox.Location = new System.Drawing.Point(205, 187);
            this.PartyATestBox.Multiline = true;
            this.PartyATestBox.Name = "PartyATestBox";
            this.PartyATestBox.Size = new System.Drawing.Size(88, 98);
            this.PartyATestBox.TabIndex = 6;
            // 
            // PartyBTextBox
            // 
            this.PartyBTextBox.Location = new System.Drawing.Point(303, 187);
            this.PartyBTextBox.Multiline = true;
            this.PartyBTextBox.Name = "PartyBTextBox";
            this.PartyBTextBox.Size = new System.Drawing.Size(90, 98);
            this.PartyBTextBox.TabIndex = 7;
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
            // 
            // CharacterStatChart
            // 
            this.CharacterStatChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.CharacterStatChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CharacterStatChart.Legends.Add(legend1);
            this.CharacterStatChart.Location = new System.Drawing.Point(202, 13);
            this.CharacterStatChart.Name = "CharacterStatChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CharacterStatChart.Series.Add(series1);
            this.CharacterStatChart.Size = new System.Drawing.Size(191, 123);
            this.CharacterStatChart.TabIndex = 14;
            this.CharacterStatChart.Text = "Character Stats";
            // 
            // CharacterImage
            // 
            this.CharacterImage.BackColor = System.Drawing.Color.Transparent;
            this.CharacterImage.Image = global::AssessExampleCombatForm.Properties.Resources.shy_ivara_by_zilvtree_zauani_d9jrp98;
            this.CharacterImage.Location = new System.Drawing.Point(12, 142);
            this.CharacterImage.Name = "CharacterImage";
            this.CharacterImage.Size = new System.Drawing.Size(175, 172);
            this.CharacterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CharacterImage.TabIndex = 15;
            this.CharacterImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 336);
            this.Controls.Add(this.CharacterImage);
            this.Controls.Add(this.CharacterStatChart);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.CreateCharacterButton);
            this.Controls.Add(this.PartyBTextBox);
            this.Controls.Add(this.PartyATestBox);
            this.Controls.Add(this.AddSelectedToB);
            this.Controls.Add(this.AddSelectedToA);
            this.Controls.Add(this.CreatedCharacters);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStatChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CreatedCharacters;
        private System.Windows.Forms.Button AddSelectedToA;
        private System.Windows.Forms.Button AddSelectedToB;
        private System.Windows.Forms.TextBox PartyATestBox;
        private System.Windows.Forms.TextBox PartyBTextBox;
        private System.Windows.Forms.Button CreateCharacterButton;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.DataVisualization.Charting.Chart CharacterStatChart;
        private System.Windows.Forms.PictureBox CharacterImage;
    }
}

