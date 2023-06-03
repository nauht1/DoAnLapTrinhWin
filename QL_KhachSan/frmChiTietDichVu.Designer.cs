namespace QL_KhachSan
{
    partial class frmChiTietDichVu
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
            this.mBtnThoat = new MetroFramework.Controls.MetroButton();
            this.mBtnReload = new MetroFramework.Controls.MetroButton();
            this.mdgvChiTietDichVu = new MetroFramework.Controls.MetroGrid();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mBtnTimKiem = new MetroFramework.Controls.MetroButton();
            this.mTxtSoDienThoai = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvChiTietDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnThoat
            // 
            this.mBtnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnThoat.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnThoat.Location = new System.Drawing.Point(577, 484);
            this.mBtnThoat.Name = "mBtnThoat";
            this.mBtnThoat.Size = new System.Drawing.Size(80, 36);
            this.mBtnThoat.TabIndex = 49;
            this.mBtnThoat.Text = "Thoát";
            this.mBtnThoat.UseSelectable = true;
            this.mBtnThoat.Click += new System.EventHandler(this.mBtnThoat_Click);
            // 
            // mBtnReload
            // 
            this.mBtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnReload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReload.Location = new System.Drawing.Point(477, 484);
            this.mBtnReload.Name = "mBtnReload";
            this.mBtnReload.Size = new System.Drawing.Size(80, 36);
            this.mBtnReload.TabIndex = 48;
            this.mBtnReload.Text = "Reload";
            this.mBtnReload.UseSelectable = true;
            this.mBtnReload.Click += new System.EventHandler(this.mBtnReload_Click);
            // 
            // mdgvChiTietDichVu
            // 
            this.mdgvChiTietDichVu.AllowUserToAddRows = false;
            this.mdgvChiTietDichVu.AllowUserToDeleteRows = false;
            this.mdgvChiTietDichVu.AllowUserToResizeRows = false;
            this.mdgvChiTietDichVu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvChiTietDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvChiTietDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvChiTietDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvChiTietDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvChiTietDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.TenDichVu,
            this.SoLuong,
            this.NgaySuDung,
            this.TenKhachHang,
            this.SoDienThoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvChiTietDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvChiTietDichVu.EnableHeadersVisualStyles = false;
            this.mdgvChiTietDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvChiTietDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvChiTietDichVu.Location = new System.Drawing.Point(23, 126);
            this.mdgvChiTietDichVu.Name = "mdgvChiTietDichVu";
            this.mdgvChiTietDichVu.ReadOnly = true;
            this.mdgvChiTietDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvChiTietDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvChiTietDichVu.RowHeadersWidth = 43;
            this.mdgvChiTietDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvChiTietDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvChiTietDichVu.Size = new System.Drawing.Size(634, 340);
            this.mdgvChiTietDichVu.TabIndex = 47;
            this.mdgvChiTietDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvChiTietDichVu_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã Phiếu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // TenDichVu
            // 
            this.TenDichVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên DV";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NgaySuDung
            // 
            this.NgaySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySuDung.DataPropertyName = "NgaySuDung";
            this.NgaySuDung.HeaderText = "Ngày Sử Dụng";
            this.NgaySuDung.MinimumWidth = 6;
            this.NgaySuDung.Name = "NgaySuDung";
            this.NgaySuDung.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên KH";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SDT";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(23, 74);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(155, 25);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Tìm kiếm theo SĐT";
            // 
            // mBtnTimKiem
            // 
            this.mBtnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnTimKiem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnTimKiem.Location = new System.Drawing.Point(492, 74);
            this.mBtnTimKiem.Name = "mBtnTimKiem";
            this.mBtnTimKiem.Size = new System.Drawing.Size(95, 27);
            this.mBtnTimKiem.TabIndex = 45;
            this.mBtnTimKiem.Text = "Tìm Kiếm";
            this.mBtnTimKiem.UseSelectable = true;
            this.mBtnTimKiem.Click += new System.EventHandler(this.mBtnTimKiem_Click);
            // 
            // mTxtSoDienThoai
            // 
            // 
            // 
            // 
            this.mTxtSoDienThoai.CustomButton.Image = null;
            this.mTxtSoDienThoai.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.mTxtSoDienThoai.CustomButton.Name = "";
            this.mTxtSoDienThoai.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtSoDienThoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtSoDienThoai.CustomButton.TabIndex = 1;
            this.mTxtSoDienThoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtSoDienThoai.CustomButton.UseSelectable = true;
            this.mTxtSoDienThoai.CustomButton.Visible = false;
            this.mTxtSoDienThoai.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtSoDienThoai.Lines = new string[0];
            this.mTxtSoDienThoai.Location = new System.Drawing.Point(207, 74);
            this.mTxtSoDienThoai.MaxLength = 32767;
            this.mTxtSoDienThoai.Multiline = true;
            this.mTxtSoDienThoai.Name = "mTxtSoDienThoai";
            this.mTxtSoDienThoai.PasswordChar = '\0';
            this.mTxtSoDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSoDienThoai.SelectedText = "";
            this.mTxtSoDienThoai.SelectionLength = 0;
            this.mTxtSoDienThoai.SelectionStart = 0;
            this.mTxtSoDienThoai.ShortcutsEnabled = true;
            this.mTxtSoDienThoai.Size = new System.Drawing.Size(250, 27);
            this.mTxtSoDienThoai.TabIndex = 44;
            this.mTxtSoDienThoai.UseSelectable = true;
            this.mTxtSoDienThoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtSoDienThoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmChiTietDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 538);
            this.Controls.Add(this.mBtnThoat);
            this.Controls.Add(this.mBtnReload);
            this.Controls.Add(this.mdgvChiTietDichVu);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mBtnTimKiem);
            this.Controls.Add(this.mTxtSoDienThoai);
            this.MaximizeBox = false;
            this.Name = "frmChiTietDichVu";
            this.Resizable = false;
            this.Text = "Chi Tiết Dịch Vụ";
            this.Load += new System.EventHandler(this.frmChiTietDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvChiTietDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnThoat;
        private MetroFramework.Controls.MetroButton mBtnReload;
        private MetroFramework.Controls.MetroGrid mdgvChiTietDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton mBtnTimKiem;
        private MetroFramework.Controls.MetroTextBox mTxtSoDienThoai;
    }
}