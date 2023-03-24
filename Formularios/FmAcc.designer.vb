<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAcc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmAcc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcomentario1 = New System.Windows.Forms.TextBox()
        Me.txtcosto1 = New System.Windows.Forms.TextBox()
        Me.txtacc1 = New System.Windows.Forms.TextBox()
        Me.txtacc2 = New System.Windows.Forms.TextBox()
        Me.txtcosto2 = New System.Windows.Forms.TextBox()
        Me.txtcomentario2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtacc3 = New System.Windows.Forms.TextBox()
        Me.txtcosto3 = New System.Windows.Forms.TextBox()
        Me.txtcomentario3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.cmbestacc = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Accesorio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Costo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comentario:"
        '
        'txtcomentario1
        '
        Me.txtcomentario1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomentario1.Location = New System.Drawing.Point(117, 86)
        Me.txtcomentario1.Multiline = True
        Me.txtcomentario1.Name = "txtcomentario1"
        Me.txtcomentario1.Size = New System.Drawing.Size(235, 49)
        Me.txtcomentario1.TabIndex = 3
        '
        'txtcosto1
        '
        Me.txtcosto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcosto1.Location = New System.Drawing.Point(117, 56)
        Me.txtcosto1.Name = "txtcosto1"
        Me.txtcosto1.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto1.TabIndex = 2
        '
        'txtacc1
        '
        Me.txtacc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtacc1.Location = New System.Drawing.Point(156, 30)
        Me.txtacc1.Name = "txtacc1"
        Me.txtacc1.Size = New System.Drawing.Size(100, 20)
        Me.txtacc1.TabIndex = 1
        '
        'txtacc2
        '
        Me.txtacc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtacc2.Location = New System.Drawing.Point(156, 164)
        Me.txtacc2.Name = "txtacc2"
        Me.txtacc2.Size = New System.Drawing.Size(100, 20)
        Me.txtacc2.TabIndex = 4
        '
        'txtcosto2
        '
        Me.txtcosto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcosto2.Location = New System.Drawing.Point(117, 190)
        Me.txtcosto2.Name = "txtcosto2"
        Me.txtcosto2.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto2.TabIndex = 5
        '
        'txtcomentario2
        '
        Me.txtcomentario2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomentario2.Location = New System.Drawing.Point(117, 220)
        Me.txtcomentario2.Multiline = True
        Me.txtcomentario2.Name = "txtcomentario2"
        Me.txtcomentario2.Size = New System.Drawing.Size(235, 49)
        Me.txtcomentario2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Comentario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Costo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tipo de Accesorio:"
        '
        'txtacc3
        '
        Me.txtacc3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtacc3.Location = New System.Drawing.Point(156, 297)
        Me.txtacc3.Name = "txtacc3"
        Me.txtacc3.Size = New System.Drawing.Size(100, 20)
        Me.txtacc3.TabIndex = 7
        '
        'txtcosto3
        '
        Me.txtcosto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcosto3.Location = New System.Drawing.Point(117, 323)
        Me.txtcosto3.Name = "txtcosto3"
        Me.txtcosto3.Size = New System.Drawing.Size(100, 20)
        Me.txtcosto3.TabIndex = 8
        '
        'txtcomentario3
        '
        Me.txtcomentario3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomentario3.Location = New System.Drawing.Point(117, 353)
        Me.txtcomentario3.Multiline = True
        Me.txtcomentario3.Name = "txtcomentario3"
        Me.txtcomentario3.Size = New System.Drawing.Size(235, 49)
        Me.txtcomentario3.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Comentario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Costo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(31, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tipo de Accesorio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 134)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accesorio 1:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 134)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accesorio 2:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 134)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accesorio 3:"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(49, 452)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(106, 23)
        Me.btnguardar.TabIndex = 21
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(232, 452)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(106, 23)
        Me.btncerrar.TabIndex = 22
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'cmbestacc
        '
        Me.cmbestacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestacc.FormattingEnabled = True
        Me.cmbestacc.Location = New System.Drawing.Point(117, 417)
        Me.cmbestacc.Name = "cmbestacc"
        Me.cmbestacc.Size = New System.Drawing.Size(138, 21)
        Me.cmbestacc.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(31, 422)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Estatus:"
        '
        'FmAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(391, 483)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbestacc)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtacc3)
        Me.Controls.Add(Me.txtcosto3)
        Me.Controls.Add(Me.txtcomentario3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtacc2)
        Me.Controls.Add(Me.txtcosto2)
        Me.Controls.Add(Me.txtcomentario2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtacc1)
        Me.Controls.Add(Me.txtcosto1)
        Me.Controls.Add(Me.txtcomentario1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmAcc"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Competidores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcomentario1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcosto1 As System.Windows.Forms.TextBox
    Friend WithEvents txtacc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtacc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcosto2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcomentario2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtacc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtcosto3 As System.Windows.Forms.TextBox
    Friend WithEvents txtcomentario3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents cmbestacc As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
