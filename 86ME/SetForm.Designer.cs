﻿namespace _86ME_ver1
{
    partial class SetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBox0 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComboBox0
            // 
            this.ComboBox0.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox0.FormattingEnabled = true;
            this.ComboBox0.Items.AddRange(new object[] {
            "--auto--",
            "--offline--"});
            this.ComboBox0.Location = new System.Drawing.Point(26, 29);
            this.ComboBox0.Name = "ComboBox0";
            this.ComboBox0.Size = new System.Drawing.Size(212, 27);
            this.ComboBox0.TabIndex = 3;
            this.ComboBox0.SelectedIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(26, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(170, 15);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Select the COM port 86Duino used:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(191, 70);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(47, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 97);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBox0);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 135);
            this.MinimumSize = new System.Drawing.Size(275, 135);
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "86ME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBox0;
        public string com_port = "AUTO";
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Exit;
    }
}