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
            this.economicBtn = new System.Windows.Forms.Button();
            this.logicBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // economicBtn
            // 
            this.economicBtn.Location = new System.Drawing.Point(12, 12);
            this.economicBtn.Name = "economicBtn";
            this.economicBtn.Size = new System.Drawing.Size(126, 23);
            this.economicBtn.TabIndex = 0;
            this.economicBtn.Text = "Экономисты";
            this.economicBtn.UseVisualStyleBackColor = true;
            // 
            // logicBtn
            // 
            this.logicBtn.Location = new System.Drawing.Point(12, 41);
            this.logicBtn.Name = "logicBtn";
            this.logicBtn.Size = new System.Drawing.Size(126, 23);
            this.logicBtn.TabIndex = 1;
            this.logicBtn.Text = "Будь кто будет";
            this.logicBtn.UseVisualStyleBackColor = true;
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logicBtn);
            this.Controls.Add(this.economicBtn);
            this.Name = "launcher";
            this.Text = "^, @";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button economicBtn;
        private System.Windows.Forms.Button logicBtn;
    }
}