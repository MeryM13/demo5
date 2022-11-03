namespace demo5.FORMS
{
    partial class MainForm
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
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbEntryNumber = new System.Windows.Forms.ComboBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblShowedEntries = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.grpEntryNumber = new System.Windows.Forms.GroupBox();
            this.rbShowBirthday = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.grpEntryNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AllowUserToDeleteRows = false;
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(15, 182);
            this.dgClients.Margin = new System.Windows.Forms.Padding(6);
            this.dgClients.MultiSelect = false;
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(1154, 512);
            this.dgClients.TabIndex = 0;
            this.dgClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellContentClick);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1129, 706);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Location = new System.Drawing.Point(1077, 706);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 40);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(999, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(999, 68);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 48);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Редактировать";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(999, 121);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbEntryNumber
            // 
            this.cmbEntryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntryNumber.FormattingEnabled = true;
            this.cmbEntryNumber.Items.AddRange(new object[] {
            "10",
            "50",
            "200",
            "Все"});
            this.cmbEntryNumber.Location = new System.Drawing.Point(9, 31);
            this.cmbEntryNumber.Margin = new System.Windows.Forms.Padding(6);
            this.cmbEntryNumber.Name = "cmbEntryNumber";
            this.cmbEntryNumber.Size = new System.Drawing.Size(440, 32);
            this.cmbEntryNumber.TabIndex = 7;
            this.cmbEntryNumber.SelectedIndexChanged += new System.EventHandler(this.cmbEntryNumber_SelectedIndexChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnResetFilter);
            this.grpFilter.Controls.Add(this.rbMale);
            this.grpFilter.Controls.Add(this.rbFemale);
            this.grpFilter.Location = new System.Drawing.Point(15, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(200, 157);
            this.grpFilter.TabIndex = 9;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Пол";
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(7, 105);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(187, 42);
            this.btnResetFilter.TabIndex = 2;
            this.btnResetFilter.Text = "Сбросить";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(7, 64);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(115, 28);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 29);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(114, 28);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // lblShowedEntries
            // 
            this.lblShowedEntries.AutoSize = true;
            this.lblShowedEntries.Location = new System.Drawing.Point(12, 714);
            this.lblShowedEntries.Name = "lblShowedEntries";
            this.lblShowedEntries.Size = new System.Drawing.Size(340, 24);
            this.lblShowedEntries.TabIndex = 10;
            this.lblShowedEntries.Text = "Показаны записи с __ по __ из __";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Controls.Add(this.cmbSearchCategory);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(221, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(304, 157);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "В";
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Items.AddRange(new object[] {
            "",
            "ФИО",
            "Телефон",
            "Email"});
            this.cmbSearchCategory.Location = new System.Drawing.Point(6, 115);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(292, 32);
            this.cmbSearchCategory.TabIndex = 2;
            this.cmbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Найти";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(292, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.cmbSort);
            this.grpSort.Location = new System.Drawing.Point(532, 12);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(458, 73);
            this.grpSort.TabIndex = 12;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Сортировка по";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "",
            "Фамилии",
            "Дате последнего посещения",
            "Количеству посещений"});
            this.cmbSort.Location = new System.Drawing.Point(7, 28);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(445, 32);
            this.cmbSort.TabIndex = 0;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // grpEntryNumber
            // 
            this.grpEntryNumber.Controls.Add(this.cmbEntryNumber);
            this.grpEntryNumber.Location = new System.Drawing.Point(531, 96);
            this.grpEntryNumber.Name = "grpEntryNumber";
            this.grpEntryNumber.Size = new System.Drawing.Size(458, 73);
            this.grpEntryNumber.TabIndex = 13;
            this.grpEntryNumber.TabStop = false;
            this.grpEntryNumber.Text = "Записей на странице";
            // 
            // rbShowBirthday
            // 
            this.rbShowBirthday.AutoSize = true;
            this.rbShowBirthday.Location = new System.Drawing.Point(457, 703);
            this.rbShowBirthday.Name = "rbShowBirthday";
            this.rbShowBirthday.Size = new System.Drawing.Size(383, 52);
            this.rbShowBirthday.TabIndex = 14;
            this.rbShowBirthday.TabStop = true;
            this.rbShowBirthday.Text = "Показать клиентов у которых день \r\nрождения в этом месяце";
            this.rbShowBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbShowBirthday.UseVisualStyleBackColor = true;
            this.rbShowBirthday.Click += new System.EventHandler(this.rbShowBirthday_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.rbShowBirthday);
            this.Controls.Add(this.grpEntryNumber);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblShowedEntries);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpEntryNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbEntryNumber;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblShowedEntries;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.GroupBox grpEntryNumber;
        private System.Windows.Forms.RadioButton rbShowBirthday;
    }
}

