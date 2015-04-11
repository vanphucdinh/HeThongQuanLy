<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnhaploaisanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmnhaploaisanpham))
        Me.lbmaloai = New System.Windows.Forms.Label()
        Me.lbtenloai = New System.Windows.Forms.Label()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnnhap = New System.Windows.Forms.Button()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbmaloai
        '
        Me.lbmaloai.AutoSize = True
        Me.lbmaloai.Location = New System.Drawing.Point(10, 21)
        Me.lbmaloai.Name = "lbmaloai"
        Me.lbmaloai.Size = New System.Drawing.Size(44, 13)
        Me.lbmaloai.TabIndex = 0
        Me.lbmaloai.Text = "Mã loại:"
        '
        'lbtenloai
        '
        Me.lbtenloai.AutoSize = True
        Me.lbtenloai.Location = New System.Drawing.Point(10, 54)
        Me.lbtenloai.Name = "lbtenloai"
        Me.lbtenloai.Size = New System.Drawing.Size(48, 13)
        Me.lbtenloai.TabIndex = 0
        Me.lbtenloai.Text = "Tên loại:"
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(70, 18)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(201, 20)
        Me.txtmaloai.TabIndex = 0
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(70, 51)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(201, 20)
        Me.txttenloai.TabIndex = 1
        '
        'DataView
        '
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(10, 149)
        Me.DataView.Name = "DataView"
        Me.DataView.Size = New System.Drawing.Size(280, 150)
        Me.DataView.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnthoat)
        Me.GroupBox1.Controls.Add(Me.btnnhap)
        Me.GroupBox1.Controls.Add(Me.txttenloai)
        Me.GroupBox1.Controls.Add(Me.txtmaloai)
        Me.GroupBox1.Controls.Add(Me.lbtenloai)
        Me.GroupBox1.Controls.Add(Me.lbmaloai)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 129)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnxoa
        '
        Me.btnxoa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnxoa.Image = Global.HeThongQuanLy.My.Resources.Resources.delete
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.Location = New System.Drawing.Point(145, 91)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(58, 25)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "  Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnsua.Image = Global.HeThongQuanLy.My.Resources.Resources.save
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.Location = New System.Drawing.Point(79, 91)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(59, 25)
        Me.btnsua.TabIndex = 4
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.ForeColor = System.Drawing.Color.Red
        Me.btnthoat.Image = Global.HeThongQuanLy.My.Resources.Resources._1428423238_exit
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthoat.Location = New System.Drawing.Point(210, 91)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(61, 25)
        Me.btnthoat.TabIndex = 3
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnnhap
        '
        Me.btnnhap.ForeColor = System.Drawing.Color.Green
        Me.btnnhap.Image = Global.HeThongQuanLy.My.Resources.Resources._1428422826_add2_
        Me.btnnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnhap.Location = New System.Drawing.Point(13, 91)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(59, 25)
        Me.btnnhap.TabIndex = 2
        Me.btnnhap.Text = "Nhập"
        Me.btnnhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'frmnhaploaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(315, 345)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(315, 345)
        Me.Name = "frmnhaploaisanpham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập loại sản phẩm"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbmaloai As System.Windows.Forms.Label
    Friend WithEvents lbtenloai As System.Windows.Forms.Label
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents btnnhap As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents DataView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
