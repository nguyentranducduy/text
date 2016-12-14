<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLUser))
        Me.txttentaikhoan = New System.Windows.Forms.TextBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.dgvdanhsach = New System.Windows.Forms.DataGridView()
        Me.grquanlytaikhoan = New System.Windows.Forms.GroupBox()
        Me.cboVT = New System.Windows.Forms.ComboBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.lblLoiPass = New System.Windows.Forms.Label()
        Me.lblLoiUser = New System.Windows.Forms.Label()
        Me.lblmk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.grbchucnang = New System.Windows.Forms.GroupBox()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.txtTim = New System.Windows.Forms.TextBox()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnLM = New System.Windows.Forms.Button()
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grquanlytaikhoan.SuspendLayout()
        Me.grbchucnang.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttentaikhoan
        '
        Me.txttentaikhoan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttentaikhoan.Location = New System.Drawing.Point(109, 40)
        Me.txttentaikhoan.Name = "txttentaikhoan"
        Me.txttentaikhoan.Size = New System.Drawing.Size(122, 22)
        Me.txttentaikhoan.TabIndex = 1
        '
        'lblpw
        '
        Me.lblpw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpw.AutoSize = True
        Me.lblpw.Location = New System.Drawing.Point(6, 40)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(102, 16)
        Me.lblpw.TabIndex = 2
        Me.lblpw.Text = "Tên Tài Khoản :"
        '
        'btnthem
        '
        Me.btnthem.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(21, 33)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(87, 34)
        Me.btnthem.TabIndex = 10
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(21, 94)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(87, 34)
        Me.btnxoa.TabIndex = 11
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgvdanhsach
        '
        Me.dgvdanhsach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsach.Location = New System.Drawing.Point(311, 118)
        Me.dgvdanhsach.Name = "dgvdanhsach"
        Me.dgvdanhsach.ReadOnly = True
        Me.dgvdanhsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdanhsach.Size = New System.Drawing.Size(588, 368)
        Me.dgvdanhsach.TabIndex = 9
        '
        'grquanlytaikhoan
        '
        Me.grquanlytaikhoan.Controls.Add(Me.cboVT)
        Me.grquanlytaikhoan.Controls.Add(Me.txtmatkhau)
        Me.grquanlytaikhoan.Controls.Add(Me.lblLoiPass)
        Me.grquanlytaikhoan.Controls.Add(Me.lblLoiUser)
        Me.grquanlytaikhoan.Controls.Add(Me.lblmk)
        Me.grquanlytaikhoan.Controls.Add(Me.Label2)
        Me.grquanlytaikhoan.Controls.Add(Me.txttentaikhoan)
        Me.grquanlytaikhoan.Controls.Add(Me.lblpw)
        Me.grquanlytaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grquanlytaikhoan.Location = New System.Drawing.Point(28, 108)
        Me.grquanlytaikhoan.Name = "grquanlytaikhoan"
        Me.grquanlytaikhoan.Size = New System.Drawing.Size(246, 200)
        Me.grquanlytaikhoan.TabIndex = 8
        Me.grquanlytaikhoan.TabStop = False
        Me.grquanlytaikhoan.Text = "Thông tin tài khoản :"
        '
        'cboVT
        '
        Me.cboVT.FormattingEnabled = True
        Me.cboVT.Items.AddRange(New Object() {"IT", "NV"})
        Me.cboVT.Location = New System.Drawing.Point(110, 157)
        Me.cboVT.Name = "cboVT"
        Me.cboVT.Size = New System.Drawing.Size(121, 24)
        Me.cboVT.TabIndex = 3
        Me.cboVT.Text = "NV"
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtmatkhau.Location = New System.Drawing.Point(109, 96)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.Size = New System.Drawing.Size(122, 22)
        Me.txtmatkhau.TabIndex = 2
        '
        'lblLoiPass
        '
        Me.lblLoiPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoiPass.ForeColor = System.Drawing.Color.Red
        Me.lblLoiPass.Location = New System.Drawing.Point(70, 121)
        Me.lblLoiPass.Name = "lblLoiPass"
        Me.lblLoiPass.Size = New System.Drawing.Size(161, 16)
        Me.lblLoiPass.TabIndex = 13
        '
        'lblLoiUser
        '
        Me.lblLoiUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoiUser.ForeColor = System.Drawing.Color.Red
        Me.lblLoiUser.Location = New System.Drawing.Point(69, 65)
        Me.lblLoiUser.Name = "lblLoiUser"
        Me.lblLoiUser.Size = New System.Drawing.Size(161, 16)
        Me.lblLoiUser.TabIndex = 13
        '
        'lblmk
        '
        Me.lblmk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmk.AutoSize = True
        Me.lblmk.Location = New System.Drawing.Point(6, 96)
        Me.lblmk.Name = "lblmk"
        Me.lblmk.Size = New System.Drawing.Size(69, 16)
        Me.lblmk.TabIndex = 13
        Me.lblmk.Text = "Mật Khẩu :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Vai Trò :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(307, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 42)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "QUẢN LÝ TÀI KHOẢN"
        '
        'btncapnhat
        '
        Me.btncapnhat.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncapnhat.Location = New System.Drawing.Point(143, 33)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(87, 34)
        Me.btncapnhat.TabIndex = 13
        Me.btncapnhat.Text = "Cập Nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'grbchucnang
        '
        Me.grbchucnang.Controls.Add(Me.btnQuayLai)
        Me.grbchucnang.Controls.Add(Me.btncapnhat)
        Me.grbchucnang.Controls.Add(Me.btnxoa)
        Me.grbchucnang.Controls.Add(Me.btnthem)
        Me.grbchucnang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbchucnang.Location = New System.Drawing.Point(28, 328)
        Me.grbchucnang.Name = "grbchucnang"
        Me.grbchucnang.Size = New System.Drawing.Size(246, 158)
        Me.grbchucnang.TabIndex = 15
        Me.grbchucnang.TabStop = False
        Me.grbchucnang.Text = "Chức năng :"
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuayLai.Location = New System.Drawing.Point(144, 94)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(86, 34)
        Me.btnQuayLai.TabIndex = 15
        Me.btnQuayLai.Text = "Quay Lại"
        Me.btnQuayLai.UseVisualStyleBackColor = True
        '
        'txtTim
        '
        Me.txtTim.Location = New System.Drawing.Point(668, 89)
        Me.txtTim.Name = "txtTim"
        Me.txtTim.Size = New System.Drawing.Size(150, 20)
        Me.txtTim.TabIndex = 16
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(824, 89)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 17
        Me.btntim.Text = "Tìm kiếm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnLM
        '
        Me.btnLM.Location = New System.Drawing.Point(311, 89)
        Me.btnLM.Name = "btnLM"
        Me.btnLM.Size = New System.Drawing.Size(75, 23)
        Me.btnLM.TabIndex = 17
        Me.btnLM.Text = "Làm Mới"
        Me.btnLM.UseVisualStyleBackColor = True
        '
        'frmQLUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 513)
        Me.Controls.Add(Me.btnLM)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txtTim)
        Me.Controls.Add(Me.grbchucnang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdanhsach)
        Me.Controls.Add(Me.grquanlytaikhoan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Giảng  Viên"
        CType(Me.dgvdanhsach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grquanlytaikhoan.ResumeLayout(False)
        Me.grquanlytaikhoan.PerformLayout()
        Me.grbchucnang.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttentaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents dgvdanhsach As System.Windows.Forms.DataGridView
    Friend WithEvents grquanlytaikhoan As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents lblmk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncapnhat As System.Windows.Forms.Button
    Friend WithEvents grbchucnang As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuayLai As System.Windows.Forms.Button
    Friend WithEvents cboVT As System.Windows.Forms.ComboBox
    Friend WithEvents lblLoiPass As System.Windows.Forms.Label
    Friend WithEvents lblLoiUser As System.Windows.Forms.Label
    Friend WithEvents txtTim As System.Windows.Forms.TextBox
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents btnLM As System.Windows.Forms.Button
End Class
