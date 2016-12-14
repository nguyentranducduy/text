Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmQLUser
    Dim chuoiketnoi As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseGV.mdf;Integrated Security=True"
    Dim lienket As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim data As New DataTable
    Private Sub frmQLUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load1 As SqlDataAdapter = New SqlDataAdapter("select * from taikhoan ", lienket)
        lienket.Open()
        load1.Fill(data)
        dgvdanhsach.DataSource = data.DefaultView
        lienket.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim querythem As String = "insert into taikhoan values(@user,@pass,@VT)"
        Dim thuchien As New SqlCommand(querythem, lienket)
        lienket.Open()
        lblLoiUser.Text = Nothing
        lblLoiPass.Text = Nothing

        If txttentaikhoan.Text = Nothing Then
            lblLoiUser.Text = "vui lòng nhập tài khoản "
            Exit Sub
        Else

            If txtmatkhau.Text = "" Then
                lblLoiPass.Text = "vui lòng nhập mật khẩu "
                Exit Sub
            Else

                Try

                    thuchien.Parameters.AddWithValue("@user", txttentaikhoan.Text)
                    thuchien.Parameters.AddWithValue("@pass", txtmatkhau.Text)
                    thuchien.Parameters.AddWithValue("@VT", cboVT.Text)

                    thuchien.ExecuteNonQuery()
                    MessageBox.Show("Thêm Dữ Liệu Thành Công")

                Catch ex As Exception
                    MessageBox.Show("Thông Tin tài khoản bị đã tồn tại", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from taikhoan", lienket)
                data.Clear()
                reset.Fill(data)
                dgvdanhsach.DataSource = data.DefaultView
                txttentaikhoan.Clear()
                txtmatkhau.Clear()
                lienket.Close()
            End If
        End If
    End Sub

    Private Sub dgvdanhsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdanhsach.CellContentClick
        Dim chon As Integer = dgvdanhsach.CurrentCell.RowIndex
        txttentaikhoan.Text = dgvdanhsach.Item(0, chon).Value
        txtmatkhau.Text = dgvdanhsach.Item(1, chon).Value
        cboVT.Text = dgvdanhsach.Item(2, chon).Value
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Dim TL As DialogResult
        TL = MessageBox.Show("Xác nhận cập nhật thông tin", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If TL = Windows.Forms.DialogResult.Yes Then
            Dim ketnoisua As New SqlConnection(chuoiketnoi)
            ketnoisua.Open()
            Dim sua As String = "update taikhoan set  pass = @pass, vaitro = @vaitro where taikhoan = @user "
            Dim doi As New SqlCommand(sua, ketnoisua)

            If txttentaikhoan.Text = "" Then
                lblLoiUser.Text = "vui lòng nhập tài khoản "
                Exit Sub
            Else
                If txtmatkhau.Text = "" Then
                    lblLoiPass.Text = "vui lòng nhập mật khẩu "
                    Exit Sub
                Else

                    Try
                        doi.Parameters.AddWithValue("@user", txttentaikhoan.Text)
                        doi.Parameters.AddWithValue("@pass", txtmatkhau.Text)
                        doi.Parameters.AddWithValue("@vaitro", cboVT.Text)
                        doi.ExecuteNonQuery()
                        MessageBox.Show("Lưu Thay Đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ketnoisua.Close()
                    Catch ex As Exception
                        MessageBox.Show("Tên Tài Khoảng đã tồn tại !", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from taikhoan", lienket)
                    data.Clear()
                    reset.Fill(data)
                    dgvdanhsach.DataSource = data.DefaultView
                    txttentaikhoan.Clear()
                    txtmatkhau.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim TL As DialogResult
        TL = MessageBox.Show("Bạn Muốn chắc chắn Xóa Thông Tin ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If TL = Windows.Forms.DialogResult.Yes Then
            Dim lienketxoa As New SqlConnection(chuoiketnoi)
            lienketxoa.Open()
            Dim xoa As String = "delete from taikhoan where taikhoan = @user"
            Dim code As New SqlCommand(xoa, lienketxoa)
            Try
                code.Parameters.AddWithValue("@user", txttentaikhoan.Text)
                code.ExecuteNonQuery()
                lienketxoa.Close()
                MessageBox.Show("Đã Xóa Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Xóa Thông Tin Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from taikhoan", lienket)
            data.Clear()
            reset.Fill(data)
            dgvdanhsach.DataSource = data.DefaultView
            txttentaikhoan.Clear()
            txtmatkhau.Clear()
        End If
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Close()
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim lienkett As New SqlConnection(chuoiketnoi)
        Dim mang As New ArrayList
        If Not String.IsNullOrEmpty(txtTim.Text) Then
            mang.Add(("taikhoan = '" & txtTim.Text & "'"))
        End If

        Dim dieu_kien As String = ""
        For i As Integer = 0 To mang.Count - 1
            If i = 0 Then
                dieu_kien = mang(0)
            Else
                dieu_kien = dieu_kien & " and" & mang(i)


            End If
        Next
        Dim querytim As String = "select * from taikhoan"
        Dim thuchien As New SqlCommand(querytim, lienkett)
        lienkett.Open()
        Dim bang As SqlDataReader = thuchien.ExecuteReader
        Dim bang_xuat As New DataTable("taikhoan")
        bang_xuat.Load(bang, LoadOption.OverwriteChanges)
        lienkett.Close()
        bang_xuat.DefaultView.RowFilter = dieu_kien
        dgvdanhsach.DataSource = bang_xuat
    End Sub

    Private Sub btnLM_Click(sender As Object, e As EventArgs) Handles btnLM.Click
        Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from taikhoan", lienket)
        data.Clear()
        reset.Fill(data)
        dgvdanhsach.DataSource = data.DefaultView
        txttentaikhoan.Clear()
        txtmatkhau.Clear()
    End Sub
End Class