namespace ModelRFiD
{
    partial class frm_kontrol
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btn_devam = new System.Windows.Forms.Button();
            this.dgv_kontrol = new System.Windows.Forms.DataGridView();
            this.KontrolNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontrolMetni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.Controls.Add(this.dgv_kontrol);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(557, 237);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Kontrol Listesi";
            // 
            // btn_devam
            // 
            this.btn_devam.Location = new System.Drawing.Point(390, 255);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(179, 33);
            this.btn_devam.TabIndex = 1;
            this.btn_devam.Text = "Devam";
            this.btn_devam.UseVisualStyleBackColor = true;
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // dgv_kontrol
            // 
            this.dgv_kontrol.AllowUserToAddRows = false;
            this.dgv_kontrol.AllowUserToDeleteRows = false;
            this.dgv_kontrol.AllowUserToResizeColumns = false;
            this.dgv_kontrol.AllowUserToResizeRows = false;
            this.dgv_kontrol.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_kontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontrolNo,
            this.KontrolMetni,
            this.Check});
            this.dgv_kontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kontrol.Location = new System.Drawing.Point(3, 16);
            this.dgv_kontrol.Name = "dgv_kontrol";
            this.dgv_kontrol.RowHeadersVisible = false;
            this.dgv_kontrol.Size = new System.Drawing.Size(551, 218);
            this.dgv_kontrol.TabIndex = 0;
            // 
            // KontrolNo
            // 
            this.KontrolNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KontrolNo.HeaderText = "No";
            this.KontrolNo.Name = "KontrolNo";
            this.KontrolNo.Width = 50;
            // 
            // KontrolMetni
            // 
            this.KontrolMetni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KontrolMetni.HeaderText = "Kontrol Açıklaması";
            this.KontrolMetni.Name = "KontrolMetni";
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Check.FalseValue = " ";
            this.Check.HeaderText = "Durum";
            this.Check.Name = "Check";
            this.Check.TrueValue = "X";
            this.Check.Width = 40;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(12, 255);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(179, 33);
            this.btn_iptal.TabIndex = 2;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // frm_kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 300);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_devam);
            this.Controls.Add(this.gb1);
            this.Name = "frm_kontrol";
            this.Text = "frm_kontrol";
            this.Load += new System.EventHandler(this.frm_kontrol_Load);
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn_devam;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontrolNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontrolMetni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button btn_iptal;
        public System.Windows.Forms.DataGridView dgv_kontrol;
    }
}