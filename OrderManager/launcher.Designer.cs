namespace OrderManager
{
    partial class launcher
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
            this.logicBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // logicBtn
            // 
            this.logicBtn.Location = new System.Drawing.Point(12, 39);
            this.logicBtn.Name = "logicBtn";
            this.logicBtn.Size = new System.Drawing.Size(126, 23);
            this.logicBtn.TabIndex = 1;
            this.logicBtn.Text = "Будь кто будет";
            this.logicBtn.UseVisualStyleBackColor = true;
            this.logicBtn.Click += new System.EventHandler(this.logicBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Экономисты",
            "Химики"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 168);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logicBtn);
            this.Name = "launcher";
            this.Text = "^, @";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button logicBtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}