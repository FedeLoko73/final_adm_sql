Public Class Alta_alumno

    Private Sub Alta_alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo()
        btn_mod_altaalumnos.Visible = False
        If operacion = "Modificar" Then
            btn_mod_altaalumnos.Visible = True
            btn_alta.Visible = False
            Dim tabla As New DataTable
            Call recuperardatos("select * from alumnos where nro_legajo_a = '" & legajobus & "'", tabla)
            txt_nlegajo.Text = tabla.Rows(0)("nro_legajo_a")
            txt_apynom.Text = tabla.Rows(0)("ape_nomb")
            cmbtipodoc.SelectedValue = tabla.Rows(0)("cod_doc")
            txt_ndoc.Text = tabla.Rows(0)("nro_doc")
            txt_direccion.Text = tabla.Rows(0)("direccion").ToString
            txt_telefono.Text = tabla.Rows(0)("telefono")
            If tabla.Rows(0)("sexo") = "M" Then
                rb_masc.Checked = True
            ElseIf tabla.Rows(0)("sexo") = "F" Then
                rb_fem.Checked = True
            End If
            dtp_fnac.Value = tabla.Rows(0)("fec_nac")
            txt_estadocivil.Text = tabla.Rows(0)("est_civil")
            txt_mail.Text = tabla.Rows(0)("email")

        End If

    End Sub

    Function Validar() As Boolean
        Dim val As Boolean
        Dim i As Integer

        If txt_nlegajo.Text.Trim <> "" And Integer.TryParse(txt_nlegajo.Text, i) Then
            If txt_apynom.Text.Trim <> "" Then
                If txt_ndoc.Text.Trim <> "" And Integer.TryParse(txt_ndoc.Text, i) Then
                    If txt_direccion.Text.Trim <> "" Then
                        If txt_telefono.Text.Trim <> "" Then
                            If txt_estadocivil.Text.Trim <> "" Then
                                val = True
                            Else
                                MessageBox.Show("Ingrese su estado civil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        Else
                            MessageBox.Show("Ingrese Numero de Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Ingrese su Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Ingrese un Numero de documento valido, sin puntos ni guiones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Ingrese su nombre y apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Ingrese numero de legajo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
      
        Return val
    End Function

    Sub cargarcombo()
        Dim tabla As DataTable
        tabla = New DataTable

        Call recuperardatos("select * from tipo_doc", tabla)
        cmbtipodoc.DataSource = tabla
        cmbtipodoc.ValueMember = "cod_doc"
        cmbtipodoc.DisplayMember = "desc_doc"
        cmbtipodoc.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub


    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        Dim sexo As Char
        If rb_masc.Checked Then
            sexo = "M"
        ElseIf rb_fem.Checked Then
            sexo = "F"
        End If
        If Validar() = True Then
            If operacion = "Alta" Then
                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from alumnos where nro_legajo_a = '" & txt_nlegajo.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    MessageBox.Show("LEGAJO EXISTENTE")
                Else

                    Call ejecutarsql("insert into alumnos (nro_legajo_a,ape_nomb,nro_doc,direccion,email,telefono,cod_doc,sexo,fec_nac,est_civil) values ('" & txt_nlegajo.Text & "', '" & txt_apynom.Text & "', '" & txt_ndoc.Text & "', '" & txt_direccion.Text & "', '" & txt_mail.Text & "', '" & txt_telefono.Text & "', '" & cmbtipodoc.SelectedValue & "', '" & sexo & "', '" & dtp_fnac.Value & "', '" & txt_estadocivil.Text & "')")
                    MessageBox.Show("Registro Exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
            If operacion = "Modificar" Then

                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from alumnos where nro_legajo_a = '" & txt_nlegajo.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    Call ejecutarsql("UPDATE Alumnos set nro_legajo_a = '" & txt_nlegajo.Text & "', ape_nomb = '" & txt_apynom.Text & "', direccion = '" & txt_direccion.Text & "', email = '" & txt_mail.Text & "', nro_doc = '" & txt_ndoc.Text & "', telefono = '" & txt_telefono.Text & "', cod_doc = '" & cmbtipodoc.SelectedValue & "', sexo = '" & sexo & "', fec_nac = '" & dtp_fnac.Value & "', est_civil = '" & txt_estadocivil.Text & "' where nro_legajo_a = '" & legajobus & "'")
                    MessageBox.Show("MODIFICACION EXITOSA!")
                    Me.Close()
                ElseIf tabla.Rows.Count <= 0 Then
                    MessageBox.Show("legajo ya existe")

                End If
            End If
        End If



    End Sub


    Private Sub btn_mod_altaalumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_altaalumnos.Click
        Dim sexo As Char
        If rb_masc.Checked Then
            sexo = "M"
        ElseIf rb_fem.Checked Then
            sexo = "F"
        End If
        If Validar() = True Then
            If operacion = "Alta" Then
                btn_mod_altaalumnos.Visible = False
                Call ejecutarsql("insert into alumnos (nro_legajo_a,ape_nomb,nro_doc,direccion,email,telefono,cod_doc,sexo,fec_nac,est_civil) values ('" & txt_nlegajo.Text & "', '" & txt_apynom.Text & "', '" & txt_ndoc.Text & "', '" & txt_direccion.Text & "', '" & txt_mail.Text & "', '" & txt_telefono.Text & "', '" & cmbtipodoc.SelectedValue & "', '" & sexo & "', '" & dtp_fnac.Value & "', '" & txt_estadocivil.Text & "')")
                MessageBox.Show("Registro Exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
            If operacion = "Modificar" Then
                btn_alta.Visible = False
                Dim tabla As New DataTable
                Dim sql As String
                sql = "select * from alumnos where nro_legajo_a = '" & txt_nlegajo.Text & "'"
                Call recuperardatos(sql, tabla)
                If tabla.Rows.Count > 0 Then
                    Call ejecutarsql("UPDATE Alumnos set nro_legajo_a = '" & txt_nlegajo.Text & "', ape_nomb = '" & txt_apynom.Text & "', direccion = '" & txt_direccion.Text & "', email = '" & txt_mail.Text & "', telefono = '" & txt_telefono.Text & "', cod_doc = '" & cmbtipodoc.SelectedValue & "', sexo = '" & sexo & "', fec_nac = '" & dtp_fnac.Value & "', est_civil = '" & txt_estadocivil.Text & "' where nro_legajo_a = '" & legajobus & "'")
                    MessageBox.Show("MODIFICACION EXITOSA!")
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class