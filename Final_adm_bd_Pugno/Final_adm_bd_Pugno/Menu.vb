Public Class Menu

    Private Sub NuevoAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoAlumnoToolStripMenuItem.Click
        Alta_alumno.Show()
    End Sub

    Private Sub ModificarAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarAlumnoToolStripMenuItem.Click
        Modificar_alumno.Show()

    End Sub

    Private Sub AgregarProfesorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProfesorToolStripMenuItem.Click
        Alta_Profesores.Show()
    End Sub

    Private Sub ModificarProfesorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarProfesorToolStripMenuItem.Click
        Modificar_prof.Show()
    End Sub

    Private Sub AltaMateriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaMateriaToolStripMenuItem.Click
        Materias.Show()
    End Sub

    Private Sub ModificarMateriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarMateriaToolStripMenuItem.Click
        Modificar_materia.Show()
    End Sub
End Class
