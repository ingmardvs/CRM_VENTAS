<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSeguimientoFI2
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSeguimientoFI2))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabProspectos = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DvgProsperto = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VEND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATN = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FI = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACC = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PA = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CRE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Enganche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl.Size = New System.Drawing.Size(1160, 703)
        Me.TabControl.TabIndex = 0
        '
        'TabProspectos
        '
        Me.TabProspectos.BackColor = System.Drawing.Color.Gainsboro
        Me.TabProspectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabProspectos.Controls.Add(Me.GroupBox1)
        Me.TabProspectos.Controls.Add(Me.DvgProsperto)
        Me.TabProspectos.Controls.Add(Me.Label11)
        Me.TabProspectos.Location = New System.Drawing.Point(4, 25)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProspectos.Size = New System.Drawing.Size(1152, 674)
        Me.TabProspectos.TabIndex = 2
        Me.TabProspectos.Text = "Prospectos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(78, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1067, 43)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Prospecto"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(83, 17)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(163, 20)
        Me.MaskedTextBox4.TabIndex = 8
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(321, 17)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(163, 20)
        Me.MaskedTextBox3.TabIndex = 7
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(561, 17)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(163, 20)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(789, 17)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(133, 20)
        Me.MaskedTextBox1.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(740, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "R.F.C. :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(490, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "A. Materno :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(252, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "A. Paterno :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nombre :"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(972, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
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
        Me.DvgProsperto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VEND, Me.NOMBRE, Me.Vehiculo, Me.ATN, Me.FI, Me.GE, Me.ACC, Me.PA, Me.PE, Me.CRE, Me.Enganche, Me.FAC, Me.ENT, Me.PRO_ID})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DvgProsperto.DefaultCellStyle = DataGridViewCellStyle5
        Me.DvgProsperto.Location = New System.Drawing.Point(5, 52)
        Me.DvgProsperto.MultiSelect = False
        Me.DvgProsperto.Name = "DvgProsperto"
        Me.DvgProsperto.ReadOnly = True
        Me.DvgProsperto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DvgProsperto.RowHeadersVisible = False
        Me.DvgProsperto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DvgProsperto.Size = New System.Drawing.Size(1140, 614)
        Me.DvgProsperto.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(20, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Prospectos"
        '
        'Timer1
        '
        '
        'VEND
        '
        Me.VEND.DataPropertyName = "VEND"
        Me.VEND.HeaderText = "Vendedor"
        Me.VEND.Name = "VEND"
        Me.VEND.ReadOnly = True
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
        'Vehiculo
        '
        Me.Vehiculo.DataPropertyName = "VEHICULO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.Vehiculo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Vehiculo.FillWeight = 200.0!
        Me.Vehiculo.HeaderText = "Vehiculo de Interes"
        Me.Vehiculo.Name = "Vehiculo"
        Me.Vehiculo.ReadOnly = True
        Me.Vehiculo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Vehiculo.Width = 250
        '
        'ATN
        '
        Me.ATN.DataPropertyName = "ATN"
        Me.ATN.HeaderText = "Atención"
        Me.ATN.Name = "ATN"
        Me.ATN.ReadOnly = True
        Me.ATN.Width = 75
        '
        'FI
        '
        Me.FI.DataPropertyName = "FI"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FI.DefaultCellStyle = DataGridViewCellStyle4
        Me.FI.HeaderText = "F&I"
        Me.FI.Name = "FI"
        Me.FI.ReadOnly = True
        Me.FI.Width = 60
        '
        'GE
        '
        Me.GE.DataPropertyName = "GE"
        Me.GE.HeaderText = "Garantía Extendida"
        Me.GE.Name = "GE"
        Me.GE.ReadOnly = True
        Me.GE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GE.Width = 75
        '
        'ACC
        '
        Me.ACC.DataPropertyName = "ACC"
        Me.ACC.HeaderText = "Accesorios"
        Me.ACC.Name = "ACC"
        Me.ACC.ReadOnly = True
        Me.ACC.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACC.Width = 60
        '
        'PA
        '
        Me.PA.DataPropertyName = "PA"
        Me.PA.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PA.HeaderText = "Pre Autorización"
        Me.PA.Name = "PA"
        Me.PA.ReadOnly = True
        Me.PA.Width = 80
        '
        'PE
        '
        Me.PE.DataPropertyName = "PE"
        Me.PE.HeaderText = "Propuesta Económica"
        Me.PE.Name = "PE"
        Me.PE.ReadOnly = True
        Me.PE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PE.Width = 65
        '
        'CRE
        '
        Me.CRE.DataPropertyName = "CRE"
        Me.CRE.HeaderText = "Estatus del Credito"
        Me.CRE.Name = "CRE"
        Me.CRE.ReadOnly = True
        '
        'Enganche
        '
        Me.Enganche.DataPropertyName = "ENG"
        Me.Enganche.HeaderText = "Enganche"
        Me.Enganche.Name = "Enganche"
        Me.Enganche.ReadOnly = True
        Me.Enganche.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enganche.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FAC
        '
        Me.FAC.DataPropertyName = "FAC"
        Me.FAC.HeaderText = "FACTURADO"
        Me.FAC.Name = "FAC"
        Me.FAC.ReadOnly = True
        '
        'ENT
        '
        Me.ENT.DataPropertyName = "ENT"
        Me.ENT.HeaderText = "ENTREGADO"
        Me.ENT.Name = "ENT"
        Me.ENT.ReadOnly = True
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
        'FmSeguimientoFI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1166, 710)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmSeguimientoFI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl.ResumeLayout(False)
        Me.TabProspectos.ResumeLayout(False)
        Me.TabProspectos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DvgProsperto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabProspectos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DvgProsperto As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VEND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ATN As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents FI As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ACC As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PA As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CRE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Enganche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
