Public Class FmTAC
    Dim Conexion As Conexion_Dr = New Conexion_Dr()

    Private Sub FmTAC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'EST' and PAR_STATUS = 'ACTIVO'", cmbest)
        Cargar_Datos("SELECT isnull(TAC_ID,''), isnull(TAC_MARCA,''), isnull(TAC_MODELO,''), isnull(TAC_AÑO,''), isnull(TAC_KM,''), isnull(TAC_PROPEC,''), isnull(TAC_ESTATUS,'') FROM CRM_TAC WHERE TAC_IDPROS ='" & Librerias.Id_Bus & "'")
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnguardar.Click
        If (txtmarca.Text = "" Or txtmodelo.Text = "" Or mtbaño.Text = "" Or mtbkm.Text = "" Or mtbpe.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT * FROM CRM_TAC WHERE TAC_IDPROS = '" & Id_Bus & "'")
            If (Conexion.dr.HasRows) Then
                Conexion.dr.Close()
                Dim Actualiza As String = "TAC_MARCA = '" & txtmarca.Text & "', TAC_MODELO = '" & txtmodelo.Text & "', TAC_AÑO = '" & mtbaño.Text & "', TAC_KM = '" & mtbkm.Text & "', TAC_PROPEC = '" & mtbpe.Text & "', TAC_ESTATUS = '" & cmbest.Text & "', TAC_IDPROS = '" & Id_Bus & "', TAC_FECACT = '" & DateTime.Today & "', TAC_HRACT = '" & Now.ToString("HH:MM") & "', TAC_IDUSU = '" & IdUsu & "', TAC_PERMISOUSU = '" & Permiso & "'"
                If Conexion.Actualizar("CRM_TAC", Actualiza, "TAC_IDPROS = '" & Id_Bus & "'") Then
                    MsgBox("Toma a cuenta actualizada correctamente")
                    Limpiar()
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al actualizar el registro")
                End If

                Conexion.desconectarse()
            Else
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_TAC(TAC_MARCA,TAC_MODELO,TAC_AÑO,TAC_KM,TAC_PROPEC,TAC_ESTATUS,TAC_FECACT,TAC_HRACT,TAC_IDPROS, TAC_IDUSU, TAC_PERMISOUSU) VALUES('" & txtmarca.Text & "','" & txtmodelo.Text & "','" & mtbaño.Text & "','" & mtbkm.Text & "','" & mtbpe.Text & "','" & cmbest.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & Id_Bus & "','" & IdUsu & "','" & Permiso & "')"
                If Conexion.Insertar(Guardar) Then
                    MsgBox("Se ha ingresado correctamente la toma a cuenta")
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
        txtid.Text = ""
        txtmodelo.Text = ""
        txtmarca.Text = ""
        mtbaño.Text = ""
        mtbkm.Text = ""
        mtbpe.Text = ""
        cmbest.Text = ""
        cmbest.Items.Clear()
    End Sub

    Public Sub Cargar_Datos(ByVal SQL As String)

        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtid.Text = Conexion.dr.GetInt32(0)
            txtmarca.Text = Conexion.dr.GetString(1)
            txtmodelo.Text = Conexion.dr.GetString(2)
            mtbaño.Text = Conexion.dr.GetString(3)
            mtbkm.Text = Conexion.dr.GetString(4)
            mtbpe.Text = Conexion.dr.GetString(5)
            cmbest.Text = Conexion.dr.GetString(6)
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