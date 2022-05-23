namespace LibEvent
{
    partial class BankView
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
            this.autoLabel = new System.Windows.Forms.Label();
            this.БИК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Label();
            this.BankList = new System.Windows.Forms.DataGridView();
            this.bAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.krrBox = new System.Windows.Forms.TextBox();
            this.phoBox = new System.Windows.Forms.TextBox();
            this.lbKrr = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.bnameBox = new System.Windows.Forms.TextBox();
            this.adrBox = new System.Windows.Forms.TextBox();
            this.BycBox = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAdr = new System.Windows.Forms.Label();
            this.lbByc = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankList)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(915, 78);
            this.autoLabel.TabIndex = 27;
            this.autoLabel.Text = "Банк";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // БИК
            // 
            this.БИК.HeaderText = "BIK";
            this.БИК.Name = "БИК";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(779, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // BankList
            // 
            this.BankList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BankList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.BankList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankList.Location = new System.Drawing.Point(201, 117);
            this.BankList.Name = "BankList";
            this.BankList.RowTemplate.Height = 25;
            this.BankList.Size = new System.Drawing.Size(700, 215);
            this.BankList.TabIndex = 33;
            // 
            // bAddButton
            // 
            this.bAddButton.AutoSize = true;
            this.bAddButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddButton.Image = global::LibEvent.Properties.Resources.addBtn2;
            this.bAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddButton.Location = new System.Drawing.Point(40, 352);
            this.bAddButton.Name = "bAddButton";
            this.bAddButton.Size = new System.Drawing.Size(125, 38);
            this.bAddButton.TabIndex = 36;
            this.bAddButton.Text = "Добавить";
            this.bAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAddButton.UseVisualStyleBackColor = true;
            this.bAddButton.Click += new System.EventHandler(this.BAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(893, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Image = global::LibEvent.Properties.Resources.delBtn1;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(776, 352);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 38);
            this.delButton.TabIndex = 48;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // krrBox
            // 
            this.krrBox.Location = new System.Drawing.Point(12, 314);
            this.krrBox.Name = "krrBox";
            this.krrBox.Size = new System.Drawing.Size(172, 23);
            this.krrBox.TabIndex = 59;
            // 
            // phoBox
            // 
            this.phoBox.Location = new System.Drawing.Point(12, 265);
            this.phoBox.Name = "phoBox";
            this.phoBox.Size = new System.Drawing.Size(172, 23);
            this.phoBox.TabIndex = 58;
            // 
            // lbKrr
            // 
            this.lbKrr.AutoSize = true;
            this.lbKrr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKrr.Location = new System.Drawing.Point(12, 288);
            this.lbKrr.Name = "lbKrr";
            this.lbKrr.Size = new System.Drawing.Size(182, 26);
            this.lbKrr.TabIndex = 57;
            this.lbKrr.Text = "Корреспондентский счет";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(12, 239);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(114, 26);
            this.lbPhone.TabIndex = 56;
            this.lbPhone.Text = "Телефон банка";
            // 
            // bnameBox
            // 
            this.bnameBox.Location = new System.Drawing.Point(12, 216);
            this.bnameBox.Name = "bnameBox";
            this.bnameBox.Size = new System.Drawing.Size(172, 23);
            this.bnameBox.TabIndex = 55;
            // 
            // adrBox
            // 
            this.adrBox.Location = new System.Drawing.Point(12, 167);
            this.adrBox.Name = "adrBox";
            this.adrBox.Size = new System.Drawing.Size(172, 23);
            this.adrBox.TabIndex = 54;
            // 
            // BycBox
            // 
            this.BycBox.Location = new System.Drawing.Point(12, 118);
            this.BycBox.Name = "BycBox";
            this.BycBox.Size = new System.Drawing.Size(172, 23);
            this.BycBox.TabIndex = 53;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(12, 190);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(153, 26);
            this.lbName.TabIndex = 52;
            this.lbName.Text = "Наименование банка";
            // 
            // lbAdr
            // 
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdr.Location = new System.Drawing.Point(12, 141);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(172, 26);
            this.lbAdr.TabIndex = 51;
            this.lbAdr.Text = "Адрес отделения банка";
            // 
            // lbByc
            // 
            this.lbByc.AutoSize = true;
            this.lbByc.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbByc.Location = new System.Drawing.Point(12, 92);
            this.lbByc.Name = "lbByc";
            this.lbByc.Size = new System.Drawing.Size(36, 26);
            this.lbByc.TabIndex = 50;
            this.lbByc.Text = "БИК";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(410, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(915, 449);
            this.Controls.Add(this.krrBox);
            this.Controls.Add(this.phoBox);
            this.Controls.Add(this.lbKrr);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.bnameBox);
            this.Controls.Add(this.adrBox);
            this.Controls.Add(this.BycBox);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAdr);
            this.Controls.Add(this.lbByc);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAddButton);
            this.Controls.Add(this.BankList);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.BankView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label autoLabel;
        private DataGridViewTextBoxColumn БИК;
        private Label closeButton;
        private DataGridView BankList;
        private Button bAddButton;
        private Label label2;
        private TextBox krrBox;
        private TextBox phoBox;
        private Label lbKrr;
        private Label lbPhone;
        private TextBox bnameBox;
        private TextBox adrBox;
        private TextBox BycBox;
        private Label lbName;
        private Label lbAdr;
        private Label lbByc;
        private Button delButton;
        private Button backButton;
    }
}