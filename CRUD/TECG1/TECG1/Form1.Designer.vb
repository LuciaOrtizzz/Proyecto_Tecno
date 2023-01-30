<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_nombres = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_apellidos = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_usuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_correo = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_edad = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_secretary = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btn_buscar = New Guna.UI.WinForms.GunaButton()
        Me.btn_eliminar = New Guna.UI.WinForms.GunaButton()
        Me.btn_actualizar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_guardar = New Guna.UI.WinForms.GunaButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(254, 419)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_nombres
        '
        Me.txt_nombres.BaseColor = System.Drawing.Color.White
        Me.txt_nombres.BorderColor = System.Drawing.Color.Silver
        Me.txt_nombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nombres.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_nombres.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nombres.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_nombres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nombres.Location = New System.Drawing.Point(296, 80)
        Me.txt_nombres.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nombres.Size = New System.Drawing.Size(234, 26)
        Me.txt_nombres.TabIndex = 1
        '
        'txt_apellidos
        '
        Me.txt_apellidos.BaseColor = System.Drawing.Color.White
        Me.txt_apellidos.BorderColor = System.Drawing.Color.Silver
        Me.txt_apellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_apellidos.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_apellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_apellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_apellidos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_apellidos.Location = New System.Drawing.Point(296, 131)
        Me.txt_apellidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_apellidos.Size = New System.Drawing.Size(234, 26)
        Me.txt_apellidos.TabIndex = 2
        '
        'txt_usuario
        '
        Me.txt_usuario.BaseColor = System.Drawing.Color.White
        Me.txt_usuario.BorderColor = System.Drawing.Color.Silver
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_usuario.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_usuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_usuario.Location = New System.Drawing.Point(296, 181)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.Size = New System.Drawing.Size(234, 26)
        Me.txt_usuario.TabIndex = 3
        '
        'txt_correo
        '
        Me.txt_correo.BaseColor = System.Drawing.Color.White
        Me.txt_correo.BorderColor = System.Drawing.Color.Silver
        Me.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_correo.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_correo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_correo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_correo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_correo.Location = New System.Drawing.Point(296, 227)
        Me.txt_correo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_correo.Size = New System.Drawing.Size(234, 26)
        Me.txt_correo.TabIndex = 4
        '
        'txt_edad
        '
        Me.txt_edad.BaseColor = System.Drawing.Color.White
        Me.txt_edad.BorderColor = System.Drawing.Color.Silver
        Me.txt_edad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_edad.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_edad.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_edad.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_edad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_edad.Location = New System.Drawing.Point(296, 274)
        Me.txt_edad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_edad.Size = New System.Drawing.Size(234, 26)
        Me.txt_edad.TabIndex = 5
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(296, 62)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(42, 18)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Names:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(296, 112)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(60, 18)
        Me.GunaLabel2.TabIndex = 7
        Me.GunaLabel2.Text = "Surnames:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(296, 162)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(59, 18)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Username:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(298, 210)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(42, 18)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "E-mail:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Bebas Neue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(296, 255)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(28, 18)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Age:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(354, 31)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(171, 31)
        Me.GunaLabel6.TabIndex = 15
        Me.GunaLabel6.Text = "management"
        '
        'lbl_secretary
        '
        Me.lbl_secretary.AutoSize = True
        Me.lbl_secretary.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secretary.Location = New System.Drawing.Point(363, 31)
        Me.lbl_secretary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_secretary.Name = "lbl_secretary"
        Me.lbl_secretary.Size = New System.Drawing.Size(131, 31)
        Me.lbl_secretary.TabIndex = 17
        Me.lbl_secretary.Text = "Secretary"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.LemonChiffon
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.7!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Global.TECG1.My.Resources.Resources.eye
        Me.GunaButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaButton1.Location = New System.Drawing.Point(310, 396)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(100, 34)
        Me.GunaButton1.TabIndex = 16
        Me.GunaButton1.Text = "show"
        '
        'btn_buscar
        '
        Me.btn_buscar.AnimationHoverSpeed = 0.07!
        Me.btn_buscar.AnimationSpeed = 0.03!
        Me.btn_buscar.BaseColor = System.Drawing.Color.LemonChiffon
        Me.btn_buscar.BorderColor = System.Drawing.Color.Black
        Me.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_buscar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_buscar.ForeColor = System.Drawing.Color.Black
        Me.btn_buscar.Image = Global.TECG1.My.Resources.Resources.lupa__1_
        Me.btn_buscar.ImageSize = New System.Drawing.Size(28, 28)
        Me.btn_buscar.Location = New System.Drawing.Point(415, 358)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_buscar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_buscar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_buscar.OnHoverImage = Nothing
        Me.btn_buscar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_buscar.Size = New System.Drawing.Size(100, 34)
        Me.btn_buscar.TabIndex = 14
        Me.btn_buscar.Text = "search"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.AnimationHoverSpeed = 0.07!
        Me.btn_eliminar.AnimationSpeed = 0.03!
        Me.btn_eliminar.BaseColor = System.Drawing.Color.LemonChiffon
        Me.btn_eliminar.BorderColor = System.Drawing.Color.Black
        Me.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_eliminar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Black
        Me.btn_eliminar.Image = Global.TECG1.My.Resources.Resources.delete
        Me.btn_eliminar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_eliminar.Location = New System.Drawing.Point(415, 318)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_eliminar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_eliminar.OnHoverImage = Nothing
        Me.btn_eliminar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_eliminar.Size = New System.Drawing.Size(100, 34)
        Me.btn_eliminar.TabIndex = 13
        Me.btn_eliminar.Text = "delete"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.AnimationHoverSpeed = 0.07!
        Me.btn_actualizar.AnimationSpeed = 0.03!
        Me.btn_actualizar.BaseColor = System.Drawing.Color.LemonChiffon
        Me.btn_actualizar.BorderColor = System.Drawing.Color.Black
        Me.btn_actualizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_actualizar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Black
        Me.btn_actualizar.Image = Global.TECG1.My.Resources.Resources.refresh
        Me.btn_actualizar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btn_actualizar.Location = New System.Drawing.Point(310, 358)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_actualizar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_actualizar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_actualizar.OnHoverImage = Nothing
        Me.btn_actualizar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_actualizar.Size = New System.Drawing.Size(100, 34)
        Me.btn_actualizar.TabIndex = 12
        Me.btn_actualizar.Text = "update"
        '
        'Btn_guardar
        '
        Me.Btn_guardar.AnimationHoverSpeed = 0.07!
        Me.Btn_guardar.AnimationSpeed = 0.03!
        Me.Btn_guardar.BaseColor = System.Drawing.Color.LemonChiffon
        Me.Btn_guardar.BorderColor = System.Drawing.Color.Black
        Me.Btn_guardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_guardar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_guardar.Image = Global.TECG1.My.Resources.Resources.expediente
        Me.Btn_guardar.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_guardar.Location = New System.Drawing.Point(310, 318)
        Me.Btn_guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_guardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_guardar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_guardar.OnHoverImage = Nothing
        Me.Btn_guardar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_guardar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_guardar.TabIndex = 11
        Me.Btn_guardar.Text = "save"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 461)
        Me.Controls.Add(Me.lbl_secretary)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btn_buscar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_eliminar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_actualizar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_guardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_edad As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_correo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_usuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_apellidos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_nombres As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents lbl_secretary As Guna.UI.WinForms.GunaLabel
End Class
