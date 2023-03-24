Public Class FmSeguimientoAcc

    Dim Conexion As Conexion_Dt = New Conexion_Dt
    Dim Conexion2 As Conexion_Dr = New Conexion_Dr
    Dim proec, etac, ege, eacc, epm As String
    Dim evpe, evape As Boolean
    Private Sub FmSeguimiento_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Nombre del Asesor - Seguimiento de Prospectos - " & DateTime.Now
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Mostrar_Datos()         'carga la informacion al datagrid
        ColoreaAct()
        DvgProsperto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DvgProsperto.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DvgProsperto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DvgProsperto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Conexion2.LlenarCombo("SELECT RTRIM(VEND_NOMBRE) + ' ' + RTRIM(VEND_PATERNO) + ' ' +VEND_MATERNO+' -'+ convert(varchar(4),VEND_ID) AS NOMBRE FROM CRM_VENDEDORES ORDER BY VEND_NOMBRE ASC", cmbvendedor)
    End Sub

    Private Sub DvgProsperto_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvgProsperto.CellContentDoubleClick
        ColoreaAct()
        If e.RowIndex >= 0 Then
            ColoreaAct()
            Dim Dgv_Buscar As DataGridViewRow = DvgProsperto.Rows(e.RowIndex)
            Id_Bus = Dgv_Buscar.Cells("PRO_ID").Value.ToString

            If (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "NOMBRE" Then
                Activar = 1
                FmActPros.Text = "ACTUALIZACION DE PROSPECTOS"
                FmActPros.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "VEHICULO" Then
                Activar = 1
                FmAltaPros.Text = "ACTUALIZACION DE UNIDADES"
                FmAltaPros.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ACC" Then
                FmAcc.ShowDialog()
            End If

        End If

    End Sub
    Public Sub Mostrar_Datos()
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO,isnull(ACC_ESTATUS,'') as ACC From CRM_PROSPECTOS as PROS left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID LEFT JOIN CRM_VENDEDORES AS VEND ON PROS.PRO_IDVEND = VEND.VEND_ID WHERE ACC_ESTATUS <> 'NO'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
    End Sub

    Public Sub COLOR_CELDAS()
        For A As Integer = 0 To DvgProsperto.RowCount() - 1 Step 1
            If DvgProsperto.Rows(A).Cells(4).Value = "SI,SI" Or DvgProsperto.Rows(A).Cells(4).Value = "SI" Then
                DvgProsperto.Rows(A).Cells(4).Style.BackColor = Color.Green
            ElseIf DvgProsperto.Rows(A).Cells(4).Value = "NO" Then
                DvgProsperto.Rows(A).Cells(4).Style.BackColor = Color.Yellow
            ElseIf DvgProsperto.Rows(A).Cells(4).Value = "PENDIENTE" Or DvgProsperto.Rows(A).Cells(4).Value = "SI,NO" Then
                DvgProsperto.Rows(A).Cells(4).Style.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub DvgProsperto_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DvgProsperto.Sorted
        COLOR_CELDAS()
    End Sub

    Public Sub ColoreaAct()
        'Dim i As Integer
        'For i = 0 To DvgProsperto.RowCount() - 1 Step +1
        'If (DvgProsperto.Rows(i).Cells(6).Value <> "" And DvgProsperto.Rows(i).Cells(6).Value <> "PENDIENTE") Then
        'DvgProsperto.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
        'End If
        'Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ColoreaAct()
        Mostrar_Datos()
        Timer1.Stop()
    End Sub

    Private Sub btncanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncanc.Click
        Mostrar_Datos()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If txtmaterno.Text <> "" Then txtmaterno.Text = "%" + txtmaterno.Text + "%"
        If txtpaterno.Text <> "" Then txtpaterno.Text = "%" + txtpaterno.Text + "%"
        If txtnombre.Text <> "" Then txtnombre.Text = "%" + txtnombre.Text + "%"
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO,isnull(ACC_ESTATUS,'') as ACC From CRM_PROSPECTOS LEFT JOIN CRM_ACTIVIDADES ON CRM_PROSPECTOS.PRO_ID = CRM_ACTIVIDADES.ACT_IDPROS LEFT JOIN CRM_VENDEDORES AS VEND ON CRM_PROSPECTOS.PRO_IDVEND = VEND.VEND_ID left join CRM_ACCESORIOS AS ACC ON CRM_PROSPECTOS.PRO_ID = ACC.ACC_PROSID WHERE ACC_ESTATUS <> 'NO' and PRO_NOMBRE like '" + txtnombre.Text + "' or PRO_PATERNO like '" + txtpaterno.Text + "' OR PRO_MATERNO like '" + txtmaterno.Text + "'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
    End Sub

    Private Sub btnbuscavend_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscavend.Click
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,isnull(ACC_ESTATUS,'') as ACC " &
        "From CRM_PROSPECTOS as PROS LEFT JOIN CRM_VENDEDORES AS VEND ON PROS.PRO_IDvend = VEND.VEND_ID left join CRM_ACTIVIDADES AS ACT ON PROS.PRO_ID = ACT.ACT_IDPROS left join CRM_ACCESORIOS AS ACC ON PROS.PRO_ID = ACC.ACC_PROSID WHERE isnull(ACT.ACT_ESTATUSFAC,'') <> 'SI' AND ACT_ESTATUSACC <> 'NO' AND VEND.VEND_ID = '" & Mid(cmbvendedor.Text, (InStr(1, cmbvendedor.Text, "-") + 1)) & "'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
        ColoreaAct()
        Limpiar()
    End Sub

    Public Sub Limpiar()
        cmbvendedor.Text = ""
        txtmaterno.Text = ""
        txtnombre.Text = ""
        txtpaterno.Text = ""
    End Sub

    Private Sub btncancvend_Click(sender As System.Object, e As System.EventArgs) Handles btncancvend.Click
        Mostrar_Datos()
    End Sub
End Class