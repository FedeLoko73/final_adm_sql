<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_alumno
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
        Me.txt_nlegajo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_apynom = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbtipodoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ndoc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.rb_masc = New System.Windows.Forms.RadioButton
        Me.rb_fem = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtp_fnac = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_estadocivil = New System.Windows.Forms.TextBox
        Me.btn_alta = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_mail = New System.Windows.Forms.TextBox
        Me.btn_mod_altaalumnos = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. De Legajo: "
        '
        'txt_nlegajo
        '
        Me.txt_nlegajo.Location = New System.Drawing.Point(138, 23)
        Me.txt_nlegajo.MaxLength = 4
        Me.txt_nlegajo.Name = "txt_nlegajo"
        Me.txt_nlegajo.Size = New System.Drawing.Size(100, 20)
        Me.txt_nlegajo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido y Nombre: "
        '
        'txt_apynom
        '
        Me.txt_apynom.Location = New System.Drawing.Point(138, 70)
        Me.txt_apynom.MaxLength = 30
        Me.txt_apynom.Name = "txt_apynom"
        Me.txt_apynom.Size = New System.Drawing.Size(164, 20)
        Me.txt_apynom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Documento:  "
        '
        'cmbtipodoc
        '
        Me.cmbtipodoc.FormattingEnabled = True
        Me.cmbtipodoc.Location = New System.Drawing.Point(138, 105)
        Me.cmbtipodoc.Name = "cmbtipodoc"
        Me.cmbtipodoc.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipodoc.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero de documento:   "
        '
        'txt_ndoc
        '
        Me.txt_ndoc.Location = New System.Drawing.Point(138, 155)
        Me.txt_ndoc.MaxLength = 8
        Me.txt_ndoc.Name = "txt_ndoc"
        Me.txt_ndoc.Size = New System.Drawing.Size(164, 20)
        Me.txt_ndoc.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Direccion: "
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(138, 194)
        Me.txt_direccion.MaxLength = 60
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(164, 20)
        Me.txt_direccion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefono: "
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(138, 235)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(164, 20)
        Me.txt_telefono.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sexo: "
        '
        'rb_masc
        '
        Me.rb_masc.AutoSize = True
        Me.rb_masc.Checked = True
        Me.rb_masc.Location = New System.Drawing.Point(138, 284)
        Me.rb_masc.Name = "rb_masc"
        Me.rb_masc.Size = New System.Drawing.Size(73, 17)
        Me.rb_masc.TabIndex = 13
        Me.rb_masc.TabStop = True
        Me.rb_masc.Text = "Masculino"
        Me.rb_masc.UseVisualStyleBackColor = True
        '
        'rb_fem
        '
        Me.rb_fem.AutoSize = True
        Me.rb_fem.Location = New System.Drawing.Point(254, 284)
        Me.rb_fem.Name = "rb_fem"
        Me.rb_fem.Size = New System.Drawing.Size(71, 17)
        Me.rb_fem.TabIndex = 14
        Me.rb_fem.TabStop = True
        Me.rb_fem.Text = "Femenino"
        Me.rb_fem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha de Nacimiento:"
        '
        'dtp_fnac
        '
        Me.dtp_fnac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fnac.Location = New System.Drawing.Point(165, 322)
        Me.dtp_fnac.Name = "dtp_fnac"
        Me.dtp_fnac.Size = New System.Drawing.Size(137, 20)
        Me.dtp_fnac.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estado Civil:"
        '
        'txt_estadocivil
        '
        Me.txt_estadocivil.Location = New System.Drawing.Point(138, 363)
        Me.txt_estadocivil.MaxLength = 10
        Me.txt_estadocivil.Name = "txt_estadocivil"
        Me.txt_estadocivil.Size = New System.Drawing.Size(164, 20)
        Me.txt_estadocivil.TabIndex = 18
        '
        'btn_alta
        '
        Me.btn_alta.Location = New System.Drawing.Point(348, 422)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta.TabIndex = 21
        Me.btn_alta.Text = "Alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Email: "
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(138, 400)
        Me.txt_mail.MaxLength = 50
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(164, 20)
        Me.txt_mail.TabIndex = 20
        '
        'btn_mod_altaalumnos
        '
        Me.btn_mod_altaalumnos.Location = New System.Drawing.Point(453, 422)
        Me.btn_mod_altaalumnos.Name = "btn_mod_altaalumnos"
        Me.btn_mod_altaalumnos.Size = New System.Drawing.Size(75, 23)
        Me.btn_mod_altaalumnos.TabIndex = 22
        Me.btn_mod_altaalumnos.Text = "Modificar"
        Me.btn_mod_altaalumnos.UseVisualStyleBackColor = True
        '
        'Alta_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 457)
        Me.Controls.Add(Me.btn_mod_altaalumnos)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.txt_estadocivil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtp_fnac)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rb_fem)
        Me.Controls.Add(Me.rb_masc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_ndoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbtipodoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_apynom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nlegajo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alta_alumno"
        Me.Text = "Alta_alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nlegajo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_apynom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbtipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ndoc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rb_masc As System.Windows.Forms.RadioButton
    Friend WithEvents rb_fem As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_fnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_estadocivil As System.Windows.Forms.TextBox
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents btn_mod_altaalumnos As System.Windows.Forms.Button
End Class
