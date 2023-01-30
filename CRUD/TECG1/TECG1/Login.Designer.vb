<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Txt_password = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Txt_Name = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(29, 189)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(70, 15)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Contraseña:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(29, 121)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Usuario:"
        '
        'Txt_password
        '
        Me.Txt_password.BackColor = System.Drawing.Color.White
        Me.Txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_password.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_password.LineColor = System.Drawing.Color.Gainsboro
        Me.Txt_password.Location = New System.Drawing.Point(29, 208)
        Me.Txt_password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_password.Size = New System.Drawing.Size(219, 30)
        Me.Txt_password.TabIndex = 8
        '
        'Txt_Name
        '
        Me.Txt_Name.BackColor = System.Drawing.Color.White
        Me.Txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Name.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_Name.LineColor = System.Drawing.Color.Gainsboro
        Me.Txt_Name.Location = New System.Drawing.Point(29, 143)
        Me.Txt_Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Name.Size = New System.Drawing.Size(219, 30)
        Me.Txt_Name.TabIndex = 7
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.LemonChiffon
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(95, 255)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Linen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(77, 34)
        Me.GunaButton1.TabIndex = 6
        Me.GunaButton1.Text = "Ingresar"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.TECG1.My.Resources.Resources._1
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(280, 92)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 11
        Me.GunaPictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 328)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Txt_password)
        Me.Controls.Add(Me.Txt_Name)
        Me.Controls.Add(Me.GunaButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Txt_password As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Txt_Name As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
