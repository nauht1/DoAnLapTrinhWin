namespace QL_KhachSan
{
    partial class frmQLDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mBtnXoa = new MetroFramework.Controls.MetroButton();
            this.mBtnHuy = new MetroFramework.Controls.MetroButton();
            this.mBtnLuu = new MetroFramework.Controls.MetroButton();
            this.mBtnSua = new MetroFramework.Controls.MetroButton();
            this.mBtnThem = new MetroFramework.Controls.MetroButton();
            this.mBtnReload = new MetroFramework.Controls.MetroButton();
            this.mdgvDichVu = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mTxtGiaDichVu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mTxtMoTa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTxtTenDichVu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mTxtMaDichVu = new MetroFramework.Controls.MetroTextBox();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnXoa
            // 
            this.mBtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnXoa.Location = new System.Drawing.Point(281, 485);
            this.mBtnXoa.Name = "mBtnXoa";
            this.mBtnXoa.Size = new System.Drawing.Size(80, 36);
            this.mBtnXoa.TabIndex = 36;
            this.mBtnXoa.Text = "Xoa";
            this.mBtnXoa.UseSelectable = true;
            this.mBtnXoa.Click += new System.EventHandler(this.mBtnXoa_Click);
            // 
            // mBtnHuy
            // 
            this.mBtnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnHuy.Location = new System.Drawing.Point(539, 485);
            this.mBtnHuy.Name = "mBtnHuy";
            this.mBtnHuy.Size = new System.Drawing.Size(80, 36);
            this.mBtnHuy.TabIndex = 37;
            this.mBtnHuy.Text = "Huy";
            this.mBtnHuy.UseSelectable = true;
            this.mBtnHuy.Click += new System.EventHandler(this.mBtnHuy_Click);
            // 
            // mBtnLuu
            // 
            this.mBtnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnLuu.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnLuu.Location = new System.Drawing.Point(452, 485);
            this.mBtnLuu.Name = "mBtnLuu";
            this.mBtnLuu.Size = new System.Drawing.Size(80, 36);
            this.mBtnLuu.TabIndex = 38;
            this.mBtnLuu.Text = "Luu";
            this.mBtnLuu.UseSelectable = true;
            this.mBtnLuu.Click += new System.EventHandler(this.mBtnLuu_Click);
            // 
            // mBtnSua
            // 
            this.mBtnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnSua.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSua.Location = new System.Drawing.Point(194, 485);
            this.mBtnSua.Name = "mBtnSua";
            this.mBtnSua.Size = new System.Drawing.Size(80, 36);
            this.mBtnSua.TabIndex = 39;
            this.mBtnSua.Text = "Sua";
            this.mBtnSua.UseSelectable = true;
            this.mBtnSua.Click += new System.EventHandler(this.mBtnSua_Click);
            // 
            // mBtnThem
            // 
            this.mBtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnThem.Location = new System.Drawing.Point(108, 485);
            this.mBtnThem.Name = "mBtnThem";
            this.mBtnThem.Size = new System.Drawing.Size(80, 36);
            this.mBtnThem.TabIndex = 40;
            this.mBtnThem.Text = "Them";
            this.mBtnThem.UseSelectable = true;
            this.mBtnThem.Click += new System.EventHandler(this.mBtnThem_Click);
            // 
            // mBtnReload
            // 
            this.mBtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnReload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReload.Location = new System.Drawing.Point(22, 485);
            this.mBtnReload.Name = "mBtnReload";
            this.mBtnReload.Size = new System.Drawing.Size(80, 36);
            this.mBtnReload.TabIndex = 35;
            this.mBtnReload.Text = "Reload";
            this.mBtnReload.UseSelectable = true;
            this.mBtnReload.Click += new System.EventHandler(this.mBtnReload_Click);
            // 
            // mdgvDichVu
            // 
            this.mdgvDichVu.AllowUserToAddRows = false;
            this.mdgvDichVu.AllowUserToDeleteRows = false;
            this.mdgvDichVu.AllowUserToResizeRows = false;
            this.mdgvDichVu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.MoTa,
            this.GiaDV,
            this.TrangThai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvDichVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvDichVu.EnableHeadersVisualStyles = false;
            this.mdgvDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvDichVu.Location = new System.Drawing.Point(22, 209);
            this.mdgvDichVu.Name = "mdgvDichVu";
            this.mdgvDichVu.ReadOnly = true;
            this.mdgvDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvDichVu.RowHeadersWidth = 43;
            this.mdgvDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvDichVu.Size = new System.Drawing.Size(598, 259);
            this.mdgvDichVu.TabIndex = 34;
            this.mdgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvDichVu_CellClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(23, 164);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 25);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Giá DV";
            // 
            // mTxtGiaDichVu
            // 
            // 
            // 
            // 
            this.mTxtGiaDichVu.CustomButton.Image = null;
            this.mTxtGiaDichVu.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.mTxtGiaDichVu.CustomButton.Name = "";
            this.mTxtGiaDichVu.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtGiaDichVu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtGiaDichVu.CustomButton.TabIndex = 1;
            this.mTxtGiaDichVu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtGiaDichVu.CustomButton.UseSelectable = true;
            this.mTxtGiaDichVu.CustomButton.Visible = false;
            this.mTxtGiaDichVu.Enabled = false;
            this.mTxtGiaDichVu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtGiaDichVu.Lines = new string[0];
            this.mTxtGiaDichVu.Location = new System.Drawing.Point(88, 164);
            this.mTxtGiaDichVu.MaxLength = 32767;
            this.mTxtGiaDichVu.Multiline = true;
            this.mTxtGiaDichVu.Name = "mTxtGiaDichVu";
            this.mTxtGiaDichVu.PasswordChar = '\0';
            this.mTxtGiaDichVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtGiaDichVu.SelectedText = "";
            this.mTxtGiaDichVu.SelectionLength = 0;
            this.mTxtGiaDichVu.SelectionStart = 0;
            this.mTxtGiaDichVu.ShortcutsEnabled = true;
            this.mTxtGiaDichVu.Size = new System.Drawing.Size(172, 27);
            this.mTxtGiaDichVu.TabIndex = 32;
            this.mTxtGiaDichVu.UseSelectable = true;
            this.mTxtGiaDichVu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtGiaDichVu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(24, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 25);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Mô tả";
            // 
            // mTxtMoTa
            // 
            // 
            // 
            // 
            this.mTxtMoTa.CustomButton.Image = null;
            this.mTxtMoTa.CustomButton.Location = new System.Drawing.Point(506, 1);
            this.mTxtMoTa.CustomButton.Name = "";
            this.mTxtMoTa.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtMoTa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtMoTa.CustomButton.TabIndex = 1;
            this.mTxtMoTa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtMoTa.CustomButton.UseSelectable = true;
            this.mTxtMoTa.CustomButton.Visible = false;
            this.mTxtMoTa.Enabled = false;
            this.mTxtMoTa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtMoTa.Lines = new string[0];
            this.mTxtMoTa.Location = new System.Drawing.Point(88, 116);
            this.mTxtMoTa.MaxLength = 32767;
            this.mTxtMoTa.Multiline = true;
            this.mTxtMoTa.Name = "mTxtMoTa";
            this.mTxtMoTa.PasswordChar = '\0';
            this.mTxtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtMoTa.SelectedText = "";
            this.mTxtMoTa.SelectionLength = 0;
            this.mTxtMoTa.SelectionStart = 0;
            this.mTxtMoTa.ShortcutsEnabled = true;
            this.mTxtMoTa.Size = new System.Drawing.Size(532, 27);
            this.mTxtMoTa.TabIndex = 30;
            this.mTxtMoTa.UseSelectable = true;
            this.mTxtMoTa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtMoTa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(315, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 25);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Tên DV";
            // 
            // mTxtTenDichVu
            // 
            // 
            // 
            // 
            this.mTxtTenDichVu.CustomButton.Image = null;
            this.mTxtTenDichVu.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.mTxtTenDichVu.CustomButton.Name = "";
            this.mTxtTenDichVu.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtTenDichVu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtTenDichVu.CustomButton.TabIndex = 1;
            this.mTxtTenDichVu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtTenDichVu.CustomButton.UseSelectable = true;
            this.mTxtTenDichVu.CustomButton.Visible = false;
            this.mTxtTenDichVu.Enabled = false;
            this.mTxtTenDichVu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtTenDichVu.Lines = new string[0];
            this.mTxtTenDichVu.Location = new System.Drawing.Point(384, 71);
            this.mTxtTenDichVu.MaxLength = 32767;
            this.mTxtTenDichVu.Multiline = true;
            this.mTxtTenDichVu.Name = "mTxtTenDichVu";
            this.mTxtTenDichVu.PasswordChar = '\0';
            this.mTxtTenDichVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtTenDichVu.SelectedText = "";
            this.mTxtTenDichVu.SelectionLength = 0;
            this.mTxtTenDichVu.SelectionStart = 0;
            this.mTxtTenDichVu.ShortcutsEnabled = true;
            this.mTxtTenDichVu.Size = new System.Drawing.Size(237, 27);
            this.mTxtTenDichVu.TabIndex = 28;
            this.mTxtTenDichVu.UseSelectable = true;
            this.mTxtTenDichVu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtTenDichVu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(375, 71);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 27;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(24, 71);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 25);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Mã DV";
            // 
            // mTxtMaDichVu
            // 
            // 
            // 
            // 
            this.mTxtMaDichVu.CustomButton.Image = null;
            this.mTxtMaDichVu.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.mTxtMaDichVu.CustomButton.Name = "";
            this.mTxtMaDichVu.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtMaDichVu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtMaDichVu.CustomButton.TabIndex = 1;
            this.mTxtMaDichVu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtMaDichVu.CustomButton.UseSelectable = true;
            this.mTxtMaDichVu.CustomButton.Visible = false;
            this.mTxtMaDichVu.Enabled = false;
            this.mTxtMaDichVu.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtMaDichVu.Lines = new string[0];
            this.mTxtMaDichVu.Location = new System.Drawing.Point(88, 71);
            this.mTxtMaDichVu.MaxLength = 32767;
            this.mTxtMaDichVu.Multiline = true;
            this.mTxtMaDichVu.Name = "mTxtMaDichVu";
            this.mTxtMaDichVu.PasswordChar = '\0';
            this.mTxtMaDichVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtMaDichVu.SelectedText = "";
            this.mTxtMaDichVu.SelectionLength = 0;
            this.mTxtMaDichVu.SelectionStart = 0;
            this.mTxtMaDichVu.ShortcutsEnabled = true;
            this.mTxtMaDichVu.Size = new System.Drawing.Size(172, 27);
            this.mTxtMaDichVu.TabIndex = 25;
            this.mTxtMaDichVu.UseSelectable = true;
            this.mTxtMaDichVu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtMaDichVu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã DV";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.ReadOnly = true;
            this.MaDichVu.Width = 150;
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên DV";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            this.TenDichVu.Width = 200;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 300;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDichVu";
            this.GiaDV.HeaderText = "Giá DV";
            this.GiaDV.MinimumWidth = 6;
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.ReadOnly = true;
            this.GiaDV.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 105;
            // 
            // frmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 543);
            this.Controls.Add(this.mBtnXoa);
            this.Controls.Add(this.mBtnHuy);
            this.Controls.Add(this.mBtnLuu);
            this.Controls.Add(this.mBtnSua);
            this.Controls.Add(this.mBtnThem);
            this.Controls.Add(this.mBtnReload);
            this.Controls.Add(this.mdgvDichVu);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mTxtGiaDichVu);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mTxtMoTa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mTxtTenDichVu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mTxtMaDichVu);
            this.MaximizeBox = false;
            this.Name = "frmQLDichVu";
            this.Resizable = false;
            this.Text = "Quản lí dịch vụ";
            this.Load += new System.EventHandler(this.frmQLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnXoa;
        private MetroFramework.Controls.MetroButton mBtnHuy;
        private MetroFramework.Controls.MetroButton mBtnLuu;
        private MetroFramework.Controls.MetroButton mBtnSua;
        private MetroFramework.Controls.MetroButton mBtnThem;
        private MetroFramework.Controls.MetroButton mBtnReload;
        private MetroFramework.Controls.MetroGrid mdgvDichVu;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox mTxtGiaDichVu;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mTxtMoTa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTxtTenDichVu;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mTxtMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}