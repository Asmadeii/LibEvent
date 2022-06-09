namespace LibEvent
{
    partial class Partners
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
            this.closeButton = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            this.PartnList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PartnList)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(298, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 58;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(670, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 57;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(691, 100);
            this.autoLabel.TabIndex = 56;
            this.autoLabel.Text = "Партнеры мероприятия";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoLabel.Click += new System.EventHandler(this.autoLabel_Click);
            // 
            // PartnList
            // 
            this.PartnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PartnList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.PartnList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.PartnList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PartnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartnList.Location = new System.Drawing.Point(13, 115);
            this.PartnList.Name = "PartnList";
            this.PartnList.RowTemplate.Height = 25;
            this.PartnList.Size = new System.Drawing.Size(664, 238);
            this.PartnList.TabIndex = 103;
            // 
            // Partners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(691, 403);
            this.Controls.Add(this.PartnList);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Partners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.Partners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartnList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Label closeButton;
        private Label autoLabel;
        private DataGridView PartnList;
    }
}