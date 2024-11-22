namespace YourLook
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изментьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnNewOrder = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnCustomRequest = new System.Windows.Forms.Button();
			this.btnYourOrders = new System.Windows.Forms.Button();
			this.btnAllOrders = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.lbDesc = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbPrice = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.Location = new System.Drawing.Point(41, 177);
			this.treeView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(810, 587);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изментьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.удалитьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(249, 154);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(248, 48);
			this.добавитьToolStripMenuItem.Text = "Добавить...";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// изментьToolStripMenuItem
			// 
			this.изментьToolStripMenuItem.Name = "изментьToolStripMenuItem";
			this.изментьToolStripMenuItem.Size = new System.Drawing.Size(248, 48);
			this.изментьToolStripMenuItem.Text = "Изменть..";
			this.изментьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 6);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(248, 48);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// btnNewOrder
			// 
			this.btnNewOrder.Location = new System.Drawing.Point(41, 22);
			this.btnNewOrder.Name = "btnNewOrder";
			this.btnNewOrder.Size = new System.Drawing.Size(228, 126);
			this.btnNewOrder.TabIndex = 1;
			this.btnNewOrder.Text = "Сделать Заказ";
			this.btnNewOrder.UseVisualStyleBackColor = true;
			this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(1079, 691);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(201, 126);
			this.btnAdmin.TabIndex = 2;
			this.btnAdmin.Text = "Администрирование";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnCustomRequest
			// 
			this.btnCustomRequest.Location = new System.Drawing.Point(890, 22);
			this.btnCustomRequest.Name = "btnCustomRequest";
			this.btnCustomRequest.Size = new System.Drawing.Size(390, 126);
			this.btnCustomRequest.TabIndex = 3;
			this.btnCustomRequest.Text = "Нестандартный запрос";
			this.btnCustomRequest.UseVisualStyleBackColor = true;
			this.btnCustomRequest.Click += new System.EventHandler(this.btnCustomRequest_Click);
			// 
			// btnYourOrders
			// 
			this.btnYourOrders.Location = new System.Drawing.Point(317, 22);
			this.btnYourOrders.Name = "btnYourOrders";
			this.btnYourOrders.Size = new System.Drawing.Size(213, 126);
			this.btnYourOrders.TabIndex = 4;
			this.btnYourOrders.Text = "История покупок";
			this.btnYourOrders.UseVisualStyleBackColor = true;
			this.btnYourOrders.Click += new System.EventHandler(this.btnYourOrders_Click);
			// 
			// btnAllOrders
			// 
			this.btnAllOrders.Location = new System.Drawing.Point(888, 691);
			this.btnAllOrders.Name = "btnAllOrders";
			this.btnAllOrders.Size = new System.Drawing.Size(168, 126);
			this.btnAllOrders.TabIndex = 5;
			this.btnAllOrders.Text = "Все покупки";
			this.btnAllOrders.UseVisualStyleBackColor = true;
			this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(570, 22);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(281, 126);
			this.btnExcel.TabIndex = 6;
			this.btnExcel.Text = "Выгрузить в Excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// lbDesc
			// 
			this.lbDesc.Location = new System.Drawing.Point(890, 388);
			this.lbDesc.MaximumSize = new System.Drawing.Size(400, 300);
			this.lbDesc.Name = "lbDesc";
			this.lbDesc.Size = new System.Drawing.Size(400, 300);
			this.lbDesc.TabIndex = 9;
			this.lbDesc.Text = "Описание:";
			// 
			// lbName
			// 
			this.lbName.Location = new System.Drawing.Point(888, 179);
			this.lbName.MaximumSize = new System.Drawing.Size(400, 100);
			this.lbName.MinimumSize = new System.Drawing.Size(400, 100);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(400, 100);
			this.lbName.TabIndex = 8;
			this.lbName.Text = "Название";
			// 
			// lbPrice
			// 
			this.lbPrice.Location = new System.Drawing.Point(890, 304);
			this.lbPrice.MaximumSize = new System.Drawing.Size(400, 50);
			this.lbPrice.MinimumSize = new System.Drawing.Size(400, 50);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(400, 50);
			this.lbPrice.TabIndex = 10;
			this.lbPrice.Text = "Цена:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1310, 847);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbDesc);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnAllOrders);
			this.Controls.Add(this.btnYourOrders);
			this.Controls.Add(this.btnCustomRequest);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.btnNewOrder);
			this.Controls.Add(this.treeView1);
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "Form1";
			this.Text = "YourLook";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изментьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private Button btnNewOrder;
		private Button btnAdmin;
		private Button btnCustomRequest;
		private Button btnYourOrders;
		private Button btnAllOrders;
		private Button btnExcel;
		private Label lbDesc;
		private Label lbName;
		private Label lbPrice;
	}
}

