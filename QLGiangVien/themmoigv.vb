Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmthemmoigv
    Dim chuoiketnoi As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseGV.mdf;Integrated Security=True"
    Dim lienket As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim data As New DataTable

    Private Sub butLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim lienket As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim querythem As String = "insert into giang_vien values(@magv,@hoten,@email,@bangcap,@honnhan,@chuyennganh,@ngaysinh,@sdt,@cmnd,@diachi,@ghichu)"
        Dim thuchien As New SqlCommand(querythem, lienket)
        Dim x As String = txtSDT.Text
        Dim y As String = txtCMND.Text
        lienket.Open()
        If txtGhiChu.Text = "" Then txtGhiChu.Text = "Null"
        Dim mail As String = txtmail1.Text + "@" + txtmail2.Text
        lblloichuyengnanh.Text = Nothing
        lblloicmnd.Text = Nothing
        lblloidiachi.Text = Nothing
        lblLoiMagv.Text = Nothing
        lblloimail.Text = Nothing
        lblloisdt.Text = Nothing
        lblloiten.Text = Nothing
        If txtMaGV.Text = "" Then
            lblLoiMagv.Text = "Nhập mã giãng viên"
            Exit Sub
        Else
            If txtHOvaten.Text = "" Then
                lblloiten.Text = "Nhập họ và tên"
                txtHOvaten.Focus()
                Exit Sub
            Else
                If txtmail1.Text = "" Or txtmail2.Text = "" Then
                    lblloimail.Text = "Nhập đúng định dạng Email"
                    txtmail1.Focus()
                    Exit Sub
                Else
                    If txtDiaChi.Text = "" Then
                        lblloidiachi.Text = "Nhập địa chỉ"
                        txtDiaChi.Focus()
                        Exit Sub
                    Else
                        If txtCHuyennganh.Text = "" Then
                            lblloichuyengnanh.Text = "Nhập tên chuyên ngành"
                            txtCHuyennganh.Focus()
                            Exit Sub
                        Else
                            If txtSDT.Text = "" Then
                                lblloisdt.Text = "Nhập SĐT : 09 / 012 ..."
                                txtSDT.Focus()
                                Exit Sub
                            Else
                                If txtCMND.Text = "" Then
                                    lblloicmnd.Text = "Nhập số CMND"
                                    txtCMND.Focus()
                                    Exit Sub
                                Else
                                    Try

                                        Try
                                            x = Convert.ToInt64(txtSDT.Text)
                                            If x >= 0 Then
                                                x = txtSDT.Text
                                            End If
                                        Catch ex As Exception
                                            lblloisdt.Text = "nhập số theo mẫu 09xxx / 012xxx"
                                            Exit Sub

                                        End Try


                                        Try
                                            y = Convert.ToInt64(txtCMND.Text)
                                            If y >= 0 Then
                                                x = txtCMND.Text
                                            End If
                                        Catch ex As Exception
                                            lblloicmnd.Text = "nhập 9 chữ số"
                                            Exit Sub

                                        End Try

                                        thuchien.Parameters.AddWithValue("@magv", txtMaGV.Text)
                                        thuchien.Parameters.AddWithValue("@hoten", txtHOvaten.Text)
                                        thuchien.Parameters.AddWithValue("@email", mail)
                                        thuchien.Parameters.AddWithValue("@sdt", txtSDT.Text)
                                        thuchien.Parameters.AddWithValue("@diachi", txtDiaChi.Text)
                                        thuchien.Parameters.AddWithValue("@chuyennganh", txtCHuyennganh.Text)
                                        thuchien.Parameters.AddWithValue("@cmnd", txtCMND.Text)
                                        thuchien.Parameters.AddWithValue("@ghiChu", txtGhiChu.Text)
                                        thuchien.Parameters.AddWithValue("@bangcap ", cboBangcap.Text)
                                        thuchien.Parameters.AddWithValue("@honnhan ", cboHonnhan.Text)
                                        thuchien.Parameters.AddWithValue("@ngaySinh", dtmNgaySinh.Text)
                                        thuchien.ExecuteNonQuery()
                                        MessageBox.Show("Thêm Dữ Liệu Thành Công")
                                        txtMaGV.Clear()
                                        txtHOvaten.Clear()
                                        txtmail1.Clear()
                                        txtSDT.Clear()
                                        txtDiaChi.Clear()
                                        txtCHuyennganh.Clear()
                                        txtCMND.Clear()
                                        txtGhiChu.Clear()
                                        txtmail2.Clear()

                                    Catch ex As Exception
                                        MessageBox.Show("Lỗi Thao Tác : Có thể Mã Giảng Viên tã tồn tại, Số Điện Thọai vượt quá 15 hoặc số CMND vuợt quá 9 chữ số. Vui lòng kiểm tra lại !", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub butnhaplai_Click(sender As Object, e As EventArgs) Handles btnnhaplai.Click
        Dim TraLoi As DialogResult

        TraLoi = MessageBox.Show("Nhập lại thông tin", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If TraLoi = Windows.Forms.DialogResult.Yes Then
            txtMaGV.Clear()
            txtHOvaten.Clear()
            txtmail1.Clear()
            txtSDT.Clear()
            txtDiaChi.Clear()
            txtCHuyennganh.Clear()
            txtCMND.Clear()
            txtGhiChu.Clear()
            txtmail2.Clear()
        End If
    End Sub

    Private Sub frmthemmoigv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class