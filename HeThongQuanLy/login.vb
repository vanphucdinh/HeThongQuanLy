Imports System.Data.SqlClient
Imports System.IO
Public Class frmlogin

    Private Sub dangnhapbt_Click(sender As Object, e As EventArgs) Handles dangnhapbt.Click
        Dim chuoiketnoi As String = "workstation id=DataAss.mssql.somee.com;packet size=4096;user id=dinh_asm;pwd=1234abc@;data source=DataAss.mssql.somee.com;persist security info=False;initial catalog=DataAss"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where MaNV='" & usertxt.Text & _
                                             "' and password='" & passtxt.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Successfully!")
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong: Username or password")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub thoatbt_Click(sender As Object, e As EventArgs) Handles thoatbt.Click
        If MessageBox.Show("Bạn có muốn thoát không", "Thông báo", _
                        MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub xoabt_Click(sender As Object, e As EventArgs) Handles xoabt.Click
        usertxt.Text = ""
        passtxt.Text = ""
    End Sub

    Private Sub usertxt_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles usertxt.KeyDown
        If e.KeyCode = Keys.Enter Then dangnhapbt.PerformClick()
    End Sub
    Private Sub passtxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles passtxt.KeyDown
        If e.KeyCode = Keys.Enter Then dangnhapbt.PerformClick()
    End Sub
End Class
