namespace LibEvent
{
    partial class Equipdocs
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
            this.backButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.condBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.descBox = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.codTBox = new System.Windows.Forms.TextBox();
            this.codBox = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAdr = new System.Windows.Forms.Label();
            this.lbByc = new System.Windows.Forms.Label();
            this.EquipList = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EquipList)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(410, 470);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 102;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Image = global::LibEvent.Properties.Resources.delBtn1;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(778, 426);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 38);
            this.delButton.TabIndex = 101;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(12, 383);
            this.priceBox.MaxLength = 3463;
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(172, 23);
            this.priceBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Стоимость";
            // 
            // condBox
            // 
            this.condBox.Location = new System.Drawing.Point(12, 334);
            this.condBox.Name = "condBox";
            this.condBox.Size = new System.Drawing.Size(172, 23);
            this.condBox.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 97;
            this.label2.Text = "Условия аренды";
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Image = global::LibEvent.Properties.Resources.addBtn2;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(46, 426);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 38);
            this.addButton.TabIndex = 96;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(12, 285);
            this.descBox.MaxLength = 3463;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(172, 23);
            this.descBox.TabIndex = 95;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(12, 259);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(134, 26);
            this.lbPhone.TabIndex = 94;
            this.lbPhone.Text = "Краткое описание";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 236);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 23);
            this.nameBox.TabIndex = 93;
            // 
            // codTBox
            // 
            this.codTBox.Location = new System.Drawing.Point(12, 187);
            this.codTBox.Name = "codTBox";
            this.codTBox.Size = new System.Drawing.Size(172, 23);
            this.codTBox.TabIndex = 92;
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(12, 138);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(172, 23);
            this.codBox.TabIndex = 91;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(12, 210);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(113, 26);
            this.lbName.TabIndex = 90;
            this.lbName.Text = "Наименование ";
            // 
            // lbAdr
            // 
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdr.Location = new System.Drawing.Point(12, 161);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(176, 26);
            this.lbAdr.TabIndex = 89;
            this.lbAdr.Text = "Код вида оборудования";
            // 
            // lbByc
            // 
            this.lbByc.AutoSize = true;
            this.lbByc.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbByc.Location = new System.Drawing.Point(12, 112);
            this.lbByc.Name = "lbByc";
            this.lbByc.Size = new System.Drawing.Size(139, 26);
            this.lbByc.TabIndex = 88;
            this.lbByc.Text = "Код оборудования";
            // 
            // EquipList
            // 
            this.EquipList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EquipList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EquipList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.EquipList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EquipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipList.Location = new System.Drawing.Point(190, 138);
            this.EquipList.Name = "EquipList";
            this.EquipList.RowTemplate.Height = 25;
            this.EquipList.Size = new System.Drawing.Size(713, 238);
            this.EquipList.TabIndex = 87;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(894, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 86;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(915, 100);
            this.autoLabel.TabIndex = 85;
            this.autoLabel.Text = "Оборудование";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Equipdocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(915, 515);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codTBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAdr);
            this.Controls.Add(this.lbByc);
            this.Controls.Add(this.EquipList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipdocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.Equipdocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Button delButton;
        private TextBox priceBox;
        private Label label1;
        private TextBox condBox;
        private Label label2;
        private Button addButton;
        private TextBox descBox;
        private Label lbPhone;
        private TextBox nameBox;
        private TextBox codTBox;
        private TextBox codBox;
        private Label lbName;
        private Label lbAdr;
        private Label lbByc;
        private DataGridView EquipList;
        private Label closeButton;
        private Label autoLabel;
    }
}