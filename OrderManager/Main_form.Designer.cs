namespace OrderManager
{
    partial class Main_form
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
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickDataBaseBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.createDataBase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.Location = new System.Drawing.Point(13, 13);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(99, 23);
            this.createOrderBtn.TabIndex = 0;
            this.createOrderBtn.Text = "Создать заказ..";
            this.createOrderBtn.UseVisualStyleBackColor = true;
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.orderList.Location = new System.Drawing.Point(13, 43);
            this.orderList.MultiSelect = false;
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(467, 493);
            this.orderList.TabIndex = 1;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Товар";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заказчик";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Сумма";
            this.columnHeader4.Width = 80;
            // 
            // pickDataBaseBtn
            // 
            this.pickDataBaseBtn.Location = new System.Drawing.Point(633, 13);
            this.pickDataBaseBtn.Name = "pickDataBaseBtn";
            this.pickDataBaseBtn.Size = new System.Drawing.Size(139, 23);
            this.pickDataBaseBtn.TabIndex = 2;
            this.pickDataBaseBtn.Text = "Выбрать базу заказов..";
            this.pickDataBaseBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "DB disconnected..";
            // 
            // createDataBase
            // 
            this.createDataBase.Location = new System.Drawing.Point(633, 43);
            this.createDataBase.Name = "createDataBase";
            this.createDataBase.Size = new System.Drawing.Size(139, 23);
            this.createDataBase.TabIndex = 4;
            this.createDataBase.Text = "Создать базу заказов";
            this.createDataBase.UseVisualStyleBackColor = true;
            this.createDataBase.Click += new System.EventHandler(this.createDataBase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createDataBase);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pickDataBaseBtn);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.createOrderBtn);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main_form";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button pickDataBaseBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button createDataBase;
        private System.Windows.Forms.Button button1;
    }
}