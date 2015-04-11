Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanlysanphamfrm
    Dim tb As New DataTable
    Dim connect As String = "workstation id=DataAss.mssql.somee.com;packet size=4096;user id=dinh_asm;pwd=1234abc@;data source=DataAss.mssql.somee.com;persist security info=False;initial catalog=DataAss"
    Private Sub quanlysanphamfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm', Ten_SP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', Chitiet_SP as 'Chi tiết sản phẩm', Loai_san_pham_Maloai as 'Mã loại sản phẩm' from San_pham", KetNoi)
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        view.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub view_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles view.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = view.CurrentCell.RowIndex
        masptxt.Text = view.Item(0, index).Value
        tensptxt.Text = view.Item(1, index).Value
        loaitxt.Text = view.Item(5, index).Value
        giatxt.Text = view.Item(2, index).Value
        soluongtxt.Text = view.Item(3, index).Value
        txtchitiet.Text = view.Item(4, index).Value
    End Sub
    Private Sub thoatbtn_Click(sender As Object, e As EventArgs) Handles thoatbtn.Click
        If MessageBox.Show("Bạn có muốn thoát không", "Thông báo", _
                    MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub suabtn_Click(sender As Object, e As EventArgs) Handles suabtn.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE San_pham SET Ten_SP = @Ten_SP,  Dongia = @Dongia, Soluong = @Soluong, Chitiet_SP = @Chitiet_SP, Loai_san_pham_Maloai = @Loai_san_pham_Maloai where Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", masptxt.Text)
            com.Parameters.AddWithValue("@Ten_SP", tensptxt.Text)
            com.Parameters.AddWithValue("@Loai_san_pham_Maloai", loaitxt.Text)
            com.Parameters.AddWithValue("@Dongia", giatxt.Text)
            com.Parameters.AddWithValue("@Soluong", soluongtxt.Text)
            com.Parameters.AddWithValue("@Chitiet_SP", txtchitiet.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi! Nhập sai kiểu kí tự.")
        End Try
        tb.Clear()
        view.DataSource = tb
        view.DataSource = Nothing
        refresh_sql()
    End Sub

    Private Sub xoabtn_Click(sender As Object, e As EventArgs) Handles xoabtn.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  San_pham where Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", masptxt.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        view.DataSource = tb
        view.DataSource = Nothing
        refresh_sql()
    End Sub

    Private Sub thembtn_Click(sender As Object, e As EventArgs) Handles thembtn.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into San_pham (Ma_SP,Ten_SP,Dongia,Soluong,Chitiet_SP,Loai_san_pham_Maloai) values('" & masptxt.Text & "','" & tensptxt.Text & "' ,'" & giatxt.Text & "','" & soluongtxt.Text & "','" & txtchitiet.Text & "','" & loaitxt.Text & "')"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        view.DataSource = tb
        view.DataSource = Nothing
        refresh_sql()
    End Sub
    Private Sub refresh_sql()
        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select Ma_SP as 'Mã sản phẩm', Ten_SP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', Chitiet_SP as 'Chi tiết sản phẩm', Loai_san_pham_Maloai as 'Mã loại sản phẩm' from San_pham", KetNoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        view.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        masptxt.Text = ""
        tensptxt.Text = ""
        loaitxt.Text = ""
        giatxt.Text = ""
        soluongtxt.Text = ""
        txtchitiet.Text = ""
    End Sub
End Class