namespace carInfoAgencyExample
{
    partial class CarInfo_UI
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
            this.lblTop = new System.Windows.Forms.Label();
            this.lblFord = new System.Windows.Forms.Label();
            this.lblToyota = new System.Windows.Forms.Label();
            this.gvCarCompanyModels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarCompanyModels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Black;
            this.lblTop.Location = new System.Drawing.Point(343, 20);
            this.lblTop.Name = "lblTop";
            this.lblTop.Padding = new System.Windows.Forms.Padding(15);
            this.lblTop.Size = new System.Drawing.Size(466, 59);
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Select the car company to see its info";
            // 
            // lblFord
            // 
            this.lblFord.AutoSize = true;
            this.lblFord.BackColor = System.Drawing.Color.LightGray;
            this.lblFord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFord.ForeColor = System.Drawing.Color.Black;
            this.lblFord.Location = new System.Drawing.Point(711, 95);
            this.lblFord.Name = "lblFord";
            this.lblFord.Padding = new System.Windows.Forms.Padding(53);
            this.lblFord.Size = new System.Drawing.Size(176, 137);
            this.lblFord.TabIndex = 5;
            this.lblFord.Text = "Ford";
            this.lblFord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFord.Click += new System.EventHandler(this.lblFord_Click);
            // 
            // lblToyota
            // 
            this.lblToyota.AutoSize = true;
            this.lblToyota.BackColor = System.Drawing.Color.LightGray;
            this.lblToyota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToyota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToyota.ForeColor = System.Drawing.Color.Black;
            this.lblToyota.Location = new System.Drawing.Point(306, 98);
            this.lblToyota.Name = "lblToyota";
            this.lblToyota.Padding = new System.Windows.Forms.Padding(50);
            this.lblToyota.Size = new System.Drawing.Size(198, 131);
            this.lblToyota.TabIndex = 4;
            this.lblToyota.Text = "Toyota";
            this.lblToyota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToyota.Click += new System.EventHandler(this.lblToyota_Click);
            // 
            // gvCarCompanyModels
            // 
            this.gvCarCompanyModels.AllowUserToAddRows = false;
            this.gvCarCompanyModels.AllowUserToDeleteRows = false;
            this.gvCarCompanyModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCarCompanyModels.Location = new System.Drawing.Point(402, 299);
            this.gvCarCompanyModels.Name = "gvCarCompanyModels";
            this.gvCarCompanyModels.ReadOnly = true;
            this.gvCarCompanyModels.Size = new System.Drawing.Size(394, 150);
            this.gvCarCompanyModels.TabIndex = 6;
            // 
            // CarInfo_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1190, 549);
            this.Controls.Add(this.gvCarCompanyModels);
            this.Controls.Add(this.lblFord);
            this.Controls.Add(this.lblToyota);
            this.Controls.Add(this.lblTop);
            this.Name = "CarInfo_UI";
            this.Text = "Car Information";
            ((System.ComponentModel.ISupportInitialize)(this.gvCarCompanyModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblFord;
        private System.Windows.Forms.Label lblToyota;
        private System.Windows.Forms.DataGridView gvCarCompanyModels;
    }
}

