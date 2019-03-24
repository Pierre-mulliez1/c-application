namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wavetextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allcheckBox = new System.Windows.Forms.CheckBox();
            this.rockcheckBox = new System.Windows.Forms.CheckBox();
            this.coralcheckBox = new System.Windows.Forms.CheckBox();
            this.sandcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.winterradioButton = new System.Windows.Forms.RadioButton();
            this.fallradioButton = new System.Windows.Forms.RadioButton();
            this.summerradioButton = new System.Windows.Forms.RadioButton();
            this.springradioButton = new System.Windows.Forms.RadioButton();
            this.ResultlistBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Temperaturelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wave size (meter)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country Result";
            // 
            // wavetextBox
            // 
            this.wavetextBox.Location = new System.Drawing.Point(186, 218);
            this.wavetextBox.Name = "wavetextBox";
            this.wavetextBox.Size = new System.Drawing.Size(100, 26);
            this.wavetextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(645, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 81);
            this.button1.TabIndex = 7;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(264, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 81);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allcheckBox);
            this.groupBox1.Controls.Add(this.rockcheckBox);
            this.groupBox1.Controls.Add(this.coralcheckBox);
            this.groupBox1.Controls.Add(this.sandcheckBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beaches preference";
            // 
            // allcheckBox
            // 
            this.allcheckBox.AutoSize = true;
            this.allcheckBox.Location = new System.Drawing.Point(109, 83);
            this.allcheckBox.Name = "allcheckBox";
            this.allcheckBox.Size = new System.Drawing.Size(52, 24);
            this.allcheckBox.TabIndex = 13;
            this.allcheckBox.Text = "All";
            this.allcheckBox.UseVisualStyleBackColor = true;
            // 
            // rockcheckBox
            // 
            this.rockcheckBox.AutoSize = true;
            this.rockcheckBox.Location = new System.Drawing.Point(109, 43);
            this.rockcheckBox.Name = "rockcheckBox";
            this.rockcheckBox.Size = new System.Drawing.Size(72, 24);
            this.rockcheckBox.TabIndex = 12;
            this.rockcheckBox.Text = "Rock";
            this.rockcheckBox.UseVisualStyleBackColor = true;
            // 
            // coralcheckBox
            // 
            this.coralcheckBox.AutoSize = true;
            this.coralcheckBox.Location = new System.Drawing.Point(6, 83);
            this.coralcheckBox.Name = "coralcheckBox";
            this.coralcheckBox.Size = new System.Drawing.Size(72, 24);
            this.coralcheckBox.TabIndex = 11;
            this.coralcheckBox.Text = "Coral";
            this.coralcheckBox.UseVisualStyleBackColor = true;
            // 
            // sandcheckBox
            // 
            this.sandcheckBox.AutoSize = true;
            this.sandcheckBox.Location = new System.Drawing.Point(8, 43);
            this.sandcheckBox.Name = "sandcheckBox";
            this.sandcheckBox.Size = new System.Drawing.Size(77, 24);
            this.sandcheckBox.TabIndex = 10;
            this.sandcheckBox.Text = "Sand ";
            this.sandcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.winterradioButton);
            this.groupBox2.Controls.Add(this.fallradioButton);
            this.groupBox2.Controls.Add(this.summerradioButton);
            this.groupBox2.Controls.Add(this.springradioButton);
            this.groupBox2.Location = new System.Drawing.Point(18, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 138);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Period of desired surf";
            // 
            // winterradioButton
            // 
            this.winterradioButton.AutoSize = true;
            this.winterradioButton.Location = new System.Drawing.Point(137, 94);
            this.winterradioButton.Name = "winterradioButton";
            this.winterradioButton.Size = new System.Drawing.Size(80, 24);
            this.winterradioButton.TabIndex = 18;
            this.winterradioButton.TabStop = true;
            this.winterradioButton.Text = "Winter";
            this.winterradioButton.UseVisualStyleBackColor = true;
            // 
            // fallradioButton
            // 
            this.fallradioButton.AutoSize = true;
            this.fallradioButton.Location = new System.Drawing.Point(137, 48);
            this.fallradioButton.Name = "fallradioButton";
            this.fallradioButton.Size = new System.Drawing.Size(59, 24);
            this.fallradioButton.TabIndex = 17;
            this.fallradioButton.TabStop = true;
            this.fallradioButton.Text = "Fall";
            this.fallradioButton.UseVisualStyleBackColor = true;
            // 
            // summerradioButton
            // 
            this.summerradioButton.AutoSize = true;
            this.summerradioButton.Location = new System.Drawing.Point(6, 94);
            this.summerradioButton.Name = "summerradioButton";
            this.summerradioButton.Size = new System.Drawing.Size(94, 24);
            this.summerradioButton.TabIndex = 16;
            this.summerradioButton.TabStop = true;
            this.summerradioButton.Text = "Summer";
            this.summerradioButton.UseVisualStyleBackColor = true;
            // 
            // springradioButton
            // 
            this.springradioButton.AutoSize = true;
            this.springradioButton.Location = new System.Drawing.Point(6, 48);
            this.springradioButton.Name = "springradioButton";
            this.springradioButton.Size = new System.Drawing.Size(80, 24);
            this.springradioButton.TabIndex = 15;
            this.springradioButton.TabStop = true;
            this.springradioButton.Text = "Spring";
            this.springradioButton.UseVisualStyleBackColor = true;
            // 
            // ResultlistBox
            // 
            this.ResultlistBox.FormattingEnabled = true;
            this.ResultlistBox.ItemHeight = 20;
            this.ResultlistBox.Location = new System.Drawing.Point(320, 85);
            this.ResultlistBox.Name = "ResultlistBox";
            this.ResultlistBox.Size = new System.Drawing.Size(481, 124);
            this.ResultlistBox.TabIndex = 5;
            this.ResultlistBox.SelectedIndexChanged += new System.EventHandler(this.ResultlistBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(516, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 81);
            this.button3.TabIndex = 14;
            this.button3.Text = "New search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cost for a week";
            // 
            // pricelabel
            // 
            this.pricelabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pricelabel.Location = new System.Drawing.Point(565, 235);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(113, 35);
            this.pricelabel.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(719, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 47);
            this.button4.TabIndex = 17;
            this.button4.Text = "Check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Temperaturelabel
            // 
            this.Temperaturelabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Temperaturelabel.Location = new System.Drawing.Point(565, 301);
            this.Temperaturelabel.Name = "Temperaturelabel";
            this.Temperaturelabel.Size = new System.Drawing.Size(113, 35);
            this.Temperaturelabel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Temperature";
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.savebutton.Location = new System.Drawing.Point(386, 379);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(105, 81);
            this.savebutton.TabIndex = 20;
            this.savebutton.Text = "Save ";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(837, 493);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Temperaturelabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wavetextBox);
            this.Controls.Add(this.ResultlistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Surf app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wavetextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox allcheckBox;
        private System.Windows.Forms.CheckBox rockcheckBox;
        private System.Windows.Forms.CheckBox coralcheckBox;
        private System.Windows.Forms.CheckBox sandcheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton winterradioButton;
        private System.Windows.Forms.RadioButton fallradioButton;
        private System.Windows.Forms.RadioButton summerradioButton;
        private System.Windows.Forms.RadioButton springradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Temperaturelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ListBox ResultlistBox;
    }
}

