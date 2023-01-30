Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection = New SqlConnection(My.Settings.connect)
    Dim sentencia, mensaje As String
    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "Update Informacion set Nombre='" + txt_nombres.Text + "', Apellidos='" + txt_apellidos.Text + "', Correo='" + txt_correo.Text + "', Edad= '" + txt_edad.Text + "' where Usuario='" + txt_usuario.Text + "' "
        mensaje = "Data updated successfully"
        EjecutarSql(sentencia, mensaje)
        'Evalución de campos nulos'
        Try
            If txt_apellidos.Text <> "" And txt_correo.Text <> "" And txt_edad.Text <> "" And txt_nombres.Text <> "" And txt_usuario.Text <> "" Then
                'Mostrar datos en DGV'
                Dim da As New SqlDataAdapter("select * from Informacion", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Me.DataGridView1.DataSource = ds.Tables(0)
                txt_apellidos.Text = ""
                txt_correo.Text = ""
                txt_edad.Text = ""
                txt_nombres.Text = ""
                txt_usuario.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete Informacion where Usuario='" + txt_usuario.Text + "'"
        mensaje = "Data deleted successfully"
        EjecutarSql(sentencia, mensaje)
        If txt_usuario.Text <> "" Then
            Try
                If txt_usuario.Text <> "" Then
                    'Mostrar datos en DGV'
                    Dim da As New SqlDataAdapter("select * from Informacion", con)
                    Dim ds As New DataSet
                    da.Fill(ds)
                    Me.DataGridView1.DataSource = ds.Tables(0)
                    txt_apellidos.Text = ""
                    txt_correo.Text = ""
                    txt_edad.Text = ""
                    txt_nombres.Text = ""
                    txt_usuario.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("ERROR, CAMPOS VACIOS", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_usuario.Text <> "" Then
            Dim da As New SqlDataAdapter("Select * from Informacion Where Usuario='" + txt_usuario.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
            txt_apellidos.Text = ""
            txt_correo.Text = ""
            txt_edad.Text = ""
            txt_nombres.Text = ""
            txt_usuario.Text = ""
        Else
            MsgBox("ERROR, CAMPOS VACIOS", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim da As New SqlDataAdapter("select * from Informacion", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        sentencia = "Insert into Informacion values('" + txt_usuario.Text + "','" + txt_nombres.Text + "','" + txt_apellidos.Text + "','" + txt_correo.Text + "'," + txt_edad.Text + ")"
        mensaje = "Data inserted correctly"
        EjecutarSql(sentencia, mensaje)

        Try
            If txt_apellidos.Text <> "" And txt_correo.Text <> "" And txt_edad.Text <> "" And txt_nombres.Text <> "" And txt_usuario.Text <> "" Then
                'Mostrar datos en DGV'
                Dim da As New SqlDataAdapter("select * from Informacion", con)
                Dim ds As New DataSet
                da.Fill(ds)
                Me.DataGridView1.DataSource = ds.Tables(0)
                'Limpiar textbox'
                txt_apellidos.Text = ""
                txt_correo.Text = ""
                txt_edad.Text = ""
                txt_nombres.Text = ""
                txt_usuario.Text = ""
            Else
                MsgBox("ERROR, VERIFIQUE LOS DATOS", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
