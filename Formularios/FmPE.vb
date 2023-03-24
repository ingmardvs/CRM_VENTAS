Public Class FmPE
    Dim Conexion As Conexion_Dr = New Conexion_Dr()

    Private Sub FmEnganche_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        ObtVeh()
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'PLAZO' and PAR_STATUS = 'ACTIVO'", cmbplazo)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'FINAN' and PAR_STATUS = 'ACTIVO'", cmbfinan)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'ENGAN' and PAR_STATUS = 'ACTIVO'", cmbesteng)
        Cargar_Datos2("SELECT isnull(ACT_ESTATUSGE,''), isnull(ACT_ESTATUSACC,'') FROM CRM_ACTIVIDADES WHERE ACT_IDPROS ='" & Librerias.Id_Bus & "'")
        Cargar_Datos("SELECT isnull(PE_PRECIO,''),isnull(PE_PLAZO,''), isnull(PE_MENS,''), isnull(PE_TIPOFINAN,''), isnull(PE_ESTATUS,'') FROM CRM_PE WHERE PE_IDPROS ='" & Librerias.Id_Bus & "'")
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As System.Object, e As System.EventArgs) Handles btnguardar.Click
        If (cmbesteng.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT * FROM CRM_PE WHERE PE_IDPROS = '" & Id_Bus & "'")
            If (Conexion.dr.HasRows) Then
                Conexion.dr.Close()
                Dim Actualiza As String = "PE_PRECIO = '" & mtbprecio.Text & "' " & "PE_UNIDAD = '" & txtunidad.Text & "' " & "PE_ENGANCHE = '" & mtbeng.Text & "' " & "PE_PLAZO = '" & cmbplazo.Text & "', PE_MENS = '" & mtbmensualidad.Text & "', PE_FINAN = '" & cmbfinan.Text & "', PE_ESTATUS = '" & cmbesteng.Text & "', PE_IDUSU = '" & IdUsu & "', PE_FECACT = '" & DateTime.Today & "', PE_HRACT = '" & Now.ToString("HH:MM") & "', PE_PERMISOUSU = '" & Permiso & "'"
                If Conexion.Actualizar("CRM_PE", Actualiza, "PE_IDPROS = '" & Id_Bus & "'") Then
                    MsgBox("Datos de la propuesta economica actualizados correctamente")
                    Limpiar()
                    Permisos()
                    Me.Close()
                Else
                    MsgBox("Error al actualizar el registro")
                End If
                Conexion.desconectarse()
            Else
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_PE VALUES('" & Id_Bus & "','" & mtbprecio.Text & "','" & txtunidad.Text & "','" & mtbeng.Text & "','" & cmbplazo.Text & "','" & mtbmensualidad.Text & "','" & cmbfinan.Text & "','" & cmbesteng.Text & "','" & IdUsu & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "','" & Permiso & "')"
                If Conexion.Insertar(Guardar) Then
                    MsgBox("Se ha ingresado correctamente los datos de Propuesta economica")
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


    Public Sub ObtVeh()
        Conexion.Consultar("SELECT ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" & "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO FROM CRM_PROSPECTOS WHERE PRO_ID = '" & Id_Bus & "'")
        If (Conexion.dr.HasRows) Then
            Conexion.dr.Read()
            txtunidad.Text = Conexion.dr.GetString(0)
            Conexion.dr.Close()
        Else
            txtunidad.Text = "NO TIENE UNIDAD"
            Conexion.dr.Close()
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Public Sub Limpiar()
        cmbfinan.Text = ""
        cmbfinan.Items.Clear()
        cmbplazo.Text = ""
        cmbplazo.Items.Clear()
    End Sub

    Public Sub Cargar_Datos(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            mtbprecio.Text = Conexion.dr.GetString(0)
            cmbplazo.Text = Conexion.dr.GetString(1)
            mtbmensualidad.Text = Conexion.dr.GetString(2)
            cmbfinan.Text = Conexion.dr.GetString(3)
            Conexion.dr.Close()
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Public Sub Cargar_Datos2(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtge.Text = Conexion.dr.GetString(0)
            txtacc.Text = Conexion.dr.GetString(1)
        End If
        Conexion.dr.Close()
        Conexion.desconectarse()
    End Sub

    Public Sub Cargar_Enganche(ByVal SQL As String)
        Conexion.Consultar(SQL)
        If Conexion.dr.HasRows Then
            Conexion.dr.Read()
            txtge.Text = Conexion.dr.GetString(0)
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