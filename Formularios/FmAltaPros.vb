
Public Class FmAltaPros
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim idtemp, index As Integer

    Private Sub FmAlta_Cli_Hostess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        CmbVeh1.Items.Clear()
        CmbVeh2.Items.Clear()
        CmbMod1.Items.Clear()
        CmbMod2.Items.Clear()
        CmbEntero.Items.Clear()
        CmbVendedor.Items.Clear()
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CLI' and PAR_STATUS = 'ACTIVO'", CmbVeh1)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CLI' and PAR_STATUS = 'ACTIVO'", CmbVeh2)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'MOD' and PAR_STATUS = 'ACTIVO'", CmbMod1)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'MOD' and PAR_STATUS = 'ACTIVO'", CmbMod2)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'ENT' and PAR_STATUS = 'ACTIVO'", CmbEntero)
        Conexion.LlenarCombo("SELECT RTRIM(VEND_NOMBRE) + ' ' + RTRIM(VEND_PATERNO) + ' ' +VEND_MATERNO+' -'+ convert(varchar(4),VEND_ID) AS NOMBRE FROM CRM_VENDEDORES ORDER BY VEND_NOMBRE ASC", CmbVendedor)
        If Activar = 1 Then Cargar_Datos("SELECT PRO_ID, PRO_NOMBRE, isnull(PRO_NOMBRE2,''),isnull(PRO_NOMBRE3,''), PRO_PATERNO,PRO_MATERNO,RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_ENTERO ," &
                                         "PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID  WHERE PRO_ID = '" & Id_Bus & "'")
    End Sub

    Private Sub btnbuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        FmBuscar.Text = "Busqueda de Prospectos"
        If (txtid.Text = "" And txtnombre.Text = "" And txtmaterno.Text = "" And txtpaterno.Text = "") Then
            MsgBox("No has Ingresado un Parametro de Busqueda")
            txtnombre.Focus()
        Else
            Librerias.Query = "SELECT * FROM CRM_PROSPECTOS WHERE PRO_ID LIKE  '" & txtid.Text & "%' AND PRO_NOMBRE LIKE '" & txtnombre.Text & "%' AND PRO_NOMBRE2 LIKE '" & txtnombre2.Text & "%' AND PRO_NOMBRE3 LIKE '" & txtnombre3.Text & "%' AND PRO_PATERNO LIKE '" & txtpaterno.Text & "%' AND PRO_MATERNO LIKE '" & txtmaterno.Text & "%'"
            Librerias.Tabla = "CRM_PROSPECTOS"
            FmBuscar.ShowDialog()
            Cargar_Datos("SELECT PRO_ID, PRO_NOMBRE, isnull(PRO_NOMBRE2,''),isnull(PRO_NOMBRE3,''), PRO_PATERNO, PRO_MATERNO,RTRIM(VEND_NOMBRE)+' '+ RTRIM(VEND_PATERNO)+' '+VEND_MATERNO+' -'+ convert(varchar(4),PRO_IDVEND) AS VENDEDOR, PRO_ENTERO ," &
                         "PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2 FROM CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES  ON PRO_IDVEND = VEND_ID  WHERE PRO_ID LIKE  '" & txtid.Text & "%' AND PRO_NOMBRE LIKE '" & txtnombre.Text & "%'")
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (txtnombre.Text = "" Or txtpaterno.Text = "" Or txtmaterno.Text = "" Or CmbVendedor.Text = "" Or CmbVeh1.Text = "" Or CmbMod1.Text = "" Or mtbpaq1.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT TOP 1 PRO_ID FROM CRM_PROSPECTOS WHERE PRO_PATERNO LIKE '" + txtpaterno.Text + "%' AND PRO_MATERNO LIKE '" + txtmaterno.Text + "%' AND PRO_NOMBRE LIKE '" + txtnombre.Text + "%' AND PRO_NOMBRE2 LIKE '" + txtnombre2.Text + "%' AND PRO_NOMBRE3 LIKE '" + txtnombre3.Text + "%' ")
            If (Conexion.dr.HasRows) Then
                Conexion.dr.Read()
                MsgBox("Ya existe un prospecto con la misma información")                
                idtemp = Conexion.dr.GetInt32(0)
                Conexion.dr.Close()
                If (MessageBox.Show("El prospecto ya se encuentra registrado, ¿Desea actualizar la información?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = vbYes Then
                    Conexion.dr.Close()
                    Grabar()
                Else
                    MsgBox("No se ha realizado ninguna modificación")
                    Limpiar()
                End If
                Conexion.dr.Close()
                Conexion.desconectarse()
            Else
                MsgBox("No encontro nada")
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_PROSPECTOS(PRO_NOMBRE, PRO_NOMBRE2, PRO_NOMBRE3, PRO_PATERNO, PRO_MATERNO, PRO_ENTERO, PRO_IDVEND, PRO_CLI1, PRO_CLI2, PRO_MOD1, PRO_MOD2, PRO_PAQ1, PRO_PAQ2, PRO_STATUS1, PRO_STATUS2, PRO_FECALTA, PRO_HORALTA, PRO_IDUSU, PRO_PERMISOUSU) VALUES('" & txtnombre.Text & "','" & txtnombre2.Text & "','" & txtnombre3.Text & "','" & txtpaterno.Text & "','" & txtmaterno.Text & "','" & CmbEntero.Text & "','" & Mid(CmbVendedor.Text, (InStr(1, CmbVendedor.Text, "-") + 1)) & "','" & CmbVeh1.Text & "','" & CmbVeh2.Text & "','" & CmbMod1.Text & "','" & CmbMod2.Text & "','" & mtbpaq1.Text & "','" & mtbpaq2.Text & "','" & chkstat1.Checked & "','" & chkstat2.Checked & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & IdUsu & "','" & Permiso & "')"
                If Conexion.Insertar(Guardar) Then
                    MsgBox("Se ha ingresado correctamente el prospecto")
                    Limpiar()
                Else
                    MsgBox("Error al intentar guardar el registro")
                    Limpiar()
                End If
                Conexion.desconectarse()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        End If
        txtnombre.Focus()

        If Activar = 1 Then
            Me.Close()
            FmSeguimiento.Mostrar_Datos()
        End If

    End Sub

    Private Sub Limpiar()
        If Activar = 1 Then GroupBox1.Enabled = False
        If Activar = 1 Then btnbuscar.Visible = False
        If Activar = 1 Then btnnuevo.Visible = False
        If Len(CmbVeh2.Text) > 0 And Len(CmbMod2.Text) > 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
        txtnombre.Focus()
        txtid.Text = ""
        txtnombre.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
        txtnombre2.Text = ""
        txtnombre3.Text = ""
        mtbpaq1.Text = ""
        mtbpaq2.Text = ""
        CmbVeh1.Text = ""
        CmbVeh2.Text = ""
        CmbMod1.Text = ""
        CmbMod2.Text = ""
        CmbEntero.Text = ""
        CmbVendedor.Text = ""
        chkstat1.Checked = False
        chkstat2.Checked = False

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
     
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Limpiar()
    End Sub

    Private Sub Cargar_Datos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtid.Text = RTrim(Conexion.dr.GetInt32(0))
            txtnombre.Text = RTrim(Conexion.dr.GetString(1))
            txtnombre2.Text = RTrim(Conexion.dr.GetString(2))
            txtnombre3.Text = RTrim(Conexion.dr.GetString(3))
            txtpaterno.Text = RTrim(Conexion.dr.GetString(4))
            txtmaterno.Text = RTrim(Conexion.dr.GetString(5))
            CmbVendedor.Text = Conexion.dr.GetString(6)
            CmbEntero.Text = Conexion.dr.GetString(7)
            CmbVeh1.Text = Conexion.dr.GetString(8)
            CmbVeh2.Text = Conexion.dr.GetString(9)
            CmbMod1.Text = Conexion.dr.GetString(10)
            CmbMod2.Text = Conexion.dr.GetString(11)
            mtbpaq1.Text = Conexion.dr.GetString(12)
            mtbpaq2.Text = Conexion.dr.GetString(13)
            chkstat1.Checked = Conexion.dr.GetBoolean(14)
            chkstat2.Checked = Conexion.dr.GetBoolean(15)
            Conexion.dr.Close()
        Else
            MsgBox("No hay información.")
            Limpiar()
        End If

        If Len(CmbVeh2.Text) > 0 And Len(CmbMod2.Text) > 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
        Conexion.desconectarse()
    End Sub

    Private Sub CmbVeh1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVeh1.SelectedIndexChanged, CmbMod1.SelectedIndexChanged, mtbpaq1.TextChanged
        If Len(CmbVeh1.Text) > 0 And Len(CmbMod1.Text) > 0 And Len(mtbpaq1.Text) > 0 Then chkstat1.Checked = True Else chkstat1.Checked = False
    End Sub

    Private Sub CmbVeh2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVeh2.SelectedIndexChanged, CmbMod2.SelectedIndexChanged, mtbpaq2.TextChanged
        If Len(CmbVeh2.Text) > 0 And Len(CmbMod2.Text) > 0 And Len(mtbpaq2.Text) > 0 Then chkstat2.Enabled = True Else chkstat2.Enabled = False
        If Len(CmbVeh2.Text) > 0 And Len(CmbMod2.Text) > 0 And Len(mtbpaq2.Text) > 0 Then chkstat2.Checked = True Else chkstat2.Checked = False
    End Sub

    Private Sub Grabar()
        Dim Actualiza As String = "PRO_NOMBRE ='" & txtnombre.Text & "', PRO_NOMBRE2 ='" & txtnombre2.Text & "', PRO_NOMBRE3 ='" & txtnombre3.Text & "',PRO_PATERNO ='" & txtpaterno.Text &
                                  "',PRO_MATERNO ='" & txtmaterno.Text & "', PRO_ENTERO = '" & CmbEntero.Text & "', PRO_IDVEND ='" & Mid(CmbVendedor.Text, (InStr(1, CmbVendedor.Text, "-") + 1)) & "', PRO_CLI1 ='" & CmbVeh1.Text &
                                  "', PRO_CLI2 ='" & CmbVeh2.Text & "', PRO_MOD1 ='" & CmbMod1.Text & "', PRO_MOD2 ='" & CmbMod2.Text & "', PRO_PAQ1 ='" & mtbpaq1.Text & "', PRO_PAQ2 ='" & mtbpaq2.Text &
                                  "', PRO_STATUS1 ='" & chkstat1.Checked & "', PRO_STATUS2 ='" & chkstat2.Checked & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "', PRO_IDUSU = '" & IdUsu & "', PRO_PERMISOUSU = '" & Permiso & "'"
        If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, "PRO_ID = '" & idtemp & "'") Then
            MsgBox("Prospecto actualizado correctamente")
            Limpiar()
            Permisos()
        Else
            MsgBox("Error al actualizar el prospecto")
            Limpiar()
        End If
        Conexion.desconectarse()
        Conexion.dr.Close()
    End Sub

    Private Sub Tabulador(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress, txtnombre.KeyPress, txtnombre2.KeyPress, txtnombre3.KeyPress, txtpaterno.KeyPress, txtmaterno.KeyPress, CmbVendedor.KeyPress, CmbEntero.KeyPress, CmbVeh1.KeyPress, CmbMod1.KeyPress, CmbVeh2.KeyPress, CmbMod2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtid.Text <> "" Then
                btnbuscar.Focus()
            Else
                SendKeys.Send("{TAB}")
            End If
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




