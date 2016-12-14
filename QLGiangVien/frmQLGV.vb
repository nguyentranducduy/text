Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class FrmQuanlyGiangVien
    Dim chuoiketnoi As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseGV.mdf;Integrated Security=True"
    Dim lienket As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim data As New DataTable
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub FrmQuanlyGiangVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim load1 As SqlDataAdapter = New SqlDataAdapter("select * from giang_vien", lienket)
        Dim data As New DataTable
        lienket.Open()
        load1.Fill(data)
        dgvQuanLyGV.DataSource = data.DefaultView
        lienket.Close()
    End Sub

    

    Private Sub btnThemMoi_Click(sender As Object, e As EventArgs) Handles btnThemMoi.Click
        frmthemmoigv.ShowDialog()
    End Sub

    

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim TL As DialogResult
        TL = MessageBox.Show("Bạn Muốn chắc chắn Xóa Thông Tin ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If TL = Windows.Forms.DialogResult.Yes Then
            Dim lienketxoa As New SqlConnection(chuoiketnoi)
            lienketxoa.Open()
            Dim xoa As String = "delete from giang_vien where magv = @magv"
            Dim code As New SqlCommand(xoa, lienketxoa)
            Try
                code.Parameters.AddWithValue("@magv", lblMaGvien.Text)
                code.ExecuteNonQuery()
                lienketxoa.Close()
                MessageBox.Show("Đã Xóa Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Xóa Thông Tin Thất Bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from giang_vien", lienket)
            data.Clear()
            reset.Fill(data)
            dgvQuanLyGV.DataSource = data.DefaultView
            lblMaGvien.Text = Nothing
            txtHoVaTen.Clear()
            txtEmail.Clear()
            txtSoDienThoai.Clear()
            txtDiaChi.Clear()
            txtChuyenNganh.Clear()
            txtCMND.Clear()
            txtGhiChu.Clear()
        End If

    End Sub

    Private Sub dgvQuanLyGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuanLyGV.CellContentClick
        Dim chon As Integer = dgvQuanLyGV.CurrentCell.RowIndex
        lblMaGvien.Text = dgvQuanLyGV.Item(0, chon).Value
        txtHoVaTen.Text = dgvQuanLyGV.Item(1, chon).Value
        txtEmail.Text = dgvQuanLyGV.Item(2, chon).Value
        txtSoDienThoai.Text = "0" & dgvQuanLyGV.Item(7, chon).Value
        txtDiaChi.Text = dgvQuanLyGV.Item(9, chon).Value
        txtChuyenNganh.Text = dgvQuanLyGV.Item(5, chon).Value
        txtCMND.Text = dgvQuanLyGV.Item(8, chon).Value
        txtGhiChu.Text = dgvQuanLyGV.Item(10, chon).Value
        cboBangCap.Text = dgvQuanLyGV.Item(3, chon).Value
        cboHonNhan.Text = dgvQuanLyGV.Item(4, chon).Value
        dtmNgaySinh.Text = dgvQuanLyGV.Item(6, chon).Value
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim TL As DialogResult
        TL = MessageBox.Show("Xác nhận cập nhật thông tin", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If TL = Windows.Forms.DialogResult.Yes Then
            Dim ketnoisua As New SqlConnection(chuoiketnoi)
            ketnoisua.Open()
            Dim sua As String = "update giang_vien set hoten = @ten, sdt = @sdt, diachi = @diachi, mail = @mail, bangcap = @bangcap, honnhan = @honnhan, chuyennganh = @chuyennganh, ngaysinh = @ngaysinh, cmnd = @cmnd, ghichu = @ghichu  where magv = @magv"
            Dim doi As New SqlCommand(sua, ketnoisua)
            If txtGhiChu.Text = "" Then txtGhiChu.Text = "Null"

            lblloichuyengnanh.Text = Nothing
            lblloicmnd.Text = Nothing
            lblloidiachi.Text = Nothing
            lblloimail.Text = Nothing
            lblloisdt.Text = Nothing
            lblloiten.Text = Nothing

            If txtHoVaTen.Text = "" Then
                lblloiten.Text = "Nhập họ và tên"
                txtHoVaTen.Focus()
                Exit Sub
            Else
                If txtSoDienThoai.Text = "" Then
                    lblloisdt.Text = "Nhập SĐT : 09 / 012 ..."
                    txtSoDienThoai.Focus()
                    Exit Sub
                Else
                    If txtEmail.Text = "" Then
                        lblloimail.Text = "Nhập đúng định dạng Email"
                        txtEmail.Focus()
                        Exit Sub
                    Else
                        If txtCMND.Text = "" Then
                            lblloicmnd.Text = "Nhập số CMND"
                            txtCMND.Focus()
                            Exit Sub
                        Else
                            If txtChuyenNganh.Text = "" Then
                                lblloichuyengnanh.Text = "Nhập tên chuyên ngành"
                                txtChuyenNganh.Focus()
                                Exit Sub
                            Else
                                If txtDiaChi.Text = "" Then
                                    lblloidiachi.Text = "Nhập địa chỉ"
                                    txtDiaChi.Focus()
                                    Exit Sub
                                Else

                                    Try
                                        doi.Parameters.AddWithValue("@magv", lblMaGvien.Text)
                                        doi.Parameters.AddWithValue("@ten", txtHoVaTen.Text)
                                        doi.Parameters.AddWithValue("@sdt", txtSoDienThoai.Text)
                                        doi.Parameters.AddWithValue("@diachi", txtDiaChi.Text)
                                        doi.Parameters.AddWithValue("@mail", txtEmail.Text)
                                        doi.Parameters.AddWithValue("@bangcap", cboBangCap.Text)
                                        doi.Parameters.AddWithValue("@honnhan", cboHonNhan.Text)
                                        doi.Parameters.AddWithValue("@chuyennganh", txtChuyenNganh.Text)
                                        doi.Parameters.AddWithValue("@ngaysinh", dtmNgaySinh.Text)
                                        doi.Parameters.AddWithValue("@cmnd", txtCMND.Text)
                                        doi.Parameters.AddWithValue("@ghichu", txtGhiChu.Text)
                                        doi.ExecuteNonQuery()
                                        MessageBox.Show("Lưu Thay Đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Catch ex As Exception
                                        MessageBox.Show("Dữ Liệu Có Vấn Đề !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                    Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from giang_vien", lienket)
                                    data.Clear()
                                    reset.Fill(data)
                                    dgvQuanLyGV.DataSource = data.DefaultView
                                    lblMaGvien.Text = Nothing
                                    txtHoVaTen.Clear()
                                    txtEmail.Clear()
                                    txtSoDienThoai.Clear()
                                    txtDiaChi.Clear()
                                    txtChuyenNganh.Clear()
                                    txtCMND.Clear()
                                    txtGhiChu.Clear()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Close()
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim lienkett As New SqlConnection(chuoiketnoi)
        Dim mang As New ArrayList
        If Not String.IsNullOrEmpty(txtTim.Text) Then
            mang.Add(("magv = '" & txtTim.Text & "'"))
        End If
        'If Not String.IsNullOrEmpty(txtTim.Text) Then
        '    mang.Add(("hoten = '" & txtTim.Text & "'"))
        'End If
        Dim dieu_kien As String = ""
        For i As Integer = 0 To mang.Count - 1
            If i = 0 Then
                dieu_kien = mang(0)
            Else
                dieu_kien = dieu_kien & " and" & mang(i)


            End If
        Next
        Dim querytim As String = "select * from giang_vien"
        Dim thuchien As New SqlCommand(querytim, lienkett)
        lienkett.Open()
        Dim bang As SqlDataReader = thuchien.ExecuteReader
        Dim bang_xuat As New DataTable("GV")
        bang_xuat.Load(bang, LoadOption.OverwriteChanges)
        lienkett.Close()
        bang_xuat.DefaultView.RowFilter = dieu_kien
        dgvQuanLyGV.DataSource = bang_xuat
    End Sub

    Private Sub btnLM_Click(sender As Object, e As EventArgs) Handles btnLM.Click
        Dim reset As SqlDataAdapter = New SqlDataAdapter("select * from giang_vien", lienket)
        data.Clear()
        reset.Fill(data)
        dgvQuanLyGV.DataSource = data.DefaultView
        lblMaGvien.Text = Nothing
        txtHoVaTen.Clear()
        txtEmail.Clear()
        txtSoDienThoai.Clear()
        txtDiaChi.Clear()
        txtChuyenNganh.Clear()
        txtCMND.Clear()
        txtGhiChu.Clear()
    End Sub
End Class
