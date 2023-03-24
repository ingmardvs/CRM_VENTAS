<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCitasHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmCitasHist))
        Me.DgvHistorico = New System.Windows.Forms.DataGridView()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOTIVOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEDIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMENTARIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIT_IDCITA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIT_IDPROS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvHistorico
        '
        Me.DgvHistorico.AllowUserToAddRows = False
        Me.DgvHistorico.AllowUserToDeleteRows = False
        Me.DgvHistorico.AllowUserToResizeColumns = False
        Me.DgvHistorico.AllowUserToResizeRows = False
        Me.DgvHistorico.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DgvHistorico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvHistorico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvHistorico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DgvHistorico.ColumnHeadersHeight = 30
        Me.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvHistorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA, Me.HORA, Me.STATUS, Me.MOTIVOS, Me.MEDIO, Me.COMENTARIOS, Me.CIT_IDCITA, Me.CIT_IDPROS})
        Me.DgvHistorico.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgvHistorico.Location = New System.Drawing.Point(12, 12)
        Me.DgvHistorico.MultiSelect = False
        Me.DgvHistorico.Name = "DgvHistorico"
        Me.DgvHistorico.ReadOnly = True
        Me.DgvHistorico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DgvHistorico.RowHeadersVisible = False
        Me.DgvHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvHistorico.ShowCellErrors = False
        Me.DgvHistorico.Size = New System.Drawing.Size(991, 395)
        Me.DgvHistorico.TabIndex = 1
        Me.DgvHistorico.VirtualMode = True
        '
        'FECHA
        '
        Me.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FECHA.Width = 70
        '
        'HORA
        '
        Me.HORA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.HORA.DataPropertyName = "HORA"
        Me.HORA.HeaderText = "HORA"
        Me.HORA.Name = "HORA"
        Me.HORA.ReadOnly = True
        Me.HORA.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HORA.Width = 50
        '
        'STATUS
        '
        Me.STATUS.DataPropertyName = "STATUS"
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'MOTIVOS
        '
        Me.MOTIVOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MOTIVOS.DataPropertyName = "MOTIVOS"
        Me.MOTIVOS.HeaderText = "MOTIVOS"
        Me.MOTIVOS.Name = "MOTIVOS"
        Me.MOTIVOS.ReadOnly = True
        Me.MOTIVOS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MOTIVOS.Width = 200
        '
        'MEDIO
        '
        Me.MEDIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MEDIO.DataPropertyName = "MEDIO"
        Me.MEDIO.HeaderText = "MEDIO"
        Me.MEDIO.Name = "MEDIO"
        Me.MEDIO.ReadOnly = True
        Me.MEDIO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'COMENTARIOS
        '
        Me.COMENTARIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.COMENTARIOS.DataPropertyName = "COMENTARIOS"
        Me.COMENTARIOS.HeaderText = "COMENTARIOS"
        Me.COMENTARIOS.Name = "COMENTARIOS"
        Me.COMENTARIOS.ReadOnly = True
        Me.COMENTARIOS.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COMENTARIOS.Width = 470
        '
        'CIT_IDCITA
        '
        Me.CIT_IDCITA.DataPropertyName = "CIT_IDCITA"
        Me.CIT_IDCITA.HeaderText = "CIT_IDCITA"
        Me.CIT_IDCITA.Name = "CIT_IDCITA"
        Me.CIT_IDCITA.ReadOnly = True
        Me.CIT_IDCITA.Visible = False
        '
        'CIT_IDPROS
        '
        Me.CIT_IDPROS.DataPropertyName = "CIT_IDPROS"
        Me.CIT_IDPROS.HeaderText = "CIT_IDPROS"
        Me.CIT_IDPROS.Name = "CIT_IDPROS"
        Me.CIT_IDPROS.ReadOnly = True
        Me.CIT_IDPROS.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Location = New System.Drawing.Point(718, 413)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(94, 30)
        Me.BtnSalir.TabIndex = 23
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregar.Location = New System.Drawing.Point(618, 413)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(94, 30)
        Me.BtnAgregar.TabIndex = 22
        Me.BtnAgregar.Text = "&Nueva Cita"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'FmCitasHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1015, 450)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DgvHistorico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmCitasHist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents DgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOTIVOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEDIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMENTARIOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIT_IDCITA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIT_IDPROS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
