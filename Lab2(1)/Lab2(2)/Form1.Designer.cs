namespace Lab2_2_
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
            this.btInputInformationAboutServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnection
            // 
            this.btConnection.Location = new System.Drawing.Point(411, 278);
            this.btConnection.Name = "btConnection";
            this.btConnection.Size = new System.Drawing.Size(246, 23);
            this.btConnection.TabIndex = 9;
            this.btConnection.Text = "Подключиться";
            this.btConnection.UseVisualStyleBackColor = true;
            this.btConnection.Click += new System.EventHandler(this.btConnection_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(12, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(645, 260);
            this.lbInfo.TabIndex = 10;
            // 
            // btInputInformationAboutServer
            // 
            this.btInputInformationAboutServer.Location = new System.Drawing.Point(12, 278);
            this.btInputInformationAboutServer.Name = "btInputInformationAboutServer";
            this.btInputInformationAboutServer.Size = new System.Drawing.Size(246, 23);
            this.btInputInformationAboutServer.TabIndex = 11;
            this.btInputInformationAboutServer.Text = "Ввод параметров соединения";
            this.btInputInformationAboutServer.UseVisualStyleBackColor = true;
            this.btInputInformationAboutServer.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 317);
            this.Controls.Add(this.btInputInformationAboutServer);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btConnection);
            this.Name = "fmMain";
            this.Text = "Подключение к базе данных";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btConnection;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btInputInformationAboutServer;
    }
}

