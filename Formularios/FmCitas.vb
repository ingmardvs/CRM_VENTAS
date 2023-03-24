Public Class FmCita
    Dim Conexion As Conexion_Dr = New Conexion_Dr()

    Private Sub FmCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbMedios.Items.Clear()
        CmbMotivos.Items.Clear()
        Conexion.LlenarCombo("Select PAR_DESCRIP1  from CRM_PARAMETR where PAR_TIPOPARA = 'MED' and PAR_STATUS = 'ACTIVO'", CmbMedios)
        Conexion.LlenarCombo("Select PAR_IDENPARA+' - '+PAR_DESCRIP1  from CRM_PARAMETR where PAR_TIPOPARA = 'ACTIV' and PAR_STATUS = 'ACTIVO'", CmbMotivos)
        Buscar()
        TxtFecCita.Focus()
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        ' FmCitasHist.Close()
    End Sub

    Private Sub Buscar()
        Conexion.Consultar("SELECT * FROM CRM_CITAS WHERE CIT_IDCITA = '" & TxtIdCita.Text & "'")
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            TxtStatus.Text = Conexion.dr.GetString(2)
            TxtFecCita.Text = Conexion.dr.GetDateTime(3)
            TxtHrCita.Text = Conexion.dr.GetString(4)
            CmbMotivos.Text = Conexion.dr.GetString(5)
            CmbMedios.Text = Conexion.dr.GetString(6)
            TxtComent.Text = Conexion.dr.GetString(7)
            'GpoDatos.Enabled = False
        Else
            Limpiar()
            TxtStatus.Text = "EN PROCESO"
            'GpoDatos.Enabled = True
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Private Sub Limpiar()
        TxtStatus.Text = ""
        TxtFecCita.Text = ""
        TxtHrCita.Text = ""
        CmbMotivos.Text = ""
        CmbMedios.Text = ""
        TxtComent.Text = ""
        TxtIdCita.Text = ""
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (TxtFecCita.Text = "  /  /" Or TxtHrCita.Text = "  :" Or CmbMotivos.Text = "" Or CmbMedios.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT CIT_IDCITA FROM CRM_CITAS WHERE CIT_IDCITA = '" & TxtIdCita.Text & "'")
            If Conexion.dr.HasRows Then
                Conexion.dr.Close()
                Dim Actualiza As String = "CIT_FECCITA ='" & TxtFecCita.Text & "',CIT_HRCITA ='" & TxtHrCita.Text & "',CIT_MOTIVO ='" & CmbMotivos.Text &
                        "',CIT_MEDIO ='" & CmbMedios.Text & "',CIT_COMENT ='" & TxtComent.Text & "',CIT_FECMOD ='" & DateTime.Today & "',CIT_HRMOD ='" & Now.ToString("HH:MM") & "',CIT_IDUSU='" & IdUsu & "',CIT_PERMISOUSU='" & Permiso & "'"

                If Conexion.Actualizar("CRM_CITAS", Actualiza, "CIT_IDCITA = '" & TxtIdCita.Text & "'") Then
                    MsgBox("Registro Actualizado Correctamente")
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al Guardar ")
                End If
            Else
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_CITAS VALUES('" & TxtIdPros.Text & "','" & TxtStatus.Text & "','" & TxtFecCita.Text & "','" & TxtHrCita.Text & "','" & CmbMotivos.Text &
                        "','" & CmbMedios.Text & "','" & TxtComent.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
                If Conexion.Insertar(Guardar) Then
                    MsgBox("Registro Insertado Correctamente")
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al Guardar ")
                End If
            End If

        End If
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

    Private Sub TxtHrCita_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles TxtHrCita.MaskInputRejected

    End Sub
End Class





