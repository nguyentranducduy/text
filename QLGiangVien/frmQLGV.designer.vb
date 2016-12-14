<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanlyGiangVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuanlyGiangVien))
        Me.lblMaGV = New System.Windows.Forms.Label()
        Me.lblHoVaTen = New System.Windows.Forms.Label()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblBangCap = New System.Windows.Forms.Label()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCMND = New System.Windows.Forms.Label()
        Me.lblHonNhan = New System.Windows.Forms.Label()
        Me.lblChuyenNganh = New System.Windows.Forms.Label()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblGhiChu = New System.Windows.Forms.Label()
        Me.lblThaoTacQuanLyGiangVien = New System.Windows.Forms.Label()
        Me.txtHoVaTen = New System.Windows.Forms.TextBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtChuyenNganh = New System.Windows.Forms.TextBox()
        Me.dtmNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.cboHonNhan = New System.Windows.Forms.ComboBox()
        Me.cboBangCap = New System.Windows.Forms.ComboBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.btnThemMoi = New System.Windows.Forms.Button()
        Me.dgvQuanLyGV = New System.Windows.Forms.DataGridView()
        Me.lblMaGvien = New System.Windows.Forms.Label()
        Me.lblloiten = New System.Windows.Forms.Label()
        Me.lblloimail = New System.Windows.Forms.Label()
        Me.lblloichuyengnanh = New System.Windows.Forms.Label()
        Me.lblloicmnd = New System.Windows.Forms.Label()
        Me.lblloisdt = New System.Windows.Forms.Label()
        Me.lblloidiachi = New System.Windows.Forms.Label()
        Me.btntim = New System.Windows.Forms.Button()
        Me.txtTim = New System.Windows.Forms.TextBox()
        Me.btnLM = New System.Windows.Forms.Button()
        CType(Me.dgvQuanLyGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaGV
        '
        Me.lblMaGV.AutoSize = True
        Me.lblMaGV.Location = New System.Drawing.Point(15, 146)
        Me.lblMaGV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaGV.Name = "lblMaGV"
        Me.lblMaGV.Size = New System.Drawing.Size(104, 18)
        Me.lblMaGV.TabIndex = 1
        Me.lblMaGV.Text = "Mã Giảng Viên"
        '
        'lblHoVaTen
        '
        Me.lblHoVaTen.AutoSize = True
        Me.lblHoVaTen.Location = New System.Drawing.Point(15, 176)
        Me.lblHoVaTen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoVaTen.Name = "lblHoVaTen"
        Me.lblHoVaTen.Size = New System.Drawing.Size(78, 18)
        Me.lblHoVaTen.TabIndex = 2
        Me.lblHoVaTen.Text = "Họ Và Tên"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(15, 224)
        Me.lblNgaySinh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(75, 18)
        Me.lblNgaySinh.TabIndex = 3
        Me.lblNgaySinh.Text = "Ngày Sinh"
        '
        'lblBangCap
        '
        Me.lblBangCap.AutoSize = True
        Me.lblBangCap.Location = New System.Drawing.Point(15, 252)
        Me.lblBangCap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBangCap.Name = "lblBangCap"
        Me.lblBangCap.Size = New System.Drawing.Size(73, 18)
        Me.lblBangCap.TabIndex = 4
        Me.lblBangCap.Text = "Bằng Cấp"
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Location = New System.Drawing.Point(13, 281)
        Me.lblSoDienThoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(102, 18)
        Me.lblSoDienThoai.TabIndex = 5
        Me.lblSoDienThoai.Text = "Số Điện Thoại"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(15, 336)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 18)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblCMND
        '
        Me.lblCMND.AutoSize = True
        Me.lblCMND.Location = New System.Drawing.Point(15, 382)
        Me.lblCMND.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCMND.Name = "lblCMND"
        Me.lblCMND.Size = New System.Drawing.Size(54, 18)
        Me.lblCMND.TabIndex = 7
        Me.lblCMND.Text = "CMND"
        '
        'lblHonNhan
        '
        Me.lblHonNhan.AutoSize = True
        Me.lblHonNhan.Location = New System.Drawing.Point(15, 423)
        Me.lblHonNhan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHonNhan.Name = "lblHonNhan"
        Me.lblHonNhan.Size = New System.Drawing.Size(75, 18)
        Me.lblHonNhan.TabIndex = 8
        Me.lblHonNhan.Text = "Hôn Nhân"
        '
        'lblChuyenNganh
        '
        Me.lblChuyenNganh.AutoSize = True
        Me.lblChuyenNganh.Location = New System.Drawing.Point(15, 455)
        Me.lblChuyenNganh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChuyenNganh.Name = "lblChuyenNganh"
        Me.lblChuyenNganh.Size = New System.Drawing.Size(105, 18)
        Me.lblChuyenNganh.TabIndex = 9
        Me.lblChuyenNganh.Text = "Chuyên Ngành"
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(15, 497)
        Me.lblDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(56, 18)
        Me.lblDiaChi.TabIndex = 10
        Me.lblDiaChi.Text = "Địa Chỉ"
        '
        'lblGhiChu
        '
        Me.lblGhiChu.AutoSize = True
        Me.lblGhiChu.Location = New System.Drawing.Point(15, 574)
        Me.lblGhiChu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(62, 18)
        Me.lblGhiChu.TabIndex = 11
        Me.lblGhiChu.Text = "Ghi Chú"
        '
        'lblThaoTacQuanLyGiangVien
        '
        Me.lblThaoTacQuanLyGiangVien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThaoTacQuanLyGiangVien.AutoSize = True
        Me.lblThaoTacQuanLyGiangVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThaoTacQuanLyGiangVien.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblThaoTacQuanLyGiangVien.Location = New System.Drawing.Point(296, 38)
        Me.lblThaoTacQuanLyGiangVien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThaoTacQuanLyGiangVien.Name = "lblThaoTacQuanLyGiangVien"
        Me.lblThaoTacQuanLyGiangVien.Size = New System.Drawing.Size(476, 39)
        Me.lblThaoTacQuanLyGiangVien.TabIndex = 12
        Me.lblThaoTacQuanLyGiangVien.Text = "Thao Tác Quản Lý Giảng Viên"
        '
        'txtHoVaTen
        '
        Me.txtHoVaTen.Location = New System.Drawing.Point(109, 176)
        Me.txtHoVaTen.Name = "txtHoVaTen"
        Me.txtHoVaTen.Size = New System.Drawing.Size(179, 24)
        Me.txtHoVaTen.TabIndex = 1
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(158, 379)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(130, 24)
        Me.txtCMND.TabIndex = 6
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(132, 281)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(156, 24)
        Me.txtSoDienThoai.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(109, 333)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 24)
        Me.txtEmail.TabIndex = 5
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(109, 497)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(179, 72)
        Me.txtDiaChi.TabIndex = 9
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(18, 595)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(270, 99)
        Me.txtGhiChu.TabIndex = 10
        '
        'txtChuyenNganh
        '
        Me.txtChuyenNganh.Location = New System.Drawing.Point(130, 455)
        Me.txtChuyenNganh.Name = "txtChuyenNganh"
        Me.txtChuyenNganh.Size = New System.Drawing.Size(158, 24)
        Me.txtChuyenNganh.TabIndex = 8
        '
        'dtmNgaySinh
        '
        Me.dtmNgaySinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmNgaySinh.Location = New System.Drawing.Point(161, 222)
        Me.dtmNgaySinh.MaxDate = New Date(1990, 12, 31, 0, 0, 0, 0)
        Me.dtmNgaySinh.Name = "dtmNgaySinh"
        Me.dtmNgaySinh.Size = New System.Drawing.Size(130, 20)
        Me.dtmNgaySinh.TabIndex = 2
        Me.dtmNgaySinh.Value = New Date(1990, 12, 31, 0, 0, 0, 0)
        '
        'cboHonNhan
        '
        Me.cboHonNhan.FormattingEnabled = True
        Me.cboHonNhan.Items.AddRange(New Object() {"Đã Kết Hôn", "Độc Thân"})
        Me.cboHonNhan.Location = New System.Drawing.Point(158, 423)
        Me.cboHonNhan.Name = "cboHonNhan"
        Me.cboHonNhan.Size = New System.Drawing.Size(130, 26)
        Me.cboHonNhan.TabIndex = 7
        '
        'cboBangCap
        '
        Me.cboBangCap.FormattingEnabled = True
        Me.cboBangCap.Items.AddRange(New Object() {"Tiến Sĩ", "Thạc Sĩ", "Đại Học", "Cao Đẳng"})
        Me.cboBangCap.Location = New System.Drawing.Point(160, 249)
        Me.cboBangCap.Name = "cboBangCap"
        Me.cboBangCap.Size = New System.Drawing.Size(130, 26)
        Me.cboBangCap.TabIndex = 3
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCapNhat.Location = New System.Drawing.Point(303, 640)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(86, 34)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXoa.Location = New System.Drawing.Point(413, 640)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(86, 34)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuayLai.Location = New System.Drawing.Point(895, 640)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(86, 34)
        Me.btnQuayLai.TabIndex = 14
        Me.btnQuayLai.Text = "Quay Lại"
        Me.btnQuayLai.UseVisualStyleBackColor = True
        '
        'btnThemMoi
        '
        Me.btnThemMoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThemMoi.Location = New System.Drawing.Point(520, 640)
        Me.btnThemMoi.Name = "btnThemMoi"
        Me.btnThemMoi.Size = New System.Drawing.Size(86, 34)
        Me.btnThemMoi.TabIndex = 12
        Me.btnThemMoi.Text = "Thêm Mới"
        Me.btnThemMoi.UseVisualStyleBackColor = True
        '
        'dgvQuanLyGV
        '
        Me.dgvQuanLyGV.AllowUserToAddRows = False
        Me.dgvQuanLyGV.AllowUserToDeleteRows = False
        Me.dgvQuanLyGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvQuanLyGV.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgvQuanLyGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuanLyGV.Location = New System.Drawing.Point(303, 146)
        Me.dgvQuanLyGV.Name = "dgvQuanLyGV"
        Me.dgvQuanLyGV.ReadOnly = True
        Me.dgvQuanLyGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvQuanLyGV.Size = New System.Drawing.Size(678, 488)
        Me.dgvQuanLyGV.TabIndex = 25
        '
        'lblMaGvien
        '
        Me.lblMaGvien.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblMaGvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaGvien.Location = New System.Drawing.Point(158, 146)
        Me.lblMaGvien.Name = "lblMaGvien"
        Me.lblMaGvien.Size = New System.Drawing.Size(130, 18)
        Me.lblMaGvien.TabIndex = 26
        '
        'lblloiten
        '
        Me.lblloiten.BackColor = System.Drawing.Color.Transparent
        Me.lblloiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloiten.ForeColor = System.Drawing.Color.Red
        Me.lblloiten.Location = New System.Drawing.Point(127, 203)
        Me.lblloiten.Name = "lblloiten"
        Me.lblloiten.Size = New System.Drawing.Size(161, 16)
        Me.lblloiten.TabIndex = 46
        Me.lblloiten.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblloimail
        '
        Me.lblloimail.BackColor = System.Drawing.Color.Transparent
        Me.lblloimail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloimail.ForeColor = System.Drawing.Color.Red
        Me.lblloimail.Location = New System.Drawing.Point(109, 360)
        Me.lblloimail.Name = "lblloimail"
        Me.lblloimail.Size = New System.Drawing.Size(179, 16)
        Me.lblloimail.TabIndex = 47
        Me.lblloimail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblloichuyengnanh
        '
        Me.lblloichuyengnanh.BackColor = System.Drawing.Color.Transparent
        Me.lblloichuyengnanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloichuyengnanh.ForeColor = System.Drawing.Color.Red
        Me.lblloichuyengnanh.Location = New System.Drawing.Point(127, 478)
        Me.lblloichuyengnanh.Name = "lblloichuyengnanh"
        Me.lblloichuyengnanh.Size = New System.Drawing.Size(161, 16)
        Me.lblloichuyengnanh.TabIndex = 49
        Me.lblloichuyengnanh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblloicmnd
        '
        Me.lblloicmnd.BackColor = System.Drawing.Color.Transparent
        Me.lblloicmnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloicmnd.ForeColor = System.Drawing.Color.Red
        Me.lblloicmnd.Location = New System.Drawing.Point(158, 406)
        Me.lblloicmnd.Name = "lblloicmnd"
        Me.lblloicmnd.Size = New System.Drawing.Size(130, 16)
        Me.lblloicmnd.TabIndex = 51
        Me.lblloicmnd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblloisdt
        '
        Me.lblloisdt.BackColor = System.Drawing.Color.Transparent
        Me.lblloisdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloisdt.ForeColor = System.Drawing.Color.Red
        Me.lblloisdt.Location = New System.Drawing.Point(129, 308)
        Me.lblloisdt.Name = "lblloisdt"
        Me.lblloisdt.Size = New System.Drawing.Size(161, 16)
        Me.lblloisdt.TabIndex = 52
        Me.lblloisdt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblloidiachi
        '
        Me.lblloidiachi.BackColor = System.Drawing.Color.Transparent
        Me.lblloidiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloidiachi.ForeColor = System.Drawing.Color.Red
        Me.lblloidiachi.Location = New System.Drawing.Point(127, 572)
        Me.lblloidiachi.Name = "lblloidiachi"
        Me.lblloidiachi.Size = New System.Drawing.Size(161, 16)
        Me.lblloidiachi.TabIndex = 53
        Me.lblloidiachi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btntim
        '
        Me.btntim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim.Location = New System.Drawing.Point(906, 117)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 55
        Me.btntim.Text = "Tìm kiếm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txtTim
        '
        Me.txtTim.Location = New System.Drawing.Point(750, 117)
        Me.txtTim.Name = "txtTim"
        Me.txtTim.Size = New System.Drawing.Size(150, 24)
        Me.txtTim.TabIndex = 54
        '
        'btnLM
        '
        Me.btnLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLM.Location = New System.Drawing.Point(303, 118)
        Me.btnLM.Name = "btnLM"
        Me.btnLM.Size = New System.Drawing.Size(75, 23)
        Me.btnLM.TabIndex = 55
        Me.btnLM.Text = "Làm Mới"
        Me.btnLM.UseVisualStyleBackColor = True
        '
        'FrmQuanlyGiangVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 706)
        Me.Controls.Add(Me.btnLM)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txtTim)
        Me.Controls.Add(Me.lblloidiachi)
        Me.Controls.Add(Me.lblloisdt)
        Me.Controls.Add(Me.lblloicmnd)
        Me.Controls.Add(Me.lblloichuyengnanh)
        Me.Controls.Add(Me.lblloimail)
        Me.Controls.Add(Me.lblloiten)
        Me.Controls.Add(Me.lblMaGvien)
        Me.Controls.Add(Me.dgvQuanLyGV)
        Me.Controls.Add(Me.btnThemMoi)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.cboBangCap)
        Me.Controls.Add(Me.cboHonNhan)
        Me.Controls.Add(Me.dtmNgaySinh)
        Me.Controls.Add(Me.txtChuyenNganh)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtHoVaTen)
        Me.Controls.Add(Me.lblThaoTacQuanLyGiangVien)
        Me.Controls.Add(Me.lblGhiChu)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblChuyenNganh)
        Me.Controls.Add(Me.lblHonNhan)
        Me.Controls.Add(Me.lblCMND)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.lblBangCap)
        Me.Controls.Add(Me.lblNgaySinh)
        Me.Controls.Add(Me.lblHoVaTen)
        Me.Controls.Add(Me.lblMaGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmQuanlyGiangVien"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Giảng Viên"
        CType(Me.dgvQuanLyGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaGV As System.Windows.Forms.Label
    Friend WithEvents lblHoVaTen As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblBangCap As System.Windows.Forms.Label
    Friend WithEvents lblSoDienThoai As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblCMND As System.Windows.Forms.Label
    Friend WithEvents lblHonNhan As System.Windows.Forms.Label
    Friend WithEvents lblChuyenNganh As System.Windows.Forms.Label
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents lblGhiChu As System.Windows.Forms.Label
    Friend WithEvents lblThaoTacQuanLyGiangVien As System.Windows.Forms.Label
    Friend WithEvents txtHoVaTen As System.Windows.Forms.TextBox
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents txtChuyenNganh As System.Windows.Forms.TextBox
    Friend WithEvents dtmNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboHonNhan As System.Windows.Forms.ComboBox
    Friend WithEvents cboBangCap As System.Windows.Forms.ComboBox
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnQuayLai As System.Windows.Forms.Button
    Friend WithEvents btnThemMoi As System.Windows.Forms.Button
    Friend WithEvents dgvQuanLyGV As System.Windows.Forms.DataGridView
    Friend WithEvents lblMaGvien As System.Windows.Forms.Label
    Friend WithEvents lblloiten As System.Windows.Forms.Label
    Friend WithEvents lblloimail As System.Windows.Forms.Label
    Friend WithEvents lblloichuyengnanh As System.Windows.Forms.Label
    Friend WithEvents lblloicmnd As System.Windows.Forms.Label
    Friend WithEvents lblloisdt As System.Windows.Forms.Label
    Friend WithEvents lblloidiachi As System.Windows.Forms.Label
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents txtTim As System.Windows.Forms.TextBox
    Friend WithEvents btnLM As System.Windows.Forms.Button

End Class
