namespace LibEvent
{
    partial class Facildocs
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
            this.closeButton = new System.Windows.Forms.Label();
            this.FasList = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.descBox = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.codTBox = new System.Windows.Forms.TextBox();
            this.codBox = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAdr = new System.Windows.Forms.Label();
            this.lbByc = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FasList)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(915, 100);
            this.autoLabel.TabIndex = 14;
            this.autoLabel.Text = "Удобства";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FasList
            // 
            this.FasList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FasList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.FasList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FasList.Location = new System.Drawing.Point(193, 121);
            this.FasList.Name = "FasList";
            this.FasList.RowTemplate.Height = 25;
            this.FasList.Size = new System.Drawing.Size(713, 196);
            this.FasList.TabIndex = 16;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(410, 390);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(8, 294);
            this.descBox.MaxLength = 3463;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(172, 23);
            this.descBox.TabIndex = 68;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(8, 268);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(134, 26);
            this.lbPhone.TabIndex = 66;
            this.lbPhone.Text = "Краткое описание";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(8, 245);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 23);
            this.nameBox.TabIndex = 65;
            // 
            // codTBox
            // 
            this.codTBox.Location = new System.Drawing.Point(8, 196);
            this.codTBox.Name = "codTBox";
            this.codTBox.Size = new System.Drawing.Size(172, 23);
            this.codTBox.TabIndex = 64;
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(8, 147);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(172, 23);
            this.codBox.TabIndex = 63;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(8, 219);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(179, 26);
            this.lbName.TabIndex = 62;
            this.lbName.Text = "Наименование удобства";
            // 
            // lbAdr
            // 
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdr.Location = new System.Drawing.Point(8, 170);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(144, 26);
            this.lbAdr.TabIndex = 61;
            this.lbAdr.Text = "Код вида удобства";
            // 
            // lbByc
            // 
            this.lbByc.AutoSize = true;
            this.lbByc.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbByc.Location = new System.Drawing.Point(8, 121);
            this.lbByc.Name = "lbByc";
            this.lbByc.Size = new System.Drawing.Size(107, 26);
            this.lbByc.TabIndex = 60;
            this.lbByc.Text = "Код удобства";
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Image = global::LibEvent.Properties.Resources.addBtn2;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(39, 346);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 38);
            this.addButton.TabIndex = 69;
            this.addButton.Text = "Добавить";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Image = global::LibEvent.Properties.Resources.delBtn1;
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delButton.Location = new System.Drawing.Point(781, 346);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(125, 38);
            this.delButton.TabIndex = 70;
            this.delButton.Text = "Удалить";
            this.delButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // Facildocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(915, 438);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.codTBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAdr);
            this.Controls.Add(this.lbByc);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.FasList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facildocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.Facildocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FasList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label autoLabel;
        private Label closeButton;
        private DataGridView FasList;
        private Button backButton;
        private TextBox descBox;
        private Label lbPhone;
        private TextBox nameBox;
        private TextBox codTBox;
        private TextBox codBox;
        private Label lbName;
        private Label lbAdr;
        private Label lbByc;
        private Button addButton;
        private Button delButton;
    }
}