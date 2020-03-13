namespace Lab2_1_
{
    partial class fmMain
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
            this.btConnection = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btConnection
            // 
            this.btConnection.Location = new System.Drawing.Point(1176, 307);
            this.btConnection.Name = "btConnection";
            this.btConnection.Size = new System.Drawing.Size(152, 23);
            this.btConnection.TabIndex = 1;
            this.btConnection.Text = "Подключить";
            this.btConnection.UseVisualStyleBackColor = true;
            this.btConnection.Click += new System.EventHandler(this.btConnection_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(12, 25);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(1316, 276);
            this.lbInfo.TabIndex = 2;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 358);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btConnection);
            this.Name = "fmMain";
            this.Text = "Состояние подключения";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnection;
        private System.Windows.Forms.ListBox lbInfo;
    }
}

