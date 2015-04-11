Imports System.Data.SqlClient

Public Class frmnhaploaisanpham
    Dim tb As New DataTable
    Dim connect As String = "workstation id=DataAss.mssql.somee.com;packet size=4096;user id=dinh_asm;pwd=1234abc@;data source=DataAss.mssql.somee.com;persist security info=False;initial catalog=DataAss"

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If MessageBox.Show("Bạn có muốn thoát không", "Thông báo", _
                   MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Loai_san_pham (Maloai,Tenloai) values('" & txtmaloai.Text & "','" & txttenloai.Text & "')"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            MessageBox.Show("Nhập thành công")
            txtmaloai.Clear()
            txttenloai.Clear()
        Catch ex As Exception

        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        refresh_sql()
    End Sub

    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = DataView.CurrentCell.RowIndex
        txtmaloai.Text = DataView.Item(0, index).Value
        txttenloai.Text = DataView.Item(1, index).Value
    End Sub

    Private Sub frmnhaploaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As New SqlConnection(connect)
        Dim sql As New SqlDataAdapter("select Maloai as 'Mã loại', tenloai as 'Tên loại' from Loai_san_pham", ketnoi)
        Try
            ketnoi.Open()
            sql.Fill(tb)
        Catch ex As Exception

        End Try
        DataView.DataSource = tb
        ketnoi.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Loai_san_pham SET Tenloai = @Tenloai where Maloai = @Maloai"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Maloai", txtmaloai.Text)
            com.Parameters.AddWithValue("@Tenloai", txttenloai.Text)

            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        refresh_sql()
    End Sub
    Private Sub refresh_sql()
        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select Maloai as 'Mã loại', tenloai as 'Tên loại' from Loai_san_pham", KetNoi)
        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataView.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Loai_san_pham where Maloai = @Maloai"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@Maloai", txtmaloai.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        refresh_sql()
        txtmaloai.Text = ""
        txttenloai.Text = ""
    End Sub
End Class