
namespace ModelRFiD
{
    partial class frm_model
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_model));
            this.ss_model = new System.Windows.Forms.StatusStrip();
            this.tss_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_space = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_tags = new System.Windows.Forms.DataGridView();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastSeen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeenCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ti_time = new System.Windows.Forms.Timer(this.components);
            this.ti_rfid_status = new System.Windows.Forms.Timer(this.components);
            this.dgv_mdl = new System.Windows.Forms.DataGridView();
            this.Model_mdl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_tags = new System.Windows.Forms.GroupBox();
            this.btn_secilenleri_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.gb_mdl = new System.Windows.Forms.GroupBox();
            this.btn_mdl = new System.Windows.Forms.Button();
            this.dgv_mlz = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GozSay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YGozSay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YgozUp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.YgozDown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gb_mlz = new System.Windows.Forms.GroupBox();
            this.pnl_hat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_d_5 = new System.Windows.Forms.RadioButton();
            this.rb_d_1 = new System.Windows.Forms.RadioButton();
            this.rb_d_4 = new System.Windows.Forms.RadioButton();
            this.rb_d_3 = new System.Windows.Forms.RadioButton();
            this.rb_d_2 = new System.Windows.Forms.RadioButton();
            this.sc_ust = new System.Windows.Forms.SplitContainer();
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.btn_devam = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.ti_rfid_reconnect = new System.Windows.Forms.Timer(this.components);
            this.tssb_reconnect = new System.Windows.Forms.ToolStripSplitButton();
            this.ss_model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdl)).BeginInit();
            this.gb_tags.SuspendLayout();
            this.gb_mdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mlz)).BeginInit();
            this.gb_mlz.SuspendLayout();
            this.pnl_hat.SuspendLayout();
            this.sc_ust.Panel1.SuspendLayout();
            this.sc_ust.Panel2.SuspendLayout();
            this.sc_ust.SuspendLayout();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_model
            // 
            this.ss_model.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_time,
            this.tss_space,
            this.tss_status,
            this.tssb_reconnect});
            this.ss_model.Location = new System.Drawing.Point(0, 540);
            this.ss_model.Name = "ss_model";
            this.ss_model.Size = new System.Drawing.Size(784, 22);
            this.ss_model.TabIndex = 2;
            this.ss_model.Text = "statusStrip1";
            // 
            // tss_time
            // 
            this.tss_time.Name = "tss_time";
            this.tss_time.Size = new System.Drawing.Size(110, 17);
            this.tss_time.Text = "0000-00-00 00:00:00";
            // 
            // tss_space
            // 
            this.tss_space.Name = "tss_space";
            this.tss_space.Size = new System.Drawing.Size(502, 17);
            this.tss_space.Spring = true;
            // 
            // tss_status
            // 
            this.tss_status.Name = "tss_status";
            this.tss_status.Size = new System.Drawing.Size(31, 17);
            this.tss_status.Text = "        ";
            // 
            // dgv_tags
            // 
            this.dgv_tags.AllowUserToAddRows = false;
            this.dgv_tags.AllowUserToDeleteRows = false;
            this.dgv_tags.AllowUserToResizeColumns = false;
            this.dgv_tags.AllowUserToResizeRows = false;
            this.dgv_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tags.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tags.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagName,
            this.LastSeen,
            this.SeenCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tags.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tags.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_tags.Location = new System.Drawing.Point(3, 16);
            this.dgv_tags.Name = "dgv_tags";
            this.dgv_tags.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tags.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tags.RowHeadersVisible = false;
            this.dgv_tags.RowHeadersWidth = 20;
            this.dgv_tags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_tags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tags.ShowCellErrors = false;
            this.dgv_tags.ShowCellToolTips = false;
            this.dgv_tags.ShowEditingIcon = false;
            this.dgv_tags.ShowRowErrors = false;
            this.dgv_tags.Size = new System.Drawing.Size(371, 203);
            this.dgv_tags.TabIndex = 0;
            this.dgv_tags.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_tags_DataError);
            this.dgv_tags.SelectionChanged += new System.EventHandler(this.dgv_tags_SelectionChanged);
            // 
            // TagName
            // 
            this.TagName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TagName.HeaderText = "TagName";
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            // 
            // LastSeen
            // 
            this.LastSeen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastSeen.HeaderText = "LastSeen";
            this.LastSeen.Name = "LastSeen";
            this.LastSeen.ReadOnly = true;
            this.LastSeen.Width = 77;
            // 
            // SeenCount
            // 
            this.SeenCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SeenCount.HeaderText = "SeenCount";
            this.SeenCount.Name = "SeenCount";
            this.SeenCount.ReadOnly = true;
            this.SeenCount.Width = 85;
            // 
            // ti_time
            // 
            this.ti_time.Enabled = true;
            this.ti_time.Interval = 1000;
            this.ti_time.Tick += new System.EventHandler(this.ti_time_Tick);
            // 
            // ti_rfid_status
            // 
            this.ti_rfid_status.Interval = 1000;
            this.ti_rfid_status.Tick += new System.EventHandler(this.ti_rfid_status_Tick);
            // 
            // dgv_mdl
            // 
            this.dgv_mdl.AllowUserToAddRows = false;
            this.dgv_mdl.AllowUserToDeleteRows = false;
            this.dgv_mdl.AllowUserToResizeColumns = false;
            this.dgv_mdl.AllowUserToResizeRows = false;
            this.dgv_mdl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_mdl.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_mdl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mdl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model_mdl,
            this.MAKTX});
            this.dgv_mdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mdl.Location = new System.Drawing.Point(3, 16);
            this.dgv_mdl.Name = "dgv_mdl";
            this.dgv_mdl.RowHeadersVisible = false;
            this.dgv_mdl.RowHeadersWidth = 20;
            this.dgv_mdl.ShowCellErrors = false;
            this.dgv_mdl.ShowCellToolTips = false;
            this.dgv_mdl.ShowEditingIcon = false;
            this.dgv_mdl.ShowRowErrors = false;
            this.dgv_mdl.Size = new System.Drawing.Size(367, 236);
            this.dgv_mdl.TabIndex = 3;
            // 
            // Model_mdl
            // 
            this.Model_mdl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Model_mdl.HeaderText = "Model";
            this.Model_mdl.Name = "Model_mdl";
            this.Model_mdl.Width = 61;
            // 
            // MAKTX
            // 
            this.MAKTX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKTX.HeaderText = "Malzeme Kısa Metni";
            this.MAKTX.Name = "MAKTX";
            // 
            // gb_tags
            // 
            this.gb_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_tags.Controls.Add(this.btn_secilenleri_sil);
            this.gb_tags.Controls.Add(this.btn_temizle);
            this.gb_tags.Controls.Add(this.dgv_tags);
            this.gb_tags.Location = new System.Drawing.Point(12, 12);
            this.gb_tags.Name = "gb_tags";
            this.gb_tags.Size = new System.Drawing.Size(377, 255);
            this.gb_tags.TabIndex = 4;
            this.gb_tags.TabStop = false;
            this.gb_tags.Text = "1. Okunan Çipler";
            // 
            // btn_secilenleri_sil
            // 
            this.btn_secilenleri_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_secilenleri_sil.Location = new System.Drawing.Point(201, 225);
            this.btn_secilenleri_sil.Name = "btn_secilenleri_sil";
            this.btn_secilenleri_sil.Size = new System.Drawing.Size(170, 27);
            this.btn_secilenleri_sil.TabIndex = 2;
            this.btn_secilenleri_sil.Text = "Seçilenleri Kaldır";
            this.btn_secilenleri_sil.UseVisualStyleBackColor = true;
            this.btn_secilenleri_sil.Click += new System.EventHandler(this.btn_secilenleri_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_temizle.Location = new System.Drawing.Point(3, 225);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(170, 27);
            this.btn_temizle.TabIndex = 1;
            this.btn_temizle.Text = "Tümünü Kaldır";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // gb_mdl
            // 
            this.gb_mdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_mdl.Controls.Add(this.dgv_mdl);
            this.gb_mdl.Location = new System.Drawing.Point(3, 12);
            this.gb_mdl.Name = "gb_mdl";
            this.gb_mdl.Size = new System.Drawing.Size(373, 255);
            this.gb_mdl.TabIndex = 5;
            this.gb_mdl.TabStop = false;
            this.gb_mdl.Text = "2. Çiplere Karşılık Gelen Modeller";
            // 
            // btn_mdl
            // 
            this.btn_mdl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mdl.Location = new System.Drawing.Point(15, 2);
            this.btn_mdl.Name = "btn_mdl";
            this.btn_mdl.Size = new System.Drawing.Size(754, 50);
            this.btn_mdl.TabIndex = 6;
            this.btn_mdl.Text = "V V V V V V";
            this.btn_mdl.UseVisualStyleBackColor = true;
            this.btn_mdl.Click += new System.EventHandler(this.btn_mdl_Click);
            // 
            // dgv_mlz
            // 
            this.dgv_mlz.AllowUserToAddRows = false;
            this.dgv_mlz.AllowUserToDeleteRows = false;
            this.dgv_mlz.AllowUserToResizeColumns = false;
            this.dgv_mlz.AllowUserToResizeRows = false;
            this.dgv_mlz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mlz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mlz.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_mlz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mlz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.GozSay,
            this.YGozSay,
            this.YgozUp,
            this.YgozDown});
            this.dgv_mlz.Location = new System.Drawing.Point(3, 47);
            this.dgv_mlz.Name = "dgv_mlz";
            this.dgv_mlz.ReadOnly = true;
            this.dgv_mlz.RowHeadersVisible = false;
            this.dgv_mlz.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_mlz.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_mlz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mlz.Size = new System.Drawing.Size(754, 123);
            this.dgv_mlz.TabIndex = 3;
            this.dgv_mlz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mlz_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Malzeme No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Malzeme Kısa Metni";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // GozSay
            // 
            this.GozSay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GozSay.HeaderText = "Göz Sayisi";
            this.GozSay.MinimumWidth = 100;
            this.GozSay.Name = "GozSay";
            this.GozSay.ReadOnly = true;
            // 
            // YGozSay
            // 
            this.YGozSay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YGozSay.DefaultCellStyle = dataGridViewCellStyle4;
            this.YGozSay.HeaderText = "Yeni Göz Sayısı";
            this.YGozSay.MinimumWidth = 100;
            this.YGozSay.Name = "YGozSay";
            this.YGozSay.ReadOnly = true;
            this.YGozSay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YGozSay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // YgozUp
            // 
            this.YgozUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.YgozUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YgozUp.HeaderText = "▼";
            this.YgozUp.Name = "YgozUp";
            this.YgozUp.ReadOnly = true;
            this.YgozUp.Width = 22;
            // 
            // YgozDown
            // 
            this.YgozDown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.YgozDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YgozDown.HeaderText = "▲";
            this.YgozDown.Name = "YgozDown";
            this.YgozDown.ReadOnly = true;
            this.YgozDown.Width = 22;
            // 
            // gb_mlz
            // 
            this.gb_mlz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_mlz.Controls.Add(this.pnl_hat);
            this.gb_mlz.Controls.Add(this.dgv_mlz);
            this.gb_mlz.Location = new System.Drawing.Point(12, 58);
            this.gb_mlz.Name = "gb_mlz";
            this.gb_mlz.Size = new System.Drawing.Size(760, 176);
            this.gb_mlz.TabIndex = 6;
            this.gb_mlz.TabStop = false;
            this.gb_mlz.Text = "3. Modeldeki Malzemeler";
            // 
            // pnl_hat
            // 
            this.pnl_hat.Controls.Add(this.label1);
            this.pnl_hat.Controls.Add(this.rb_d_5);
            this.pnl_hat.Controls.Add(this.rb_d_1);
            this.pnl_hat.Controls.Add(this.rb_d_4);
            this.pnl_hat.Controls.Add(this.rb_d_3);
            this.pnl_hat.Controls.Add(this.rb_d_2);
            this.pnl_hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_hat.Location = new System.Drawing.Point(3, 16);
            this.pnl_hat.Name = "pnl_hat";
            this.pnl_hat.Size = new System.Drawing.Size(754, 25);
            this.pnl_hat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disa:";
            // 
            // rb_d_5
            // 
            this.rb_d_5.Location = new System.Drawing.Point(202, 2);
            this.rb_d_5.Name = "rb_d_5";
            this.rb_d_5.Size = new System.Drawing.Size(33, 20);
            this.rb_d_5.TabIndex = 6;
            this.rb_d_5.Text = "5";
            this.rb_d_5.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_d_1
            // 
            this.rb_d_1.Checked = true;
            this.rb_d_1.Location = new System.Drawing.Point(46, 2);
            this.rb_d_1.Name = "rb_d_1";
            this.rb_d_1.Size = new System.Drawing.Size(33, 20);
            this.rb_d_1.TabIndex = 2;
            this.rb_d_1.TabStop = true;
            this.rb_d_1.Text = "1";
            this.rb_d_1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_d_4
            // 
            this.rb_d_4.Location = new System.Drawing.Point(163, 2);
            this.rb_d_4.Name = "rb_d_4";
            this.rb_d_4.Size = new System.Drawing.Size(33, 20);
            this.rb_d_4.TabIndex = 5;
            this.rb_d_4.Text = "4";
            this.rb_d_4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_d_3
            // 
            this.rb_d_3.Location = new System.Drawing.Point(124, 2);
            this.rb_d_3.Name = "rb_d_3";
            this.rb_d_3.Size = new System.Drawing.Size(33, 20);
            this.rb_d_3.TabIndex = 3;
            this.rb_d_3.Text = "3";
            this.rb_d_3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_d_2
            // 
            this.rb_d_2.Location = new System.Drawing.Point(85, 2);
            this.rb_d_2.Name = "rb_d_2";
            this.rb_d_2.Size = new System.Drawing.Size(33, 20);
            this.rb_d_2.TabIndex = 4;
            this.rb_d_2.Text = "2";
            this.rb_d_2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // sc_ust
            // 
            this.sc_ust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_ust.Location = new System.Drawing.Point(0, 0);
            this.sc_ust.Name = "sc_ust";
            // 
            // sc_ust.Panel1
            // 
            this.sc_ust.Panel1.Controls.Add(this.gb_tags);
            // 
            // sc_ust.Panel2
            // 
            this.sc_ust.Panel2.Controls.Add(this.gb_mdl);
            this.sc_ust.Size = new System.Drawing.Size(784, 270);
            this.sc_ust.SplitterDistance = 392;
            this.sc_ust.TabIndex = 7;
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            this.sc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.sc_ust);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.btn_devam);
            this.sc_main.Panel2.Controls.Add(this.btn_mdl);
            this.sc_main.Panel2.Controls.Add(this.btn_iptal);
            this.sc_main.Panel2.Controls.Add(this.gb_mlz);
            this.sc_main.Size = new System.Drawing.Size(784, 540);
            this.sc_main.SplitterDistance = 270;
            this.sc_main.TabIndex = 8;
            // 
            // btn_devam
            // 
            this.btn_devam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_devam.Location = new System.Drawing.Point(664, 240);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(108, 23);
            this.btn_devam.TabIndex = 5;
            this.btn_devam.Text = "Devam >>>";
            this.btn_devam.UseVisualStyleBackColor = true;
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_iptal.Location = new System.Drawing.Point(12, 240);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(108, 23);
            this.btn_iptal.TabIndex = 4;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // ti_rfid_reconnect
            // 
            this.ti_rfid_reconnect.Interval = 5000;
            this.ti_rfid_reconnect.Tick += new System.EventHandler(this.ti_rfid_reconnect_Tick);
            // 
            // tssb_reconnect
            // 
            this.tssb_reconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssb_reconnect.Image = ((System.Drawing.Image)(resources.GetObject("tssb_reconnect.Image")));
            this.tssb_reconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssb_reconnect.Name = "tssb_reconnect";
            this.tssb_reconnect.Size = new System.Drawing.Size(95, 20);
            this.tssb_reconnect.Text = "Tekrar Bağlan";
            this.tssb_reconnect.ButtonClick += new System.EventHandler(this.tssb_reconnect_ButtonClick);
            // 
            // frm_model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.sc_main);
            this.Controls.Add(this.ss_model);
            this.Name = "frm_model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disa RFiD Model Göz Değiştirici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_mdi_Load);
            this.EnabledChanged += new System.EventHandler(this.frm_model_EnabledChanged);
            this.ss_model.ResumeLayout(false);
            this.ss_model.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mdl)).EndInit();
            this.gb_tags.ResumeLayout(false);
            this.gb_mdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mlz)).EndInit();
            this.gb_mlz.ResumeLayout(false);
            this.pnl_hat.ResumeLayout(false);
            this.sc_ust.Panel1.ResumeLayout(false);
            this.sc_ust.Panel2.ResumeLayout(false);
            this.sc_ust.ResumeLayout(false);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            this.sc_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_model;
        private System.Windows.Forms.ToolStripStatusLabel tss_time;
        private System.Windows.Forms.ToolStripStatusLabel tss_space;
        private System.Windows.Forms.ToolStripStatusLabel tss_status;
        private System.Windows.Forms.Timer ti_time;
        private System.Windows.Forms.Timer ti_rfid_status;
        private System.Windows.Forms.GroupBox gb_tags;
        private System.Windows.Forms.GroupBox gb_mdl;
        private System.Windows.Forms.Button btn_mdl;
        private System.Windows.Forms.GroupBox gb_mlz;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastSeen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeenCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_mdl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKTX;
        private System.Windows.Forms.SplitContainer sc_ust;
        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Button btn_devam;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_secilenleri_sil;
        private System.Windows.Forms.Panel pnl_hat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_d_5;
        private System.Windows.Forms.RadioButton rb_d_1;
        private System.Windows.Forms.RadioButton rb_d_4;
        private System.Windows.Forms.RadioButton rb_d_3;
        private System.Windows.Forms.RadioButton rb_d_2;
        public System.Windows.Forms.DataGridView dgv_tags;
        public System.Windows.Forms.DataGridView dgv_mdl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GozSay;
        private System.Windows.Forms.DataGridViewTextBoxColumn YGozSay;
        private System.Windows.Forms.DataGridViewButtonColumn YgozUp;
        private System.Windows.Forms.DataGridViewButtonColumn YgozDown;
        public System.Windows.Forms.DataGridView dgv_mlz;
        private System.Windows.Forms.Timer ti_rfid_reconnect;
        private System.Windows.Forms.ToolStripSplitButton tssb_reconnect;
        

    }
}

