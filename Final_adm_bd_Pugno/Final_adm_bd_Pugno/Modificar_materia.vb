Public Class Modificar_materia

    Private Sub Modificar_materia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        cargargrilla()
    End Sub
    Sub cargarcombo()
        Dim tablas As New DataTable

        Call recuperardatos("select * from materias", tablas)
        cmb_busqueda_mat.DataSource = tablas
        cmb_busqueda_mat.ValueMember = "cod_materia"
        cmb_busqueda_mat.DisplayMember = "desc_mat"
        cmb_busqueda_mat.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
    Sub cargargrilla()
        Dim tabla As New DataTable
        Call recuperardatos("select * from materias", tabla)
        dtv_modificar_mat.DataSource = tabla
        dtv_modificar_mat.Columns("nro_legajo_p").Visible = False
    End Sub

    Private Sub btn_modificar_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar_mat.Click
        If dtv_modificar_mat.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Una Materia a modificar")
        Else

            codmateriabus = dtv_modificar_mat.CurrentRow.Cells("cod_materia").Value
            operacion = "Modificar"
            Materias.Show()
        End If
    End Sub

    Private Sub btneliminar_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_mat.Click
        Dim resp As Integer
        If dtv_modificar_mat.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Una Materia a Eliminar")
        Else
            codmateriabus = dtv_modificar_mat.CurrentRow.Cells("cod_materia").Value
            resp = MessageBox.Show("Estas Seguro Que Quiere Eliminar Registro??", "Atencion!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Call ejecutarsql("delete from materias where cod_materia = '" & codmateriabus & "'")
            End If

        End If
    End Sub
End Class