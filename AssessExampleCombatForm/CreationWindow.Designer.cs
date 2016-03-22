namespace AssessExampleCombatForm
{
    partial class CreationWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatPlus = new System.Windows.Forms.Button();
            this.StrengthValue = new System.Windows.Forms.Label();
            this.StatMinus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemainingPoints = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.IntelligenceValue = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DexterityValue = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.UnitClass = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.Label();
            this.UnitName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StatPlus);
            this.panel1.Controls.Add(this.StrengthValue);
            this.panel1.Controls.Add(this.StatMinus);
            this.panel1.Location = new System.Drawing.Point(90, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 31);
            this.panel1.TabIndex = 0;
            // 
            // StatPlus
            // 
            this.StatPlus.Location = new System.Drawing.Point(51, 3);
            this.StatPlus.Name = "StatPlus";
            this.StatPlus.Size = new System.Drawing.Size(23, 23);
            this.StatPlus.TabIndex = 3;
            this.StatPlus.Text = ">";
            this.StatPlus.UseVisualStyleBackColor = true;
            this.StatPlus.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // StrengthValue
            // 
            this.StrengthValue.AutoSize = true;
            this.StrengthValue.Location = new System.Drawing.Point(32, 8);
            this.StrengthValue.Name = "StrengthValue";
            this.StrengthValue.Size = new System.Drawing.Size(13, 13);
            this.StrengthValue.TabIndex = 2;
            this.StrengthValue.Text = "0";
            // 
            // StatMinus
            // 
            this.StatMinus.Location = new System.Drawing.Point(3, 3);
            this.StatMinus.Name = "StatMinus";
            this.StatMinus.Size = new System.Drawing.Size(23, 23);
            this.StatMinus.TabIndex = 1;
            this.StatMinus.Text = "<";
            this.StatMinus.UseVisualStyleBackColor = true;
            this.StatMinus.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemainingPoints);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.SpeedLabel);
            this.panel2.Controls.Add(this.IntelligenceLabel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.DexterityLabel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.StrengthLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.UnitClass);
            this.panel2.Controls.Add(this.ClassName);
            this.panel2.Controls.Add(this.UnitName);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 324);
            this.panel2.TabIndex = 1;
            // 
            // RemainingPoints
            // 
            this.RemainingPoints.AutoSize = true;
            this.RemainingPoints.Location = new System.Drawing.Point(116, 246);
            this.RemainingPoints.Name = "RemainingPoints";
            this.RemainingPoints.Size = new System.Drawing.Size(19, 13);
            this.RemainingPoints.TabIndex = 8;
            this.RemainingPoints.Text = "15";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(9, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveAttributes);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(9, 209);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "Speed";
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(9, 172);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.IntelligenceLabel.TabIndex = 6;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.SpeedValue);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Location = new System.Drawing.Point(90, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 31);
            this.panel5.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(32, 8);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(13, 13);
            this.SpeedValue.TabIndex = 2;
            this.SpeedValue.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(9, 135);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(48, 13);
            this.DexterityLabel.TabIndex = 6;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.IntelligenceValue);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(90, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 31);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // IntelligenceValue
            // 
            this.IntelligenceValue.AutoSize = true;
            this.IntelligenceValue.Location = new System.Drawing.Point(32, 8);
            this.IntelligenceValue.Name = "IntelligenceValue";
            this.IntelligenceValue.Size = new System.Drawing.Size(13, 13);
            this.IntelligenceValue.TabIndex = 2;
            this.IntelligenceValue.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.DexterityValue);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(90, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 31);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // DexterityValue
            // 
            this.DexterityValue.AutoSize = true;
            this.DexterityValue.Location = new System.Drawing.Point(32, 8);
            this.DexterityValue.Name = "DexterityValue";
            this.DexterityValue.Size = new System.Drawing.Size(13, 13);
            this.DexterityValue.TabIndex = 2;
            this.DexterityValue.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeAttribute);
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(9, 98);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(47, 13);
            this.StrengthLabel.TabIndex = 4;
            this.StrengthLabel.Text = "Strength";
            // 
            // UnitClass
            // 
            this.UnitClass.Location = new System.Drawing.Point(75, 52);
            this.UnitClass.Name = "UnitClass";
            this.UnitClass.Size = new System.Drawing.Size(131, 20);
            this.UnitClass.TabIndex = 3;
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Location = new System.Drawing.Point(6, 55);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(60, 13);
            this.ClassName.TabIndex = 2;
            this.ClassName.Text = "ClassName";
            // 
            // UnitName
            // 
            this.UnitName.Location = new System.Drawing.Point(75, 22);
            this.UnitName.Name = "UnitName";
            this.UnitName.Size = new System.Drawing.Size(131, 20);
            this.UnitName.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // CreationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 347);
            this.Controls.Add(this.panel2);
            this.Name = "CreationWindow";
            this.Text = "CreationWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StatPlus;
        private System.Windows.Forms.Label StrengthValue;
        private System.Windows.Forms.Button StatMinus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UnitName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label IntelligenceValue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DexterityValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.TextBox UnitClass;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label RemainingPoints;
    }
}