namespace QL_KhachSan
{
    partial class frmQLPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mdgvPhong = new MetroFramework.Controls.MetroGrid();
            this.mCboLoaiPhong = new MetroFramework.Controls.MetroComboBox();
            this.mTxtMaPhong = new MetroFramework.Controls.MetroTextBox();
            this.mTxtTenPhong = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mCboTrangThai = new MetroFramework.Controls.MetroComboBox();
            this.mBtnThem = new MetroFramework.Controls.MetroButton();
            this.mBtnSua = new MetroFramework.Controls.MetroButton();
            this.mBtnXoa = new MetroFramework.Controls.MetroButton();
            this.mBtnLuu = new MetroFramework.Controls.MetroButton();
            this.mBtnHuy = new MetroFramework.Controls.MetroButton();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // mdgvPhong
            // 
            this.mdgvPhong.AllowUserToAddRows = false;
            this.mdgvPhong.AllowUserToDeleteRows = false;
            this.mdgvPhong.AllowUserToResizeRows = false;
            this.mdgvPhong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.mdgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.TenPhong,
            this.TrangThai});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvPhong.DefaultCellStyle = dataGridViewCellStyle17;
            this.mdgvPhong.EnableHeadersVisualStyles = false;
            this.mdgvPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvPhong.Location = new System.Drawing.Point(23, 255);
            this.mdgvPhong.Name = "mdgvPhong";
            this.mdgvPhong.ReadOnly = true;
            this.mdgvPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.mdgvPhong.RowHeadersWidth = 43;
            this.mdgvPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvPhong.Size = new System.Drawing.Size(533, 303);
            this.mdgvPhong.TabIndex = 57;
            this.mdgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvPhong_CellClick);
            // 
            // mCboLoaiPhong
            // 
            this.mCboLoaiPhong.Enabled = false;
            this.mCboLoaiPhong.FormattingEnabled = true;
            this.mCboLoaiPhong.ItemHeight = 23;
            this.mCboLoaiPhong.Location = new System.Drawing.Point(150, 118);
            this.mCboLoaiPhong.Name = "mCboLoaiPhong";
            this.mCboLoaiPhong.Size = new System.Drawing.Size(240, 29);
            this.mCboLoaiPhong.TabIndex = 63;
            this.mCboLoaiPhong.UseSelectable = true;
            // 
            // mTxtMaPhong
            // 
            // 
            // 
            // 
            this.mTxtMaPhong.CustomButton.Image = null;
            this.mTxtMaPhong.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtMaPhong.CustomButton.Name = "";
            this.mTxtMaPhong.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtMaPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtMaPhong.CustomButton.TabIndex = 1;
            this.mTxtMaPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtMaPhong.CustomButton.UseSelectable = true;
            this.mTxtMaPhong.CustomButton.Visible = false;
            this.mTxtMaPhong.Enabled = false;
            this.mTxtMaPhong.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtMaPhong.Lines = new string[0];
            this.mTxtMaPhong.Location = new System.Drawing.Point(150, 75);
            this.mTxtMaPhong.MaxLength = 32767;
            this.mTxtMaPhong.Multiline = true;
            this.mTxtMaPhong.Name = "mTxtMaPhong";
            this.mTxtMaPhong.PasswordChar = '\0';
            this.mTxtMaPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtMaPhong.SelectedText = "";
            this.mTxtMaPhong.SelectionLength = 0;
            this.mTxtMaPhong.SelectionStart = 0;
            this.mTxtMaPhong.ShortcutsEnabled = true;
            this.mTxtMaPhong.Size = new System.Drawing.Size(240, 27);
            this.mTxtMaPhong.TabIndex = 61;
            this.mTxtMaPhong.UseSelectable = true;
            this.mTxtMaPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtMaPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTxtTenPhong
            // 
            // 
            // 
            // 
            this.mTxtTenPhong.CustomButton.Image = null;
            this.mTxtTenPhong.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtTenPhong.CustomButton.Name = "";
            this.mTxtTenPhong.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtTenPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtTenPhong.CustomButton.TabIndex = 1;
            this.mTxtTenPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtTenPhong.CustomButton.UseSelectable = true;
            this.mTxtTenPhong.CustomButton.Visible = false;
            this.mTxtTenPhong.Enabled = false;
            this.mTxtTenPhong.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtTenPhong.Lines = new string[0];
            this.mTxtTenPhong.Location = new System.Drawing.Point(150, 162);
            this.mTxtTenPhong.MaxLength = 32767;
            this.mTxtTenPhong.Multiline = true;
            this.mTxtTenPhong.Name = "mTxtTenPhong";
            this.mTxtTenPhong.PasswordChar = '\0';
            this.mTxtTenPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtTenPhong.SelectedText = "";
            this.mTxtTenPhong.SelectionLength = 0;
            this.mTxtTenPhong.SelectionStart = 0;
            this.mTxtTenPhong.ShortcutsEnabled = true;
            this.mTxtTenPhong.Size = new System.Drawing.Size(240, 27);
            this.mTxtTenPhong.TabIndex = 62;
            this.mTxtTenPhong.UseSelectable = true;
            this.mTxtTenPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtTenPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(29, 75);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 25);
            this.metroLabel6.TabIndex = 58;
            this.metroLabel6.Text = "Mã phòng";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(29, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 25);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Loại phòng";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(29, 164);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Tên phòng";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(29, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 25);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "Trạng thái";
            // 
            // mCboTrangThai
            // 
            this.mCboTrangThai.Enabled = false;
            this.mCboTrangThai.FormattingEnabled = true;
            this.mCboTrangThai.ItemHeight = 23;
            this.mCboTrangThai.Items.AddRange(new object[] {
            "Con phong",
            "Dang su dung",
            "Dang sua chua"});
            this.mCboTrangThai.Location = new System.Drawing.Point(150, 204);
            this.mCboTrangThai.Name = "mCboTrangThai";
            this.mCboTrangThai.Size = new System.Drawing.Size(240, 29);
            this.mCboTrangThai.TabIndex = 65;
            this.mCboTrangThai.UseSelectable = true;
            // 
            // mBtnThem
            // 
            this.mBtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnThem.Location = new System.Drawing.Point(23, 580);
            this.mBtnThem.Name = "mBtnThem";
            this.mBtnThem.Size = new System.Drawing.Size(80, 36);
            this.mBtnThem.TabIndex = 66;
            this.mBtnThem.Text = "Them";
            this.mBtnThem.UseSelectable = true;
            this.mBtnThem.Click += new System.EventHandler(this.mBtnThem_Click);
            // 
            // mBtnSua
            // 
            this.mBtnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnSua.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSua.Location = new System.Drawing.Point(127, 580);
            this.mBtnSua.Name = "mBtnSua";
            this.mBtnSua.Size = new System.Drawing.Size(80, 36);
            this.mBtnSua.TabIndex = 67;
            this.mBtnSua.Text = "Sua";
            this.mBtnSua.UseSelectable = true;
            this.mBtnSua.Click += new System.EventHandler(this.mBtnSua_Click);
            // 
            // mBtnXoa
            // 
            this.mBtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnXoa.Location = new System.Drawing.Point(232, 580);
            this.mBtnXoa.Name = "mBtnXoa";
            this.mBtnXoa.Size = new System.Drawing.Size(80, 36);
            this.mBtnXoa.TabIndex = 68;
            this.mBtnXoa.Text = "Xoa";
            this.mBtnXoa.UseSelectable = true;
            this.mBtnXoa.Click += new System.EventHandler(this.mBtnXoa_Click);
            // 
            // mBtnLuu
            // 
            this.mBtnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnLuu.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnLuu.Location = new System.Drawing.Point(382, 580);
            this.mBtnLuu.Name = "mBtnLuu";
            this.mBtnLuu.Size = new System.Drawing.Size(80, 36);
            this.mBtnLuu.TabIndex = 69;
            this.mBtnLuu.Text = "Luu";
            this.mBtnLuu.UseSelectable = true;
            this.mBtnLuu.Click += new System.EventHandler(this.mBtnLuu_Click);
            // 
            // mBtnHuy
            // 
            this.mBtnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mBtnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnHuy.Location = new System.Drawing.Point(476, 580);
            this.mBtnHuy.Name = "mBtnHuy";
            this.mBtnHuy.Size = new System.Drawing.Size(80, 36);
            this.mBtnHuy.TabIndex = 70;
            this.mBtnHuy.Text = "Huy";
            this.mBtnHuy.UseSelectable = true;
            this.mBtnHuy.Click += new System.EventHandler(this.mBtnHuy_Click);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 105;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            this.LoaiPhong.Width = 105;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 105;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 105;
            // 
            // frmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 640);
            this.Controls.Add(this.mBtnHuy);
            this.Controls.Add(this.mBtnLuu);
            this.Controls.Add(this.mBtnXoa);
            this.Controls.Add(this.mBtnSua);
            this.Controls.Add(this.mBtnThem);
            this.Controls.Add(this.mCboTrangThai);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mCboLoaiPhong);
            this.Controls.Add(this.mTxtMaPhong);
            this.Controls.Add(this.mTxtTenPhong);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mdgvPhong);
            this.MaximizeBox = false;
            this.Name = "frmQLPhong";
            this.Resizable = false;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmQLPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mdgvPhong;
        private MetroFramework.Controls.MetroComboBox mCboLoaiPhong;
        private MetroFramework.Controls.MetroTextBox mTxtMaPhong;
        private MetroFramework.Controls.MetroTextBox mTxtTenPhong;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mCboTrangThai;
        private MetroFramework.Controls.MetroButton mBtnThem;
        private MetroFramework.Controls.MetroButton mBtnSua;
        private MetroFramework.Controls.MetroButton mBtnXoa;
        private MetroFramework.Controls.MetroButton mBtnLuu;
        private MetroFramework.Controls.MetroButton mBtnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}