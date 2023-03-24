
Public Class FmParametros

    Dim Alta As String
    Dim Conexion As Conexion_Ds = New Conexion_Ds()
    Private Sub FmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Parametros"
        Librerias.CambiaColorDgv(Me.DgvDatos)
        MostraDatos()
    End Sub
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        MostraDatos()
        Limpiar_Datos()
    End Sub
    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Limpiar_Datos()
        MostraDatos()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click

        If TxtTipo.Text = "" Or TxtId.Text = "" Or CmbStatus.Text = "" Or TxtDescripcion1.Text = "" Then
            MsgBox("Falta Capturar Informacion Obligatoria")
            Exit Sub
        End If

        Validar()
        If Alta = 0 Then
            ' Insertar registro nuevo
            Dim Guardar As String = "Insert Into CRM_PARAMETR Values ('" & TxtTipo.Text & "','" & TxtId.Text & "','" & TxtDescripcion1.Text & "','" &
              TxtDescripcion2.Text & "','" & TxtDescripcion3.Text & "','" & CmbStatus.Text & "'," & 0.0 & "," & 0.0 & "," & 0.0 & ",'" &
            TxtFecha1.Text & "','" & TxtFecha2.Text & "','" & TxtFecha3.Text & "','','','','','','')"

            If Conexion.Insertar(Guardar) Then
                MsgBox("Registro Insertado Correctamente")
                MostraDatos()
            Else
                MsgBox("Error al Guardar ")
            End If
        Else
            ' Actualizar Registro
            Dim Actualiza As String = "PAR_TIPOPARA ='" & TxtTipo.Text &
                "',PAR_IDENPARA ='" & TxtId.Text & "',PAR_DESCRIP1 ='" & TxtDescripcion1.Text &
                "',PAR_DESCRIP2 ='" & TxtDescripcion2.Text & "',PAR_DESCRIP3 ='" & TxtDescripcion3.Text & "',PAR_STATUS ='" & CmbStatus.Text &
                "',PAR_FECHA1 ='" & TxtFecha1.Text & "',PAR_FECHA2 ='" & TxtFecha2.Text & "',PAR_FECHA3 ='" & TxtFecha3.Text & "'"

            If Conexion.Actualizar("CRM_PARAMETR", Actualiza, "PAR_TIPOPARA = '" & TxtTipo.Text & "'and PAR_IDENPARA ='" & TxtId.Text & "'") Then
                MsgBox("Registro Actualizado Correctamente")
                MostraDatos()
            Else
                MsgBox("Error al Guardar ")
            End If

        End If
        MostraDatos()
        Limpiar_Datos()
    End Sub

    Private Sub MostraDatos()
        'carga la infoirmacion al datagrid
        Conexion.Consultar("Select PAR_TIPOPARA,PAR_IDENPARA,PAR_DESCRIP1 AS DESCRIP,PAR_DESCRIP2 AS DESCRIP2,PAR_DESCRIP3 AS DESCRIP3,PAR_STATUS," &
                           "PAR_FECHA1,PAR_FECHA2,PAR_FECHA3 from CRM_PARAMETR where PAR_TIPOPARA like'" & TxtTipo.Text & "%' and PAR_IDENPARA like'" & TxtId.Text & "%'", "CRM_PARAMETR")
        DgvDatos.DataSource = Conexion.Ds.Tables("CRM_PARAMETR")
        Me.DgvDatos.Columns(0).HeaderText = "TIPO"
        Me.DgvDatos.Columns(1).HeaderText = "ID"
        Me.DgvDatos.Columns(2).HeaderText = "DESCRIPCION"
        Me.DgvDatos.Columns(3).HeaderText = "DESCRIPCION2"
        Me.DgvDatos.Columns(4).HeaderText = "DESCRIPCION3"
        Me.DgvDatos.Columns(5).HeaderText = "STATUS"
        Me.DgvDatos.Columns(6).HeaderText = "FECHA1"
        Me.DgvDatos.Columns(7).HeaderText = "FECHA2"
        Me.DgvDatos.Columns(8).HeaderText = "FECHA3"
        Me.DgvDatos.Columns(0).Width = 60
        Me.DgvDatos.Columns(1).Width = 60
        Me.DgvDatos.Columns(2).Width = 160
        Me.DgvDatos.Columns(3).Width = 160
    End Sub
    Private Sub Limpiar_Datos()
        TxtTipo.Text = ""
        TxtId.Text = ""
        TxtDescripcion1.Text = ""
        TxtDescripcion2.Text = ""
        TxtDescripcion3.Text = ""
        TxtFecha1.Text = ""
        TxtFecha2.Text = ""
        TxtFecha3.Text = ""
        CmbStatus.Text = ""
    End Sub
    Private Sub Validar()
        Conexion.Consultar("Select PAR_TIPOPARA,PAR_IDENPARA from CRM_PARAMETR where PAR_TIPOPARA = '" & TxtTipo.Text & "' and PAR_IDENPARA ='" & TxtId.Text & "'", "CRM_PARAMETR")
        Alta = Conexion.Ds.Tables("CRM_PARAMETR").Rows.Count
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DgvDatos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDatos.CellContentDoubleClick
        Try
            Dim Dvg As DataGridViewRow = DgvDatos.Rows(e.RowIndex)
            TxtTipo.Text = Dvg.Cells(0).Value.ToString
            TxtId.Text = Dvg.Cells(1).Value.ToString
            TxtDescripcion1.Text = Dvg.Cells(2).Value.ToString
            TxtDescripcion2.Text = Dvg.Cells(3).Value.ToString
            TxtDescripcion3.Text = Dvg.Cells(4).Value.ToString
            TxtFecha1.Text = Dvg.Cells(6).Value.ToString
            TxtFecha2.Text = Dvg.Cells(7).Value.ToString
            TxtFecha3.Text = Dvg.Cells(8).Value.ToString
            CmbStatus.Text = Dvg.Cells(5).Value.ToString
        Catch ex As Exception
        End Try

    End Sub
End Class

