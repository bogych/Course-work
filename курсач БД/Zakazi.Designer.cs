namespace курсач_БД
{
    partial class Zakazi
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(199, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(692, 12);
            button2.Name = "button2";
            button2.Size = new Size(96, 56);
            button2.TabIndex = 3;
            button2.Text = "добавить клиента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(694, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 5;
            label1.Text = "Выберите авто из списка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 4);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "ФИО клиента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 9);
            label3.Name = "label3";
            label3.Size = new Size(307, 80);
            label3.TabIndex = 7;
            label3.Text = "Если в списке авто не найден \r\nнужный экземпляр то его нужно добавить\r\nв базу данных\r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "год авто";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(191, 126);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 103);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 11;
            label5.Text = "Дата доставки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 196);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 13;
            label6.Text = "Цена";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(395, 126);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 103);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 15;
            label7.Text = "ФИО сотрудника";
            // 
            // Zakazi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Zakazi";
            Text = "Zakazi";
            Load += Zakazi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Label label7;
    }
}