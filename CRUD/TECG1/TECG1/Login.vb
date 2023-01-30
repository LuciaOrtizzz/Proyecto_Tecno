Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Login
    Dim con As SqlConnection = New SqlConnection(My.Settings.connect)
    Dim verificacion As Verificación = New Verificación
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim fn = Form1
        Dim verificar As String = "update Ingreso set Rol=Rol where Usuario='" + Txt_Name.Text + "' and Contraseña='" + Txt_password.Text + "' and Rol='ADMINISTRADOR'"
        Dim verificar2 As String = "update Ingreso set Rol=Rol where Usuario='" + Txt_Name.Text + "' and contraseña='" + Txt_password.Text + "' and Rol='USUARIO'"
        Dim verificar3 As String = "update Ingreso set Rol=Rol where Usuario='" + Txt_Name.Text + "' and Contraseña='" + Txt_password.Text + "' and Rol='SECRETARIA'"

        If verificacion.Verificacion(verificar) Then
            Me.Hide()
            Form1.Show()
            fn.lbl_secretary.Visible = False
        ElseIf verificacion.Verificacion(verificar2) Then
            Me.Hide()
            Form1.Show()
            fn.txt_apellidos.Visible = False
            fn.txt_correo.Visible = False
            fn.txt_edad.Visible = False
            fn.txt_nombres.Visible = False
            fn.GunaLabel1.Visible = False
            fn.GunaLabel2.Visible = False
            fn.GunaLabel3.Visible = False
            fn.GunaLabel4.Visible = False
            fn.GunaLabel5.Visible = False
            fn.GunaLabel6.Visible = False
            fn.lbl_secretary.Visible = False
            fn.btn_eliminar.Visible = False
            fn.Btn_guardar.Visible = False
            fn.btn_actualizar.Visible = False
        ElseIf verificacion.Verificacion(verificar3) Then
            Me.Hide()
            Form1.Show()
            fn.btn_buscar.Location = New Point(420, 318)
            fn.GunaButton1.Location = New Point(310, 360)
            fn.lbl_secretary.Visible = False
            fn.btn_eliminar.Visible = False
            fn.btn_actualizar.Visible = False
        Else
            MsgBox("Error")
        End If
    End Sub
End Class