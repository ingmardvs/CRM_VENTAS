<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmBuscar))
        Me.DgvConsulta = New System.Windows.Forms.DataGridView()
        CType(Me.DgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConsulta
        '
        Me.DgvConsulta.AllowUserToAddRows = False
        Me.DgvConsulta.AllowUserToDeleteRows = False
        Me.DgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsulta.Location = New System.Drawing.Point(13, 13)
        Me.DgvConsulta.MultiSelect = False
        Me.DgvConsulta.Name = "DgvConsulta"
        Me.DgvConsulta.ReadOnly = True
        Me.DgvConsulta.RowHeadersVisible = False
        Me.DgvConsulta.Size = New System.Drawing.Size(608, 213)
        Me.DgvConsulta.TabIndex = 1
        '
        'FmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 240)
        Me.Controls.Add(Me.DgvConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmBuscar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvConsulta As System.Windows.Forms.DataGridView

End Class
