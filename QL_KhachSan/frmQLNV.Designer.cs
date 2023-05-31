namespace QL_KhachSan
{
    partial class frmQLNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mdgvNhanVien = new MetroFramework.Controls.MetroGrid();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoatDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBtnReload = new MetroFramework.Controls.MetroButton();
            this.mBtnThem = new MetroFramework.Controls.MetroButton();
            this.mBtnSua = new MetroFramework.Controls.MetroButton();
            this.mBtnLuu = new MetroFramework.Controls.MetroButton();
            this.mBtnHuy = new MetroFramework.Controls.MetroButton();
            this.mBtnXoa = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mTxtTenNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.mTxtDiaChi = new MetroFramework.Controls.MetroTextBox();
            this.mTxtSDT = new MetroFramework.Controls.MetroTextBox();
            this.mCboChucVu = new MetroFramework.Controls.MetroComboBox();
            this.mCboGioiTinh = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mTxtMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mdgvNhanVien
            // 
            this.mdgvNhanVien.AllowUserToAddRows = false;
            this.mdgvNhanVien.AllowUserToDeleteRows = false;
            this.mdgvNhanVien.AllowUserToResizeRows = false;
            this.mdgvNhanVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ChucVu,
            this.GioiTinh,
            this.DiaChi,
            this.SoDienThoai,
            this.HoatDong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvNhanVien.EnableHeadersVisualStyles = false;
            this.mdgvNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvNhanVien.Location = new System.Drawing.Point(21, 255);
            this.mdgvNhanVien.Name = "mdgvNhanVien";
            this.mdgvNhanVien.ReadOnly = true;
            this.mdgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvNhanVien.RowHeadersWidth = 43;
            this.mdgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvNhanVien.Size = new System.Drawing.Size(787, 307);
            this.mdgvNhanVien.TabIndex = 0;
            this.mdgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvNhanVien_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 105;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên NV";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 105;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "MaChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChucVu.Width = 105;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GioiTinh.Width = 105;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 105;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số ĐT";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 105;
            // 
            // HoatDong
            // 
            this.HoatDong.DataPropertyName = "HoatDong";
            this.HoatDong.HeaderText = "Hoạt động";
            this.HoatDong.Name = "HoatDong";
            this.HoatDong.ReadOnly = true;
            this.HoatDong.Width = 105;
            // 
            // mBtnReload
            // 
            this.mBtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnReload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReload.Location = new System.Drawing.Point(21, 578);
            this.mBtnReload.Name = "mBtnReload";
            this.mBtnReload.Size = new System.Drawing.Size(80, 36);
            this.mBtnReload.TabIndex = 1;
            this.mBtnReload.Text = "Reload";
            this.mBtnReload.UseSelectable = true;
            // 
            // mBtnThem
            // 
            this.mBtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnThem.Location = new System.Drawing.Point(130, 578);
            this.mBtnThem.Name = "mBtnThem";
            this.mBtnThem.Size = new System.Drawing.Size(80, 36);
            this.mBtnThem.TabIndex = 1;
            this.mBtnThem.Text = "Them";
            this.mBtnThem.UseSelectable = true;
            // 
            // mBtnSua
            // 
            this.mBtnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnSua.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSua.Location = new System.Drawing.Point(240, 578);
            this.mBtnSua.Name = "mBtnSua";
            this.mBtnSua.Size = new System.Drawing.Size(80, 36);
            this.mBtnSua.TabIndex = 1;
            this.mBtnSua.Text = "Sua";
            this.mBtnSua.UseSelectable = true;
            // 
            // mBtnLuu
            // 
            this.mBtnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnLuu.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnLuu.Location = new System.Drawing.Point(623, 578);
            this.mBtnLuu.Name = "mBtnLuu";
            this.mBtnLuu.Size = new System.Drawing.Size(80, 36);
            this.mBtnLuu.TabIndex = 1;
            this.mBtnLuu.Text = "Luu";
            this.mBtnLuu.UseSelectable = true;
            // 
            // mBtnHuy
            // 
            this.mBtnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnHuy.Location = new System.Drawing.Point(728, 578);
            this.mBtnHuy.Name = "mBtnHuy";
            this.mBtnHuy.Size = new System.Drawing.Size(80, 36);
            this.mBtnHuy.TabIndex = 1;
            this.mBtnHuy.Text = "Huy";
            this.mBtnHuy.UseSelectable = true;
            // 
            // mBtnXoa
            // 
            this.mBtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnXoa.Location = new System.Drawing.Point(352, 578);
            this.mBtnXoa.Name = "mBtnXoa";
            this.mBtnXoa.Size = new System.Drawing.Size(80, 36);
            this.mBtnXoa.TabIndex = 1;
            this.mBtnXoa.Text = "Xoa";
            this.mBtnXoa.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(17, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tên nhân viên";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(19, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Chức vụ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(431, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Giới tính";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(431, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Địa chỉ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(431, 205);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Số ĐT";
            // 
            // mTxtTenNhanVien
            // 
            // 
            // 
            // 
            this.mTxtTenNhanVien.CustomButton.Image = null;
            this.mTxtTenNhanVien.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtTenNhanVien.CustomButton.Name = "";
            this.mTxtTenNhanVien.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtTenNhanVien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtTenNhanVien.CustomButton.TabIndex = 1;
            this.mTxtTenNhanVien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtTenNhanVien.CustomButton.UseSelectable = true;
            this.mTxtTenNhanVien.CustomButton.Visible = false;
            this.mTxtTenNhanVien.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtTenNhanVien.Lines = new string[0];
            this.mTxtTenNhanVien.Location = new System.Drawing.Point(140, 121);
            this.mTxtTenNhanVien.MaxLength = 32767;
            this.mTxtTenNhanVien.Multiline = true;
            this.mTxtTenNhanVien.Name = "mTxtTenNhanVien";
            this.mTxtTenNhanVien.PasswordChar = '\0';
            this.mTxtTenNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtTenNhanVien.SelectedText = "";
            this.mTxtTenNhanVien.SelectionLength = 0;
            this.mTxtTenNhanVien.SelectionStart = 0;
            this.mTxtTenNhanVien.ShortcutsEnabled = true;
            this.mTxtTenNhanVien.Size = new System.Drawing.Size(240, 27);
            this.mTxtTenNhanVien.TabIndex = 5;
            this.mTxtTenNhanVien.UseSelectable = true;
            this.mTxtTenNhanVien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtTenNhanVien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxtDiaChi
            // 
            // 
            // 
            // 
            this.mTxtDiaChi.CustomButton.Image = null;
            this.mTxtDiaChi.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.mTxtDiaChi.CustomButton.Name = "";
            this.mTxtDiaChi.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.mTxtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtDiaChi.CustomButton.TabIndex = 1;
            this.mTxtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtDiaChi.CustomButton.UseSelectable = true;
            this.mTxtDiaChi.CustomButton.Visible = false;
            this.mTxtDiaChi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtDiaChi.Lines = new string[0];
            this.mTxtDiaChi.Location = new System.Drawing.Point(524, 121);
            this.mTxtDiaChi.MaxLength = 32767;
            this.mTxtDiaChi.Multiline = true;
            this.mTxtDiaChi.Name = "mTxtDiaChi";
            this.mTxtDiaChi.PasswordChar = '\0';
            this.mTxtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtDiaChi.SelectedText = "";
            this.mTxtDiaChi.SelectionLength = 0;
            this.mTxtDiaChi.SelectionStart = 0;
            this.mTxtDiaChi.ShortcutsEnabled = true;
            this.mTxtDiaChi.Size = new System.Drawing.Size(240, 68);
            this.mTxtDiaChi.TabIndex = 5;
            this.mTxtDiaChi.UseSelectable = true;
            this.mTxtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtDiaChi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxtSDT
            // 
            // 
            // 
            // 
            this.mTxtSDT.CustomButton.Image = null;
            this.mTxtSDT.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtSDT.CustomButton.Name = "";
            this.mTxtSDT.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtSDT.CustomButton.TabIndex = 1;
            this.mTxtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtSDT.CustomButton.UseSelectable = true;
            this.mTxtSDT.CustomButton.Visible = false;
            this.mTxtSDT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtSDT.Lines = new string[0];
            this.mTxtSDT.Location = new System.Drawing.Point(524, 205);
            this.mTxtSDT.MaxLength = 32767;
            this.mTxtSDT.Multiline = true;
            this.mTxtSDT.Name = "mTxtSDT";
            this.mTxtSDT.PasswordChar = '\0';
            this.mTxtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSDT.SelectedText = "";
            this.mTxtSDT.SelectionLength = 0;
            this.mTxtSDT.SelectionStart = 0;
            this.mTxtSDT.ShortcutsEnabled = true;
            this.mTxtSDT.Size = new System.Drawing.Size(240, 27);
            this.mTxtSDT.TabIndex = 5;
            this.mTxtSDT.UseSelectable = true;
            this.mTxtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mCboChucVu
            // 
            this.mCboChucVu.FormattingEnabled = true;
            this.mCboChucVu.ItemHeight = 23;
            this.mCboChucVu.Location = new System.Drawing.Point(140, 160);
            this.mCboChucVu.Name = "mCboChucVu";
            this.mCboChucVu.Size = new System.Drawing.Size(240, 29);
            this.mCboChucVu.TabIndex = 6;
            this.mCboChucVu.UseSelectable = true;
            // 
            // mCboGioiTinh
            // 
            this.mCboGioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.mCboGioiTinh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mCboGioiTinh.FormattingEnabled = true;
            this.mCboGioiTinh.ItemHeight = 23;
            this.mCboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.mCboGioiTinh.Location = new System.Drawing.Point(524, 80);
            this.mCboGioiTinh.Name = "mCboGioiTinh";
            this.mCboGioiTinh.Size = new System.Drawing.Size(240, 29);
            this.mCboGioiTinh.TabIndex = 6;
            this.mCboGioiTinh.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(19, 81);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Mã NV";
            // 
            // mTxtMaNhanVien
            // 
            // 
            // 
            // 
            this.mTxtMaNhanVien.CustomButton.Image = null;
            this.mTxtMaNhanVien.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtMaNhanVien.CustomButton.Name = "";
            this.mTxtMaNhanVien.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtMaNhanVien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtMaNhanVien.CustomButton.TabIndex = 1;
            this.mTxtMaNhanVien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtMaNhanVien.CustomButton.UseSelectable = true;
            this.mTxtMaNhanVien.CustomButton.Visible = false;
            this.mTxtMaNhanVien.Enabled = false;
            this.mTxtMaNhanVien.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtMaNhanVien.Lines = new string[0];
            this.mTxtMaNhanVien.Location = new System.Drawing.Point(140, 81);
            this.mTxtMaNhanVien.MaxLength = 32767;
            this.mTxtMaNhanVien.Multiline = true;
            this.mTxtMaNhanVien.Name = "mTxtMaNhanVien";
            this.mTxtMaNhanVien.PasswordChar = '\0';
            this.mTxtMaNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtMaNhanVien.SelectedText = "";
            this.mTxtMaNhanVien.SelectionLength = 0;
            this.mTxtMaNhanVien.SelectionStart = 0;
            this.mTxtMaNhanVien.ShortcutsEnabled = true;
            this.mTxtMaNhanVien.Size = new System.Drawing.Size(240, 27);
            this.mTxtMaNhanVien.TabIndex = 5;
            this.mTxtMaNhanVien.UseSelectable = true;
            this.mTxtMaNhanVien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtMaNhanVien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 633);
            this.Controls.Add(this.mCboGioiTinh);
            this.Controls.Add(this.mCboChucVu);
            this.Controls.Add(this.mTxtDiaChi);
            this.Controls.Add(this.mTxtSDT);
            this.Controls.Add(this.mTxtMaNhanVien);
            this.Controls.Add(this.mTxtTenNhanVien);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mBtnXoa);
            this.Controls.Add(this.mBtnHuy);
            this.Controls.Add(this.mBtnLuu);
            this.Controls.Add(this.mBtnSua);
            this.Controls.Add(this.mBtnThem);
            this.Controls.Add(this.mBtnReload);
            this.Controls.Add(this.mdgvNhanVien);
            this.MaximizeBox = false;
            this.Name = "frmQLNV";
            this.Resizable = false;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mdgvNhanVien;
        private MetroFramework.Controls.MetroButton mBtnReload;
        private MetroFramework.Controls.MetroButton mBtnThem;
        private MetroFramework.Controls.MetroButton mBtnSua;
        private MetroFramework.Controls.MetroButton mBtnLuu;
        private MetroFramework.Controls.MetroButton mBtnXoa;
        private MetroFramework.Controls.MetroButton mBtnHuy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mTxtTenNhanVien;
        private MetroFramework.Controls.MetroTextBox mTxtDiaChi;
        private MetroFramework.Controls.MetroTextBox mTxtSDT;
        private MetroFramework.Controls.MetroComboBox mCboChucVu;
        private MetroFramework.Controls.MetroComboBox mCboGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoatDong;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mTxtMaNhanVien;
    }
}

