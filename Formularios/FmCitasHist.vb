
Public Class FmCitasHist
    Dim Conexion As Conexion_Dt = New Conexion_Dt

    Private Sub FmCitasHist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mostrar_Datos()
    End Sub

    Public Sub Mostrar_Datos()
        Dim Consulta As String = "SELECT CIT_FECCITA AS FECHA,CIT_HRCITA AS HORA,CIT_ESTATUS AS STATUS,CIT_MOTIVO AS MOTIVOS,CIT_MEDIO AS MEDIO,CIT_COMENT AS COMENTARIOS,CIT_IDCITA,CIT_IDPROS FROM CRM_CITAS WHERE CIT_IDPROS = '" & Id_Bus & "' ORDER BY CIT_IDPROS ,CIT_IDCITA DESC"
        Conexion.LlenarGrilla(Consulta, "CRM_CITAS")
        DgvHistorico.DataSource = Conexion.Dt
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        FmCita.TxtIdCita.Text = ""
        FmCita.TxtIdPros.Text = Id_Bus
        FmCita.ShowDialog()
        Mostrar_Datos()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
        FmSeguimiento.Mostrar_Datos()
    End Sub

    Private Sub DgvHistorico_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvHistorico.CellContentClick
        If e.RowIndex >= 0 Then
            Dim Dvg As DataGridViewRow = DgvHistorico.Rows(e.RowIndex)
            FmCita.TxtIdCita.Text = Dvg.Cells("CIT_IDCITA").Value.ToString
            FmCita.TxtIdPros.Text = Id_Bus
            FmCita.ShowDialog()
            Mostrar_Datos()
        End If
    End Sub
End Class
