Public Class FmEC
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim bandera As Boolean
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub FmCompetidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'EC' and PAR_STATUS = 'ACTIVO'", cmbestec)
        CargarDatos("SELECT isnull(EC_ESTATUS,''), isnull(EC_COMENTARIO,'') FROM CRM_EC WHERE EC_IDPROS ='" & Librerias.Id_Bus & "'")
    End Sub

    Public Sub Limpiar()
        cmbestec.Text = ""
        cmbestec.Items.Clear()
        txtcomentario.Text = ""
    End Sub

    Public Sub CargarDatos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            cmbestec.Text = Conexion.dr.GetString(0)
            txtcomentario.Text = Conexion.dr.GetString(1)
            bandera = True
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (bandera = True) Then
            Conexion.conectarse()
            Dim Actualiza As String = "EC_IDPROS = '" & Id_Bus & "', EC_ESTATUS = '" & cmbestec.Text & "',  EC_COMENTARIO1 ='" & txtcomentario.Text & "', EC_FECACT = '" & DateTime.Today & "', EC_HRACT ='" & Now.ToString("HH:MM") & "', EC_IDUSU = '" & IdUsu & "', EC_PERMISOUSU='" & Permiso & "'"
            If Conexion.Actualizar("CRM_EC", Actualiza, "EC_IDPROS = '" & Id_Bus & "'") Then
                MsgBox("Estatus del Credito actualizado correctamente")
                Limpiar()
                Permisos()
                Me.Close()
            Else
                MsgBox("Error al actualizar el registro")
            End If
            Conexion.desconectarse()
        Else
            Conexion.conectarse()
            Dim Guardar As String = "INSERT INTO CRM_EC VALUES('" & Id_Bus & "','" & cmbestec.Text & "','" & txtcomentario.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
            If Conexion.Insertar(Guardar) Then
                MsgBox("Se ha ingresado correctamente el estatus del credito")
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
            Case 9
                FmSeguimientoAcc.Mostrar_Datos()
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