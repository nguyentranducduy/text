Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class frmLogin

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click, btnDangNhap.Enter
        Dim chuoiketnoi As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseGV.mdf;Integrated Security=True"
        Dim lienket As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sql As New SqlDataAdapter("select * from taikhoan where taikhoan = '" & txtUser.Text & "'and pass = '" & txtPass.Text & "' and vaitro = '" & cboVaiTro.Text & "'", lienket)
        Dim tb As New DataTable
        Try
            lienket.Open()
            sql.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Được Phép Kết Nối !")
                frmMain.lblUser.Text = txtUser.Text
                frmMain.lblVT.Text = cboVaiTro.Text
                If (frmMain.lblVT.Text = "NV") Then
                    frmMain.btnUser.Enabled = False
                    frmMain.mnrQLuser.Enabled = False
                    frmMain.btnGV.Enabled = True
                    frmMain.mnrQLGV.Enabled = True
                End If

                If (frmMain.lblVT.Text = "IT") Then
                    frmMain.btnGV.Enabled = False
                    frmMain.mnrQLGV.Enabled = False
                    frmMain.btnUser.Enabled = True
                    frmMain.mnrQLuser.Enabled = True
                End If
                Me.Close()
            Else
                MessageBox.Show("Mã Nhân Viên, Mật Khẩu hoặc Vai Trò Không Đúng. Vui lòng nhập lại !", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Function tb() As DataSet
        Throw New NotImplementedException
    End Function

End Class
