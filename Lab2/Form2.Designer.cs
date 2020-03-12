namespace Lab2
{
    partial class SettingsForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.dBNameTextBox = new System.Windows.Forms.TextBox();
            this.dBNameLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(424, 177);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 41);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Enabled = false;
            this.saveAndExitButton.Location = new System.Drawing.Point(253, 177);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(164, 41);
            this.saveAndExitButton.TabIndex = 1;
            this.saveAndExitButton.Text = "Сохранить и выйти";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            // 
            // dBNameTextBox
            // 
            this.dBNameTextBox.Location = new System.Drawing.Point(153, 70);
            this.dBNameTextBox.Name = "dBNameTextBox";
            this.dBNameTextBox.Size = new System.Drawing.Size(326, 22);
            this.dBNameTextBox.TabIndex = 2;
            // 
            // dBNameLabel
            // 
            this.dBNameLabel.AutoSize = true;
            this.dBNameLabel.Location = new System.Drawing.Point(38, 75);
            this.dBNameLabel.Name = "dBNameLabel";
            this.dBNameLabel.Size = new System.Drawing.Size(72, 17);
            this.dBNameLabel.TabIndex = 3;
            this.dBNameLabel.Text = "Имя базы";
            this.dBNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dBNameLabel.Click += new System.EventHandler(this.aBNameLabel_Click);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(38, 34);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(93, 17);
            this.serverNameLabel.TabIndex = 4;
            this.serverNameLabel.Text = "Имя сервера";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(153, 34);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(326, 22);
            this.serverNameTextBox.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 231);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.dBNameLabel);
            this.Controls.Add(this.dBNameTextBox);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Настройка параметров подключения";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.TextBox dBNameTextBox;
        private System.Windows.Forms.Label dBNameLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.TextBox serverNameTextBox;
    }
}