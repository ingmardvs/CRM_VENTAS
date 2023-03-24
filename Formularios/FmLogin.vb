Public Class FmLogin
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim Actualiza As String
    Dim Guardar, nombre, pat, mat As String
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Login()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtcon_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtcon.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If

    End Sub

    Public Sub Login()
        Conexion.Consultar("SELECT USU_PERMISO FROM CRM_USUARIOS WHERE USU_IDUSU = '" & txtusu.Text & "' AND USU_CONTRASEÑA = '" & txtcon.Text & "'")
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Read()
            Permiso = Conexion.dr.GetString(0)
            IdUsu = txtusu.Text
            Conexion.dr.Close()
            Conexion.desconectarse()
            If Permiso = "2" Then
                Conexion.Consultar("SELECT USU_NOMBRE, USU_PATERNO, USU_MATERNO FROM CRM_USUARIOS WHERE USU_IDUSU = '" & txtusu.Text & "' AND USU_CONTRASEÑA = '" & txtcon.Text & "'")
                Conexion.dr.Read()
                nombre = Conexion.dr.GetString(0)
                pat = Conexion.dr.GetString(1)
                mat = Conexion.dr.GetString(2)
                Conexion.dr.Close()
                Conexion.desconectarse()

                Conexion.Consultar("Select VEND_ID from CRM_VENDEDORES where VEND_NOMBRE = '" & nombre & "' AND VEND_PATERNO = '" & pat & "' AND VEND_MATERNO = '" & mat & "'")
                Conexion.dr.Read()
                Vendedor = Conexion.dr.GetInt32(0)
                Conexion.dr.Close()
                Conexion.desconectarse()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
            FmMenu_Principal.Show()
            Me.Hide()
        Else
            MsgBox("No se han introducido los datos correctamente.")
        End If
        Conexion.desconectarse()
    End Sub

End Class