namespace demo5.FORMS
{
    partial class AddUpdateForm
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
            this.imgClient = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnChangeImg = new System.Windows.Forms.Button();
            this.panelTags = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOpenServices = new System.Windows.Forms.Button();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgClient)).BeginInit();
            this.SuspendLayout();
            // 
            // imgClient
            // 
            this.imgClient.Location = new System.Drawing.Point(12, 12);
            this.imgClient.Name = "imgClient";
            this.imgClient.Size = new System.Drawing.Size(347, 342);
            this.imgClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClient.TabIndex = 0;
            this.imgClient.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(538, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 29);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(538, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(294, 29);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(538, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(294, 29);
            this.txtFirstName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(538, 117);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(294, 29);
            this.txtPatronymic.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(538, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 29);
            this.txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(538, 187);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(294, 29);
            this.txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Пол";
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(538, 222);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(294, 29);
            this.dtBirthdate.TabIndex = 17;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(538, 256);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(42, 28);
            this.rbMale.TabIndex = 18;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "м";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(607, 256);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(43, 28);
            this.rbFemale.TabIndex = 19;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "ж";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.Location = new System.Drawing.Point(376, 290);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.Size = new System.Drawing.Size(456, 29);
            this.btnChangeImg.TabIndex = 20;
            this.btnChangeImg.Text = "Изменить фотографию";
            this.btnChangeImg.UseVisualStyleBackColor = true;
            this.btnChangeImg.Click += new System.EventHandler(this.btnChangeImg_Click);
            // 
            // panelTags
            // 
            this.panelTags.Location = new System.Drawing.Point(858, 117);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(319, 237);
            this.panelTags.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(854, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Теги";
            // 
            // btnOpenServices
            // 
            this.btnOpenServices.Location = new System.Drawing.Point(376, 325);
            this.btnOpenServices.Name = "btnOpenServices";
            this.btnOpenServices.Size = new System.Drawing.Size(456, 29);
            this.btnOpenServices.TabIndex = 23;
            this.btnOpenServices.Text = "Посещения";
            this.btnOpenServices.UseVisualStyleBackColor = true;
            this.btnOpenServices.Click += new System.EventHandler(this.btnOpenServices_Click);
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(858, 42);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(319, 32);
            this.cmbTags.TabIndex = 24;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(858, 82);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(319, 29);
            this.btnAddTag.TabIndex = 25;
            this.btnAddTag.Text = "Добавить";
            this.btnAddTag.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(293, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 29);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(607, 378);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(287, 29);
            this.btnSaveAndExit.TabIndex = 27;
            this.btnSaveAndExit.Text = "Сохранить и выйти";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 419);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.btnOpenServices);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelTags);
            this.Controls.Add(this.btnChangeImg);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.imgClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddUpdateForm";
            this.Text = "AddUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgClient;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnChangeImg;
        private System.Windows.Forms.FlowLayoutPanel panelTags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOpenServices;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAndExit;
    }
}