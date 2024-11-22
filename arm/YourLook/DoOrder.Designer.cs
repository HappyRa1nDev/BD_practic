namespace YourLook
{
    partial class DoOrder
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(1000, 637);
			this.button1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(276, 91);
			this.button1.TabIndex = 0;
			this.button1.Text = "Купить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(34, 38);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(486, 49);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(797, 665);
			this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 41);
			this.label2.TabIndex = 5;
			this.label2.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(536, 665);
			this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 41);
			this.label3.TabIndex = 6;
			this.label3.Text = "Сумма заказа: ";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 41;
			this.listBox1.Location = new System.Drawing.Point(34, 136);
			this.listBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(486, 455);
			this.listBox1.TabIndex = 7;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 41;
			this.listBox2.Location = new System.Drawing.Point(734, 136);
			this.listBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(542, 455);
			this.listBox2.TabIndex = 8;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(548, 171);
			this.button2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(170, 142);
			this.button2.TabIndex = 9;
			this.button2.Text = ">";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(548, 350);
			this.button3.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(170, 148);
			this.button3.TabIndex = 10;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(536, 38);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(486, 49);
			this.comboBox2.TabIndex = 11;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// DoOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1297, 776);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
			this.Name = "DoOrder";
			this.Text = "VadosDostavka";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
		private ComboBox comboBox2;
	}
}