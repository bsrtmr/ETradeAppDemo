
namespace ETrade.WebFormsUI
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.tbxCustomerNameSurname = new System.Windows.Forms.TextBox();
            this.lblCustomerNameSurname = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxCustomerAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCustomerTelNr1Add = new System.Windows.Forms.TextBox();
            this.tbxCustomerTelNr2Add = new System.Windows.Forms.TextBox();
            this.lblCustomerTelNr2Add = new System.Windows.Forms.Label();
            this.lblCustomerTelNr1Add = new System.Windows.Forms.Label();
            this.cbxCustomerGenderAdd = new System.Windows.Forms.ComboBox();
            this.tbxCustomerBirthdateAdd = new System.Windows.Forms.TextBox();
            this.tbxCustomerNameSurnameAdd = new System.Windows.Forms.TextBox();
            this.tbxCustomerEmailAdd = new System.Windows.Forms.TextBox();
            this.lblCustomerBirthdateAdd = new System.Windows.Forms.Label();
            this.lblCustomerNameSurnameAdd = new System.Windows.Forms.Label();
            this.lblCustomerEmailAdd = new System.Windows.Forms.Label();
            this.lblCustomerGenderAdd = new System.Windows.Forms.Label();
            this.gbxCustomerUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxCustomerTelNr1Update = new System.Windows.Forms.TextBox();
            this.tbxCustomerTelNr2Update = new System.Windows.Forms.TextBox();
            this.lblCustomerTelNr2Update = new System.Windows.Forms.Label();
            this.lblCustomerTelNr1Update = new System.Windows.Forms.Label();
            this.cbxCustomerGenderUpdate = new System.Windows.Forms.ComboBox();
            this.tbxCustomerBirthdateUpdate = new System.Windows.Forms.TextBox();
            this.tbxCustomerNameSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxCustomerEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblCustomerBirthdateUpdate = new System.Windows.Forms.Label();
            this.lblCustomerNameSurnameUpdate = new System.Windows.Forms.Label();
            this.lblCustomerEmailUpdate = new System.Windows.Forms.Label();
            this.lblCustomerGenderUpdate = new System.Windows.Forms.Label();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.gbxCustomerAdd.SuspendLayout();
            this.gbxCustomerUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.tbxCustomerNameSurname);
            this.gbxCategory.Controls.Add(this.lblCustomerNameSurname);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(950, 84);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Müşteri Adına Göre Ara";
            // 
            // tbxCustomerNameSurname
            // 
            this.tbxCustomerNameSurname.Location = new System.Drawing.Point(149, 40);
            this.tbxCustomerNameSurname.Name = "tbxCustomerNameSurname";
            this.tbxCustomerNameSurname.Size = new System.Drawing.Size(157, 20);
            this.tbxCustomerNameSurname.TabIndex = 1;
            this.tbxCustomerNameSurname.TextChanged += new System.EventHandler(this.tbxCustomerNameSurname_TextChanged);
            // 
            // lblCustomerNameSurname
            // 
            this.lblCustomerNameSurname.AutoSize = true;
            this.lblCustomerNameSurname.Location = new System.Drawing.Point(22, 40);
            this.lblCustomerNameSurname.Name = "lblCustomerNameSurname";
            this.lblCustomerNameSurname.Size = new System.Drawing.Size(94, 13);
            this.lblCustomerNameSurname.TabIndex = 0;
            this.lblCustomerNameSurname.Text = "Müşteri Adı Soyadı";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 125);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(950, 126);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(806, 277);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxCustomerAdd
            // 
            this.gbxCustomerAdd.Controls.Add(this.btnAdd);
            this.gbxCustomerAdd.Controls.Add(this.tbxCustomerTelNr1Add);
            this.gbxCustomerAdd.Controls.Add(this.tbxCustomerTelNr2Add);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerTelNr2Add);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerTelNr1Add);
            this.gbxCustomerAdd.Controls.Add(this.cbxCustomerGenderAdd);
            this.gbxCustomerAdd.Controls.Add(this.tbxCustomerBirthdateAdd);
            this.gbxCustomerAdd.Controls.Add(this.tbxCustomerNameSurnameAdd);
            this.gbxCustomerAdd.Controls.Add(this.tbxCustomerEmailAdd);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerBirthdateAdd);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerNameSurnameAdd);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerEmailAdd);
            this.gbxCustomerAdd.Controls.Add(this.lblCustomerGenderAdd);
            this.gbxCustomerAdd.Location = new System.Drawing.Point(12, 306);
            this.gbxCustomerAdd.Name = "gbxCustomerAdd";
            this.gbxCustomerAdd.Size = new System.Drawing.Size(950, 184);
            this.gbxCustomerAdd.TabIndex = 2;
            this.gbxCustomerAdd.TabStop = false;
            this.gbxCustomerAdd.Text = "Yeni Müşteri Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(599, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxCustomerTelNr1Add
            // 
            this.tbxCustomerTelNr1Add.Location = new System.Drawing.Point(599, 39);
            this.tbxCustomerTelNr1Add.Name = "tbxCustomerTelNr1Add";
            this.tbxCustomerTelNr1Add.Size = new System.Drawing.Size(142, 20);
            this.tbxCustomerTelNr1Add.TabIndex = 10;
            // 
            // tbxCustomerTelNr2Add
            // 
            this.tbxCustomerTelNr2Add.Location = new System.Drawing.Point(599, 65);
            this.tbxCustomerTelNr2Add.Name = "tbxCustomerTelNr2Add";
            this.tbxCustomerTelNr2Add.Size = new System.Drawing.Size(142, 20);
            this.tbxCustomerTelNr2Add.TabIndex = 9;
            // 
            // lblCustomerTelNr2Add
            // 
            this.lblCustomerTelNr2Add.AutoSize = true;
            this.lblCustomerTelNr2Add.Location = new System.Drawing.Point(522, 65);
            this.lblCustomerTelNr2Add.Name = "lblCustomerTelNr2Add";
            this.lblCustomerTelNr2Add.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerTelNr2Add.TabIndex = 7;
            this.lblCustomerTelNr2Add.Text = "Telefon2";
            // 
            // lblCustomerTelNr1Add
            // 
            this.lblCustomerTelNr1Add.AutoSize = true;
            this.lblCustomerTelNr1Add.Location = new System.Drawing.Point(522, 39);
            this.lblCustomerTelNr1Add.Name = "lblCustomerTelNr1Add";
            this.lblCustomerTelNr1Add.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerTelNr1Add.TabIndex = 8;
            this.lblCustomerTelNr1Add.Text = "Telefon1";
            // 
            // cbxCustomerGenderAdd
            // 
            this.cbxCustomerGenderAdd.FormattingEnabled = true;
            this.cbxCustomerGenderAdd.Location = new System.Drawing.Point(100, 92);
            this.cbxCustomerGenderAdd.Name = "cbxCustomerGenderAdd";
            this.cbxCustomerGenderAdd.Size = new System.Drawing.Size(138, 21);
            this.cbxCustomerGenderAdd.TabIndex = 7;
            // 
            // tbxCustomerBirthdateAdd
            // 
            this.tbxCustomerBirthdateAdd.Location = new System.Drawing.Point(100, 122);
            this.tbxCustomerBirthdateAdd.Name = "tbxCustomerBirthdateAdd";
            this.tbxCustomerBirthdateAdd.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerBirthdateAdd.TabIndex = 5;
            // 
            // tbxCustomerNameSurnameAdd
            // 
            this.tbxCustomerNameSurnameAdd.Location = new System.Drawing.Point(100, 36);
            this.tbxCustomerNameSurnameAdd.Name = "tbxCustomerNameSurnameAdd";
            this.tbxCustomerNameSurnameAdd.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerNameSurnameAdd.TabIndex = 6;
            // 
            // tbxCustomerEmailAdd
            // 
            this.tbxCustomerEmailAdd.Location = new System.Drawing.Point(100, 62);
            this.tbxCustomerEmailAdd.Name = "tbxCustomerEmailAdd";
            this.tbxCustomerEmailAdd.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerEmailAdd.TabIndex = 4;
            // 
            // lblCustomerBirthdateAdd
            // 
            this.lblCustomerBirthdateAdd.AutoSize = true;
            this.lblCustomerBirthdateAdd.Location = new System.Drawing.Point(22, 125);
            this.lblCustomerBirthdateAdd.Name = "lblCustomerBirthdateAdd";
            this.lblCustomerBirthdateAdd.Size = new System.Drawing.Size(70, 13);
            this.lblCustomerBirthdateAdd.TabIndex = 6;
            this.lblCustomerBirthdateAdd.Text = "Doğum Tarihi";
            // 
            // lblCustomerNameSurnameAdd
            // 
            this.lblCustomerNameSurnameAdd.AutoSize = true;
            this.lblCustomerNameSurnameAdd.Location = new System.Drawing.Point(22, 39);
            this.lblCustomerNameSurnameAdd.Name = "lblCustomerNameSurnameAdd";
            this.lblCustomerNameSurnameAdd.Size = new System.Drawing.Size(53, 13);
            this.lblCustomerNameSurnameAdd.TabIndex = 3;
            this.lblCustomerNameSurnameAdd.Text = "Ad Soyad";
            // 
            // lblCustomerEmailAdd
            // 
            this.lblCustomerEmailAdd.AutoSize = true;
            this.lblCustomerEmailAdd.Location = new System.Drawing.Point(22, 65);
            this.lblCustomerEmailAdd.Name = "lblCustomerEmailAdd";
            this.lblCustomerEmailAdd.Size = new System.Drawing.Size(32, 13);
            this.lblCustomerEmailAdd.TabIndex = 4;
            this.lblCustomerEmailAdd.Text = "Email";
            // 
            // lblCustomerGenderAdd
            // 
            this.lblCustomerGenderAdd.AutoSize = true;
            this.lblCustomerGenderAdd.Location = new System.Drawing.Point(22, 95);
            this.lblCustomerGenderAdd.Name = "lblCustomerGenderAdd";
            this.lblCustomerGenderAdd.Size = new System.Drawing.Size(43, 13);
            this.lblCustomerGenderAdd.TabIndex = 5;
            this.lblCustomerGenderAdd.Text = "Cinsiyet";
            // 
            // gbxCustomerUpdate
            // 
            this.gbxCustomerUpdate.Controls.Add(this.btnUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerTelNr1Update);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerTelNr2Update);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerTelNr2Update);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerTelNr1Update);
            this.gbxCustomerUpdate.Controls.Add(this.cbxCustomerGenderUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerBirthdateUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerNameSurnameUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerEmailUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerBirthdateUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerNameSurnameUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerEmailUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.lblCustomerGenderUpdate);
            this.gbxCustomerUpdate.Location = new System.Drawing.Point(12, 496);
            this.gbxCustomerUpdate.Name = "gbxCustomerUpdate";
            this.gbxCustomerUpdate.Size = new System.Drawing.Size(950, 155);
            this.gbxCustomerUpdate.TabIndex = 3;
            this.gbxCustomerUpdate.TabStop = false;
            this.gbxCustomerUpdate.Text = "Müşteri Bilgilerini Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxCustomerTelNr1Update
            // 
            this.tbxCustomerTelNr1Update.Location = new System.Drawing.Point(599, 32);
            this.tbxCustomerTelNr1Update.Name = "tbxCustomerTelNr1Update";
            this.tbxCustomerTelNr1Update.Size = new System.Drawing.Size(142, 20);
            this.tbxCustomerTelNr1Update.TabIndex = 10;
            // 
            // tbxCustomerTelNr2Update
            // 
            this.tbxCustomerTelNr2Update.Location = new System.Drawing.Point(599, 58);
            this.tbxCustomerTelNr2Update.Name = "tbxCustomerTelNr2Update";
            this.tbxCustomerTelNr2Update.Size = new System.Drawing.Size(142, 20);
            this.tbxCustomerTelNr2Update.TabIndex = 9;
            // 
            // lblCustomerTelNr2Update
            // 
            this.lblCustomerTelNr2Update.AutoSize = true;
            this.lblCustomerTelNr2Update.Location = new System.Drawing.Point(532, 61);
            this.lblCustomerTelNr2Update.Name = "lblCustomerTelNr2Update";
            this.lblCustomerTelNr2Update.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerTelNr2Update.TabIndex = 7;
            this.lblCustomerTelNr2Update.Text = "Telefon2";
            // 
            // lblCustomerTelNr1Update
            // 
            this.lblCustomerTelNr1Update.AutoSize = true;
            this.lblCustomerTelNr1Update.Location = new System.Drawing.Point(532, 35);
            this.lblCustomerTelNr1Update.Name = "lblCustomerTelNr1Update";
            this.lblCustomerTelNr1Update.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerTelNr1Update.TabIndex = 8;
            this.lblCustomerTelNr1Update.Text = "Telefon1";
            // 
            // cbxCustomerGenderUpdate
            // 
            this.cbxCustomerGenderUpdate.FormattingEnabled = true;
            this.cbxCustomerGenderUpdate.Location = new System.Drawing.Point(98, 88);
            this.cbxCustomerGenderUpdate.Name = "cbxCustomerGenderUpdate";
            this.cbxCustomerGenderUpdate.Size = new System.Drawing.Size(138, 21);
            this.cbxCustomerGenderUpdate.TabIndex = 7;
            // 
            // tbxCustomerBirthdateUpdate
            // 
            this.tbxCustomerBirthdateUpdate.Location = new System.Drawing.Point(98, 115);
            this.tbxCustomerBirthdateUpdate.Name = "tbxCustomerBirthdateUpdate";
            this.tbxCustomerBirthdateUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerBirthdateUpdate.TabIndex = 5;
            // 
            // tbxCustomerNameSurnameUpdate
            // 
            this.tbxCustomerNameSurnameUpdate.Location = new System.Drawing.Point(100, 36);
            this.tbxCustomerNameSurnameUpdate.Name = "tbxCustomerNameSurnameUpdate";
            this.tbxCustomerNameSurnameUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerNameSurnameUpdate.TabIndex = 6;
            // 
            // tbxCustomerEmailUpdate
            // 
            this.tbxCustomerEmailUpdate.Location = new System.Drawing.Point(98, 62);
            this.tbxCustomerEmailUpdate.Name = "tbxCustomerEmailUpdate";
            this.tbxCustomerEmailUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxCustomerEmailUpdate.TabIndex = 4;
            // 
            // lblCustomerBirthdateUpdate
            // 
            this.lblCustomerBirthdateUpdate.AutoSize = true;
            this.lblCustomerBirthdateUpdate.Location = new System.Drawing.Point(22, 115);
            this.lblCustomerBirthdateUpdate.Name = "lblCustomerBirthdateUpdate";
            this.lblCustomerBirthdateUpdate.Size = new System.Drawing.Size(70, 13);
            this.lblCustomerBirthdateUpdate.TabIndex = 6;
            this.lblCustomerBirthdateUpdate.Text = "Doğum Tarihi";
            // 
            // lblCustomerNameSurnameUpdate
            // 
            this.lblCustomerNameSurnameUpdate.AutoSize = true;
            this.lblCustomerNameSurnameUpdate.Location = new System.Drawing.Point(22, 39);
            this.lblCustomerNameSurnameUpdate.Name = "lblCustomerNameSurnameUpdate";
            this.lblCustomerNameSurnameUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblCustomerNameSurnameUpdate.TabIndex = 3;
            this.lblCustomerNameSurnameUpdate.Text = "Ad Soyad";
            // 
            // lblCustomerEmailUpdate
            // 
            this.lblCustomerEmailUpdate.AutoSize = true;
            this.lblCustomerEmailUpdate.Location = new System.Drawing.Point(22, 65);
            this.lblCustomerEmailUpdate.Name = "lblCustomerEmailUpdate";
            this.lblCustomerEmailUpdate.Size = new System.Drawing.Size(32, 13);
            this.lblCustomerEmailUpdate.TabIndex = 4;
            this.lblCustomerEmailUpdate.Text = "Email";
            // 
            // lblCustomerGenderUpdate
            // 
            this.lblCustomerGenderUpdate.AutoSize = true;
            this.lblCustomerGenderUpdate.Location = new System.Drawing.Point(22, 91);
            this.lblCustomerGenderUpdate.Name = "lblCustomerGenderUpdate";
            this.lblCustomerGenderUpdate.Size = new System.Drawing.Size(43, 13);
            this.lblCustomerGenderUpdate.TabIndex = 5;
            this.lblCustomerGenderUpdate.Text = "Cinsiyet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 785);
            this.Controls.Add(this.gbxCustomerUpdate);
            this.Controls.Add(this.gbxCustomerAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.gbxCustomerAdd.ResumeLayout(false);
            this.gbxCustomerAdd.PerformLayout();
            this.gbxCustomerUpdate.ResumeLayout(false);
            this.gbxCustomerUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox tbxCustomerNameSurname;
        private System.Windows.Forms.Label lblCustomerNameSurname;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxCustomerAdd;
        private System.Windows.Forms.Label lblCustomerNameSurnameAdd;
        private System.Windows.Forms.Label lblCustomerEmailAdd;
        private System.Windows.Forms.Label lblCustomerGenderAdd;
        private System.Windows.Forms.Label lblCustomerBirthdateAdd;
        private System.Windows.Forms.Label lblCustomerTelNr2Add;
        private System.Windows.Forms.Label lblCustomerTelNr1Add;
        private System.Windows.Forms.TextBox tbxCustomerNameSurnameAdd;
        private System.Windows.Forms.TextBox tbxCustomerEmailAdd;
        private System.Windows.Forms.TextBox tbxCustomerBirthdateAdd;
        private System.Windows.Forms.ComboBox cbxCustomerGenderAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCustomerTelNr1Add;
        private System.Windows.Forms.TextBox tbxCustomerTelNr2Add;
        private System.Windows.Forms.GroupBox gbxCustomerUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxCustomerTelNr1Update;
        private System.Windows.Forms.TextBox tbxCustomerTelNr2Update;
        private System.Windows.Forms.Label lblCustomerTelNr2Update;
        private System.Windows.Forms.Label lblCustomerTelNr1Update;
        private System.Windows.Forms.ComboBox cbxCustomerGenderUpdate;
        private System.Windows.Forms.TextBox tbxCustomerBirthdateUpdate;
        private System.Windows.Forms.TextBox tbxCustomerNameSurnameUpdate;
        private System.Windows.Forms.TextBox tbxCustomerEmailUpdate;
        private System.Windows.Forms.Label lblCustomerBirthdateUpdate;
        private System.Windows.Forms.Label lblCustomerNameSurnameUpdate;
        private System.Windows.Forms.Label lblCustomerEmailUpdate;
        private System.Windows.Forms.Label lblCustomerGenderUpdate;
    }
}

