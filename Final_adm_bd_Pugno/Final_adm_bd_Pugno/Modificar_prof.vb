Public Class Modificar_prof

    Private Sub Modificar_prof_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cargargrilla()
    End Sub

    Private Sub Modificar_prof_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        cargargrilla()
        chk_mod_prof.Checked = False
    End Sub
    Sub cargarcombo()
        Dim tablas As New DataTable

        Call recuperardatos("select * from profesores", tablas)
        cmb_mod_prof.DataSource = tablas
        cmb_mod_prof.ValueMember = "nro_legajo_p"
        cmb_mod_prof.DisplayMember = "ape_nomb"
        cmb_mod_prof.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub
    Sub cargargrilla()
        Dim tabla As New DataTable
        Call recuperardatos("select * from profesores", tabla)
        dgv_mod_prof.DataSource = tabla
        dgv_mod_prof.Columns("cod_doc").Visible = False
        dgv_mod_prof.Columns("cod_titulo").Visible = False
    End Sub

    Private Sub btn_mod_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_prof.Click
        If dgv_mod_prof.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Un Profesor a modificar")
        Else

            legajobus = dgv_mod_prof.CurrentRow.Cells("nro_legajo_p").Value
            operacion = "Modificar"
            Alta_Profesores.Show()
        End If
    End Sub

    Private Sub chk_mod_prof_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mod_prof.CheckedChanged
        If chk_mod_prof.Checked Then
            cmb_mod_prof.Enabled = True
        ElseIf chk_mod_prof.Checked = False Then
            cmb_mod_prof.Enabled = False
        End If
    End Sub

    Private Sub btnbuscar_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_prof.Click
        Dim tabla As New DataTable
        Call recuperardatos("select * from profesores where ape_nomb = '" & cmb_mod_prof.Text & "'", tabla)
        dgv_mod_prof.DataSource = tabla
        dgv_mod_prof.Columns("cod_doc").Visible = False
        dgv_mod_prof.Columns("cod_titulo").Visible = False
    End Sub

    Private Sub btneliminar_prof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_prof.Click
        Dim resp As Integer
        If dgv_mod_prof.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Un Profesor a Eliminar")
        Else
            legajobus = dgv_mod_prof.CurrentRow.Cells("nro_legajo_p").Value
            resp = MessageBox.Show("Estas Seguro Que Quiere Eliminar Registro??", "Atencion!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Call ejecutarsql("delete from profesores where nro_legajo_p = '" & legajobus & "'")
            End If
            Me.Close()
        End If
    End Sub
End Class