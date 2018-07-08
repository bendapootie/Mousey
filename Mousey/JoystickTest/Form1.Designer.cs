namespace JoytsicTest
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label15;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TriggerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.LeftThumbInnerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.RightThumbOuterDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.LeftThumbOuterDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.RightThumbInnerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.RadialMouseInput = new System.Windows.Forms.CheckBox();
            this.SubPixelMouseInput = new System.Windows.Forms.CheckBox();
            this.MouseSensitivityInput = new System.Windows.Forms.NumericUpDown();
            this.StickTranslationExponentInput = new System.Windows.Forms.NumericUpDown();
            this.FeatherMovementInput = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label15 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbInnerDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbOuterDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbOuterDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbInnerDeadZoneInput)).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseSensitivityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickTranslationExponentInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 13);
            label2.TabIndex = 8;
            label2.Text = "Dead Zones";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(this.TriggerDeadZoneInput);
            panel1.Controls.Add(this.LeftThumbInnerDeadZoneInput);
            panel1.Controls.Add(this.RightThumbOuterDeadZoneInput);
            panel1.Controls.Add(this.LeftThumbOuterDeadZoneInput);
            panel1.Controls.Add(this.RightThumbInnerDeadZoneInput);
            panel1.Location = new System.Drawing.Point(234, 50);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(221, 122);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 94);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 13);
            label7.TabIndex = 13;
            label7.Text = "Triggers";
            label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 13);
            label6.TabIndex = 12;
            label6.Text = "Right Stick";
            label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 13);
            label5.TabIndex = 11;
            label5.Text = "Left Stick";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(141, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 10;
            label4.Text = "Outer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(72, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 13);
            label3.TabIndex = 9;
            label3.Text = "Inner";
            // 
            // TriggerDeadZoneInput
            // 
            this.TriggerDeadZoneInput.DecimalPlaces = 4;
            this.TriggerDeadZoneInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TriggerDeadZoneInput.Location = new System.Drawing.Point(75, 92);
            this.TriggerDeadZoneInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TriggerDeadZoneInput.Name = "TriggerDeadZoneInput";
            this.TriggerDeadZoneInput.Size = new System.Drawing.Size(60, 20);
            this.TriggerDeadZoneInput.TabIndex = 7;
            // 
            // LeftThumbInnerDeadZoneInput
            // 
            this.LeftThumbInnerDeadZoneInput.DecimalPlaces = 4;
            this.LeftThumbInnerDeadZoneInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LeftThumbInnerDeadZoneInput.Location = new System.Drawing.Point(75, 40);
            this.LeftThumbInnerDeadZoneInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftThumbInnerDeadZoneInput.Name = "LeftThumbInnerDeadZoneInput";
            this.LeftThumbInnerDeadZoneInput.Size = new System.Drawing.Size(60, 20);
            this.LeftThumbInnerDeadZoneInput.TabIndex = 3;
            // 
            // RightThumbOuterDeadZoneInput
            // 
            this.RightThumbOuterDeadZoneInput.DecimalPlaces = 4;
            this.RightThumbOuterDeadZoneInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RightThumbOuterDeadZoneInput.Location = new System.Drawing.Point(141, 66);
            this.RightThumbOuterDeadZoneInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RightThumbOuterDeadZoneInput.Name = "RightThumbOuterDeadZoneInput";
            this.RightThumbOuterDeadZoneInput.Size = new System.Drawing.Size(60, 20);
            this.RightThumbOuterDeadZoneInput.TabIndex = 6;
            // 
            // LeftThumbOuterDeadZoneInput
            // 
            this.LeftThumbOuterDeadZoneInput.DecimalPlaces = 4;
            this.LeftThumbOuterDeadZoneInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LeftThumbOuterDeadZoneInput.Location = new System.Drawing.Point(141, 40);
            this.LeftThumbOuterDeadZoneInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LeftThumbOuterDeadZoneInput.Name = "LeftThumbOuterDeadZoneInput";
            this.LeftThumbOuterDeadZoneInput.Size = new System.Drawing.Size(60, 20);
            this.LeftThumbOuterDeadZoneInput.TabIndex = 4;
            // 
            // RightThumbInnerDeadZoneInput
            // 
            this.RightThumbInnerDeadZoneInput.DecimalPlaces = 4;
            this.RightThumbInnerDeadZoneInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RightThumbInnerDeadZoneInput.Location = new System.Drawing.Point(75, 66);
            this.RightThumbInnerDeadZoneInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RightThumbInnerDeadZoneInput.Name = "RightThumbInnerDeadZoneInput";
            this.RightThumbInnerDeadZoneInput.Size = new System.Drawing.Size(60, 20);
            this.RightThumbInnerDeadZoneInput.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(11, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(444, 56);
            textBox1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(69, 65);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 13);
            label8.TabIndex = 14;
            label8.Text = "Sensitivity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(69, 90);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 13);
            label9.TabIndex = 16;
            label9.Text = "Exponent";
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Controls.Add(this.RadialMouseInput);
            panel2.Controls.Add(this.SubPixelMouseInput);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(this.MouseSensitivityInput);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(this.StickTranslationExponentInput);
            panel2.Location = new System.Drawing.Point(11, 50);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(217, 111);
            panel2.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(3, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(39, 13);
            label15.TabIndex = 8;
            label15.Text = "Mouse";
            // 
            // RadialMouseInput
            // 
            this.RadialMouseInput.AutoSize = true;
            this.RadialMouseInput.Location = new System.Drawing.Point(3, 16);
            this.RadialMouseInput.Name = "RadialMouseInput";
            this.RadialMouseInput.Size = new System.Drawing.Size(91, 17);
            this.RadialMouseInput.TabIndex = 11;
            this.RadialMouseInput.Text = "Radial Mouse";
            this.RadialMouseInput.UseVisualStyleBackColor = true;
            // 
            // SubPixelMouseInput
            // 
            this.SubPixelMouseInput.AutoSize = true;
            this.SubPixelMouseInput.Location = new System.Drawing.Point(3, 39);
            this.SubPixelMouseInput.Name = "SubPixelMouseInput";
            this.SubPixelMouseInput.Size = new System.Drawing.Size(101, 17);
            this.SubPixelMouseInput.TabIndex = 12;
            this.SubPixelMouseInput.Text = "Subpixel Mouse";
            this.SubPixelMouseInput.UseVisualStyleBackColor = true;
            // 
            // MouseSensitivityInput
            // 
            this.MouseSensitivityInput.Location = new System.Drawing.Point(3, 62);
            this.MouseSensitivityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MouseSensitivityInput.Name = "MouseSensitivityInput";
            this.MouseSensitivityInput.Size = new System.Drawing.Size(60, 20);
            this.MouseSensitivityInput.TabIndex = 14;
            this.MouseSensitivityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StickTranslationExponentInput
            // 
            this.StickTranslationExponentInput.DecimalPlaces = 2;
            this.StickTranslationExponentInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StickTranslationExponentInput.Location = new System.Drawing.Point(3, 88);
            this.StickTranslationExponentInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StickTranslationExponentInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.StickTranslationExponentInput.Name = "StickTranslationExponentInput";
            this.StickTranslationExponentInput.Size = new System.Drawing.Size(60, 20);
            this.StickTranslationExponentInput.TabIndex = 15;
            this.StickTranslationExponentInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FeatherMovementInput
            // 
            this.FeatherMovementInput.AutoSize = true;
            this.FeatherMovementInput.Location = new System.Drawing.Point(12, 27);
            this.FeatherMovementInput.Name = "FeatherMovementInput";
            this.FeatherMovementInput.Size = new System.Drawing.Size(115, 17);
            this.FeatherMovementInput.TabIndex = 2;
            this.FeatherMovementInput.Text = "Feather Movement";
            this.FeatherMovementInput.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 254);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 276);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(panel2);
            this.Controls.Add(textBox1);
            this.Controls.Add(panel1);
            this.Controls.Add(this.FeatherMovementInput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mousey";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbInnerDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbOuterDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbOuterDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbInnerDeadZoneInput)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouseSensitivityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StickTranslationExponentInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox FeatherMovementInput;
        private System.Windows.Forms.NumericUpDown LeftThumbInnerDeadZoneInput;
        private System.Windows.Forms.NumericUpDown LeftThumbOuterDeadZoneInput;
        private System.Windows.Forms.NumericUpDown RightThumbInnerDeadZoneInput;
        private System.Windows.Forms.NumericUpDown RightThumbOuterDeadZoneInput;
        private System.Windows.Forms.NumericUpDown TriggerDeadZoneInput;
        private System.Windows.Forms.CheckBox RadialMouseInput;
        private System.Windows.Forms.CheckBox SubPixelMouseInput;
        private System.Windows.Forms.NumericUpDown MouseSensitivityInput;
        private System.Windows.Forms.NumericUpDown StickTranslationExponentInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

