Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmwelcome.ShowDialog()
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        frmQLUser.ShowDialog()
    End Sub


    Private Sub btnGV_Click(sender As Object, e As EventArgs) Handles btnGV.Click
        FrmQuanlyGiangVien.ShowDialog()

    End Sub

    Private Sub ThêmSinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnrQLuser.Click
        frmQLUser.ShowDialog()
    End Sub

    Private Sub XemThôngTinSinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnrQLGV.Click
        FrmQuanlyGiangVien.ShowDialog()
    End Sub

    Private Sub mnrDangxuat_Click(sender As Object, e As EventArgs) Handles mnrDangxuat.Click
        frmLogin.ShowDialog()
    End Sub
End Class
