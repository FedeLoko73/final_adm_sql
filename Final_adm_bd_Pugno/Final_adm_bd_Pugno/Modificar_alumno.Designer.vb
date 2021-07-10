<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_alumno
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
        Me.chk_buscar = New System.Windows.Forms.CheckBox
        Me.cmb_busqueda = New System.Windows.Forms.ComboBox
        Me.dtv_modificar = New System.Windows.Forms.DataGridView
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btneliminar_alum = New System.Windows.Forms.Button
        CType(Me.dtv_modificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_buscar
        '
        Me.chk_buscar.AutoSize = True
        Me.chk_buscar.Location = New System.Drawing.Point(13, 49)
        Me.chk_buscar.Name = "chk_buscar"
        Me.chk_buscar.Size = New System.Drawing.Size(15, 14)
        Me.chk_buscar.TabIndex = 0
        Me.chk_buscar.UseVisualStyleBackColor = True
        '
        'cmb_busqueda
        '
        Me.cmb_busqueda.FormattingEnabled = True
        Me.cmb_busqueda.Location = New System.Drawing.Point(85, 42)
        Me.cmb_busqueda.Name = "cmb_busqueda"
        Me.cmb_busqueda.Size = New System.Drawing.Size(327, 21)
        Me.cmb_busqueda.TabIndex = 1
        '
        'dtv_modificar
        '
        Me.dtv_modificar.AllowUserToAddRows = False
        Me.dtv_modificar.AllowUserToDeleteRows = False
        Me.dtv_modificar.AllowUserToOrderColumns = True
        Me.dtv_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv_modificar.Location = New System.Drawing.Point(13, 102)
        Me.dtv_modificar.Name = "dtv_modificar"
        Me.dtv_modificar.ReadOnly = True
        Me.dtv_modificar.Size = New System.Drawing.Size(723, 304)
        Me.dtv_modificar.TabIndex = 2
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(292, 420)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 4
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(488, 40)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btneliminar_alum
        '
        Me.btneliminar_alum.Location = New System.Drawing.Point(580, 420)
        Me.btneliminar_alum.Name = "btneliminar_alum"
        Me.btneliminar_alum.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar_alum.TabIndex = 6
        Me.btneliminar_alum.Text = "Eliminar"
        Me.btneliminar_alum.UseVisualStyleBackColor = True
        '
        'Modificar_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 455)
        Me.Controls.Add(Me.btneliminar_alum)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dtv_modificar)
        Me.Controls.Add(Me.cmb_busqueda)
        Me.Controls.Add(Me.chk_buscar)
        Me.Name = "Modificar_alumno"
        Me.Text = "Modificar_alumno"
        CType(Me.dtv_modificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_buscar As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_busqueda As System.Windows.Forms.ComboBox
    Friend WithEvents dtv_modificar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btneliminar_alum As System.Windows.Forms.Button
End Class
