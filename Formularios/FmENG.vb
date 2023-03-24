Public Class FmENG
    Dim Conexion As Conexion_Dr = New Conexion_Dr()

    Private Sub FmEnganche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        lblfecha.Text = DateTime.Today
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'ENGAN' and PAR_STATUS = 'ACTIVO'", cmbesteng)
        Cargar_Datos("SELECT isnull(ENG_ENG,''),isnull(ENG_FECHA,''), isnull(ENG_ESTATUS,'') FROM CRM_ENG WHERE ENG_IDPROS ='" & Librerias.Id_Bus & "'")
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnguardar.Click
        If (cmbesteng.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT * FROM CRM_ENG WHERE ENG_IDPROS = '" & Id_Bus & "'")
            If (Conexion.dr.HasRows) Then
                Conexion.dr.Close()
                Dim Actualiza As String = "ENG_ENG = '" & mtbeng.Text & "' " & ", ENG_ESTATUS = '" & cmbesteng.Text & "' " & ", ENG_FECHA = '" & lblfecha.Text & "' " & ", ENG_IDUSU = '" & IdUsu & "', ENG_FECACT = '" & DateTime.Today & "', ENG_HRACT = '" & Now.ToString("HH:MM") & "'"
                If Conexion.Actualizar("CRM_ENG", Actualiza, "ENG_IDPROS = '" & Id_Bus & "'") Then
                    MsgBox("Datos del Enganche actualizados correctamente")
                    Limpiar()
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al actualizar el registro")
                End If
                Conexion.desconectarse()
            Else
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_ENG VALUES('" & Id_Bus & "','" & mtbeng.Text & "','" & DateTime.Today & "','" & cmbesteng.Text & "','" & IdUsu & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "')"
                If Conexion.Insertar(Guardar) Then
                    MsgBox("Se ha ingresado correctamente los datos del enganche")
                    Limpiar()
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al intentar guardar el registro")
                End If
                Conexion.desconectarse()
            End If
        End If
    End Sub

    Public Sub Limpiar()
        cmbesteng.Text = ""
        lblfecha.Text = ""
        mtbeng.Text = ""
    End Sub

    Public Sub Cargar_Datos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            mtbeng.Text = Conexion.dr.GetString(0)
            lblfecha.Text = Conexion.dr.GetDateTime(1)
            cmbesteng.Text = Conexion.dr.GetString(2)
            Conexion.dr.Close()
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
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