<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSeguimientoValuador2
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSeguimientoValuador2))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabProspectos = New System.Windows.Forms.TabPage()
        Me.DvgProsperto = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAC = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        CType(Me.DvgProsperto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.TabProspectos)
        Me.TabControl.Location = New System.Drawing.Point(1, 2)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1357, 703)
        Me.TabControl.TabIndex = 0
        '
        'TabProspectos
        '
        Me.TabProspectos.BackColor = System.Drawing.Color.Gainsboro
        Me.TabProspectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabProspectos.Controls.Add(Me.DvgProsperto)
        Me.TabProspectos.Location = New System.Drawing.Point(4, 25)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProspectos.Size = New System.Drawing.Size(1349, 674)
        Me.TabProspectos.TabIndex = 2
        Me.TabProspectos.Text = "Prospectos"
        '
        'DvgProsperto
        '
        Me.DvgProsperto.AllowUserToAddRows = False
        Me.DvgProsperto.AllowUserToDeleteRows = False
        Me.DvgProsperto.AllowUserToResizeColumns = False
        Me.DvgProsperto.AllowUserToResizeRows = False
        Me.DvgProsperto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DvgProsperto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DvgProsperto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DvgProsperto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DvgProsperto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DvgProsperto.ColumnHeadersHeight = 60
        Me.DvgProsperto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DvgProsperto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.TAC, Me.FECHA, Me.PRO_ID})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DvgProsperto.DefaultCellStyle = DataGridViewCellStyle4
        Me.DvgProsperto.Location = New System.Drawing.Point(5, 6)
        Me.DvgProsperto.MultiSelect = False
        Me.DvgProsperto.Name = "DvgProsperto"
        Me.DvgProsperto.ReadOnly = True
        Me.DvgProsperto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DvgProsperto.RowHeadersVisible = False
        Me.DvgProsperto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DvgProsperto.Size = New System.Drawing.Size(605, 449)
        Me.DvgProsperto.TabIndex = 15
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.NOMBRE.DefaultCellStyle = DataGridViewCellStyle2
        Me.NOMBRE.FillWeight = 200.0!
        Me.NOMBRE.HeaderText = "Nombre Prospecto"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NOMBRE.Width = 201
        '
        'TAC
        '
        Me.TAC.DataPropertyName = "TAC"
        Me.TAC.HeaderText = "T.A.C."
        Me.TAC.Name = "TAC"
        Me.TAC.ReadOnly = True
        Me.TAC.Width = 200
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.FECHA.DefaultCellStyle = DataGridViewCellStyle3
        Me.FECHA.FillWeight = 200.0!
        Me.FECHA.HeaderText = "Fecha de Alta"
        Me.FECHA.MaxInputLength = 15
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.ToolTipText = "Fecha de Alta del Prospecto"
        Me.FECHA.Width = 200
        '
        'PRO_ID
        '
        Me.PRO_ID.DataPropertyName = "PRO_ID"
        Me.PRO_ID.HeaderText = "PRO_ID"
        Me.PRO_ID.Name = "PRO_ID"
        Me.PRO_ID.ReadOnly = True
        Me.PRO_ID.Visible = False
        Me.PRO_ID.Width = 70
        '
        'FmSeguimientoValuador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(625, 491)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmSeguimientoValuador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl.ResumeLayout(False)
        Me.TabProspectos.ResumeLayout(False)
        CType(Me.DvgProsperto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabProspectos As System.Windows.Forms.TabPage
    Friend WithEvents DvgProsperto As System.Windows.Forms.DataGridView
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAC As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
