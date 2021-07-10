<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_materia
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
        Me.btneliminar_mat = New System.Windows.Forms.Button
        Me.btn_buscar_mat = New System.Windows.Forms.Button
        Me.btn_modificar_mat = New System.Windows.Forms.Button
        Me.dtv_modificar_mat = New System.Windows.Forms.DataGridView
        Me.cmb_busqueda_mat = New System.Windows.Forms.ComboBox
        Me.chk_buscar_mat = New System.Windows.Forms.CheckBox
        CType(Me.dtv_modificar_mat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminar_mat
        '
        Me.btneliminar_mat.Location = New System.Drawing.Point(308, 393)
        Me.btneliminar_mat.Name = "btneliminar_mat"
        Me.btneliminar_mat.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar_mat.TabIndex = 12
        Me.btneliminar_mat.Text = "Eliminar"
        Me.btneliminar_mat.UseVisualStyleBackColor = True
        '
        'btn_buscar_mat
        '
        Me.btn_buscar_mat.Location = New System.Drawing.Point(310, 10)
        Me.btn_buscar_mat.Name = "btn_buscar_mat"
        Me.btn_buscar_mat.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar_mat.TabIndex = 11
        Me.btn_buscar_mat.Text = "Buscar"
        Me.btn_buscar_mat.UseVisualStyleBackColor = True
        '
        'btn_modificar_mat
        '
        Me.btn_modificar_mat.Location = New System.Drawing.Point(54, 393)
        Me.btn_modificar_mat.Name = "btn_modificar_mat"
        Me.btn_modificar_mat.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar_mat.TabIndex = 10
        Me.btn_modificar_mat.Text = "Modificar"
        Me.btn_modificar_mat.UseVisualStyleBackColor = True
        '
        'dtv_modificar_mat
        '
        Me.dtv_modificar_mat.AllowUserToAddRows = False
        Me.dtv_modificar_mat.AllowUserToDeleteRows = False
        Me.dtv_modificar_mat.AllowUserToOrderColumns = True
        Me.dtv_modificar_mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv_modificar_mat.Location = New System.Drawing.Point(12, 57)
        Me.dtv_modificar_mat.Name = "dtv_modificar_mat"
        Me.dtv_modificar_mat.ReadOnly = True
        Me.dtv_modificar_mat.Size = New System.Drawing.Size(371, 330)
        Me.dtv_modificar_mat.TabIndex = 9
        '
        'cmb_busqueda_mat
        '
        Me.cmb_busqueda_mat.FormattingEnabled = True
        Me.cmb_busqueda_mat.Location = New System.Drawing.Point(72, 12)
        Me.cmb_busqueda_mat.Name = "cmb_busqueda_mat"
        Me.cmb_busqueda_mat.Size = New System.Drawing.Size(232, 21)
        Me.cmb_busqueda_mat.TabIndex = 8
        '
        'chk_buscar_mat
        '
        Me.chk_buscar_mat.AutoSize = True
        Me.chk_buscar_mat.Location = New System.Drawing.Point(12, 19)
        Me.chk_buscar_mat.Name = "chk_buscar_mat"
        Me.chk_buscar_mat.Size = New System.Drawing.Size(15, 14)
        Me.chk_buscar_mat.TabIndex = 7
        Me.chk_buscar_mat.UseVisualStyleBackColor = True
        '
        'Modificar_materia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 428)
        Me.Controls.Add(Me.btneliminar_mat)
        Me.Controls.Add(Me.btn_buscar_mat)
        Me.Controls.Add(Me.btn_modificar_mat)
        Me.Controls.Add(Me.dtv_modificar_mat)
        Me.Controls.Add(Me.cmb_busqueda_mat)
        Me.Controls.Add(Me.chk_buscar_mat)
        Me.Name = "Modificar_materia"
        Me.Text = "Modificar_materia"
        CType(Me.dtv_modificar_mat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btneliminar_mat As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_mat As System.Windows.Forms.Button
    Friend WithEvents btn_modificar_mat As System.Windows.Forms.Button
    Friend WithEvents dtv_modificar_mat As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_busqueda_mat As System.Windows.Forms.ComboBox
    Friend WithEvents chk_buscar_mat As System.Windows.Forms.CheckBox
End Class
