Imports System.Data.SqlClient
Public Class FmAlta_Cli_Hostess
    Dim Conexion As Conexion_Dr = New Conexion_Dr()
    Dim Conexion2 As Conexion_Dt = New Conexion_Dt()
    Dim Conexion3 As Conexion_Dt = New Conexion_Dt()
    Dim idtemp As Integer
    Dim prueba1, prueba2 As String

    Private Sub FmAlta_Cli_Hostess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conexion2.LlenarGrilla("SELECT PAR_DESCRIP1 FROM CRM_PARAMETR WHERE PAR_TIPOPARA = 'CLI'", "CRM_PARAMETR")
        'cm = New SqlCommand("SELECT RTRIM(PAR_IDENPARA) FROM CRM_PARAMETR", con)
        'Dim adapter As New SqlDataAdapter(Cmd)
        'Dim table As New DataTable()
        'm row As DataRow = table.NewRow
        'row.Item("vend_nombre") = ""
        'table.Rows.InsertAt(row, 0)
        'adapter.Fill(table)
        cmbveh1.Items.Clear()
        cmbveh1.DataSource = Conexion2.Dt
        cmbveh1.DisplayMember = "PAR_DESCRIP1"
        cmbveh2.DataSource = Conexion2.Dt
        cmbveh2.DisplayMember = "PAR_DESCRIP1"
        Conexion3.LlenarGrilla("SELECT RTRIM(VEND_NOMBRE)+' '+RTRIM(VEND_PATERNO)+' '+RTRIM(VEND_MATERNO) as NOMBRE FROM CRM_VENDEDORES", "CRM_VENDEDORES")
        cmbvendedor.DataSource = Conexion3.Dt
        cmbvendedor.DisplayMember = "NOMBRE"

    End Sub

    Private Sub btnbuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Librerias.Query = "SELECT * FROM CRM_PROSPECTOS WHERE PRO_ID LIKE  '" & txtid.Text & "%' AND PRO_NOMBRE LIKE '" & txtnombre.Text & "%' AND PRO_PATERNO LIKE '" & txtpaterno.Text & "%' AND PRO_MATERNO LIKE '" & txtmaterno.Text & "%'"
        Librerias.Tabla = "CRM_PROSPECTOS"

        If (txtid.Text = "" And txtnombre.Text = "" And txtmaterno.Text = "" And txtpaterno.Text = "") Then
            MsgBox("No has ingresado un parametro de busqueda")
        Else
            FmBuscar.ShowDialog()
            txtid.Text = Id_Bus
            Conexion.Consultar("SELECT PRO_ID, PRO_NOMBRE, PRO_PATERNO, PRO_MATERNO, PRO_VENDEDOR FROM CRM_PROSPECTOS WHERE PRO_ID LIKE  '" & txtid.Text & "%' AND PRO_NOMBRE LIKE '" & txtnombre.Text & "%' AND PRO_PATERNO LIKE '" & txtpaterno.Text & "%' AND PRO_MATERNO LIKE '" & txtmaterno.Text & "%'")
            If Conexion.dr.HasRows Then
                Conexion.dr.Read()
                txtid.Text = Conexion.dr.GetInt32(0)
                txtnombre.Text = Conexion.dr.GetString(1)
                txtpaterno.Text = Conexion.dr.GetString(2)
                txtmaterno.Text = Conexion.dr.GetString(3)
                cmbvendedor.Text = Conexion.dr.GetString(4)
                Conexion.dr.Close()
                Conexion.desconectarse()
                Conexion.Consultar("SELECT PRO_ID FROM CRM_PROSPECTOS WHERE PRO_NOMBRE = '" & txtnombre.Text & "' AND PRO_PATERNO = '" & txtpaterno.Text & "' AND PRO_MATERNO = '" & txtmaterno.Text & "' AND PRO_FECALTA = '" & DateTime.Today & "'")
                If Conexion.dr.HasRows Then
                    Conexion.dr.Read()
                    idtemp = Conexion.dr.GetInt32(0)
                    Conexion.dr.Close()
                    Conexion.desconectarse()
                Else
                    Conexion.dr.Close()
                    Conexion.desconectarse()
                End If
                'Se establece una nueva consulta para traer la información de la tabla de PROSPECTO_DET
                Conexion.Consultar("SELECT PRO_DET_VEH1, PRO_DET_VEH2 FROM CRM_PROSPECTO_DET WHERE PRO_DET_IDPRO = '" & idtemp & "'")
                If Conexion.dr.HasRows Then
                    Conexion.dr.Read()
                    cmbveh1.Text = Conexion.dr.GetString(0)
                    cmbveh2.Text = Conexion.dr.GetString(1)
                Else
                    MsgBox("No tiene ningun vehiculo de interes.")
                    Limpiar()
                End If
            Else
                MsgBox("No hay información.")
                Limpiar()
            End If
                Conexion.dr.Close()
                Conexion.desconectarse()
            End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If (txtnombre.Text = "" Or txtpaterno.Text = "" Or txtmaterno.Text = "" Or cmbvendedor.Text = "" And cmbveh1.Text = "" And cmbveh2.Text = "") Then
            MsgBox("Verifique que todos los campos esten llenados")


        Else
            Conexion.Consultar("SELECT * FROM CRM_PROSPECTOS WHERE PRO_PATERNO LIKE '" & txtnombre.Text & "%' AND PRO_PATERNO LIKE '" & txtpaterno.Text & "%' AND PRO_MATERNO = '" & txtmaterno.Text & "%'")
            If Conexion.dr.HasRows Then
                ' Modificar registro nuevo
                Conexion.dr.Close()

                Dim Actualiza As String = "PRO_NOMBRE ='" & txtnombre.Text & "',PRO_PATERNO ='" & txtpaterno.Text & "',PRO_MATERNO ='" & txtmaterno.Text &
                                         "'.PRO_VENDEDOR ='" & cmbvendedor.Text & "',PRO_FECALTA ='" & DateTime.Today & "',PRO_HORALTA ='" & Now.ToString("HH:MM") & "'"

                If Conexion.Actualizar("CRM_PROSPECTOS", Actualiza, "PRO_ID = '" & Id_Bus & "'") Then
                    'Se establece una nueva consulta para actualizar la información de la tabla de PROSPECTO_DET
                    Conexion.Consultar("SELECT PRO_DET_VEH1, PRO_DET_VEH2 FROM CRM_PROSPECTO_DET WHERE PRO_DET_IDPRO = '" & Id_Bus & "'")
                    If Conexion.dr.HasRows Then
                        Conexion.dr.Close()
                        Actualiza = "PRO_DET_VEH1 ='" & cmbveh1.Text & "',PRO_DET_VEH2 ='" & cmbveh2.Text & ""
                        If Conexion.Actualizar("CRM_PROSPECTO_DET", Actualiza, "PRO_DET_IDPRO = '" & Id_Bus & "'") Then
                            MsgBox("Registro Actualizado Correctamente")
                        Else
                            MsgBox("No tiene ningun vehiculo de interes.")
                        End If
                    Else
                        MsgBox("Error al guardar")
                    End If
                Else
                End If

            Else

                ' Insertar registro nuevo
                Conexion.dr.Close()
                Dim Guardar As String = "INSERT INTO CRM_PROSPECTOS(PRO_NOMBRE, PRO_PATERNO, PRO_MATERNO, PRO_VENDEDOR, PRO_FECALTA, PRO_HORALTA, PRO_IDUSU) VALUES('" & txtnombre.Text & "','" & txtpaterno.Text & "','" & txtmaterno.Text & "','" & cmbvendedor.Text & "','" & DateTime.Today & "','" & Now.ToString("HH:MM") & "', 'X')"
                If Conexion.Insertar(Guardar) Then
                    Conexion.Consultar("SELECT PRO_ID FROM CRM_PROSPECTOS WHERE PRO_NOMBRE = '" & txtnombre.Text & "' AND PRO_PATERNO = '" & txtpaterno.Text & "' AND PRO_MATERNO = '" & txtmaterno.Text & "' AND PRO_FECALTA = '" & DateTime.Today & "'")
                    If Conexion.dr.HasRows Then
                        Conexion.dr.Read()
                        idtemp = Conexion.dr.GetInt32(0)
                        Conexion.dr.Close()
                    Else
                        Conexion.dr.Close()
                    End If
                    Guardar = "INSERT INTO CRM_PROSPECTO_DET(PRO_DET_IDPRO, PRO_DET_VEH1, PRO_DET_VEH2) VALUES('" & idtemp & "','" & cmbveh1.Text & "','" & cmbveh2.Text & "')"
                    If Conexion.Insertar(Guardar) Then
                        MsgBox("Registro ingreado correctamente")
                        Limpiar()
                    Else
                        MsgBox("Error al intentar ingresar el registro")
                    End If


                Else

                End If
            End If
        End If
        Conexion.desconectarse()

    End Sub

    Private Sub Limpiar()
        txtid.Text = ""
        txtmaterno.Text = ""
        txtnombre.Text = ""
        txtpaterno.Text = ""
        cmbveh1.Text = ""
        cmbveh2.Text = ""
        cmbvendedor.Text = ""
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Limpiar()
    End Sub
End Class