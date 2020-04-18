namespace yar_bfng
{
    partial class Creatormode
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categorybox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(43, 37);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(43, 110);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // categorybox
            // 
            this.categorybox.FormattingEnabled = true;
            this.categorybox.Items.AddRange(new object[] {
            "Процессоры",
            "Блоки питания",
            "Системы охолождения",
            "Видеокарты",
            "Материнские платы",
            "Оперативная память",
            "SSD накопители",
            "HDD накопители",
            "Корпуса"});
            this.categorybox.Location = new System.Drawing.Point(216, 37);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(121, 21);
            this.categorybox.TabIndex = 6;
            this.categorybox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(216, 110);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(205, 114);
            this.description.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Картинка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы изображений (.bmp, .jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(498, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 168);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Creatormode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categorybox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Creatormode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Creatormode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categorybox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}