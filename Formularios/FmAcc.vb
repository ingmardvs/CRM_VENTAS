Public Class FmAcc
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim bandera As Boolean
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub FmCompetidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        If Permiso = "2" Then
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'STVEN' and PAR_STATUS = 'ACTIVO'", cmbestacc)
            txtacc1.Enabled = False
            txtacc2.Enabled = False
            txtacc3.Enabled = False
            txtcomentario1.Enabled = False
            txtcomentario2.Enabled = False
            txtcomentario3.Enabled = False
            txtcosto1.Enabled = False
            txtcosto2.Enabled = False
            txtcosto3.Enabled = False
        Else
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'EST' and PAR_STATUS = 'ACTIVO'", cmbestacc)
        End If
        CargarDatos("SELECT isnull(ACC_ACC1,''), isnull(ACC_ACC2,''), isnull(ACC_ACC3,''),isnull(ACC_COSTO1,''), isnull(ACC_COSTO2,''), isnull(ACC_COSTO3,''),isnull(ACC_COMENTARIO1,''), isnull(ACC_COMENTARIO2,''), isnull(ACC_COMENTARIO3,''),isnull(ACC_ESTATUS,'') FROM CRM_ACCESORIOS WHERE ACC_PROSID ='" & Librerias.Id_Bus & "'")

    End Sub

    Public Sub Limpiar()
        cmbestacc.Text = ""
        cmbestacc.Items.Clear()
        txtcomentario1.Text = ""
        txtcomentario2.Text = ""
        txtcomentario3.Text = ""
        txtacc1.Text = ""
        txtacc2.Text = ""
        txtacc3.Text = ""
        txtcosto1.Text = ""
        txtcosto2.Text = ""
        txtcosto3.Text = ""
    End Sub

    Public Sub CargarDatos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtacc1.Text = Conexion.dr.GetString(0)
            txtacc2.Text = Conexion.dr.GetString(1)
            txtacc3.Text = Conexion.dr.GetString(2)
            txtcosto1.Text = Conexion.dr.GetString(3)
            txtcosto2.Text = Conexion.dr.GetString(4)
            txtcosto3.Text = Conexion.dr.GetString(5)
            txtcomentario1.Text = Conexion.dr.GetString(6)
            txtcomentario2.Text = Conexion.dr.GetString(7)
            txtcomentario3.Text = Conexion.dr.GetString(8)
            cmbestacc.Text = Conexion.dr.GetString(9)
            bandera = True
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (bandera = True) Then
            Conexion.conectarse()
            Dim Actualiza As String = "ACC_PROSID = '" & Id_Bus & "', ACC_ACC1 ='" & txtacc1.Text & "', ACC_ACC2 ='" & txtacc2.Text & "', ACC_ACC3 ='" & txtacc3.Text & "', ACC_COMENTARIO1 ='" & txtcomentario1.Text & "', ACC_COMENTARIO2 ='" & txtcomentario2.Text & "', ACC_COMENTARIO3 ='" & txtcomentario3.Text & "', ACC_FECACT = '" & DateTime.Today & "', ACC_HRACT = '" & Now.ToString("HH:MM") & "', ACC_IDUSU ='" & IdUsu & "', ACC_PERMISOUSU = '" & Permiso & "', ACC_COSTO1 ='" & txtcosto1.Text & "', ACC_COSTO2 ='" & txtcosto2.Text & "', ACC_COSTO3 ='" & txtcosto3.Text & "', ACC_ESTATUS = '" & cmbestacc.Text & "'"
            If Conexion.Actualizar("CRM_ACCESORIOS", Actualiza, "ACC_PROSID = '" & Id_Bus & "'") Then
                MsgBox("Accesorios actualizados correctamente")
                Limpiar()
                Permisos()
                Me.Close()
            Else
                MsgBox("Error al actualizar el registro")
            End If
            Conexion.desconectarse()
        Else
            Conexion.conectarse()
            Dim Guardar As String = "INSERT INTO CRM_ACCESORIOS VALUES('" & Id_Bus & "','" & txtacc1.Text & "','" & txtacc2.Text & "','" & txtacc3.Text & "','" & txtcomentario1.Text & "','" & txtcomentario2.Text & "','" & txtcomentario3.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "','" & txtcosto1.Text & "','" & txtcosto2.Text & "','" & txtcosto3.Text & "','" & cmbestacc.Text & "')"
            If Conexion.Insertar(Guardar) Then
                MsgBox("Se ha ingresado correctamente el accesorio")
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