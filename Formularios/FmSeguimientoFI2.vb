Public Class FmSeguimientoFI2

    Dim Conexion As Conexion_Dt = New Conexion_Dt
    Dim Conexion2 As Conexion_Dr = New Conexion_Dr
    Dim proec, etac, ege, eacc, epm As String
    Dim eved As Boolean
    Private Sub FmSeguimiento_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Nombre del Asesor - Seguimiento de Prospectos - " & DateTime.Now
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Mostrar_Datos()         'carga la informacion al datagrid
        DvgProsperto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DvgProsperto.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DvgProsperto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DvgProsperto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    End Sub

    Private Sub DvgProsperto_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvgProsperto.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim Dgv_Buscar As DataGridViewRow = DvgProsperto.Rows(e.RowIndex)
            Id_Bus = Dgv_Buscar.Cells("PRO_ID").Value.ToString

            If (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "NOMBRE" Then

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "VEHICULO" Then

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "FI" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                FmActividades.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "GE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                FmActividades.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ACC" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                FmActividades.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "CRE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                ValidaED()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "PE" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                FmActividades.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ENG" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                FmActividades.ShowDialog()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "PA" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                ValidaPA()

            ElseIf (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "ATN" Then
                Actividad = DvgProsperto.CurrentCell.OwningColumn.DataPropertyName
                MsgBox(DvgProsperto.CurrentCell.ColumnIndex)
                If eved = True Then
                    FmActividades.ShowDialog()
                Else
                    MsgBox("No se ha realizado la compra.")
                End If

            End If

        End If

    End Sub
    Public Sub Mostrar_Datos()
        Dim Sql As String =
"Select PRO_ID,isnull(RTRIM(VEND_NOMBRE),'') + ' ' + isnull(RTRIM(VEND_PATERNO),'') + ' ' + isnull(RTRIM(VEND_MATERNO),'') as VEND, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE ,ISNULL((CASE PRO_STATUS1 WHEN 1 THEN Rtrim(PRO_CLI1)+ ' ' + Rtrim(PRO_MOD1)+' Paq. '+ PRO_PAQ1 END),'')+' '+" &
        "ISNULL((CASE PRO_STATUS2 WHEN 1 THEN Rtrim(PRO_CLI2)+ ' ' + Rtrim(PRO_MOD2)+' Paq. '+ PRO_PAQ2 END),'') AS VEHICULO ,isnull(ACT_ESTATUSATN,'') as ATN, " &
        "isnull(ACT_ESTATUSFI,'') as FI,isnull(ACT_ESTATUSGE,'') as GE,isnull(ACT_ESTATUSACC,'') as ACC,isnull(ACT_ESTATUSPA,'') as PA,isnull(ACT_ESTATUSPE,'') as PE,isnull(ACT_ESTATUSCRE,'') as CRE,isnull(ACT_ESTATUSENG,'') as ENG,isnull(ACT_ESTATUSFAC,'') as FAC,isnull(ACT_ESTATUSENT,'') as ENT " &
        "From CRM_PROSPECTOS LEFT JOIN CRM_VENDEDORES AS VEND ON CRM_PROSPECTOS.PRO_IDvend = VEND.VEND_ID left join CRM_ACTIVIDADES ON CRM_PROSPECTOS.PRO_ID = CRM_ACTIVIDADES.ACT_IDPROS left join CRM_COMPETIDOR ON CRM_PROSPECTOS.PRO_ID = CRM_COMPETIDOR.COM_IDPROS WHERE isnull(CRM_ACTIVIDADES.ACT_ESTATUSFAC,'') <> 'SI'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
        COLOR_CELDAS()
    End Sub

    Public Sub COLOR_CELDAS()
        For A As Integer = 0 To DvgProsperto.RowCount() - 1 Step 1
            For B As Integer = 4 To 13 Step 1
                If B = 4 Then
                    'Actividad Atención
                    If DvgProsperto.Rows(A).Cells(B).Value = "ACUERDO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "DESACUERDO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    End If
                Else
                    If DvgProsperto.Rows(A).Cells(B).Value = "SI" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Green
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "PENDIENTE" Or DvgProsperto.Rows(A).Cells(B).Value = "NO" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.Red
                    ElseIf DvgProsperto.Rows(A).Cells(B).Value = "SI,SI" Or DvgProsperto.Rows(A).Cells(B).Value = "SI,NO" Or DvgProsperto.Rows(A).Cells(B).Value = "NO,NO" Or DvgProsperto.Rows(A).Cells(B).Value = "NO,SI" Then
                        DvgProsperto.Rows(A).Cells(B).Style.BackColor = Color.LightBlue
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub ValidaPA()
        Conexion2.Consultar("SELECT isnull(ACT_ESTATUSFI,'') FROM CRM_ACTIVIDADES WHERE ACT_IDPROS = '" & Id_Bus & "'")
        If Conexion2.dr.HasRows Then
            Conexion2.dr.Read()
            If Conexion2.dr.GetString(0) = "" Or Conexion2.dr.GetString(0) = "PENDIENTE" Then
                MsgBox("Aun no se ha realizado la Presentación de la F & I.")
            Else
                Conexion2.dr.Close()
                Conexion2.desconectarse()
                FmActividades.ShowDialog()
            End If
            Conexion2.dr.Close()
            Conexion2.desconectarse()
        Else
            MsgBox("Aun no se ha realizado la Presentación de la F & I.")
        End If
        Conexion2.dr.Close()
        Conexion2.desconectarse()

    End Sub

    Public Sub ValidaED()
        Conexion2.Consultar("SELECT isnull(ACT_ESTATUSPA,'') FROM CRM_ACTIVIDADES WHERE ACT_IDPROS = '" & Id_Bus & "'")
        If Conexion2.dr.HasRows Then
            Conexion2.dr.Read()
            If Conexion2.dr.GetString(0) = "" Or Conexion2.dr.GetString(0) = "PENDIENTE" Then
                MsgBox("No se ha realizado la Pre Autorización")
            Else
                Conexion2.dr.Close()
                Conexion2.desconectarse()
                FmActividades.ShowDialog()
                eved = True
            End If
            Conexion2.dr.Close()
            Conexion2.desconectarse()
        Else
            MsgBox("No se ha realizado la Pre Autorización")
            eved = False
        End If
        Conexion2.dr.Close()
        Conexion2.desconectarse()
    End Sub

    Private Sub DvgProsperto_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DvgProsperto.Sorted
        COLOR_CELDAS()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Mostrar_Datos()
        Timer1.Stop()
    End Sub
End Class