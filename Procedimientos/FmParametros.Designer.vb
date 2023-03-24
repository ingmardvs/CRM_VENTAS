<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmParametros
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmParametros))
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtFecha1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFecha2 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFecha3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvDatos
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDatos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvDatos.Location = New System.Drawing.Point(10, 226)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.Size = New System.Drawing.Size(672, 233)
        Me.DgvDatos.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CmbStatus)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(174, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 13)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 13)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'CmbStatus
        '
        Me.CmbStatus.CausesValidation = False
        Me.CmbStatus.Items.AddRange(New Object() {"ACTIVO" & Global.Microsoft.VisualBasic.ChrW(9), "INACTIVO"})
        Me.CmbStatus.Location = New System.Drawing.Point(352, 33)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(157, 21)
        Me.CmbStatus.TabIndex = 5
        '
        'TxtId
        '
        Me.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtId.Location = New System.Drawing.Point(169, 33)
        Me.TxtId.MaxLength = 10
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(173, 20)
        Me.TxtId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Identificador"
        '
        'TxtTipo
        '
        Me.TxtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipo.Location = New System.Drawing.Point(13, 32)
        Me.TxtTipo.MaxLength = 5
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(141, 20)
        Me.TxtTipo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(356, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(35, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(10, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 144)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripcion"
        '
        'TxtDescripcion3
        '
        Me.TxtDescripcion3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion3.Location = New System.Drawing.Point(13, 112)
        Me.TxtDescripcion3.MaxLength = 50
        Me.TxtDescripcion3.Name = "TxtDescripcion3"
        Me.TxtDescripcion3.Size = New System.Drawing.Size(492, 20)
        Me.TxtDescripcion3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descricion 3"
        '
        'TxtDescripcion2
        '
        Me.TxtDescripcion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion2.Location = New System.Drawing.Point(13, 73)
        Me.TxtDescripcion2.MaxLength = 50
        Me.TxtDescripcion2.Name = "TxtDescripcion2"
        Me.TxtDescripcion2.Size = New System.Drawing.Size(492, 20)
        Me.TxtDescripcion2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descricion 2"
        '
        'TxtDescripcion1
        '
        Me.TxtDescripcion1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion1.Location = New System.Drawing.Point(13, 34)
        Me.TxtDescripcion1.MaxLength = 50
        Me.TxtDescripcion1.Name = "TxtDescripcion1"
        Me.TxtDescripcion1.Size = New System.Drawing.Size(492, 20)
        Me.TxtDescripcion1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(16, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Descricion 1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtFecha1)
        Me.GroupBox4.Controls.Add(Me.TxtFecha2)
        Me.GroupBox4.Controls.Add(Me.TxtFecha3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(536, 71)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(146, 144)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fechas"
        '
        'TxtFecha1
        '
        Me.TxtFecha1.Location = New System.Drawing.Point(13, 34)
        Me.TxtFecha1.Mask = "00/00/0000"
        Me.TxtFecha1.Name = "TxtFecha1"
        Me.TxtFecha1.Size = New System.Drawing.Size(120, 20)
        Me.TxtFecha1.TabIndex = 11
        Me.TxtFecha1.ValidatingType = GetType(Date)
        '
        'TxtFecha2
        '
        Me.TxtFecha2.Location = New System.Drawing.Point(13, 73)
        Me.TxtFecha2.Mask = "00/00/0000"
        Me.TxtFecha2.Name = "TxtFecha2"
        Me.TxtFecha2.Size = New System.Drawing.Size(120, 20)
        Me.TxtFecha2.TabIndex = 10
        Me.TxtFecha2.ValidatingType = GetType(Date)
        '
        'TxtFecha3
        '
        Me.TxtFecha3.Location = New System.Drawing.Point(13, 111)
        Me.TxtFecha3.Mask = "00/00/0000"
        Me.TxtFecha3.Name = "TxtFecha3"
        Me.TxtFecha3.Size = New System.Drawing.Size(120, 20)
        Me.TxtFecha3.TabIndex = 9
        Me.TxtFecha3.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Fecha 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha 1"
        '
        'Buscar
        '
        Me.Buscar.BackColor = System.Drawing.SystemColors.Control
        Me.Buscar.ForeColor = System.Drawing.Color.Black
        Me.Buscar.Location = New System.Drawing.Point(4, 10)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(70, 26)
        Me.Buscar.TabIndex = 6
        Me.Buscar.Text = "&Buscar"
        Me.Buscar.UseVisualStyleBackColor = False
        '
        'Nuevo
        '
        Me.Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.Nuevo.ForeColor = System.Drawing.Color.Black
        Me.Nuevo.Location = New System.Drawing.Point(74, 10)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(69, 26)
        Me.Nuevo.TabIndex = 7
        Me.Nuevo.Text = "&Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = False
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.Guardar.ForeColor = System.Drawing.Color.Black
        Me.Guardar.Location = New System.Drawing.Point(4, 37)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(70, 25)
        Me.Guardar.TabIndex = 8
        Me.Guardar.Text = "&Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Guardar)
        Me.GroupBox3.Controls.Add(Me.Nuevo)
        Me.GroupBox3.Controls.Add(Me.Buscar)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(536, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(147, 65)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(74, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(692, 469)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFecha3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtFecha1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtFecha2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
