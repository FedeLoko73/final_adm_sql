Public Class Modificar_alumno

    Private Sub Modificar_alumno_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cargargrilla()
    End Sub

    Private Sub Modificar_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        cargargrilla()
        chk_buscar.Checked = False

    End Sub

    Sub cargarcombo()
        Dim tablas As New DataTable

        Call recuperardatos("select * from alumnos", tablas)
        cmb_busqueda.DataSource = tablas
        cmb_busqueda.ValueMember = "nro_legajo_a"
        cmb_busqueda.DisplayMember = "ape_nomb"
        cmb_busqueda.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub


    Sub cargargrilla()
        Dim tabla As New DataTable
        Call recuperardatos("select * from alumnos", tabla)
        dtv_modificar.DataSource = tabla
        dtv_modificar.Columns("cod_doc").Visible = False

    End Sub


    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If dtv_modificar.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Un Alumno a modificar")
        Else

            legajobus = dtv_modificar.CurrentRow.Cells("nro_legajo_a").Value
            operacion = "Modificar"
            Alta_alumno.Show()
        End If
    End Sub

    Private Sub chk_buscar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_buscar.CheckedChanged
        If chk_buscar.Checked Then
            cmb_busqueda.Enabled = True
        ElseIf chk_buscar.Checked = False Then
            cmb_busqueda.Enabled = False
        End If
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim tabla As New DataTable
        Call recuperardatos("select * from Alumnos where ape_nomb = '" & cmb_busqueda.Text & "'", tabla)
        dtv_modificar.DataSource = tabla
        dtv_modificar.Columns("cod_doc").Visible = False
    End Sub

    Private Sub btneliminar_alum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_alum.Click
        Dim resp As Integer
        If dtv_modificar.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione Un Profesor a Eliminar")
        Else
            legajobus = dtv_modificar.CurrentRow.Cells("nro_legajo_a").Value
            resp = MessageBox.Show("Estas Seguro Que Quiere Eliminar Registro??", "Atencion!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Call ejecutarsql("delete from alumnos where nro_legajo_a = '" & legajobus & "'")
            End If
            Me.Close()
        End If
    End Sub

End Class