namespace Apteka
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonOpenNalich = new System.Windows.Forms.Button();
            this.buttonOpenLekarstv = new System.Windows.Forms.Button();
            this.buttonOpenAptek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apteka.Properties.Resources.avatar_82702;
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonOpenNalich
            // 
            this.buttonOpenNalich.Location = new System.Drawing.Point(12, 166);
            this.buttonOpenNalich.Name = "buttonOpenNalich";
            this.buttonOpenNalich.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenNalich.TabIndex = 2;
            this.buttonOpenNalich.Text = "Сортировка";
            this.buttonOpenNalich.UseVisualStyleBackColor = true;
            // 
            // buttonOpenLekarstv
            // 
            this.buttonOpenLekarstv.Location = new System.Drawing.Point(12, 221);
            this.buttonOpenLekarstv.Name = "buttonOpenLekarstv";
            this.buttonOpenLekarstv.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenLekarstv.TabIndex = 3;
            this.buttonOpenLekarstv.Text = "Лекарства";
            this.buttonOpenLekarstv.UseVisualStyleBackColor = true;
            // 
            // buttonOpenAptek
            // 
            this.buttonOpenAptek.Location = new System.Drawing.Point(12, 275);
            this.buttonOpenAptek.Name = "buttonOpenAptek";
            this.buttonOpenAptek.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAptek.TabIndex = 4;
            this.buttonOpenAptek.Text = "Аптека";
            this.buttonOpenAptek.UseVisualStyleBackColor = true;
            this.buttonOpenAptek.Click += new System.EventHandler(this.buttonOpenAptek_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 331);
            this.Controls.Add(this.buttonOpenAptek);
            this.Controls.Add(this.buttonOpenLekarstv);
            this.Controls.Add(this.buttonOpenNalich);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonOpenNalich;
        private System.Windows.Forms.Button buttonOpenLekarstv;
        private System.Windows.Forms.Button buttonOpenAptek;
    }
}

