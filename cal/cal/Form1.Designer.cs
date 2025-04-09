namespace cal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(361, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(361, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Imprint MT Shadow", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(190, 126, 131);
            button1.Location = new Point(152, 241);
            button1.Name = "button1";
            button1.Size = new Size(132, 62);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(190, 126, 131);
            label1.Location = new Point(195, 47);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "1st Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(190, 126, 131);
            label2.Location = new Point(195, 116);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "2nd Number:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Imprint MT Shadow", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(190, 126, 131);
            button2.Location = new Point(281, 241);
            button2.Name = "button2";
            button2.Size = new Size(132, 62);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Imprint MT Shadow", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(190, 126, 131);
            button3.Location = new Point(409, 241);
            button3.Name = "button3";
            button3.Size = new Size(132, 62);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Imprint MT Shadow", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(190, 126, 131);
            button4.Location = new Point(152, 298);
            button4.Name = "button4";
            button4.Size = new Size(132, 62);
            button4.TabIndex = 7;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Imprint MT Shadow", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(190, 126, 131);
            button5.Location = new Point(281, 298);
            button5.Name = "button5";
            button5.Size = new Size(132, 62);
            button5.TabIndex = 8;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(190, 126, 131);
            label3.Location = new Point(230, 188);
            label3.Name = "label3";
            label3.Size = new Size(226, 24);
            label3.TabIndex = 9;
            label3.Text = "Choose an operator (click):";
            label3.Click += label3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Kristen ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(190, 126, 131);
            button6.Location = new Point(409, 298);
            button6.Name = "button6";
            button6.Size = new Size(132, 62);
            button6.TabIndex = 10;
            button6.Text = "CLEAR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(693, 411);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private Button button6;
    }
}
