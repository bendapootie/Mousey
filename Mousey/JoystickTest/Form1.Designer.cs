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
            this.TriggerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.LeftThumbInnerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.RightThumbOuterDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.LeftThumbOuterDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.RightThumbInnerDeadZoneInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FeatherMovementCheckBox = new System.Windows.Forms.CheckBox();
            this.RadialMouseInput = new System.Windows.Forms.CheckBox();
            this.SubPixelMouseInput = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbInnerDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbOuterDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbOuterDeadZoneInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbInnerDeadZoneInput)).BeginInit();
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
            panel1.Location = new System.Drawing.Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(217, 122);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FeatherMovementCheckBox
            // 
            this.FeatherMovementCheckBox.AutoSize = true;
            this.FeatherMovementCheckBox.Location = new System.Drawing.Point(13, 26);
            this.FeatherMovementCheckBox.Name = "FeatherMovementCheckBox";
            this.FeatherMovementCheckBox.Size = new System.Drawing.Size(115, 17);
            this.FeatherMovementCheckBox.TabIndex = 2;
            this.FeatherMovementCheckBox.Text = "Feather Movement";
            this.FeatherMovementCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 177);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(265, 56);
            textBox1.TabIndex = 10;
            // 
            // RadialMouseInput
            // 
            this.RadialMouseInput.AutoSize = true;
            this.RadialMouseInput.Checked = true;
            this.RadialMouseInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadialMouseInput.Location = new System.Drawing.Point(134, 26);
            this.RadialMouseInput.Name = "RadialMouseInput";
            this.RadialMouseInput.Size = new System.Drawing.Size(91, 17);
            this.RadialMouseInput.TabIndex = 11;
            this.RadialMouseInput.Text = "Radial Mouse";
            this.RadialMouseInput.UseVisualStyleBackColor = true;
            // 
            // SubPixelMouseInput
            // 
            this.SubPixelMouseInput.AutoSize = true;
            this.SubPixelMouseInput.Checked = true;
            this.SubPixelMouseInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubPixelMouseInput.Location = new System.Drawing.Point(231, 26);
            this.SubPixelMouseInput.Name = "SubPixelMouseInput";
            this.SubPixelMouseInput.Size = new System.Drawing.Size(101, 17);
            this.SubPixelMouseInput.TabIndex = 12;
            this.SubPixelMouseInput.Text = "Subpixel Mouse";
            this.SubPixelMouseInput.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 245);
            this.Controls.Add(this.SubPixelMouseInput);
            this.Controls.Add(this.RadialMouseInput);
            this.Controls.Add(textBox1);
            this.Controls.Add(panel1);
            this.Controls.Add(this.FeatherMovementCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriggerDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbInnerDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbOuterDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftThumbOuterDeadZoneInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightThumbInnerDeadZoneInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FeatherMovementCheckBox;
        private System.Windows.Forms.NumericUpDown LeftThumbInnerDeadZoneInput;
        private System.Windows.Forms.NumericUpDown LeftThumbOuterDeadZoneInput;
        private System.Windows.Forms.NumericUpDown RightThumbInnerDeadZoneInput;
        private System.Windows.Forms.NumericUpDown RightThumbOuterDeadZoneInput;
        private System.Windows.Forms.NumericUpDown TriggerDeadZoneInput;
        private System.Windows.Forms.CheckBox RadialMouseInput;
        private System.Windows.Forms.CheckBox SubPixelMouseInput;
    }
}

