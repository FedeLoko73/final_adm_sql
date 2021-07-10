Public Class Alta_Profesores

    Sub cargarcombo()
        Dim tabla As DataTable
        tabla = New DataTable

        Call recuperardatos("select * from tipo_doc", tabla)
        cmb_tipodoc_p.DataSource = tabla
        cmb_tipodoc_p.ValueMember = "cod_doc"
        cmb_tipodoc_p.DisplayMember = "desc_doc"
        cmb_tipodoc_p.DropDownStyle = ComboBoxStyle.DropDownList

        Dim tabla2 As DataTable
        tabla2 = New DataTable
        Call recuperardatos("select * from titulos", tabla2)
        cmbtitulo_p.DataSource = tabla2
        cmbtitulo_p.ValueMember = "cod_titulo"
        cmbtitulo_p.DisplayMember = "desc_titulo"
        cmbtitulo_p.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Alta_Profesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        btnmodificar_p.Visible = False
        If operacion = "Modificar" Then
            btnmodificar_p.Visible = True
            btnalta_p.Visible = False
            Dim tabla As New DataTable
            Call recuperardatos("select * from profesores where nro_legajo_p = '" & legajobus & "'", tabla)
            txt_nlegajo_p.Text = tabla.Rows(0)("nro_legajo_p")
            txt_apynom_p.Text = tabla.Rows(0)("ape_nomb")
            cmb_tipodoc_p.SelectedValue = tabla.Rows(0)("cod_doc")
            txt_ndoc_p.Text = tabla.Rows(0)("nro_doc")
            txt_direccion_p.Text = tabla.Rows(0)("direccion").ToString
            txt_tel_p.Text = tabla.Rows(0)("telefono")
            If tabla.Rows(0)("sexo") = "M" Then
                rbmasc_p.Checked = True
            ElseIf tabla.Rows(0)("sexo") = "F" Then
                rbfem_p.Checked = True
            End If
            dtpfnac_p.Value = tabla.Rows(0)("fec_nac")
            txtestadocivil_p.Text = tabla.Rows(0)("est_civil")
            txtmail_p.Text = tabla.Rows(0)("email")
            cmbtitulo_p.SelectedValue = tabla.Rows(0)("cod_titulo")

        End If
    End Sub

    Function Validar() As Boolean
        Dim val As Boolean
        Dim i As Integer


        If txt_nlegajo_p.Text.Trim <> "" And Integer.TryParse(txt_nlegajo_p.Text, i) Then
            If txt_apynom_p.Text.Trim <> "" Then
                If txt_ndoc_p.Text.Trim <> "" And Integer.TryParse(txt_ndoc_p.Text, i) Then
                    If txt_direccion_p.Text.Trim <> "" Then
                        If txt_tel_p.Text.Trim <> "" Then
                            If txtestadocivil_p.Text.Trim <> "" Then
                                val = True
                            Else
                                MessageBox.Show("Ingrese estado civil", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Else
                            MessageBox.Show("Ingrese un Numero de Telefono Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Ingrese Una Direccion Valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Ingrese Nro De Dcoumenoto Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Ingrese Nombre Y Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Ingrese Numero de Legajo Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return val
    End Function

    Private Sub btnalta_p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta_p.Click
        Dim sexo As Char
        If rbfem_p.Checked Then
            sexo = "F"
        ElseIf rbmasc_p.Checked Then
            sexo = "M"
        End If
        If Validar() = True Then
            If operacion = "Alta" Then
                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from profesores where nro_legajo_p = '" & txt_nlegajo_p.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    MessageBox.Show("LEGAJO EXISTENTE")
                Else

                    Call ejecutarsql("insert into profesores (nro_legajo_p,ape_nomb,nro_doc,direccion,email,telefono,cod_doc,sexo,fec_nac,est_civil, cod_titulo) values ('" & txt_nlegajo_p.Text & "', '" & txt_apynom_p.Text & "', '" & txt_ndoc_p.Text & "', '" & txt_direccion_p.Text & "', '" & txtmail_p.Text & "', '" & txt_tel_p.Text & "', '" & cmb_tipodoc_p.SelectedValue & "', '" & sexo & "', '" & dtpfnac_p.Value & "', '" & txtestadocivil_p.Text & "', '" & cmbtitulo_p.SelectedValue & "')")
                    MessageBox.Show("Registro Exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
            If operacion = "Modificar" Then

                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from profesores where nro_legajo_p = '" & txt_nlegajo_p.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    Call ejecutarsql("UPDATE profesores set nro_legajo_a = '" & txt_nlegajo_p.Text & "', ape_nomb = '" & txt_apynom_p.Text & "', direccion = '" & txt_direccion_p.Text & "', email = '" & txtmail_p.Text & "', nro_doc = '" & txt_ndoc_p.Text & "', telefono = '" & txt_tel_p.Text & "', cod_doc = '" & cmb_tipodoc_p.SelectedValue & "', sexo = '" & sexo & "', fec_nac = '" & dtpfnac_p.Value & "', est_civil = '" & txtestadocivil_p.Text & "', cod_titulo = '" & cmbtitulo_p.SelectedValue & "' where nro_legajo_p = '" & legajobus & "'")
                    MessageBox.Show("MODIFICACION EXITOSA!")
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub btnmodificar_p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar_p.Click
        Dim sexo As Char
        If rbfem_p.Checked Then
            sexo = "F"
        ElseIf rbmasc_p.Checked Then
            sexo = "M"
        End If
        If Validar() = True Then
            If operacion = "Alta" Then

                Call ejecutarsql("insert into profesores (nro_legajo_p,ape_nomb,nro_doc,direccion,email,telefono,cod_doc,sexo,fec_nac,est_civil, cod_titulo) values ('" & txt_nlegajo_p.Text & "', '" & txt_apynom_p.Text & "', '" & txt_ndoc_p.Text & "', '" & txt_direccion_p.Text & "', '" & txtmail_p.Text & "', '" & txt_tel_p.Text & "', '" & cmb_tipodoc_p.SelectedValue & "', '" & sexo & "', '" & dtpfnac_p.Value & "', '" & txtestadocivil_p.Text & "', '" & cmbtitulo_p.SelectedValue & "')")
                MessageBox.Show("Registro Exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
            If operacion = "Modificar" Then

                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from profesores where nro_legajo_p = '" & txt_nlegajo_p.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    Call ejecutarsql("UPDATE profesores set nro_legajo_p = '" & txt_nlegajo_p.Text & "', ape_nomb = '" & txt_apynom_p.Text & "', direccion = '" & txt_direccion_p.Text & "', email = '" & txtmail_p.Text & "', nro_doc = '" & txt_ndoc_p.Text & "', telefono = '" & txt_tel_p.Text & "', cod_doc = '" & cmb_tipodoc_p.SelectedValue & "', sexo = '" & sexo & "', fec_nac = '" & dtpfnac_p.Value & "', est_civil = '" & txtestadocivil_p.Text & "', cod_titulo = '" & cmbtitulo_p.SelectedValue & "' where nro_legajo_p = '" & legajobus & "'")
                    MessageBox.Show("MODIFICACION EXITOSA!")
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class