
Public Class FmBuscar

    Dim Conexion As Conexion_Dt = New Conexion_Dt

    Private Sub FmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'carga la infoirmacion al datagrid
        Conexion.Dt.Columns.Clear()
        Conexion.LlenarGrilla(Librerias.Query, Librerias.Tabla)
        DgvConsulta.DataSource = Conexion.Dt

    End Sub

    Private Sub DgvConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvConsulta.CellContentClick
        Try
            Dim Dvg As DataGridViewRow = DgvConsulta.Rows(e.RowIndex)
            Librerias.Id_Bus = Dvg.Cells(0).Value.ToString
        Catch ex As Exception
        End Try
        Conexion.Dt.Clear()

        Me.Close()
    End Sub

End Class
