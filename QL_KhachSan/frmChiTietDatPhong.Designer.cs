namespace QL_KhachSan
{
    partial class frmChiTietDatPhong
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
            this.mBtnReload = new MetroFramework.Controls.MetroButton();
            this.mBtnHuy = new MetroFramework.Controls.MetroButton();
            this.mBtnTim = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mTxtSDT = new MetroFramework.Controls.MetroTextBox();
            this.mdgvKhachHang = new MetroFramework.Controls.MetroGrid();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // mBtnReload
            // 
            this.mBtnReload.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnReload.Location = new System.Drawing.Point(485, 430);
            this.mBtnReload.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnReload.Name = "mBtnReload";
            this.mBtnReload.Size = new System.Drawing.Size(92, 31);
            this.mBtnReload.TabIndex = 49;
            this.mBtnReload.Text = "Reload";
            this.mBtnReload.UseSelectable = true;
            this.mBtnReload.Click += new System.EventHandler(this.mBtnReload_Click);
            // 
            // mBtnHuy
            // 
            this.mBtnHuy.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnHuy.Location = new System.Drawing.Point(599, 430);
            this.mBtnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnHuy.Name = "mBtnHuy";
            this.mBtnHuy.Size = new System.Drawing.Size(92, 31);
            this.mBtnHuy.TabIndex = 48;
            this.mBtnHuy.Text = "Thoát";
            this.mBtnHuy.UseSelectable = true;
            this.mBtnHuy.Click += new System.EventHandler(this.mBtnHuy_Click);
            // 
            // mBtnTim
            // 
            this.mBtnTim.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnTim.Location = new System.Drawing.Point(310, 71);
            this.mBtnTim.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnTim.Name = "mBtnTim";
            this.mBtnTim.Size = new System.Drawing.Size(73, 31);
            this.mBtnTim.TabIndex = 47;
            this.mBtnTim.Text = "Tìm";
            this.mBtnTim.UseSelectable = true;
            this.mBtnTim.Click += new System.EventHandler(this.mBtnTim_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(23, 75);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 25);
            this.metroLabel7.TabIndex = 45;
            this.metroLabel7.Text = "SDT";
            // 
            // mTxtSDT
            // 
            // 
            // 
            // 
            this.mTxtSDT.CustomButton.Image = null;
            this.mTxtSDT.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.mTxtSDT.CustomButton.Name = "";
            this.mTxtSDT.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.mTxtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtSDT.CustomButton.TabIndex = 1;
            this.mTxtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtSDT.CustomButton.UseSelectable = true;
            this.mTxtSDT.CustomButton.Visible = false;
            this.mTxtSDT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtSDT.Lines = new string[0];
            this.mTxtSDT.Location = new System.Drawing.Point(70, 71);
            this.mTxtSDT.MaxLength = 32767;
            this.mTxtSDT.Multiline = true;
            this.mTxtSDT.Name = "mTxtSDT";
            this.mTxtSDT.PasswordChar = '\0';
            this.mTxtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSDT.SelectedText = "";
            this.mTxtSDT.SelectionLength = 0;
            this.mTxtSDT.SelectionStart = 0;
            this.mTxtSDT.ShortcutsEnabled = true;
            this.mTxtSDT.Size = new System.Drawing.Size(219, 31);
            this.mTxtSDT.TabIndex = 46;
            this.mTxtSDT.UseSelectable = true;
            this.mTxtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdgvKhachHang
            // 
            this.mdgvKhachHang.AllowUserToAddRows = false;
            this.mdgvKhachHang.AllowUserToDeleteRows = false;
            this.mdgvKhachHang.AllowUserToResizeRows = false;
            this.mdgvKhachHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.TenKhachHang,
            this.SoDienThoai,
            this.TenPhong,
            this.NgayNhanPhong,
            this.NgayTraPhong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvKhachHang.EnableHeadersVisualStyles = false;
            this.mdgvKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvKhachHang.Location = new System.Drawing.Point(23, 116);
            this.mdgvKhachHang.Name = "mdgvKhachHang";
            this.mdgvKhachHang.ReadOnly = true;
            this.mdgvKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvKhachHang.RowHeadersWidth = 43;
            this.mdgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvKhachHang.Size = new System.Drawing.Size(668, 297);
            this.mdgvKhachHang.TabIndex = 44;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            this.MaPhieu.Width = 105;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 150;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 110;
            // 
            // NgayNhanPhong
            // 
            this.NgayNhanPhong.DataPropertyName = "NgayNhanPhong";
            this.NgayNhanPhong.HeaderText = "Ngày Nhận Phòng";
            this.NgayNhanPhong.MinimumWidth = 6;
            this.NgayNhanPhong.Name = "NgayNhanPhong";
            this.NgayNhanPhong.ReadOnly = true;
            this.NgayNhanPhong.Width = 200;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày Trả Phòng";
            this.NgayTraPhong.MinimumWidth = 6;
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.ReadOnly = true;
            this.NgayTraPhong.Width = 200;
            // 
            // frmChiTietDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 486);
            this.Controls.Add(this.mBtnReload);
            this.Controls.Add(this.mBtnHuy);
            this.Controls.Add(this.mBtnTim);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mTxtSDT);
            this.Controls.Add(this.mdgvKhachHang);
            this.MaximizeBox = false;
            this.Name = "frmChiTietDatPhong";
            this.Resizable = false;
            this.Text = "Chi Tiết Đặt Phòng";
            this.Load += new System.EventHandler(this.frmChiTietDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnReload;
        private MetroFramework.Controls.MetroButton mBtnHuy;
        private MetroFramework.Controls.MetroButton mBtnTim;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox mTxtSDT;
        private MetroFramework.Controls.MetroGrid mdgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
    }
}