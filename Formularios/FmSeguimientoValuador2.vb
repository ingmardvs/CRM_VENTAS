Public Class FmSeguimientoValuador2

    Dim Conexion As Conexion_Dt = New Conexion_Dt
    Dim Conexion2 As Conexion_Dr = New Conexion_Dr

    Private Sub FmSeguimientoValuador_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "" & DateTime.Now
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Mostrar_Datos()         'carga la informacion al datagrid

        DvgProsperto.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
        DvgProsperto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DvgProsperto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
    End Sub

    Private Sub DvgProsperto_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DvgProsperto.CellContentDoubleClick

        If e.RowIndex >= 0 Then

            Dim Dgv_Buscar As DataGridViewRow = DvgProsperto.Rows(e.RowIndex)
            Id_Bus = Dgv_Buscar.Cells("PRO_ID").Value.ToString
            If (DvgProsperto.CurrentCell.OwningColumn.DataPropertyName) = "TAC" Then
                FmTAC.ShowDialog()
            End If
        End If

    End Sub
    Public Sub Mostrar_Datos()
        Dim Sql As String = "Select PRO_ID, PRO_FECALTA As FECHA, Rtrim(PRO_NOMBRE)+' '+Rtrim(PRO_PATERNO)+' '+Rtrim(PRO_MATERNO) as NOMBRE,isnull(TAC_ESTATUS,'') as TAC From CRM_PROSPECTOS LEFT JOIN CRM_TAC ON CRM_PROSPECTOS.PRO_ID = CRM_TAC.TAC_IDPROS where TAC_ESTATUS <> 'NO'"
        Conexion.LlenarGrilla(Sql, "CRM_PROSPECTOS")
        DvgProsperto.DataSource = Conexion.Dt
    End Sub

    Public Sub ActualizarDatos()
        If (FmActividades.FindForm.CanFocus) Then
            Mostrar_Datos()
        End If
    End Sub

End Class