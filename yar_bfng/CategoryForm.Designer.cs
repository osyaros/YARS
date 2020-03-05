namespace yar_bfng
{
    partial class CategoryForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(941, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(693, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Смотреть подробнее";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Цена";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(82, 37);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(137, 22);
            this.priceTextBox.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.filter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(6, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 95);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Категория товаров";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(574, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Поиск";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(665, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(237, 22);
            this.searchBox.TabIndex = 17;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Процессоры",
            "Блоки питания",
            "Системы охолождения",
            "Видеокарты",
            "Материнские платы",
            "Оперативная память",
            "SSD накопители",
            "HDD накопители",
            "Корпуса"});
            this.typeComboBox.Location = new System.Drawing.Point(365, 35);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(189, 24);
            this.typeComboBox.TabIndex = 16;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.filter_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(6, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 572);
            this.panel2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(914, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 60);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 781);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CategoryForm";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.CoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}