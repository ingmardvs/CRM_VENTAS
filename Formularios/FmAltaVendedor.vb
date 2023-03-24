
Public Class FmAltaVendedor
    Dim Conexion As Conexion_Dr = New Conexion_Dr()

    Private Sub Altavendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'GENER' and PAR_STATUS = 'ACTIVO'", CmbGenero)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'CIVIL' and PAR_STATUS = 'ACTIVO'", CmbEstadoCivil)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'STATU' and PAR_STATUS = 'ACTIVO'", CboStatus)
        TxtNombre.Focus()

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FmBuscar.Text = "Busqueda de Vendedores"
        Id_Bus = 0
        Librerias.Query = "SELECT * FROM CRM_VENDEDORES WHERE vend_id like '%" & txtid.Text & "' and vend_nombre like '" & TxtNombre.Text & "%' AND vend_paterno like '" & txtpaterno.Text & "%' AND vend_materno like '" & txtmaterno.Text & "%'"
        Librerias.Tabla = "CRM_VENDEDORES"

        If (txtid.Text = "" And TxtNombre.Text = "" And txtpaterno.Text = "" And txtmaterno.Text = "") Then
            MsgBox("No has ingresado un parametro de busqueda")
        Else
            FmBuscar.ShowDialog()
            txtid.Text = Id_Bus
            Conexion.Consultar("SELECT * FROM CRM_VENDEDORES WHERE vend_id =  '" & txtid.Text & "'")
            If Conexion.dr.HasRows Then
                Conexion.dr.Read()
                TxtNombre.Text = Conexion.dr.GetString(1)
                txtpaterno.Text = Conexion.dr.GetString(2)
                txtmaterno.Text = Conexion.dr.GetString(3)
                CmbGenero.Text = Conexion.dr.GetString(4)
                CboStatus.Text = Conexion.dr.GetString(5)
                CmbEstadoCivil.Text = Conexion.dr.GetString(6)
                TxtRfc.Text = Conexion.dr.GetString(7)
                TxtCel.Text = Conexion.dr.GetString(8)
                txtcorreo.Text = Conexion.dr.GetString(9)
            Else
                MsgBox("No hay información.")
                Limpiar()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If (TxtNombre.Text = "" Or txtpaterno.Text = "" Or txtmaterno.Text = "" Or CmbGenero.Text = "" Or CboStatus.Text = "" Or CmbEstadoCivil.Text = "" Or TxtRfc.Text = "" Or TxtCel.Text = "" Or txtcorreo.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            Conexion.Consultar("SELECT * FROM CRM_VENDEDORES WHERE vend_id =  '" & txtid.Text & "' OR vend_nombre = '" & TxtNombre.Text & "' AND vend_paterno = '" & txtpaterno.Text & "' AND vend_materno = '" & txtmaterno.Text & "'")
            If Conexion.dr.HasRows Then
                ' Modificar registro nuevo
                Conexion.dr.Close()

                Dim Actualiza As String = "VEND_NOMBRE ='" & TxtNombre.Text & "',VEND_PATERNO ='" & txtpaterno.Text & "',VEND_MATERNO ='" & txtmaterno.Text &
                                         "',VEND_GENERO ='" & CmbGenero.Text & "',VEND_STATUS ='" & CboStatus.Text & "',VEND_EDOCIVIL ='" & CmbEstadoCivil.Text &
                                         "',VEND_RFC ='" & TxtRfc.Text & "',VEND_TELCEL ='" & TxtCel.Text &
                                         "',VEND_CORREO ='" & txtcorreo.Text & "',VEND_FECALTA ='" & DateTime.Today & "',VEND_HRALTA ='" & Now.ToString("HH:MM") & "'"

                If Conexion.Actualizar("CRM_VENDEDORES", Actualiza, "vend_id = '" & txtid.Text & "'") Then
                    MsgBox("Registro Actualizado Correctamente")
                Else
                    MsgBox("Error al Guardar ")
                End If
            Else
                ' Insertar registro nuevo
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_VENDEDORES VALUES('" & TxtNombre.Text & "','" & txtpaterno.Text & "','" & txtmaterno.Text & "','" & CmbGenero.Text & "','" & CboStatus.Text &
                                        "','" & CmbEstadoCivil.Text & "','" & TxtRfc.Text & "','" & TxtCel.Text & "','" & txtcorreo.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "')"

                If Conexion.Insertar(Guardar) Then
                    MsgBox("Registro Insertado Correctamente")
                Else
                    MsgBox("Error al Guardar ")
                End If
            End If
            Conexion.desconectarse()
            Limpiar()
        End If

    End Sub

    Private Sub Limpiar()
        txtid.Text = Nothing
        TxtNombre.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
        CmbGenero.Text = ""
        CboStatus.Text = ""
        CmbEstadoCivil.Text = ""
        TxtRfc.Text = ""
        TxtCel.Text = ""
        txtcorreo.Text = ""
        TxtNombre.Focus()
    End Sub
    Private Sub Tabulador(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress, TxtNombre.KeyPress, txtpaterno.KeyPress, txtmaterno.KeyPress, CmbGenero.KeyPress, CboStatus.KeyPress, CmbEstadoCivil.KeyPress, TxtRfc.KeyPress, TxtCel.KeyPress, txtcorreo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If txtid.Text <> "" Then
                BtnBuscar.Focus()
            Else
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End If

    End Sub

End Class