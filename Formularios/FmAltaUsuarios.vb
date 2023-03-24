
Public Class FmAltaUsuarios
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim usupermiso As String
    Private Sub Altausuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'STATU' and PAR_STATUS = 'ACTIVO'", CmbStatus)
        Conexion.LlenarCombo("Select PAR_DESCRIP1,PAR_STATUS  from CRM_PARAMETR where PAR_TIPOPARA = 'USUAR' and PAR_STATUS = 'ACTIVO'", CmbTipoUsu)
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Limpiar()
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (txtusuario.Text = "") Then
            MsgBox("No has ingresado un parametro de busqueda")
        Else
            Conexion.Consultar("SELECT * FROM CRM_USUARIOS WHERE usu_idusu =  '" & txtusuario.Text & "'")
            If Conexion.dr.HasRows Then
                Conexion.dr.Read()
                txtusuario.Text = Conexion.dr.GetString(0)
                txtnombre.Text = Conexion.dr.GetString(1)
                txtpaterno.Text = Conexion.dr.GetString(2)
                txtmaterno.Text = Conexion.dr.GetString(3)
                txtcontraseña.Text = Conexion.dr.GetString(4)
                CmbTipoUsu.Text = Conexion.dr.GetString(5)
                CmbStatus.Text = Conexion.dr.GetString(6)
            Else
                MsgBox("No hay información.")
                Limpiar()
            End If
            Conexion.dr.Close()
            Conexion.desconectarse()
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        If (txtcontraseña.Text = "" Or txtnombre.Text = "" Or txtusuario.Text = "" Or CmbStatus.Text = "" Or CmbTipoUsu.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")
        Else
            If (CmbTipoUsu.Text = "ADMINISTRADOR" Or CmbTipoUsu.Text = "SISTEMAS") Then
                usupermiso = "0"
            ElseIf CmbTipoUsu.Text = "GERENTE" Then
                usupermiso = "1"
            ElseIf CmbTipoUsu.Text = "VENDEDOR" Then
                usupermiso = "2"
            ElseIf CmbTipoUsu.Text = "HOSTESS" Then
                usupermiso = "3"
            ElseIf CmbTipoUsu.Text = "F & I" Then
                usupermiso = "4"
            ElseIf CmbTipoUsu.Text = "VALUADOR" Then
                usupermiso = "5"            
            ElseIf CmbTipoUsu.Text = "BDC" Then
                usupermiso = "6"
            ElseIf CmbTipoUsu.Text = "CRM" Then
                usupermiso = "7"
            ElseIf CmbTipoUsu.Text = "ENTREGAS" Then
                usupermiso = "8"
            ElseIf CmbTipoUsu.Text = "ACCESORIOS" Then
                usupermiso = "9"
            End If
            Conexion.Consultar("SELECT * FROM CRM_USUARIOS WHERE USU_IDUSU =  '" & txtusuario.Text & "'")
            If Conexion.dr.HasRows Then
                ' Modificar registro nuevo
                Conexion.dr.Close()
                Dim Actualiza As String = "USU_IDUSU ='" & txtusuario.Text & "',USU_NOMBRE ='" & txtnombre.Text & "',USU_PATERNO ='" & txtpaterno.Text & "',USU_MATERNO ='" & txtmaterno.Text & "',USU_CONTRASEÑA ='" & txtcontraseña.Text &
                    "',USU_TIPUSU ='" & CmbTipoUsu.Text & "',USU_STATUS ='" & CmbStatus.Text & "',USU_PERMISO ='" & usupermiso & "',USU_FECHA ='" & DateTime.Today & "',USU_HORA ='" & Now.ToString("HH:MM") & "'"
                If Conexion.Actualizar("CRM_USUARIOS", Actualiza, "USU_IDUSU = '" & txtusuario.Text & "'") Then
                    MsgBox("Registro Actualizado Correctamente")
                Else
                    MsgBox("Error al Guardar ")
                End If
            Else
                ' Insertar registro nuevo
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_USUARIOS VALUES('" & txtusuario.Text & "' , '" & txtnombre.Text & "','" & txtpaterno.Text & "','" & txtmaterno.Text & "','" & txtcontraseña.Text & "','" & CmbTipoUsu.Text & "','" &
                                        CmbStatus.Text & "','" & usupermiso & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "')"
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
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
        CmbTipoUsu.Text = ""
        CmbStatus.Text = ""
        txtpaterno.Text = ""
        txtmaterno.Text = ""
    End Sub

    Private Sub Tabulador(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress, txtnombre.KeyPress, txtcontraseña.KeyPress, CmbTipoUsu.KeyPress, CmbStatus.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class