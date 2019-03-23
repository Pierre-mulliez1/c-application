namespace WindowsFormsApp1
{
    partial class Save_and_view
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
            this.viewbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SavelistBox = new System.Windows.Forms.ListBox();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewbutton
            // 
            this.viewbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewbutton.Location = new System.Drawing.Point(149, 83);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(192, 88);
            this.viewbutton.TabIndex = 0;
            this.viewbutton.Text = "View saved countries";
            this.viewbutton.UseVisualStyleBackColor = false;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your country has been saved succesfully!";
            // 
            // SavelistBox
            // 
            this.SavelistBox.FormattingEnabled = true;
            this.SavelistBox.ItemHeight = 20;
            this.SavelistBox.Location = new System.Drawing.Point(71, 187);
            this.SavelistBox.Name = "SavelistBox";
            this.SavelistBox.Size = new System.Drawing.Size(312, 124);
            this.SavelistBox.TabIndex = 2;
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Closebutton.Location = new System.Drawing.Point(436, 239);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(124, 72);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = false;
            // 
            // Save_and_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 349);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.SavelistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewbutton);
            this.Name = "Save_and_view";
            this.Text = "Save_and_view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SavelistBox;
        private System.Windows.Forms.Button Closebutton;
    }
}