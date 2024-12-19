namespace курсач_БД
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
            menuStrip1 = new MenuStrip();
            самавToolStripMenuItem = new ToolStripMenuItem();
            вводКлиентовВБДToolStripMenuItem = new ToolStripMenuItem();
            персоналToolStripMenuItem = new ToolStripMenuItem();
            автоToolStripMenuItem = new ToolStripMenuItem();
            заказыToolStripMenuItem = new ToolStripMenuItem();
            отчетностьToolStripMenuItem = new ToolStripMenuItem();
            услугиToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { самавToolStripMenuItem, вводКлиентовВБДToolStripMenuItem, персоналToolStripMenuItem, автоToolStripMenuItem, заказыToolStripMenuItem, отчетностьToolStripMenuItem, услугиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // самавToolStripMenuItem
            // 
            самавToolStripMenuItem.Name = "самавToolStripMenuItem";
            самавToolStripMenuItem.Size = new Size(124, 24);
            самавToolStripMenuItem.Text = "Ввод Моделей";
            самавToolStripMenuItem.Click += самавToolStripMenuItem_Click;
            // 
            // вводКлиентовВБДToolStripMenuItem
            // 
            вводКлиентовВБДToolStripMenuItem.Name = "вводКлиентовВБДToolStripMenuItem";
            вводКлиентовВБДToolStripMenuItem.Size = new Size(160, 24);
            вводКлиентовВБДToolStripMenuItem.Text = "Ввод клиентов в БД";
            вводКлиентовВБДToolStripMenuItem.Click += вводКлиентовВБДToolStripMenuItem_Click;
            // 
            // персоналToolStripMenuItem
            // 
            персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            персоналToolStripMenuItem.Size = new Size(92, 24);
            персоналToolStripMenuItem.Text = "Персонал";
            персоналToolStripMenuItem.Click += персоналToolStripMenuItem_Click;
            // 
            // автоToolStripMenuItem
            // 
            автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            автоToolStripMenuItem.Size = new Size(56, 24);
            автоToolStripMenuItem.Text = "Авто";
            автоToolStripMenuItem.Click += автоToolStripMenuItem_Click;
            // 
            // заказыToolStripMenuItem
            // 
            заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            заказыToolStripMenuItem.Size = new Size(72, 24);
            заказыToolStripMenuItem.Text = "Заказы";
            заказыToolStripMenuItem.Click += заказыToolStripMenuItem_Click;
            // 
            // отчетностьToolStripMenuItem
            // 
            отчетностьToolStripMenuItem.Name = "отчетностьToolStripMenuItem";
            отчетностьToolStripMenuItem.Size = new Size(101, 24);
            отчетностьToolStripMenuItem.Text = "Отчетность";
            отчетностьToolStripMenuItem.Click += отчетностьToolStripMenuItem_Click;
            // 
            // услугиToolStripMenuItem
            // 
            услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            услугиToolStripMenuItem.Size = new Size(67, 24);
            услугиToolStripMenuItem.Text = "услуги";
            услугиToolStripMenuItem.Click += услугиToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(631, 407);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "авто";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 66);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "клиенты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 101);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "модели";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 136);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "марки";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Информационная система автосалона";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem самавToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem вводКлиентовВБДToolStripMenuItem;
        private ToolStripMenuItem персоналToolStripMenuItem;
        private ToolStripMenuItem автоToolStripMenuItem;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem отчетностьToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
