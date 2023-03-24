Public Class FmCompetidor
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim bandera As Boolean
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub FmCompetidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        CargarDatos("SELECT isnull(COM_MARCA1,''), isnull(COM_MODELO1,''), isnull(COM_COMENTARIO1,''),isnull(COM_MARCA2,''), isnull(COM_MODELO2,''), isnull(COM_COMENTARIO2,''),isnull(COM_MARCA3,''), isnull(COM_MODELO3,''), isnull(COM_COMENTARIO3,'') FROM CRM_COMPETIDOR WHERE COM_IDPROS ='" & Librerias.Id_Bus & "'")
    End Sub

    Public Sub Limpiar()
        txtcomentario1.Text = ""
        txtcomentario2.Text = ""
        txtcomentario3.Text = ""
        txtmarca1.Text = ""
        txtmarca2.Text = ""
        txtmarca3.Text = ""
        txtmodelo1.Text = ""
        txtmodelo2.Text = ""
        txtmodelo3.Text = ""
    End Sub

    Public Sub CargarDatos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtmarca1.Text = Conexion.dr.GetString(0)
            txtmodelo1.Text = Conexion.dr.GetString(1)
            txtcomentario1.Text = Conexion.dr.GetString(2)
            txtmarca2.Text = Conexion.dr.GetString(3)
            txtmodelo2.Text = Conexion.dr.GetString(4)
            txtcomentario2.Text = Conexion.dr.GetString(5)
            txtmarca3.Text = Conexion.dr.GetString(6)
            txtmodelo3.Text = Conexion.dr.GetString(7)
            txtcomentario3.Text = Conexion.dr.GetString(8)
            bandera = True
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (bandera = True) Then
            Conexion.conectarse()
            Dim Actualiza As String = "COM_MARCA1 ='" & txtmarca1.Text & "', COM_MODELO1 ='" & txtmodelo1.Text & "', COM_COMENTARIO1 ='" & txtcomentario1.Text & "', COM_MARCA2 ='" & txtmarca2.Text & "', COM_MODELO2 ='" & txtmodelo2.Text & "', COM_COMENTARIO2 ='" & txtcomentario2.Text & "', COM_MARCA3 ='" & txtmarca3.Text & "', COM_MODELO3 ='" & txtmodelo3.Text & "', COM_COMENTARIO3 ='" & txtcomentario3.Text & "', COM_FECACT = '" & DateTime.Today & "', COM_HRACT = '" & Now.ToString("HH:MM") & "', COM_IDUSU ='" & IdUsu & "', COM_PERMISOUSU = '" & Permiso & "', COM_PRIVISITA = '" & chkboxvisita.Checked & "'"
            If Conexion.Actualizar("CRM_COMPETIDOR", Actualiza, "COM_IDPROS = '" & Id_Bus & "'") Then
                MsgBox("Competidor actualizado correctamente")
                Limpiar()
                Permisos()
                Me.Close()
            Else
                MsgBox("Error al actualizar el registro")
            End If
            Conexion.desconectarse()
        Else
            Conexion.conectarse()
            Dim Guardar As String = "INSERT INTO CRM_COMPETIDOR VALUES('" & Id_Bus & "','" & txtmarca1.Text & "','" & txtmodelo1.Text & "','" & txtcomentario1.Text & "','" & txtmarca2.Text & "','" & txtmodelo2.Text & "','" & txtcomentario2.Text & "','" & txtmarca3.Text & "','" & txtmodelo3.Text & "','" & txtcomentario3.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "','" & chkboxvisita.Checked & "')"
            If Conexion.Insertar(Guardar) Then
                MsgBox("Se ha ingresado correctamente el competidor")
                Limpiar()
                Permisos()
                Me.Close()
            Else
                MsgBox("Error al intentar guardar el registro")
            End If
            Conexion.desconectarse()
        End If
    End Sub

    Public Sub Permisos()
        Select Case Permiso
            Case 8
                FmSeguimientoEnt.Mostrar_Datos()
            Case 7
                FmSeguimientoAux.Mostrar_Datos()
            Case 6
                FmSeguimientoBDC.Mostrar_Datos()
            Case 5
                FmSeguimientoVal.Mostrar_Datos()
            Case 4
                FmSeguimientoFI.Mostrar_Datos()
            Case 2
                FmSeguimientoVend.Mostrar_Datos()
            Case 1
                FmSeguimientoGTES.Mostrar_Datos()
            Case 0
                FmSeguimiento.Mostrar_Datos()
        End Select
    End Sub

End Class