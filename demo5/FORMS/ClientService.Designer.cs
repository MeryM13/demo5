namespace demo5.FORMS
{
    partial class ClientService
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(10, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 24);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(10, 97);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(66, 24);
            this.lblFileCount.TabIndex = 2;
            this.lblFileCount.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 105);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClientService";
            this.Size = new System.Drawing.Size(644, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Button button1;
    }
}
