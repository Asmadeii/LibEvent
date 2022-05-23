namespace LibEvent
{
    partial class Customer
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
            this.closeButton = new System.Windows.Forms.Label();
            this.БИК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoLabel = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.phoBox = new System.Windows.Forms.TextBox();
            this.lbKrr = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.adrBox = new System.Windows.Forms.TextBox();
            this.InnBox = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAdr = new System.Windows.Forms.Label();
            this.lbByc = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CusList = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(903, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // БИК
            // 
            this.БИК.HeaderText = "BIK";
            this.БИК.Name = "БИК";
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(924, 78);
            this.autoLabel.TabIndex = 26;
            this.autoLabel.Text = "заказчик";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(13, 304);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(172, 23);
            this.mailBox.TabIndex = 76;
            // 
            // phoBox
            // 
            this.phoBox.Location = new System.Drawing.Point(13, 255);
            this.phoBox.Name = "phoBox";
            this.phoBox.Size = new System.Drawing.Size(172, 23);
            this.phoBox.TabIndex = 75;
            // 
            // lbKrr
            // 
            this.lbKrr.AutoSize = true;
            this.lbKrr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKrr.Location = new System.Drawing.Point(12, 278);
            this.lbKrr.Name = "lbKrr";
            this.lbKrr.Size = new System.Drawing.Size(55, 26);
            this.lbKrr.TabIndex = 74;
            this.lbKrr.Text = "e-mail";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(13, 229);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(157, 26);
            this.lbPhone.TabIndex = 73;
            this.lbPhone.Text = "Контактный телефон";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(13, 157);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 23);
            this.nameBox.TabIndex = 72;
            // 
            // adrBox
            // 
            this.adrBox.Location = new System.Drawing.Point(13, 206);
            this.adrBox.Name = "adrBox";
            this.adrBox.Size = new System.Drawing.Size(172, 23);
            this.adrBox.TabIndex = 71;
            // 
            // InnBox
            // 
            this.InnBox.Location = new System.Drawing.Point(13, 108);
            this.InnBox.Name = "InnBox";
            this.InnBox.Size = new System.Drawing.Size(172, 23);
            this.InnBox.TabIndex = 70;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(13, 131);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(113, 26);
            this.lbName.TabIndex = 69;
            this.lbName.Text = "Наименование ";
            // 
            // lbAdr
            // 
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdr.Location = new System.Drawing.Point(13, 180);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(147, 26);
            this.lbAdr.TabIndex = 68;
            this.lbAdr.Text = "юридический адрес";
            // 
            // lbByc
            // 
            this.lbByc.AutoSize = true;
            this.lbByc.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbByc.Location = new System.Drawing.Point(12, 82);
            this.lbByc.Name = "lbByc";
            this.lbByc.Size = new System.Drawing.Size(36, 26);
            this.lbByc.TabIndex = 67;
            this.lbByc.Text = "ИНН";
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Image = global::LibEvent.Properties.Resources.delBtn1;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(786, 382);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 38);
            this.delButton.TabIndex = 66;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Image = global::LibEvent.Properties.Resources.addBtn2;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(35, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 38);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CusList
            // 
            this.CusList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CusList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.CusList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusList.Location = new System.Drawing.Point(202, 130);
            this.CusList.Name = "CusList";
            this.CusList.RowTemplate.Height = 25;
            this.CusList.Size = new System.Drawing.Size(709, 208);
            this.CusList.TabIndex = 63;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(415, 426);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 62;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "BIK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fcodeBox
            // 
            this.fcodeBox.Location = new System.Drawing.Point(13, 353);
            this.fcodeBox.Name = "fcodeBox";
            this.fcodeBox.Size = new System.Drawing.Size(172, 23);
            this.fcodeBox.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "код_отв_лица_зак";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.fcodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.phoBox);
            this.Controls.Add(this.lbKrr);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.adrBox);
            this.Controls.Add(this.InnBox);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAdr);
            this.Controls.Add(this.lbByc);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CusList);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label closeButton;
        private DataGridViewTextBoxColumn БИК;
        private Label autoLabel;
        private TextBox mailBox;
        private TextBox phoBox;
        private Label lbKrr;
        private Label lbPhone;
        private TextBox nameBox;
        private TextBox adrBox;
        private TextBox InnBox;
        private Label lbName;
        private Label lbAdr;
        private Label lbByc;
        private Button delButton;
        private Button AddButton;
        private DataGridView CusList;
        private Button backButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox fcodeBox;
        private Label label1;
    }
}