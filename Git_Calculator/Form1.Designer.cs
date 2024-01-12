namespace Git_Calculator
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
            button1 = new Button();
            text1 = new TextBox();
            text2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            num_two_label = new Label();
            num_one_label = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // text1
            // 
            resources.ApplyResources(text1, "text1");
            text1.BackColor = Color.BlanchedAlmond;
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.ForeColor = Color.Crimson;
            text1.Name = "text1";
            text1.TextChanged += text1_TextChanged;
            // 
            // text2
            // 
            resources.ApplyResources(text2, "text2");
            text2.BackColor = Color.BlanchedAlmond;
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.ForeColor = Color.Crimson;
            text2.Name = "text2";
            text2.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.MintCream;
            label1.Name = "label1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.trixie;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // num_two_label
            // 
            resources.ApplyResources(num_two_label, "num_two_label");
            num_two_label.BackColor = Color.MistyRose;
            num_two_label.Name = "num_two_label";
            // 
            // num_one_label
            // 
            resources.ApplyResources(num_one_label, "num_one_label");
            num_one_label.BackColor = Color.MistyRose;
            num_one_label.ForeColor = Color.IndianRed;
            num_one_label.Name = "num_one_label";
            num_one_label.Click += num_one_label_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.back;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(num_one_label);
            Controls.Add(num_two_label);
            Controls.Add(text1);
            Controls.Add(button5);
            Controls.Add(text2);
            Controls.Add(pictureBox2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.IndianRed;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox text1;
        private TextBox text2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox2;
        private Label num_two_label;
        private Label num_one_label;
        private Label label4;
        private Label label5;
    }
}
