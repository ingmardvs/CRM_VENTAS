<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSeguimiento
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSeguimiento))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabProspectos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpcita = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncanccita = New System.Windows.Forms.Button()
        Me.btnbuscacita = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbvendedor = New System.Windows.Forms.ComboBox()
        Me.btncancvend = New System.Windows.Forms.Button()
        Me.btnbuscavend = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncanc = New System.Windows.Forms.Button()
        Me.mtbrfc = New System.Windows.Forms.MaskedTextBox()
        Me.txtmaterno = New System.Windows.Forms.TextBox()
        Me.txtpaterno = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DvgProsperto = New System.Windows.Forms.DataGridView()
        Me.VEND = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Vehiculo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Cita = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ATN = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PM = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACC = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FI = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TAC = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CMP = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PA = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CRE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Enganche = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Facturar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ENT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PRO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.TabControl.Size = New System.Drawing.Size(1060, 756)
        Me.TabControl.TabIndex = 0
        '
        'TabProspectos
        '
        Me.TabProspectos.BackColor = System.Drawing.Color.Gainsboro
        Me.TabProspectos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabProspectos.Controls.Add(Me.GroupBox3)
        Me.TabProspectos.Controls.Add(Me.GroupBox2)
        Me.TabProspectos.Controls.Add(Me.GroupBox1)
        Me.TabProspectos.Controls.Add(Me.DvgProsperto)
        Me.TabProspectos.Location = New System.Drawing.Point(4, 25)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabProspectos.Size = New System.Drawing.Size(1052, 727)
        Me.TabProspectos.TabIndex = 2
        Me.TabProspectos.Text = "Prospectos"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox3.Controls.Add(Me.dtpcita)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btncanccita)
        Me.GroupBox3.Controls.Add(Me.btnbuscacita)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(584, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 48)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenar Por Cita"
        '
        'dtpcita
        '
        Me.dtpcita.Location = New System.Drawing.Point(129, 23)
        Me.dtpcita.Name = "dtpcita"
        Me.dtpcita.Size = New System.Drawing.Size(200, 20)
        Me.dtpcita.TabIndex = 23
        Me.dtpcita.Value = New Date(2018, 3, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Selecciona la fecha"
        '
        'btncanccita
        '
        Me.btncanccita.Location = New System.Drawing.Point(432, 21)
        Me.btncanccita.Name = "btncanccita"
        Me.btncanccita.Size = New System.Drawing.Size(75, 23)
        Me.btncanccita.TabIndex = 6
        Me.btncanccita.Text = "&Cancelar"
        Me.btncanccita.UseVisualStyleBackColor = True
        '
        'btnbuscacita
        '
        Me.btnbuscacita.Location = New System.Drawing.Point(351, 21)
        Me.btnbuscacita.Name = "btnbuscacita"
        Me.btnbuscacita.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscacita.TabIndex = 5
        Me.btnbuscacita.Text = "&Buscar"
        Me.btnbuscacita.UseVisualStyleBackColor = True
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
        Me.cmbvendedor.TabIndex = 7
        '
        'btncancvend
        '
        Me.btncancvend.Location = New System.Drawing.Point(485, 21)
        Me.btncancvend.Name = "btncancvend"
        Me.btncancvend.Size = New System.Drawing.Size(75, 23)
        Me.btncancvend.TabIndex = 6
        Me.btncancvend.Text = "&Cancelar"
        Me.btncancvend.UseVisualStyleBackColor = True
        '
        'btnbuscavend
        '
        Me.btnbuscavend.Location = New System.Drawing.Point(404, 21)
        Me.btnbuscavend.Name = "btnbuscavend"
        Me.btnbuscavend.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscavend.TabIndex = 5
        Me.btnbuscavend.Text = "&Buscar"
        Me.btnbuscavend.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btncanc)
        Me.GroupBox1.Controls.Add(Me.mtbrfc)
        Me.GroupBox1.Controls.Add(Me.txtmaterno)
        Me.GroupBox1.Controls.Add(Me.txtpaterno)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1098, 43)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Prospecto"
        '
        'btncanc
        '
        Me.btncanc.Location = New System.Drawing.Point(1011, 14)
        Me.btncanc.Name = "btncanc"
        Me.btncanc.Size = New System.Drawing.Size(75, 23)
        Me.btncanc.TabIndex = 6
        Me.btncanc.Text = "&Cancelar"
        Me.btncanc.UseVisualStyleBackColor = True
        '
        'mtbrfc
        '
        Me.mtbrfc.Location = New System.Drawing.Point(789, 14)
        Me.mtbrfc.Mask = ">L>L>L>L-000000->a>a>a"
        Me.mtbrfc.Name = "mtbrfc"
        Me.mtbrfc.Size = New System.Drawing.Size(119, 20)
        Me.mtbrfc.TabIndex = 4
        '
        'txtmaterno
        '
        Me.txtmaterno.Location = New System.Drawing.Point(561, 16)
        Me.txtmaterno.Name = "txtmaterno"
        Me.txtmaterno.Size = New System.Drawing.Size(162, 20)
        Me.txtmaterno.TabIndex = 3
        '
        'txtpaterno
        '
        Me.txtpaterno.Location = New System.Drawing.Point(322, 16)
        Me.txtpaterno.Name = "txtpaterno"
        Me.txtpaterno.Size = New System.Drawing.Size(162, 20)
        Me.txtpaterno.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(84, 16)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(162, 20)
        Me.txtnombre.TabIndex = 1
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
        Me.BtnBuscar.Location = New System.Drawing.Point(930, 13)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 5
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
        Me.DvgProsperto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VEND, Me.NOMBRE, Me.Vehiculo, Me.Cita, Me.ATN, Me.PM, Me.GE, Me.ACC, Me.FI, Me.TAC, Me.CMP, Me.PE, Me.PA, Me.CRE, Me.Enganche, Me.Facturar, Me.ENT, Me.PRO_ID})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DvgProsperto.DefaultCellStyle = DataGridViewCellStyle6
        Me.DvgProsperto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DvgProsperto.Location = New System.Drawing.Point(3, 106)
        Me.DvgProsperto.MultiSelect = False
        Me.DvgProsperto.Name = "DvgProsperto"
        Me.DvgProsperto.ReadOnly = True
        Me.DvgProsperto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DvgProsperto.RowHeadersVisible = False
        Me.DvgProsperto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DvgProsperto.Size = New System.Drawing.Size(1042, 614)
        Me.DvgProsperto.TabIndex = 6
        '
        'VEND
        '
        Me.VEND.DataPropertyName = "VEND"
        Me.VEND.HeaderText = "Vendedor"
        Me.VEND.Name = "VEND"
        Me.VEND.ReadOnly = True
        Me.VEND.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VEND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        Me.NOMBRE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NOMBRE.Text = ""
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
        Me.Vehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Vehiculo.Width = 250
        '
        'Cita
        '
        Me.Cita.DataPropertyName = "CITA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.Cita.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cita.FillWeight = 200.0!
        Me.Cita.HeaderText = "Fecha de Cita"
        Me.Cita.Name = "Cita"
        Me.Cita.ReadOnly = True
        Me.Cita.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Cita.Width = 70
        '
        'ATN
        '
        Me.ATN.DataPropertyName = "ATN"
        Me.ATN.HeaderText = "Atención"
        Me.ATN.Name = "ATN"
        Me.ATN.ReadOnly = True
        Me.ATN.Width = 75
        '
        'PM
        '
        Me.PM.DataPropertyName = "PM"
        Me.PM.HeaderText = "Prueba de Manejo"
        Me.PM.Name = "PM"
        Me.PM.ReadOnly = True
        Me.PM.Width = 80
        '
        'GE
        '
        Me.GE.DataPropertyName = "GE"
        Me.GE.HeaderText = "Garantía Extendida"
        Me.GE.Name = "GE"
        Me.GE.ReadOnly = True
        Me.GE.Width = 75
        '
        'ACC
        '
        Me.ACC.DataPropertyName = "ACC"
        Me.ACC.HeaderText = "Presentar Accesorios"
        Me.ACC.Name = "ACC"
        Me.ACC.ReadOnly = True
        Me.ACC.Width = 60
        '
        'FI
        '
        Me.FI.DataPropertyName = "FI"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FI.DefaultCellStyle = DataGridViewCellStyle5
        Me.FI.HeaderText = "Presentar F&I"
        Me.FI.Name = "FI"
        Me.FI.ReadOnly = True
        Me.FI.Width = 60
        '
        'TAC
        '
        Me.TAC.DataPropertyName = "TAC"
        Me.TAC.HeaderText = "T.A.C."
        Me.TAC.Name = "TAC"
        Me.TAC.ReadOnly = True
        Me.TAC.Width = 60
        '
        'CMP
        '
        Me.CMP.DataPropertyName = "CMP"
        Me.CMP.HeaderText = "Competidor"
        Me.CMP.Name = "CMP"
        Me.CMP.ReadOnly = True
        Me.CMP.Width = 83
        '
        'PE
        '
        Me.PE.DataPropertyName = "PE"
        Me.PE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PE.HeaderText = "Propuesta Económica"
        Me.PE.Name = "PE"
        Me.PE.ReadOnly = True
        Me.PE.Width = 65
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
        '
        'Facturar
        '
        Me.Facturar.DataPropertyName = "FAC"
        Me.Facturar.HeaderText = "Facturar"
        Me.Facturar.Name = "Facturar"
        Me.Facturar.ReadOnly = True
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
        'FmSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1060, 756)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmSeguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl.ResumeLayout(False)
        Me.TabProspectos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtmaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtpaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents mtbrfc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btncanc As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents btncancvend As System.Windows.Forms.Button
    Friend WithEvents btnbuscavend As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncanccita As System.Windows.Forms.Button
    Friend WithEvents btnbuscacita As System.Windows.Forms.Button
    Friend WithEvents dtpcita As System.Windows.Forms.DateTimePicker
    Friend WithEvents VEND As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Vehiculo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Cita As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ATN As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PM As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ACC As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents FI As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TAC As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CMP As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PA As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CRE As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Enganche As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Facturar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ENT As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PRO_ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
