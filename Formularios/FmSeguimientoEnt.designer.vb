﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSeguimientoEnt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSeguimientoEnt))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabProspectos = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbvendedor = New System.Windows.Forms.ComboBox()
        Me.btncancvend = New System.Windows.Forms.Button()
        Me.btnbuscavend = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncanc = New System.Windows.Forms.Button()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DvgProsperto = New System.Windows.Forms.DataGridView()
        Me.VEND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facturar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PRO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DvgProsperto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.TabProspectos)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1376, 756)
        Me.TabControl.TabIndex = 0
        '
        'TabProspectos
        '
        Me.TabProspectos.BackColor = System.Drawing.Color.Gainsboro
        Me.TabProspectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabProspectos.Controls.Add(Me.GroupBox2)
        Me.TabProspectos.Controls.Add(Me.GroupBox1)
        Me.TabProspectos.Controls.Add(Me.DvgProsperto)
        Me.TabProspectos.Location = New System.Drawing.Point(4, 25)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProspectos.Size = New System.Drawing.Size(1368, 727)
        Me.TabProspectos.TabIndex = 2
        Me.TabProspectos.Text = "Prospectos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbvendedor)
        Me.GroupBox2.Controls.Add(Me.btncancvend)
        Me.GroupBox2.Controls.Add(Me.btnbuscavend)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 48)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenar Por Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Selecciona el vendedor :"
        '
        'cmbvendedor
        '
        Me.cmbvendedor.FormattingEnabled = True
        Me.cmbvendedor.Location = New System.Drawing.Point(151, 21)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Size = New System.Drawing.Size(237, 21)
        Me.cmbvendedor.TabIndex = 6
        '
        'btncancvend
        '
        Me.btncancvend.Location = New System.Drawing.Point(485, 21)
        Me.btncancvend.Name = "btncancvend"
        Me.btncancvend.Size = New System.Drawing.Size(75, 23)
        Me.btncancvend.TabIndex = 8
        Me.btncancvend.Text = "&Cancelar"
        Me.btncancvend.UseVisualStyleBackColor = True
        '
        'btnbuscavend
        '
        Me.btnbuscavend.Location = New System.Drawing.Point(404, 21)
        Me.btnbuscavend.Name = "btnbuscavend"
        Me.btnbuscavend.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscavend.TabIndex = 7
        Me.btnbuscavend.Text = "&Buscar"
        Me.btnbuscavend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btncanc)
        Me.GroupBox1.Controls.Add(Me.txtmaterno)
        Me.GroupBox1.Controls.Add(Me.txtpaterno)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 43)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Prospecto"
        '
        'btncanc
        '
        Me.btncanc.Location = New System.Drawing.Point(818, 14)
        Me.btncanc.Name = "btncanc"
        Me.btncanc.Size = New System.Drawing.Size(75, 23)
        Me.btncanc.TabIndex = 5
        Me.btncanc.Text = "&Cancelar"
        Me.btncanc.UseVisualStyleBackColor = True
        '
        'txtmaterno
        '
        Me.txtmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmaterno.Location = New System.Drawing.Point(561, 16)
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(162, 20)
        Me.txtmaterno.TabIndex = 3
        '
        'txtpaterno
        '
        Me.txtpaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaterno.Location = New System.Drawing.Point(322, 16)
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(162, 20)
        Me.txtpaterno.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(84, 16)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(162, 20)
        Me.txtnombre.TabIndex = 1
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
        Me.BtnBuscar.Location = New System.Drawing.Point(737, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 4
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
        Me.DvgProsperto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VEND, Me.NOMBRE, Me.Vehiculo, Me.Facturar, Me.ENT, Me.PRO_ID})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DvgProsperto.DefaultCellStyle = DataGridViewCellStyle4
        Me.DvgProsperto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DvgProsperto.Location = New System.Drawing.Point(3, 106)
        Me.DvgProsperto.MultiSelect = False
        Me.DvgProsperto.Name = "DvgProsperto"
        Me.DvgProsperto.ReadOnly = True
        Me.DvgProsperto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DvgProsperto.RowHeadersVisible = False
        Me.DvgProsperto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DvgProsperto.Size = New System.Drawing.Size(1358, 614)
        Me.DvgProsperto.TabIndex = 6
        '
        'VEND
        '
        Me.VEND.DataPropertyName = "VEND"
        Me.VEND.HeaderText = "Vendedor"
        Me.VEND.Name = "VEND"
        Me.VEND.ReadOnly = True
        Me.VEND.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
        'Facturar
        '
        Me.Facturar.DataPropertyName = "FAC"
        Me.Facturar.HeaderText = "Facturar"
        Me.Facturar.Name = "Facturar"
        Me.Facturar.ReadOnly = True
        Me.Facturar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Facturar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ENT
        '
        Me.ENT.DataPropertyName = "ENT"
        Me.ENT.HeaderText = "Entrega"
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
        'Timer1
        '
        '
        'FmSeguimientoEnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1376, 756)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmSeguimientoEnt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl.ResumeLayout(False)
        Me.TabProspectos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DvgProsperto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabProspectos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DvgProsperto As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtmaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtpaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents btncanc As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents btncancvend As System.Windows.Forms.Button
    Friend WithEvents btnbuscavend As System.Windows.Forms.Button
    Friend WithEvents VEND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Facturar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENT As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PRO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
