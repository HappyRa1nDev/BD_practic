namespace YourLook
{
    partial class CustomRequestF
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.delete = new System.Windows.Forms.Button();
			this.select = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.listView2 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1955, 914);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.listBox2);
			this.tabPage1.Controls.Add(this.delete);
			this.tabPage1.Controls.Add(this.select);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new System.Drawing.Point(10, 58);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage1.Size = new System.Drawing.Size(1935, 846);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Поля";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1057, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(251, 41);
			this.label2.TabIndex = 5;
			this.label2.Text = "Выбранные поля";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 41;
			this.listBox2.Location = new System.Drawing.Point(1057, 114);
			this.listBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(508, 578);
			this.listBox2.TabIndex = 4;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.delete.Location = new System.Drawing.Point(833, 445);
			this.delete.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(196, 161);
			this.delete.TabIndex = 3;
			this.delete.Text = "<-";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// select
			// 
			this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.select.Location = new System.Drawing.Point(833, 148);
			this.select.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(196, 161);
			this.select.TabIndex = 2;
			this.select.Text = "->";
			this.select.UseVisualStyleBackColor = true;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(334, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 41);
			this.label1.TabIndex = 1;
			this.label1.Text = "Все поля";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 41;
			this.listBox1.Location = new System.Drawing.Point(343, 114);
			this.listBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(474, 578);
			this.listBox1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.comboBox4);
			this.tabPage2.Controls.Add(this.comboBox3);
			this.tabPage2.Controls.Add(this.comboBox2);
			this.tabPage2.Controls.Add(this.comboBox1);
			this.tabPage2.Controls.Add(this.listView1);
			this.tabPage2.Location = new System.Drawing.Point(10, 58);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage2.Size = new System.Drawing.Size(1935, 846);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Условия";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(1696, 752);
			this.button5.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(212, 73);
			this.button5.TabIndex = 10;
			this.button5.Text = "Удалить";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1426, 752);
			this.button4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(212, 73);
			this.button4.TabIndex = 9;
			this.button4.Text = "Добавить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1716, 619);
			this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 41);
			this.label7.TabIndex = 8;
			this.label7.Text = "Связка";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1294, 622);
			this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 41);
			this.label6.TabIndex = 7;
			this.label6.Text = "Выражение";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1019, 622);
			this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 41);
			this.label5.TabIndex = 6;
			this.label5.Text = "Критерий";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(583, 619);
			this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 41);
			this.label4.TabIndex = 5;
			this.label4.Text = "Имя поля";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(1696, 669);
			this.comboBox4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(205, 49);
			this.comboBox4.TabIndex = 4;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(1302, 669);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(336, 49);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(1028, 669);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(185, 49);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(591, 672);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(336, 49);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// listView1
			// 
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(23, 19);
			this.listView1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1885, 565);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(10, 58);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage3.Size = new System.Drawing.Size(1935, 846);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Порядок";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.listView2);
			this.tabPage4.Location = new System.Drawing.Point(10, 58);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.tabPage4.Size = new System.Drawing.Size(1935, 846);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Результат";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(17, 19);
			this.listView2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(1882, 1171);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(771, 932);
			this.button1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(385, 82);
			this.button1.TabIndex = 1;
			this.button1.Text = "Просмотр SQL";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1218, 932);
			this.button2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(385, 82);
			this.button2.TabIndex = 2;
			this.button2.Text = "Выполнить запрос";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1655, 932);
			this.button3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(283, 82);
			this.button3.TabIndex = 3;
			this.button3.Text = "Отмена";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// CustomRequestF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1955, 1045);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "CustomRequestF";
			this.Text = "Новый запрос";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView2;
    }
}