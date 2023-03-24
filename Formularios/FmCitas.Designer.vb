<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmCita))
        Me.GpoDatos = New System.Windows.Forms.GroupBox()
        Me.CmbMotivos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.CmbMedios = New System.Windows.Forms.ComboBox()
        Me.TxtFecCita = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHrCita = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtComent = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.TxtIdCita = New System.Windows.Forms.TextBox()
        Me.TxtIdPros = New System.Windows.Forms.TextBox()
        Me.GpoDatos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpoDatos
        '
        Me.GpoDatos.Controls.Add(Me.CmbMotivos)
        Me.GpoDatos.Controls.Add(Me.Label5)
        Me.GpoDatos.Controls.Add(Me.Label2)
        Me.GpoDatos.Controls.Add(Me.TxtStatus)
        Me.GpoDatos.Controls.Add(Me.CmbMedios)
        Me.GpoDatos.Controls.Add(Me.TxtFecCita)
        Me.GpoDatos.Controls.Add(Me.Label1)
        Me.GpoDatos.Controls.Add(Me.TxtHrCita)
        Me.GpoDatos.Controls.Add(Me.Label4)
        Me.GpoDatos.Controls.Add(Me.Label3)
        Me.GpoDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GpoDatos.Location = New System.Drawing.Point(12, 12)
        Me.GpoDatos.Name = "GpoDatos"
        Me.GpoDatos.Size = New System.Drawing.Size(523, 71)
        Me.GpoDatos.TabIndex = 1
        Me.GpoDatos.TabStop = False
        Me.GpoDatos.Text = "Datos:"
        '
        'CmbMotivos
        '
        Me.CmbMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMotivos.FormattingEnabled = True
        Me.CmbMotivos.Location = New System.Drawing.Point(61, 41)
        Me.CmbMotivos.Name = "CmbMotivos"
        Me.CmbMotivos.Size = New System.Drawing.Size(202, 21)
        Me.CmbMotivos.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Motivo :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(256, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Status de Cita"
        '
        'TxtStatus
        '
        Me.TxtStatus.Enabled = False
        Me.TxtStatus.Location = New System.Drawing.Point(344, 16)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(171, 20)
        Me.TxtStatus.TabIndex = 4
        '
        'CmbMedios
        '
        Me.CmbMedios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMedios.FormattingEnabled = True
        Me.CmbMedios.Location = New System.Drawing.Point(344, 42)
        Me.CmbMedios.Name = "CmbMedios"
        Me.CmbMedios.Size = New System.Drawing.Size(171, 21)
        Me.CmbMedios.TabIndex = 6
        '
        'TxtFecCita
        '
        Me.TxtFecCita.Location = New System.Drawing.Point(61, 15)
        Me.TxtFecCita.Mask = "00/00/0000"
        Me.TxtFecCita.Name = "TxtFecCita"
        Me.TxtFecCita.Size = New System.Drawing.Size(77, 20)
        Me.TxtFecCita.TabIndex = 2
        Me.TxtFecCita.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Fecha:"
        '
        'TxtHrCita
        '
        Me.TxtHrCita.Location = New System.Drawing.Point(203, 15)
        Me.TxtHrCita.Mask = "00:00"
        Me.TxtHrCita.Name = "TxtHrCita"
        Me.TxtHrCita.Size = New System.Drawing.Size(40, 20)
        Me.TxtHrCita.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(156, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Hora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(293, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Medio:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtComent)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 92)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comentarios"
        '
        'TxtComent
        '
        Me.TxtComent.Location = New System.Drawing.Point(12, 17)
        Me.TxtComent.MaxLength = 100
        Me.TxtComent.Multiline = True
        Me.TxtComent.Name = "TxtComent"
        Me.TxtComent.Size = New System.Drawing.Size(500, 64)
        Me.TxtComent.TabIndex = 8
        '
        'BtnSalir
        '
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Location = New System.Drawing.Point(433, 173)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(94, 30)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(333, 173)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(94, 30)
        Me.btnguardar.TabIndex = 9
        Me.btnguardar.Text = "&Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'TxtIdCita
        '
        Me.TxtIdCita.Enabled = False
        Me.TxtIdCita.Location = New System.Drawing.Point(18, 179)
        Me.TxtIdCita.Name = "TxtIdCita"
        Me.TxtIdCita.Size = New System.Drawing.Size(58, 20)
        Me.TxtIdCita.TabIndex = 7
        '
        'TxtIdPros
        '
        Me.TxtIdPros.Enabled = False
        Me.TxtIdPros.Location = New System.Drawing.Point(82, 179)
        Me.TxtIdPros.Name = "TxtIdPros"
        Me.TxtIdPros.Size = New System.Drawing.Size(58, 20)
        Me.TxtIdPros.TabIndex = 22
        '
        'FmCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 214)
        Me.Controls.Add(Me.TxtIdPros)
        Me.Controls.Add(Me.TxtIdCita)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GpoDatos)
        Me.Controls.Add(Me.btnguardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FmCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GpoDatos.ResumeLayout(False)
        Me.GpoDatos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtComent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtHrCita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFecCita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CmbMedios As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbMotivos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtIdCita As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdPros As System.Windows.Forms.TextBox
End Class
