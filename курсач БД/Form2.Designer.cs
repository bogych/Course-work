namespace курсач_БД
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            comboBox4 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Кроссовер", "Седан", "Универсал", "Внедорожник" });
            comboBox2.Location = new Point(271, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Бензин", "Дизель", "Гибрид", "Электро" });
            comboBox3.Location = new Point(523, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 404);
            button1.Name = "button1";
            button1.Size = new Size(93, 34);
            button1.TabIndex = 3;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(523, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 6;
            label1.Text = "Выберите Марку автомобиля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 5);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 7;
            label2.Text = "Тип кузова";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(523, 5);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 8;
            label3.Text = "Тип двигателя";
            // 
            // button2
            // 
            button2.Location = new Point(694, 407);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "МКПП", "АКПП", "Робот", "Вариатор" });
            comboBox4.Location = new Point(523, 122);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 11;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 100);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 12;
            label4.Text = "Объем двигателя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 188);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 13;
            label5.Text = "Начальная цена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(523, 100);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 14;
            label6.Text = "КПП";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 199);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(151, 30);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 176);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 16;
            label7.Text = "Название модели";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(523, 254);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 17;
            label8.Text = "Начальная цена";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(523, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Ввод Моделей";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private ComboBox comboBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
    }
}