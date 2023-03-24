<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmActividades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmActividades))
        Me.cmbstat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.chkfisica = New System.Windows.Forms.CheckBox()
        Me.chkmoral = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbstat
        '
        Me.cmbstat.FormattingEnabled = True
        Me.cmbstat.Location = New System.Drawing.Point(69, 12)
        Me.cmbstat.Name = "cmbstat"
        Me.cmbstat.Size = New System.Drawing.Size(121, 21)
        Me.cmbstat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estatus:"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(17, 64)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(111, 64)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 3
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'chkfisica
        '
        Me.chkfisica.AutoSize = True
        Me.chkfisica.Location = New System.Drawing.Point(10, 41)
        Me.chkfisica.Name = "chkfisica"
        Me.chkfisica.Size = New System.Drawing.Size(95, 17)
        Me.chkfisica.TabIndex = 4
        Me.chkfisica.Text = "Persona Fisica"
        Me.chkfisica.UseVisualStyleBackColor = True
        Me.chkfisica.Visible = False
        '
        'chkmoral
        '
        Me.chkmoral.AutoSize = True
        Me.chkmoral.Location = New System.Drawing.Point(104, 41)
        Me.chkmoral.Name = "chkmoral"
        Me.chkmoral.Size = New System.Drawing.Size(94, 17)
        Me.chkmoral.TabIndex = 5
        Me.chkmoral.Text = "Persona Moral"
        Me.chkmoral.UseVisualStyleBackColor = True
        Me.chkmoral.Visible = False
        '
        'FmActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(202, 92)
        Me.Controls.Add(Me.chkmoral)
        Me.Controls.Add(Me.chkfisica)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbstat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmActividades"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbstat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents chkfisica As System.Windows.Forms.CheckBox
    Friend WithEvents chkmoral As System.Windows.Forms.CheckBox
End Class
