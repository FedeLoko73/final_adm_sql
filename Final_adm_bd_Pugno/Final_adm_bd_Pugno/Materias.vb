Public Class Materias

    Private Sub Materias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        btn_mod_mat.Visible = False
        If operacion = "Modificar" Then
            btn_mod_mat.Visible = True
            btnalta_mat.Visible = False
            Dim tabla As New DataTable
            Call recuperardatos("select * from materias where cod_materia = '" & codmateriabus & "'", tabla)
            txt_codmat.Text = tabla.Rows(0)("cod_materia")
            txt_nombremateria.Text = tabla.Rows(0)("desc_mat")
            txtcarrera_mat.Text = tabla.Rows(0)("desc_carrera")
            cmbprof_mat.SelectedValue = tabla.Rows(0)("nro_legajo_p")
        End If
    End Sub

    Sub cargarcombo()
        Dim tabla As New DataTable

        Call recuperardatos("select * from profesores", tabla)
        cmbprof_mat.DataSource = tabla
        cmbprof_mat.ValueMember = "nro_legajo_p"
        cmbprof_mat.DisplayMember = "ape_nomb"
        cmbprof_mat.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Function validar() As Boolean
        Dim val As Boolean
        If txt_codmat.Text.Trim <> "" Then
            If txt_nombremateria.Text.Trim <> "" Then
                If txtcarrera_mat.Text.Trim <> "" Then
                    val = True
                Else
                    MessageBox.Show("ingrese carrera")
                End If
            Else
                MessageBox.Show("ingrese Nombre Materia")
            End If
        Else
            MessageBox.Show("Ingrese COdigo de materia Valido")
        End If
        Return val
    End Function


    Private Sub btnalta_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta_mat.Click
        validar()
        Dim tabla As New DataTable
        Dim sql As String
        sql = "select * from materias where cod_materia = '" & txt_codmat.Text & "'"
        Call recuperardatos(sql, tabla)
        If tabla.Rows.Count > 0 Then
            MessageBox.Show("CODIGO MATERIA EXISTENTE")
        Else
            Call ejecutarsql("insert into materias (cod_materia,desc_mat,desc_carrera,nro_legajo_p) values ('" & txt_codmat.Text & "', '" & txt_nombremateria.Text & "' , '" & txtcarrera_mat.Text & "', '" & cmbprof_mat.SelectedValue & "')")
            MessageBox.Show("Registro Exitoso")
            Me.Close()
        End If

    End Sub

    Private Sub btn_mod_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_mat.Click
        If validar() = True Then
            If operacion = "Alta" Then
                
            Else
                Call ejecutarsql("insert into materias (cod_materia,desc_mat,desc_carrera,nro_legajo_p) values ('" & txt_codmat.Text & "', '" & txt_nombremateria.Text & "' , '" & txtcarrera_mat.Text & "', '" & cmbprof_mat.SelectedValue & "')")
                MessageBox.Show("Registro Exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
                If operacion = "Modificar" Then

                    Dim tabla As New DataTable
                    Dim sql As String
                    sql = "select * from materias where cod_materia = '" & txt_codmat.Text & "'"
                    Call recuperardatos(sql, tabla)
                    If tabla.Rows.Count > 0 Then
                        Call ejecutarsql("UPDATE materias set cod_materia = '" & txt_codmat.Text & "', desc_mat = '" & txt_nombremateria.Text & "', desc_carrera = '" & txtcarrera_mat.Text & "', nro_legajo_p = '" & cmbprof_mat.SelectedValue & "' where cod_materia = '" & codmateriabus & "'")
                        MessageBox.Show("MODIFICACION EXITOSA!")
                        Me.Close()
                    End If
                End If

    End Sub

    Private Sub btn_altaprof_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_altaprof_mat.Click
        Alta_Profesores.Show()
    End Sub
End Class