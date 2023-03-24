<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMenu_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmMenu_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PanelDeControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Vendedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Parametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.PisoDeVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProspectoHostessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Asesores = New System.Windows.Forms.ToolStripMenuItem()
        Me.Seguimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelDeControl, Me.PisoDeVenta, Me.Asesores, Me.SalirToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1216, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PanelDeControl
        '
        Me.PanelDeControl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuarios, Me.ToolStripSeparator1, Me.Vendedores, Me.ToolStripSeparator2, Me.Parametros})
        Me.PanelDeControl.Name = "PanelDeControl"
        Me.PanelDeControl.ShowShortcutKeys = False
        Me.PanelDeControl.Size = New System.Drawing.Size(107, 20)
        Me.PanelDeControl.Text = "&Panel de Control"
        '
        'Usuarios
        '
        Me.Usuarios.Image = CType(resources.GetObject("Usuarios.Image"), System.Drawing.Image)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(135, 22)
        Me.Usuarios.Text = "&Usuarios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'Vendedores
        '
        Me.Vendedores.Image = CType(resources.GetObject("Vendedores.Image"), System.Drawing.Image)
        Me.Vendedores.Name = "Vendedores"
        Me.Vendedores.Size = New System.Drawing.Size(135, 22)
        Me.Vendedores.Text = "&Vendedores"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(132, 6)
        '
        'Parametros
        '
        Me.Parametros.Image = CType(resources.GetObject("Parametros.Image"), System.Drawing.Image)
        Me.Parametros.Name = "Parametros"
        Me.Parametros.Size = New System.Drawing.Size(135, 22)
        Me.Parametros.Text = "&Parametros"
        '
        'PisoDeVenta
        '
        Me.PisoDeVenta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProspectoHostessToolStripMenuItem})
        Me.PisoDeVenta.Name = "PisoDeVenta"
        Me.PisoDeVenta.Size = New System.Drawing.Size(94, 20)
        Me.PisoDeVenta.Text = "Piso de &Ventas"
        '
        'ProspectoHostessToolStripMenuItem
        '
        Me.ProspectoHostessToolStripMenuItem.Name = "ProspectoHostessToolStripMenuItem"
        Me.ProspectoHostessToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ProspectoHostessToolStripMenuItem.Text = "&Prospectos"
        '
        'Asesores
        '
        Me.Asesores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Seguimiento})
        Me.Asesores.Name = "Asesores"
        Me.Asesores.Size = New System.Drawing.Size(65, 20)
        Me.Asesores.Text = "&Asesores"
        '
        'Seguimiento
        '
        Me.Seguimiento.Name = "Seguimiento"
        Me.Seguimiento.Size = New System.Drawing.Size(202, 22)
        Me.Seguimiento.Text = "&Seguimiento Prospectos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShowShortcutKeys = False
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(122, 20)
        Me.ToolStripMenuItem1.Text = "Prueba de personas"
        '
        'FmMenu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1216, 641)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FmMenu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "CRM AUTOIDEAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PanelDeControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Vendedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Parametros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PisoDeVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Asesores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Seguimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProspectoHostessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
