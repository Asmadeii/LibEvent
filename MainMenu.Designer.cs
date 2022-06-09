namespace LibEvent
{
    partial class MainMenu
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
            this.eventButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.contractButton = new System.Windows.Forms.Button();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.priceButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(314, 100);
            this.autoLabel.TabIndex = 3;
            this.autoLabel.Text = "Главное меню";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(294, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // eventButton
            // 
            this.eventButton.AutoSize = true;
            this.eventButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventButton.Location = new System.Drawing.Point(132, 139);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(115, 36);
            this.eventButton.TabIndex = 5;
            this.eventButton.Text = "Мероприятия";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.AutoSize = true;
            this.DirectoryButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectoryButton.Location = new System.Drawing.Point(132, 334);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(115, 36);
            this.DirectoryButton.TabIndex = 6;
            this.DirectoryButton.Text = "Справочники";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // contractButton
            // 
            this.contractButton.AutoSize = true;
            this.contractButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contractButton.Location = new System.Drawing.Point(132, 204);
            this.contractButton.Name = "contractButton";
            this.contractButton.Size = new System.Drawing.Size(115, 36);
            this.contractButton.TabIndex = 7;
            this.contractButton.Text = "Договоры";
            this.contractButton.UseVisualStyleBackColor = true;
            this.contractButton.Click += new System.EventHandler(this.contractButton_Click);
            // 
            // userImg
            // 
            this.userImg.Image = global::LibEvent.Properties.Resources.event1;
            this.userImg.InitialImage = global::LibEvent.Properties.Resources.user;
            this.userImg.Location = new System.Drawing.Point(68, 129);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(56, 56);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImg.TabIndex = 8;
            this.userImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibEvent.Properties.Resources.contract1;
            this.pictureBox1.InitialImage = global::LibEvent.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(68, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibEvent.Properties.Resources.directory1;
            this.pictureBox2.InitialImage = global::LibEvent.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(68, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(110, 477);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibEvent.Properties.Resources.price;
            this.pictureBox3.InitialImage = global::LibEvent.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(68, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // priceButton
            // 
            this.priceButton.AutoSize = true;
            this.priceButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceButton.Location = new System.Drawing.Point(132, 269);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(115, 36);
            this.priceButton.TabIndex = 12;
            this.priceButton.Text = "Прайс-лист";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibEvent.Properties.Resources.report;
            this.pictureBox4.InitialImage = global::LibEvent.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(68, 389);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.Location = new System.Drawing.Point(132, 399);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(115, 36);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Отчеты";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(314, 527);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userImg);
            this.Controls.Add(this.contractButton);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.eventButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label autoLabel;
        private Label closeButton;
        private Button eventButton;
        private Button DirectoryButton;
        private Button contractButton;
        private PictureBox userImg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button backButton;
        private PictureBox pictureBox3;
        private Button priceButton;
        private PictureBox pictureBox4;
        private Button btnReport;
    }
}