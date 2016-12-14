<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnstaikhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrDangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsbangdiem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrQLuser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnrQLGV = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnGV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVT = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnstaikhoan, Me.mnsbangdiem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnstaikhoan
        '
        Me.mnstaikhoan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnrDangxuat, Me.mnrThoat})
        Me.mnstaikhoan.Name = "mnstaikhoan"
        Me.mnstaikhoan.ShowShortcutKeys = False
        Me.mnstaikhoan.Size = New System.Drawing.Size(72, 20)
        Me.mnstaikhoan.Text = "Hệ Thống"
        '
        'mnrDangxuat
        '
        Me.mnrDangxuat.Name = "mnrDangxuat"
        Me.mnrDangxuat.Size = New System.Drawing.Size(140, 22)
        Me.mnrDangxuat.Text = "Đăng Xuất"
        '
        'mnrThoat
        '
        Me.mnrThoat.Name = "mnrThoat"
        Me.mnrThoat.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnrThoat.Size = New System.Drawing.Size(140, 22)
        Me.mnrThoat.Text = "Thoát Ra"
        '
        'mnsbangdiem
        '
        Me.mnsbangdiem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnrQLuser, Me.mnrQLGV})
        Me.mnsbangdiem.Name = "mnsbangdiem"
        Me.mnsbangdiem.Size = New System.Drawing.Size(125, 20)
        Me.mnsbangdiem.Text = "Quản lý phầm mềm"
        '
        'mnrQLuser
        '
        Me.mnrQLuser.Name = "mnrQLuser"
        Me.mnrQLuser.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnrQLuser.Size = New System.Drawing.Size(214, 22)
        Me.mnrQLuser.Text = "Quản lý tài khoản"
        '
        'mnrQLGV
        '
        Me.mnrQLGV.Name = "mnrQLGV"
        Me.mnrQLGV.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnrQLGV.Size = New System.Drawing.Size(214, 22)
        Me.mnrQLGV.Text = "Quản lý giảng viên"
        '
        'btnUser
        '
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUser.Location = New System.Drawing.Point(45, 168)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(151, 130)
        Me.btnUser.TabIndex = 5
        Me.btnUser.Text = "Quản Lý Tài Khoản"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnGV
        '
        Me.btnGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGV.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGV.Location = New System.Drawing.Point(231, 168)
        Me.btnGV.Name = "btnGV"
        Me.btnGV.Size = New System.Drawing.Size(155, 130)
        Me.btnGV.TabIndex = 6
        Me.btnGV.Text = "Quản Lý Giảng Viên"
        Me.btnGV.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(38, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DANH MỤC QUẢN LÝ"
        '
        'lblVT
        '
        Me.lblVT.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblVT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVT.Location = New System.Drawing.Point(269, 37)
        Me.lblVT.Name = "lblVT"
        Me.lblVT.Size = New System.Drawing.Size(41, 15)
        Me.lblVT.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(318, 37)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(91, 15)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "                     "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(423, 310)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblVT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGV)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ GIẢNG VIÊN"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnstaikhoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsbangdiem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrQLuser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnrQLGV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnGV As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVT As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents mnrDangxuat As System.Windows.Forms.ToolStripMenuItem

End Class
