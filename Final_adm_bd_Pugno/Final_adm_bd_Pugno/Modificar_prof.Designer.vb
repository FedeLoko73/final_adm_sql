<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_prof
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
        Me.chk_mod_prof = New System.Windows.Forms.CheckBox
        Me.cmb_mod_prof = New System.Windows.Forms.ComboBox
        Me.btnbuscar_prof = New System.Windows.Forms.Button
        Me.dgv_mod_prof = New System.Windows.Forms.DataGridView
        Me.btn_mod_prof = New System.Windows.Forms.Button
        Me.btneliminar_prof = New System.Windows.Forms.Button
        CType(Me.dgv_mod_prof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_mod_prof
        '
        Me.chk_mod_prof.AutoSize = True
        Me.chk_mod_prof.Location = New System.Drawing.Point(13, 55)
        Me.chk_mod_prof.Name = "chk_mod_prof"
        Me.chk_mod_prof.Size = New System.Drawing.Size(15, 14)
        Me.chk_mod_prof.TabIndex = 0
        Me.chk_mod_prof.UseVisualStyleBackColor = True
        '
        'cmb_mod_prof
        '
        Me.cmb_mod_prof.FormattingEnabled = True
        Me.cmb_mod_prof.Location = New System.Drawing.Point(123, 52)
        Me.cmb_mod_prof.Name = "cmb_mod_prof"
        Me.cmb_mod_prof.Size = New System.Drawing.Size(417, 21)
        Me.cmb_mod_prof.TabIndex = 1
        '
        'btnbuscar_prof
        '
        Me.btnbuscar_prof.Location = New System.Drawing.Point(630, 50)
        Me.btnbuscar_prof.Name = "btnbuscar_prof"
        Me.btnbuscar_prof.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar_prof.TabIndex = 2
        Me.btnbuscar_prof.Text = "Buscar"
        Me.btnbuscar_prof.UseVisualStyleBackColor = True
        '
        'dgv_mod_prof
        '
        Me.dgv_mod_prof.AllowUserToAddRows = False
        Me.dgv_mod_prof.AllowUserToDeleteRows = False
        Me.dgv_mod_prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mod_prof.Location = New System.Drawing.Point(13, 119)
        Me.dgv_mod_prof.Name = "dgv_mod_prof"
        Me.dgv_mod_prof.ReadOnly = True
        Me.dgv_mod_prof.Size = New System.Drawing.Size(748, 300)
        Me.dgv_mod_prof.TabIndex = 3
        '
        'btn_mod_prof
        '
        Me.btn_mod_prof.Location = New System.Drawing.Point(343, 437)
        Me.btn_mod_prof.Name = "btn_mod_prof"
        Me.btn_mod_prof.Size = New System.Drawing.Size(75, 23)
        Me.btn_mod_prof.TabIndex = 4
        Me.btn_mod_prof.Text = "Modificar"
        Me.btn_mod_prof.UseVisualStyleBackColor = True
        '
        'btneliminar_prof
        '
        Me.btneliminar_prof.Location = New System.Drawing.Point(679, 436)
        Me.btneliminar_prof.Name = "btneliminar_prof"
        Me.btneliminar_prof.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar_prof.TabIndex = 5
        Me.btneliminar_prof.Text = "Eliminar"
        Me.btneliminar_prof.UseVisualStyleBackColor = True
        '
        'Modificar_prof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.btneliminar_prof)
        Me.Controls.Add(Me.btn_mod_prof)
        Me.Controls.Add(Me.dgv_mod_prof)
        Me.Controls.Add(Me.btnbuscar_prof)
        Me.Controls.Add(Me.cmb_mod_prof)
        Me.Controls.Add(Me.chk_mod_prof)
        Me.Name = "Modificar_prof"
        Me.Text = "Modificar_prof"
        CType(Me.dgv_mod_prof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_mod_prof As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_mod_prof As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscar_prof As System.Windows.Forms.Button
    Friend WithEvents dgv_mod_prof As System.Windows.Forms.DataGridView
    Friend WithEvents btn_mod_prof As System.Windows.Forms.Button
    Friend WithEvents btneliminar_prof As System.Windows.Forms.Button
End Class
