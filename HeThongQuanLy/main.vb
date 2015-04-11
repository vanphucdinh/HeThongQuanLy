Imports System
Public Class main
    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hethongtmi.Click

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        If MessageBox.Show("Bạn có muốn thoát không", "Thông báo", _
                  MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub NhậpLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhậpLoạiSảnPhẩmToolStripMenuItem.Click

        frmnhaploaisanpham.Show()
    End Sub

    Private Sub QuảnLýKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKhoToolStripMenuItem.Click

        quanlysanphamfrm.Show()
    End Sub

    Private Sub Timer1_timer(sender As Object, e As EventArgs) Handles Timer1.Tick

        btntime.Text = DateTime.Now.Hour & ":" & DateTime.Now.Minute & ":" & DateTime.Now.Second
        lbngay.Text = "Ngày " & DateTime.Now.Day
        lbthang.Text = "Tháng " & DateTime.Now.Month
        lbnam.Text = "Năm " & DateTime.Now.Year
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Me.Close()
        frmlogin.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmabout.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label1.Text = Microsoft.VisualBasic.Right(Label1.Text, Len(Label1.Text) - 1) & Microsoft.VisualBasic.Left(Label1.Text, 1)
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Space(160) & "Welcome to management software!"
    End Sub
End Class