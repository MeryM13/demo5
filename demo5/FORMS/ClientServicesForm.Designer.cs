namespace demo5.FORMS
{
    partial class ClientServicesForm
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
            this.layoutServices = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layoutServices
            // 
            this.layoutServices.AutoScroll = true;
            this.layoutServices.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutServices.Location = new System.Drawing.Point(15, 15);
            this.layoutServices.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.layoutServices.Name = "layoutServices";
            this.layoutServices.Size = new System.Drawing.Size(754, 485);
            this.layoutServices.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(329, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClientServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.layoutServices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClientServicesForm";
            this.Text = "ClientServicesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutServices;
        private System.Windows.Forms.Button btnExit;
    }
}