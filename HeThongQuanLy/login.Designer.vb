<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.xoabt = New System.Windows.Forms.Button()
        Me.thoatbt = New System.Windows.Forms.Button()
        Me.dangnhapbt = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(97, 26)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(197, 20)
        Me.usertxt.TabIndex = 0
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(97, 58)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(197, 20)
        Me.passtxt.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.passtxt)
        Me.GroupBox1.Controls.Add(Me.usertxt)
        Me.GroupBox1.Controls.Add(Me.xoabt)
        Me.GroupBox1.Controls.Add(Me.thoatbt)
        Me.GroupBox1.Controls.Add(Me.dangnhapbt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 150)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'xoabt
        '
        Me.xoabt.ForeColor = System.Drawing.Color.Blue
        Me.xoabt.Image = Global.HeThongQuanLy.My.Resources.Resources.icon_reset
        Me.xoabt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xoabt.Location = New System.Drawing.Point(182, 97)
        Me.xoabt.Name = "xoabt"
        Me.xoabt.Size = New System.Drawing.Size(45, 30)
        Me.xoabt.TabIndex = 3
        Me.xoabt.Text = "Xóa"
        Me.xoabt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.xoabt.UseVisualStyleBackColor = True
        '
        'thoatbt
        '
        Me.thoatbt.ForeColor = System.Drawing.Color.Red
        Me.thoatbt.Image = Global.HeThongQuanLy.My.Resources.Resources.icon_exit
        Me.thoatbt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.thoatbt.Location = New System.Drawing.Point(233, 97)
        Me.thoatbt.Name = "thoatbt"
        Me.thoatbt.Size = New System.Drawing.Size(61, 30)
        Me.thoatbt.TabIndex = 4
        Me.thoatbt.Text = "Thoát"
        Me.thoatbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.thoatbt.UseVisualStyleBackColor = True
        '
        'dangnhapbt
        '
        Me.dangnhapbt.BackColor = System.Drawing.SystemColors.Control
        Me.dangnhapbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dangnhapbt.ForeColor = System.Drawing.Color.SeaGreen
        Me.dangnhapbt.Image = Global.HeThongQuanLy.My.Resources.Resources.icon_sign
        Me.dangnhapbt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dangnhapbt.Location = New System.Drawing.Point(89, 97)
        Me.dangnhapbt.Name = "dangnhapbt"
        Me.dangnhapbt.Size = New System.Drawing.Size(87, 30)
        Me.dangnhapbt.TabIndex = 2
        Me.dangnhapbt.Text = "Đăng Nhập"
        Me.dangnhapbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dangnhapbt.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HeThongQuanLy.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(321, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 169)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dangnhapbt As System.Windows.Forms.Button
    Friend WithEvents thoatbt As System.Windows.Forms.Button
    Friend WithEvents xoabt As System.Windows.Forms.Button
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
