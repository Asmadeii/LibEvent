namespace LibEvent
{
    partial class BillCustomer
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
            this.БИК = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.CustomList = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.lbByc = new System.Windows.Forms.Label();
            this.lbAdr = new System.Windows.Forms.Label();
            this.billBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomList)).BeginInit();
            this.SuspendLayout();
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
            this.autoLabel.Size = new System.Drawing.Size(525, 78);
            this.autoLabel.TabIndex = 72;
            this.autoLabel.Text = "Счет заказчика";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(215, 300);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(12, 185);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(172, 23);
            this.typeBox.TabIndex = 82;
            // 
            // CustomList
            // 
            this.CustomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.CustomList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomList.Location = new System.Drawing.Point(194, 111);
            this.CustomList.Name = "CustomList";
            this.CustomList.RowTemplate.Height = 25;
            this.CustomList.Size = new System.Drawing.Size(319, 126);
            this.CustomList.TabIndex = 75;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Image = global::LibEvent.Properties.Resources.addBtn2;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(25, 255);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 38);
            this.AddButton.TabIndex = 76;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(503, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 77;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Image = global::LibEvent.Properties.Resources.delBtn1;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(388, 255);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 38);
            this.delButton.TabIndex = 78;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // lbByc
            // 
            this.lbByc.AutoSize = true;
            this.lbByc.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbByc.Location = new System.Drawing.Point(12, 110);
            this.lbByc.Name = "lbByc";
            this.lbByc.Size = new System.Drawing.Size(97, 26);
            this.lbByc.TabIndex = 79;
            this.lbByc.Text = "Номер счета";
            // 
            // lbAdr
            // 
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdr.Location = new System.Drawing.Point(12, 159);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(79, 26);
            this.lbAdr.TabIndex = 80;
            this.lbAdr.Text = "тип счета";
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(12, 136);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(172, 23);
            this.billBox.TabIndex = 81;
            // 
            // BillCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(525, 345);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.lbAdr);
            this.Controls.Add(this.lbByc);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomList);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.BillCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridViewTextBoxColumn БИК;
        private Label autoLabel;
        private Button backButton;
        private TextBox typeBox;
        private DataGridView CustomList;
        private Button AddButton;
        private Label closeButton;
        private Button delButton;
        private Label lbByc;
        private Label lbAdr;
        private TextBox billBox;
    }
}