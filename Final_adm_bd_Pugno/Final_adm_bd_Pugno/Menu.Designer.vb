<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.ProToolStripMenuItem, Me.MateriasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoAlumnoToolStripMenuItem, Me.ModificarAlumnoToolStripMenuItem})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'NuevoAlumnoToolStripMenuItem
        '
        Me.NuevoAlumnoToolStripMenuItem.Name = "NuevoAlumnoToolStripMenuItem"
        Me.NuevoAlumnoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.NuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno"
        '
        'ModificarAlumnoToolStripMenuItem
        '
        Me.ModificarAlumnoToolStripMenuItem.Name = "ModificarAlumnoToolStripMenuItem"
        Me.ModificarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModificarAlumnoToolStripMenuItem.Text = "Modificar Alumno"
        '
        'ProToolStripMenuItem
        '
        Me.ProToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProfesorToolStripMenuItem, Me.ModificarProfesorToolStripMenuItem})
        Me.ProToolStripMenuItem.Name = "ProToolStripMenuItem"
        Me.ProToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ProToolStripMenuItem.Text = "Profesores"
        '
        'AgregarProfesorToolStripMenuItem
        '
        Me.AgregarProfesorToolStripMenuItem.Name = "AgregarProfesorToolStripMenuItem"
        Me.AgregarProfesorToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AgregarProfesorToolStripMenuItem.Text = "Agregar Profesor"
        '
        'ModificarProfesorToolStripMenuItem
        '
        Me.ModificarProfesorToolStripMenuItem.Name = "ModificarProfesorToolStripMenuItem"
        Me.ModificarProfesorToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModificarProfesorToolStripMenuItem.Text = "Modificar Profesor"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaMateriaToolStripMenuItem, Me.ModificarMateriaToolStripMenuItem})
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'AltaMateriaToolStripMenuItem
        '
        Me.AltaMateriaToolStripMenuItem.Name = "AltaMateriaToolStripMenuItem"
        Me.AltaMateriaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AltaMateriaToolStripMenuItem.Text = "Alta Materia"
        '
        'ModificarMateriaToolStripMenuItem
        '
        Me.ModificarMateriaToolStripMenuItem.Name = "ModificarMateriaToolStripMenuItem"
        Me.ModificarMateriaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ModificarMateriaToolStripMenuItem.Text = "Modificar Materia"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProfesorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProfesorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
