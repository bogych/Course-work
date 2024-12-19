namespace курсач_БД
{
    partial class Service
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 385);
            button1.Name = "button1";
            button1.Size = new Size(118, 53);
            button1.TabIndex = 0;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(670, 385);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 1;
            button2.Text = "выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(670, 326);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 5;
            button3.Text = "добавить клиента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 200);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(219, 179);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 177);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 8;
            label2.Text = "описание услуги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 5);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "цена услуги";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(172, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(329, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 5);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 14;
            label3.Text = "Выбрать клиента";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 5);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 15;
            label5.Text = "Выбрать сотрудника";
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Service";
            Text = "Service";
            Load += Service_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Label label5;
    }
}