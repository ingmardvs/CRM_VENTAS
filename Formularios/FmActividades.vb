Public Class FmActividades
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim Actualiza As String
    Dim Guardar As String
    Dim pe As String
    Dim bandera As Boolean
    Private Sub FmActividades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Actividad
        Limpiar()
        If (Actividad = "ATN") Then
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'ATNST' and PAR_STATUS = 'ACTIVO'", cmbstat)
        ElseIf (Actividad = "CMP") Then
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CMPST' and PAR_STATUS = 'ACTIVO'", cmbstat)
        ElseIf (Permiso = "7" Or Permiso = "4") Then
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'EST' and PAR_STATUS = 'ACTIVO'", cmbstat)
        ElseIf (Actividad = "FAC") Then
            MsgBox("Esta facturando")
            Conexion.desconectarse()
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'FACST' and PAR_STATUS = 'ACTIVO'", cmbstat)
            chkfisica.Visible = True
            chkmoral.Visible = True
        ElseIf (Permiso = "2" Or Actividad = "COMPRA" Or Actividad = "ENT" Or Actividad = "ENG" Or Actividad = "AUT") Then
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'STVEN' and PAR_STATUS = 'ACTIVO'", cmbstat)
        Else
            Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'EST' and PAR_STATUS = 'ACTIVO'", cmbstat)
        End If
        Cargar_Datos("SELECT isnull(ACT_ESTATUS" & Actividad & ",'') FROM CRM_ACTIVIDADES WHERE ACT_IDPROS ='" & Librerias.Id_Bus & "'")
        If (Actividad = "FAC") Then bandera = True Else bandera = False
    End Sub

    Private Sub btnguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnguardar.Click
        If (cmbstat.Text = "") Then
            MsgBox("Debes ingresar un status para la actividad")
        Else
            If (bandera = True) Then
                If (MessageBox.Show("¿Realemente desea facturar al cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = vbYes Then
                    bd()
                    Conexion.Consultar("SELECT FAC_CLI,FAC_VEH,FAC_IDVEND FROM CRM_FACTURA WHERE FAC_IDCLI = '" & Librerias.Id_Bus & "'")
                    'si se encuentra información del registro se actualizará
                    If (Conexion.dr.HasRows) Then
                        'Se actualiza la tabla de facturación
                        Conexion.dr.Read()
                        Actualiza = "FAC_CLI='" & Conexion.dr.GetString(0) & "', FAC_VEH='" & Conexion.dr.GetString(1) & "', FAC_IDVEND='" & Conexion.dr.GetInt32(2) & "'"
                        Conexion.dr.Close()

                        If Conexion.Actualizar("CRM_FACTURA", Actualiza, "FAC_IDCLI = '" & Id_Bus & "'") Then
                            MsgBox("Factura actualizada correctamente.")
                            Me.Close()
                            Permisos()
                        Else
                            MsgBox("Error al actualizar la factura.")
                        End If
                        Conexion.dr.Close()
                        Conexion.desconectarse()
                    Else
                        'Se inserta en la tabla de facturación
                        Conexion.dr.Close()
                        Conexion.desconectarse()
                        Conexion.Consultar("SELECT Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO,PRO_IDVEND, RTRIM(VEND_NOMBRE) + ' ' + RTRIM(VEND_PATERNO) + ' ' + RTRIM(VEND_MATERNO) AS VEND FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES AS VEND ON CRM_PROSPECTOS.PRO_IDVEND = VEND.VEND_ID WHERE PRO_ID = '" & Librerias.Id_Bus & "'")
                        If (Conexion.dr.HasRows) Then
                            Conexion.dr.Read()
                            Guardar = "INSERT INTO CRM_FACTURA (FAC_IDCLI, FAC_CLI, FAC_VEH , FAC_FEC, FAC_HRA, FAC_IDVEND, FAC_VEND, FAC_IDUSU, FAC_PERMISOUSU) VALUES('" & Id_Bus & "','" & Conexion.dr.GetString(0) & "','" & Conexion.dr.GetString(1) & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & Conexion.dr.GetInt32(2) & "','" & Conexion.dr.GetString(3) & "','" & IdUsu & "','" & Permiso & "')"
                        Else
                            MsgBox("No existe información del prospecto.")
                        End If
                        Conexion.dr.Close()
                        If (Conexion.Insertar(Guardar)) Then
                            MsgBox("Se ha ingresado correctamente la factura.")
                            Me.Close()
                            Permisos()
                        Else
                            MsgBox("Ocurrio un error al intentar guardar la factura.")
                        End If
                        Conexion.desconectarse()
                        End If
                Else
                        Me.Close()
                End If
            Else
                bd()
            End If
        End If
    End Sub

    Public Sub Limpiar()
        cmbstat.Text = ""
        cmbstat.Items.Clear()
    End Sub

    Public Sub bd()
        'evaluo la actividad que se va a insertar o actualizar
        Conexion.Consultar("SELECT * FROM CRM_ACTIVIDADES WHERE ACT_IDPROS = '" & Librerias.Id_Bus & "'")

        'si se encuentra información del registro se actualizará
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Close()
            Actualiza = "ACT_ESTATUS" & Actividad & "= '" & cmbstat.Text & "', ACT_FECALTA='" & DateTime.Today & "', ACT_HRALTA='" & Now.ToString("HH:MM") & "', ACT_IDUSU = '" & IdUsu & "', ACT_PERMISOUSU = '" & Permiso & "'"
            If Conexion.Actualizar("CRM_ACTIVIDADES", Actualiza, "ACT_IDPROS = '" & Id_Bus & "'") Then
                MsgBox("Actividad actualizada correctamente.")
                Me.Close()
                Permisos()
            Else
                MsgBox("Error al actualizar el registro.")
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        Else
            'Si no existe se insertará
            Conexion.dr.Close()
            Guardar = "INSERT INTO CRM_ACTIVIDADES(ACT_IDPROS,ACT_ESTATUS" & Actividad & ", ACT_FECALTA, ACT_HRALTA, ACT_IDUSU, ACT_PERMISOUSU) VALUES('" & Id_Bus & "','" & cmbstat.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
            If (Conexion.Insertar(Guardar)) Then
                MsgBox("Se ha ingresado correctamente la actividad.")
                Me.Close()
                Permisos()
            Else
                MsgBox("Ocurrio un error al intentar guardar la actividad.")
            End If
            Conexion.desconectarse()
        End If
    End Sub

    Public Sub Cargar_Datos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            cmbstat.Text = Conexion.dr.GetString(0)
            Conexion.dr.Close()
            Conexion.desconectarse()
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

    Private Sub btncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class