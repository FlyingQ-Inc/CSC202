namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Seven = new Button();
            textBox1 = new TextBox();
            Eight = new Button();
            Nine = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Zero = new Button();
            Dot = new Button();
            Clear = new Button();
            Divide = new Button();
            Multiply = new Button();
            Add = new Button();
            Subtract = new Button();
            Equal = new Button();
            SuspendLayout();
            // 
            // Seven
            // 
            Seven.BackColor = SystemColors.GradientActiveCaption;
            Seven.Location = new Point(138, 74);
            Seven.Name = "Seven";
            Seven.Size = new Size(41, 31);
            Seven.TabIndex = 0;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += Seven_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 255, 128);
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(138, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 41);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Eight
            // 
            Eight.BackColor = SystemColors.GradientActiveCaption;
            Eight.Location = new Point(185, 74);
            Eight.Name = "Eight";
            Eight.Size = new Size(41, 31);
            Eight.TabIndex = 2;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.BackColor = SystemColors.GradientActiveCaption;
            Nine.Location = new Point(232, 74);
            Nine.Name = "Nine";
            Nine.Size = new Size(41, 31);
            Nine.TabIndex = 3;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += Nine_Click;
            // 
            // Four
            // 
            Four.BackColor = SystemColors.GradientActiveCaption;
            Four.Location = new Point(138, 111);
            Four.Name = "Four";
            Four.Size = new Size(41, 31);
            Four.TabIndex = 4;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = false;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.BackColor = SystemColors.GradientActiveCaption;
            Five.Location = new Point(185, 111);
            Five.Name = "Five";
            Five.Size = new Size(41, 31);
            Five.TabIndex = 5;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = false;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.BackColor = SystemColors.GradientActiveCaption;
            Six.Location = new Point(232, 111);
            Six.Name = "Six";
            Six.Size = new Size(41, 31);
            Six.TabIndex = 6;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = false;
            Six.Click += Six_Click;
            // 
            // One
            // 
            One.BackColor = SystemColors.GradientActiveCaption;
            One.Location = new Point(138, 148);
            One.Name = "One";
            One.Size = new Size(41, 31);
            One.TabIndex = 7;
            One.Text = "1";
            One.UseVisualStyleBackColor = false;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.BackColor = SystemColors.GradientActiveCaption;
            Two.Location = new Point(185, 148);
            Two.Name = "Two";
            Two.Size = new Size(41, 31);
            Two.TabIndex = 8;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = false;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.BackColor = SystemColors.GradientActiveCaption;
            Three.Location = new Point(232, 148);
            Three.Name = "Three";
            Three.Size = new Size(41, 31);
            Three.TabIndex = 9;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = false;
            Three.Click += Three_Click;
            // 
            // Zero
            // 
            Zero.BackColor = SystemColors.GradientActiveCaption;
            Zero.Location = new Point(138, 185);
            Zero.Name = "Zero";
            Zero.Size = new Size(41, 31);
            Zero.TabIndex = 10;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += Zero_Click;
            // 
            // Dot
            // 
            Dot.BackColor = SystemColors.GradientActiveCaption;
            Dot.ForeColor = SystemColors.ControlText;
            Dot.Location = new Point(185, 185);
            Dot.Name = "Dot";
            Dot.Size = new Size(41, 31);
            Dot.TabIndex = 11;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = false;
            Dot.Click += Dot_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.GradientActiveCaption;
            Clear.Location = new Point(232, 185);
            Clear.Name = "Clear";
            Clear.Size = new Size(41, 31);
            Clear.TabIndex = 12;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Divide
            // 
            Divide.BackColor = SystemColors.GradientActiveCaption;
            Divide.Location = new Point(294, 74);
            Divide.Name = "Divide";
            Divide.Size = new Size(41, 31);
            Divide.TabIndex = 13;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = SystemColors.GradientActiveCaption;
            Multiply.Location = new Point(294, 111);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(41, 31);
            Multiply.TabIndex = 14;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.GradientActiveCaption;
            Add.Location = new Point(294, 148);
            Add.Name = "Add";
            Add.Size = new Size(41, 31);
            Add.TabIndex = 15;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = SystemColors.GradientActiveCaption;
            Subtract.Location = new Point(294, 185);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(41, 31);
            Subtract.TabIndex = 16;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Subtract_Click;
            // 
            // Equal
            // 
            Equal.BackColor = SystemColors.Highlight;
            Equal.Location = new Point(138, 232);
            Equal.Name = "Equal";
            Equal.Size = new Size(197, 31);
            Equal.TabIndex = 17;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Equal);
            Controls.Add(Subtract);
            Controls.Add(Add);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Clear);
            Controls.Add(Dot);
            Controls.Add(Zero);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(textBox1);
            Controls.Add(Seven);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Seven;
        private TextBox textBox1;
        private Button Eight;
        private Button Nine;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Zero;
        private Button Dot;
        private Button Clear;
        private Button Divide;
        private Button Multiply;
        private Button Add;
        private Button Subtract;
        private Button Equal;
    }
}
