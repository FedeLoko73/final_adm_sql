<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materias
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nombremateria = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcarrera_mat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbprof_mat = New System.Windows.Forms.ComboBox
        Me.btnalta_mat = New System.Windows.Forms.Button
        Me.btn_mod_mat = New System.Windows.Forms.Button
        Me.txt_codmat = New System.Windows.Forms.TextBox
        Me.btn_altaprof_mat = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod Materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Materia:"
        '
        'txt_nombremateria
        '
        Me.txt_nombremateria.Location = New System.Drawing.Point(150, 77)
        Me.txt_nombremateria.Name = "txt_nombremateria"
        Me.txt_nombremateria.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombremateria.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Carrera:"
        '
        'txtcarrera_mat
        '
        Me.txtcarrera_mat.Location = New System.Drawing.Point(150, 133)
        Me.txtcarrera_mat.Name = "txtcarrera_mat"
        Me.txtcarrera_mat.Size = New System.Drawing.Size(100, 20)
        Me.txtcarrera_mat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Profesor:"
        '
        'cmbprof_mat
        '
        Me.cmbprof_mat.FormattingEnabled = True
        Me.cmbprof_mat.Location = New System.Drawing.Point(150, 182)
        Me.cmbprof_mat.Name = "cmbprof_mat"
        Me.cmbprof_mat.Size = New System.Drawing.Size(121, 21)
        Me.cmbprof_mat.TabIndex = 7
        '
        'btnalta_mat
        '
        Me.btnalta_mat.Location = New System.Drawing.Point(175, 246)
        Me.btnalta_mat.Name = "btnalta_mat"
        Me.btnalta_mat.Size = New System.Drawing.Size(75, 23)
        Me.btnalta_mat.TabIndex = 8
        Me.btnalta_mat.Text = "Alta"
        Me.btnalta_mat.UseVisualStyleBackColor = True
        '
        'btn_mod_mat
        '
        Me.btn_mod_mat.Location = New System.Drawing.Point(276, 246)
        Me.btn_mod_mat.Name = "btn_mod_mat"
        Me.btn_mod_mat.Size = New System.Drawing.Size(75, 23)
        Me.btn_mod_mat.TabIndex = 9
        Me.btn_mod_mat.Text = "Modificar"
        Me.btn_mod_mat.UseVisualStyleBackColor = True
        '
        'txt_codmat
        '
        Me.txt_codmat.Location = New System.Drawing.Point(150, 31)
        Me.txt_codmat.Name = "txt_codmat"
        Me.txt_codmat.Size = New System.Drawing.Size(100, 20)
        Me.txt_codmat.TabIndex = 10
        '
        'btn_altaprof_mat
        '
        Me.btn_altaprof_mat.Location = New System.Drawing.Point(299, 182)
        Me.btn_altaprof_mat.Name = "btn_altaprof_mat"
        Me.btn_altaprof_mat.Size = New System.Drawing.Size(75, 39)
        Me.btn_altaprof_mat.TabIndex = 11
        Me.btn_altaprof_mat.Text = "Agregar Profesor"
        Me.btn_altaprof_mat.UseVisualStyleBackColor = True
        '
        'Materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 281)
        Me.Controls.Add(Me.btn_altaprof_mat)
        Me.Controls.Add(Me.txt_codmat)
        Me.Controls.Add(Me.btn_mod_mat)
        Me.Controls.Add(Me.btnalta_mat)
        Me.Controls.Add(Me.cmbprof_mat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcarrera_mat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombremateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Materias"
        Me.Text = "Materias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombremateria As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcarrera_mat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbprof_mat As System.Windows.Forms.ComboBox
    Friend WithEvents btnalta_mat As System.Windows.Forms.Button
    Friend WithEvents btn_mod_mat As System.Windows.Forms.Button
    Friend WithEvents txt_codmat As System.Windows.Forms.TextBox
    Friend WithEvents btn_altaprof_mat As System.Windows.Forms.Button
End Class
