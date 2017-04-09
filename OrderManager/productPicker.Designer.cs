namespace OrderManager
{
    partial class productPicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addProductBtn = new System.Windows.Forms.Button();
            this.addSelectedBtn = new System.Windows.Forms.Button();
            this.editSelectedBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new wmgCMS.WaterMarkTextBox();
            this.nameTextBox = new wmgCMS.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(313, 77);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.commentTextBox.Size = new System.Drawing.Size(160, 93);
            this.commentTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Примечания:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 337);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Примечания";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(373, 176);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(99, 23);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Создать товар";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // addSelectedBtn
            // 
            this.addSelectedBtn.Location = new System.Drawing.Point(312, 326);
            this.addSelectedBtn.Name = "addSelectedBtn";
            this.addSelectedBtn.Size = new System.Drawing.Size(168, 23);
            this.addSelectedBtn.TabIndex = 7;
            this.addSelectedBtn.Text = "Добавить в заказ выбранные";
            this.addSelectedBtn.UseVisualStyleBackColor = true;
            this.addSelectedBtn.Click += new System.EventHandler(this.addSelectedBtn_Click);
            // 
            // editSelectedBtn
            // 
            this.editSelectedBtn.Location = new System.Drawing.Point(313, 205);
            this.editSelectedBtn.Name = "editSelectedBtn";
            this.editSelectedBtn.Size = new System.Drawing.Size(159, 23);
            this.editSelectedBtn.TabIndex = 8;
            this.editSelectedBtn.Text = "Редактировать выбранный";
            this.editSelectedBtn.UseVisualStyleBackColor = true;
            this.editSelectedBtn.Click += new System.EventHandler(this.editSelectedBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(312, 231);
            this.label3.MaximumSize = new System.Drawing.Size(160, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "Осторожно: редактирование товара также изменит его в других заказах и их сумма мо" +
    "жет изменится!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.priceTextBox.Location = new System.Drawing.Point(372, 38);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.priceTextBox.WaterMarkText = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nameTextBox.Location = new System.Drawing.Point(312, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.nameTextBox.WaterMarkText = "Наименование";
            // 
            // productPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editSelectedBtn);
            this.Controls.Add(this.addSelectedBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "productPicker";
            this.Text = "productPicker";
            this.Load += new System.EventHandler(this.productPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wmgCMS.WaterMarkTextBox nameTextBox;
        private wmgCMS.WaterMarkTextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button addSelectedBtn;
        private System.Windows.Forms.Button editSelectedBtn;
        private System.Windows.Forms.Label label3;
    }
}