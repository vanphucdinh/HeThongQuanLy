<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlysanphamfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quanlysanphamfrm))
        Me.masplb = New System.Windows.Forms.Label()
        Me.tensplb = New System.Windows.Forms.Label()
        Me.loailb = New System.Windows.Forms.Label()
        Me.masptxt = New System.Windows.Forms.TextBox()
        Me.tensptxt = New System.Windows.Forms.TextBox()
        Me.giatxt = New System.Windows.Forms.TextBox()
        Me.gialb = New System.Windows.Forms.Label()
        Me.soluonglb = New System.Windows.Forms.Label()
        Me.loaitxt = New System.Windows.Forms.TextBox()
        Me.soluongtxt = New System.Windows.Forms.TextBox()
        Me.chitietlb = New System.Windows.Forms.Label()
        Me.view = New System.Windows.Forms.DataGridView()
        Me.thembtn = New System.Windows.Forms.Button()
        Me.suabtn = New System.Windows.Forms.Button()
        Me.xoabtn = New System.Windows.Forms.Button()
        Me.thoatbtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtchitiet = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'masplb
        '
        Me.masplb.AutoSize = True
        Me.masplb.Location = New System.Drawing.Point(26, 23)
        Me.masplb.Name = "masplb"
        Me.masplb.Size = New System.Drawing.Size(74, 13)
        Me.masplb.TabIndex = 0
        Me.masplb.Text = "Mã sản phẩm:"
        '
        'tensplb
        '
        Me.tensplb.AutoSize = True
        Me.tensplb.Location = New System.Drawing.Point(22, 55)
        Me.tensplb.Name = "tensplb"
        Me.tensplb.Size = New System.Drawing.Size(78, 13)
        Me.tensplb.TabIndex = 0
        Me.tensplb.Text = "Tên sản phẩm:"
        '
        'loailb
        '
        Me.loailb.AutoSize = True
        Me.loailb.Location = New System.Drawing.Point(21, 87)
        Me.loailb.Name = "loailb"
        Me.loailb.Size = New System.Drawing.Size(79, 13)
        Me.loailb.TabIndex = 0
        Me.loailb.Text = "Loại sản phẩm:"
        '
        'masptxt
        '
        Me.masptxt.Location = New System.Drawing.Point(124, 20)
        Me.masptxt.Name = "masptxt"
        Me.masptxt.Size = New System.Drawing.Size(326, 20)
        Me.masptxt.TabIndex = 0
        '
        'tensptxt
        '
        Me.tensptxt.Location = New System.Drawing.Point(124, 52)
        Me.tensptxt.Name = "tensptxt"
        Me.tensptxt.Size = New System.Drawing.Size(326, 20)
        Me.tensptxt.TabIndex = 1
        '
        'giatxt
        '
        Me.giatxt.Location = New System.Drawing.Point(124, 116)
        Me.giatxt.Name = "giatxt"
        Me.giatxt.Size = New System.Drawing.Size(326, 20)
        Me.giatxt.TabIndex = 3
        '
        'gialb
        '
        Me.gialb.AutoSize = True
        Me.gialb.Cursor = System.Windows.Forms.Cursors.Default
        Me.gialb.Location = New System.Drawing.Point(53, 119)
        Me.gialb.Name = "gialb"
        Me.gialb.Size = New System.Drawing.Size(47, 13)
        Me.gialb.TabIndex = 3
        Me.gialb.Text = "Đơn giá:"
        '
        'soluonglb
        '
        Me.soluonglb.AutoSize = True
        Me.soluonglb.Location = New System.Drawing.Point(48, 151)
        Me.soluonglb.Name = "soluonglb"
        Me.soluonglb.Size = New System.Drawing.Size(52, 13)
        Me.soluonglb.TabIndex = 4
        Me.soluonglb.Text = "Số lượng:"
        '
        'loaitxt
        '
        Me.loaitxt.Location = New System.Drawing.Point(124, 84)
        Me.loaitxt.Name = "loaitxt"
        Me.loaitxt.Size = New System.Drawing.Size(326, 20)
        Me.loaitxt.TabIndex = 2
        '
        'soluongtxt
        '
        Me.soluongtxt.Location = New System.Drawing.Point(124, 148)
        Me.soluongtxt.Name = "soluongtxt"
        Me.soluongtxt.Size = New System.Drawing.Size(326, 20)
        Me.soluongtxt.TabIndex = 4
        '
        'chitietlb
        '
        Me.chitietlb.AutoSize = True
        Me.chitietlb.Location = New System.Drawing.Point(9, 183)
        Me.chitietlb.Name = "chitietlb"
        Me.chitietlb.Size = New System.Drawing.Size(91, 13)
        Me.chitietlb.TabIndex = 4
        Me.chitietlb.Text = "Chi tiết sản phẩm:"
        '
        'view
        '
        Me.view.AllowDrop = True
        Me.view.AllowUserToOrderColumns = True
        Me.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.view.Location = New System.Drawing.Point(21, 237)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(750, 161)
        Me.view.TabIndex = 10
        '
        'thembtn
        '
        Me.thembtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.thembtn.Location = New System.Drawing.Point(497, 181)
        Me.thembtn.Name = "thembtn"
        Me.thembtn.Size = New System.Drawing.Size(50, 40)
        Me.thembtn.TabIndex = 6
        Me.thembtn.Text = "Thêm"
        Me.thembtn.UseVisualStyleBackColor = True
        '
        'suabtn
        '
        Me.suabtn.Location = New System.Drawing.Point(553, 181)
        Me.suabtn.Name = "suabtn"
        Me.suabtn.Size = New System.Drawing.Size(50, 40)
        Me.suabtn.TabIndex = 7
        Me.suabtn.Text = "Sửa"
        Me.suabtn.UseVisualStyleBackColor = True
        '
        'xoabtn
        '
        Me.xoabtn.Location = New System.Drawing.Point(609, 181)
        Me.xoabtn.Name = "xoabtn"
        Me.xoabtn.Size = New System.Drawing.Size(50, 40)
        Me.xoabtn.TabIndex = 8
        Me.xoabtn.Text = "Xóa"
        Me.xoabtn.UseVisualStyleBackColor = True
        '
        'thoatbtn
        '
        Me.thoatbtn.Location = New System.Drawing.Point(721, 181)
        Me.thoatbtn.Name = "thoatbtn"
        Me.thoatbtn.Size = New System.Drawing.Size(50, 40)
        Me.thoatbtn.TabIndex = 9
        Me.thoatbtn.Text = "Thoát"
        Me.thoatbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtchitiet)
        Me.GroupBox1.Controls.Add(Me.chitietlb)
        Me.GroupBox1.Controls.Add(Me.soluonglb)
        Me.GroupBox1.Controls.Add(Me.gialb)
        Me.GroupBox1.Controls.Add(Me.soluongtxt)
        Me.GroupBox1.Controls.Add(Me.loaitxt)
        Me.GroupBox1.Controls.Add(Me.giatxt)
        Me.GroupBox1.Controls.Add(Me.tensptxt)
        Me.GroupBox1.Controls.Add(Me.masptxt)
        Me.GroupBox1.Controls.Add(Me.loailb)
        Me.GroupBox1.Controls.Add(Me.tensplb)
        Me.GroupBox1.Controls.Add(Me.masplb)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 214)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtchitiet
        '
        Me.txtchitiet.Location = New System.Drawing.Point(125, 180)
        Me.txtchitiet.Multiline = True
        Me.txtchitiet.Name = "txtchitiet"
        Me.txtchitiet.Size = New System.Drawing.Size(325, 20)
        Me.txtchitiet.TabIndex = 5
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(665, 181)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(50, 40)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Làm mới"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HeThongQuanLy.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(497, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'quanlysanphamfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.thoatbtn)
        Me.Controls.Add(Me.xoabtn)
        Me.Controls.Add(Me.suabtn)
        Me.Controls.Add(Me.thembtn)
        Me.Controls.Add(Me.view)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "quanlysanphamfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sản phẩm"
        CType(Me.view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents masplb As System.Windows.Forms.Label
    Friend WithEvents tensplb As System.Windows.Forms.Label
    Friend WithEvents loailb As System.Windows.Forms.Label
    Friend WithEvents masptxt As System.Windows.Forms.TextBox
    Friend WithEvents tensptxt As System.Windows.Forms.TextBox
    Friend WithEvents giatxt As System.Windows.Forms.TextBox
    Friend WithEvents gialb As System.Windows.Forms.Label
    Friend WithEvents soluonglb As System.Windows.Forms.Label
    Friend WithEvents loaitxt As System.Windows.Forms.TextBox
    Friend WithEvents soluongtxt As System.Windows.Forms.TextBox
    Friend WithEvents chitietlb As System.Windows.Forms.Label
    Friend WithEvents view As System.Windows.Forms.DataGridView
    Friend WithEvents thembtn As System.Windows.Forms.Button
    Friend WithEvents suabtn As System.Windows.Forms.Button
    Friend WithEvents xoabtn As System.Windows.Forms.Button
    Friend WithEvents thoatbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtchitiet As System.Windows.Forms.TextBox
End Class
