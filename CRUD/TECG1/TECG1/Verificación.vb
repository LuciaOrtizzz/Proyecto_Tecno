Imports System.Data.SqlClient
Public Class Verificación
    Public conexion As SqlConnection = New SqlConnection(My.Settings.connect)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
    Function Verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
