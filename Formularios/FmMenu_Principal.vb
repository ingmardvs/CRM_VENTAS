

Public Class FmMenu_Principal

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
    Private Sub Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usuarios.Click
        FmAltaUsuarios.MdiParent = Me
        FmAltaUsuarios.Show()
    End Sub
    Private Sub Vendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendedores.Click
        FmAltaVendedor.MdiParent = Me
        FmAltaVendedor.Show()
    End Sub
    Private Sub Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Parametros.Click
        FmParametros.MdiParent = Me
        FmParametros.Show()
    End Sub
    Private Sub Seguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seguimiento.Click
        Select Case Permiso
            Case 9
                FmSeguimientoAcc.MdiParent = Me
                FmSeguimientoAcc.Show()
            Case 8
                FmSeguimientoEnt.MdiParent = Me
                FmSeguimientoEnt.Show()
            Case 7
                FmSeguimientoAux.MdiParent = Me
                FmSeguimientoAux.Show()
            Case 6
                FmSeguimientoBDC.MdiParent = Me
                FmSeguimientoBDC.Show()
            Case 5
                FmSeguimientoVal.MdiParent = Me
                FmSeguimientoVal.Show()
            Case 4
                FmSeguimientoFI.MdiParent = Me
                FmSeguimientoFI.Show()
            Case 2
                FmSeguimientoVend.MdiParent = Me
                FmSeguimientoVend.Show()
            Case 1
                FmSeguimientoGTES.MdiParent = Me
                FmSeguimientoGTES.Show()
            Case 0
                FmSeguimiento.MdiParent = Me
                FmSeguimiento.Show()
        End Select

    End Sub
    Private Sub ProspectoHostessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProspectoHostessToolStripMenuItem.Click
        Activar = 0
        Dim Alt_Pro As New FmAltaPros() ' permite abrir varias pantallas
        With Alt_Pro
            .MdiParent = Me
            .Text = "ALTA DE PROSPECTOS"
            .Show()
        End With

    End Sub

    Private Sub FmMenu_Principal_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub FmMenu_Principal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Select Case Permiso
            Case 9
                PanelDeControl.Visible = False
            Case 8
                PanelDeControl.Visible = False
            Case 7
                PanelDeControl.Visible = False
                Asesores.Visible = True
            Case 6
                PanelDeControl.Visible = False
                Asesores.Visible = True
            Case 5
                PanelDeControl.Visible = False
            Case 3
                PanelDeControl.Visible = False
                Asesores.Visible = False
            Case 4
                PanelDeControl.Visible = False
            Case 2
                PanelDeControl.Visible = False
            Case 1
                PanelDeControl.Visible = False
                Asesores.Visible = True
                PisoDeVenta.Visible = True
        End Select
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FmActProsGral.MdiParent = Me
        FmActProsGral.Show()
    End Sub
End Class