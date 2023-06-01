namespace QL_KhachSan
{
    partial class frmQLDanhGia
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
            this.mdgvDanhGia = new MetroFramework.Controls.MetroGrid();
            this.mTxtNoiDung = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mTxtMaDanhGia = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mTxtTenKhachHang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mTxtSDT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MaDanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // mdgvDanhGia
            // 
            this.mdgvDanhGia.AllowUserToAddRows = false;
            this.mdgvDanhGia.AllowUserToDeleteRows = false;
            this.mdgvDanhGia.AllowUserToResizeRows = false;
            this.mdgvDanhGia.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mdgvDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvDanhGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvDanhGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvDanhGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvDanhGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhGia,
            this.SoDienThoai,
            this.TenKhachHang,
            this.NoiDung});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvDanhGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvDanhGia.EnableHeadersVisualStyles = false;
            this.mdgvDanhGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvDanhGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvDanhGia.Location = new System.Drawing.Point(36, 252);
            this.mdgvDanhGia.Name = "mdgvDanhGia";
            this.mdgvDanhGia.ReadOnly = true;
            this.mdgvDanhGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvDanhGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvDanhGia.RowHeadersWidth = 43;
            this.mdgvDanhGia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvDanhGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvDanhGia.Size = new System.Drawing.Size(720, 323);
            this.mdgvDanhGia.TabIndex = 52;
            this.mdgvDanhGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvDanhGia_CellClick);
            // 
            // mTxtNoiDung
            // 
            // 
            // 
            // 
            this.mTxtNoiDung.CustomButton.Image = null;
            this.mTxtNoiDung.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.mTxtNoiDung.CustomButton.Name = "";
            this.mTxtNoiDung.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.mTxtNoiDung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtNoiDung.CustomButton.TabIndex = 1;
            this.mTxtNoiDung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtNoiDung.CustomButton.UseSelectable = true;
            this.mTxtNoiDung.CustomButton.Visible = false;
            this.mTxtNoiDung.Enabled = false;
            this.mTxtNoiDung.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtNoiDung.Lines = new string[0];
            this.mTxtNoiDung.Location = new System.Drawing.Point(495, 79);
            this.mTxtNoiDung.MaxLength = 32767;
            this.mTxtNoiDung.Multiline = true;
            this.mTxtNoiDung.Name = "mTxtNoiDung";
            this.mTxtNoiDung.PasswordChar = '\0';
            this.mTxtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtNoiDung.SelectedText = "";
            this.mTxtNoiDung.SelectionLength = 0;
            this.mTxtNoiDung.SelectionStart = 0;
            this.mTxtNoiDung.ShortcutsEnabled = true;
            this.mTxtNoiDung.Size = new System.Drawing.Size(261, 125);
            this.mTxtNoiDung.TabIndex = 51;
            this.mTxtNoiDung.UseSelectable = true;
            this.mTxtNoiDung.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtNoiDung.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(405, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Nội dung";
            // 
            // mTxtMaDanhGia
            // 
            // 
            // 
            // 
            this.mTxtMaDanhGia.CustomButton.Image = null;
            this.mTxtMaDanhGia.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.mTxtMaDanhGia.CustomButton.Name = "";
            this.mTxtMaDanhGia.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtMaDanhGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtMaDanhGia.CustomButton.TabIndex = 1;
            this.mTxtMaDanhGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtMaDanhGia.CustomButton.UseSelectable = true;
            this.mTxtMaDanhGia.CustomButton.Visible = false;
            this.mTxtMaDanhGia.Enabled = false;
            this.mTxtMaDanhGia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtMaDanhGia.Lines = new string[0];
            this.mTxtMaDanhGia.Location = new System.Drawing.Point(172, 79);
            this.mTxtMaDanhGia.MaxLength = 32767;
            this.mTxtMaDanhGia.Multiline = true;
            this.mTxtMaDanhGia.Name = "mTxtMaDanhGia";
            this.mTxtMaDanhGia.PasswordChar = '\0';
            this.mTxtMaDanhGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtMaDanhGia.SelectedText = "";
            this.mTxtMaDanhGia.SelectionLength = 0;
            this.mTxtMaDanhGia.SelectionStart = 0;
            this.mTxtMaDanhGia.ShortcutsEnabled = true;
            this.mTxtMaDanhGia.Size = new System.Drawing.Size(218, 27);
            this.mTxtMaDanhGia.TabIndex = 49;
            this.mTxtMaDanhGia.UseSelectable = true;
            this.mTxtMaDanhGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtMaDanhGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(35, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 25);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Mã đánh giá ";
            // 
            // mTxtTenKhachHang
            // 
            // 
            // 
            // 
            this.mTxtTenKhachHang.CustomButton.Image = null;
            this.mTxtTenKhachHang.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.mTxtTenKhachHang.CustomButton.Name = "";
            this.mTxtTenKhachHang.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtTenKhachHang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtTenKhachHang.CustomButton.TabIndex = 1;
            this.mTxtTenKhachHang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtTenKhachHang.CustomButton.UseSelectable = true;
            this.mTxtTenKhachHang.CustomButton.Visible = false;
            this.mTxtTenKhachHang.Enabled = false;
            this.mTxtTenKhachHang.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtTenKhachHang.Lines = new string[0];
            this.mTxtTenKhachHang.Location = new System.Drawing.Point(172, 127);
            this.mTxtTenKhachHang.MaxLength = 32767;
            this.mTxtTenKhachHang.Multiline = true;
            this.mTxtTenKhachHang.Name = "mTxtTenKhachHang";
            this.mTxtTenKhachHang.PasswordChar = '\0';
            this.mTxtTenKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtTenKhachHang.SelectedText = "";
            this.mTxtTenKhachHang.SelectionLength = 0;
            this.mTxtTenKhachHang.SelectionStart = 0;
            this.mTxtTenKhachHang.ShortcutsEnabled = true;
            this.mTxtTenKhachHang.Size = new System.Drawing.Size(218, 27);
            this.mTxtTenKhachHang.TabIndex = 47;
            this.mTxtTenKhachHang.UseSelectable = true;
            this.mTxtTenKhachHang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtTenKhachHang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(35, 129);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(131, 25);
            this.metroLabel6.TabIndex = 46;
            this.metroLabel6.Text = "Tên khách hàng";
            // 
            // mTxtSDT
            // 
            // 
            // 
            // 
            this.mTxtSDT.CustomButton.Image = null;
            this.mTxtSDT.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.mTxtSDT.CustomButton.Name = "";
            this.mTxtSDT.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtSDT.CustomButton.TabIndex = 1;
            this.mTxtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtSDT.CustomButton.UseSelectable = true;
            this.mTxtSDT.CustomButton.Visible = false;
            this.mTxtSDT.Enabled = false;
            this.mTxtSDT.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtSDT.Lines = new string[0];
            this.mTxtSDT.Location = new System.Drawing.Point(172, 179);
            this.mTxtSDT.MaxLength = 32767;
            this.mTxtSDT.Multiline = true;
            this.mTxtSDT.Name = "mTxtSDT";
            this.mTxtSDT.PasswordChar = '\0';
            this.mTxtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtSDT.SelectedText = "";
            this.mTxtSDT.SelectionLength = 0;
            this.mTxtSDT.SelectionStart = 0;
            this.mTxtSDT.ShortcutsEnabled = true;
            this.mTxtSDT.Size = new System.Drawing.Size(218, 27);
            this.mTxtSDT.TabIndex = 54;
            this.mTxtSDT.UseSelectable = true;
            this.mTxtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(36, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 25);
            this.metroLabel3.TabIndex = 53;
            this.metroLabel3.Text = "Số điện thoại";
            // 
            // MaDanhGia
            // 
            this.MaDanhGia.DataPropertyName = "MaDanhGia";
            this.MaDanhGia.HeaderText = "Mã đánh giá ";
            this.MaDanhGia.MinimumWidth = 6;
            this.MaDanhGia.Name = "MaDanhGia";
            this.MaDanhGia.ReadOnly = true;
            this.MaDanhGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaDanhGia.Width = 140;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 105;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên KH";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 140;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            this.NoiDung.Width = 180;
            // 
            // frmQLDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 605);
            this.Controls.Add(this.mTxtSDT);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mdgvDanhGia);
            this.Controls.Add(this.mTxtNoiDung);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mTxtMaDanhGia);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mTxtTenKhachHang);
            this.Controls.Add(this.metroLabel6);
            this.MaximizeBox = false;
            this.Name = "frmQLDanhGia";
            this.Resizable = false;
            this.Text = "Quản lý đánh giá";
            this.Load += new System.EventHandler(this.frmQLDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mdgvDanhGia;
        private MetroFramework.Controls.MetroTextBox mTxtNoiDung;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mTxtMaDanhGia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mTxtTenKhachHang;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mTxtSDT;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
    }
}