<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Profesores
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
        Me.txt_nlegajo_p = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_apynom_p = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_tipodoc_p = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ndoc_p = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_direccion_p = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtmail_p = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_tel_p = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.rbmasc_p = New System.Windows.Forms.RadioButton
        Me.rbfem_p = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbtitulo_p = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtestadocivil_p = New System.Windows.Forms.TextBox
        Me.btnalta_p = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpfnac_p = New System.Windows.Forms.DateTimePicker
        Me.btnmodificar_p = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Legajo: "
        '
        'txt_nlegajo_p
        '
        Me.txt_nlegajo_p.Location = New System.Drawing.Point(153, 24)
        Me.txt_nlegajo_p.Name = "txt_nlegajo_p"
        Me.txt_nlegajo_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_nlegajo_p.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido Y Nombre: "
        '
        'txt_apynom_p
        '
        Me.txt_apynom_p.Location = New System.Drawing.Point(153, 67)
        Me.txt_apynom_p.MaxLength = 30
        Me.txt_apynom_p.Name = "txt_apynom_p"
        Me.txt_apynom_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_apynom_p.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Documento: "
        '
        'cmb_tipodoc_p
        '
        Me.cmb_tipodoc_p.FormattingEnabled = True
        Me.cmb_tipodoc_p.Location = New System.Drawing.Point(153, 108)
        Me.cmb_tipodoc_p.Name = "cmb_tipodoc_p"
        Me.cmb_tipodoc_p.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipodoc_p.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nro Documento: "
        '
        'txt_ndoc_p
        '
        Me.txt_ndoc_p.Location = New System.Drawing.Point(153, 152)
        Me.txt_ndoc_p.Name = "txt_ndoc_p"
        Me.txt_ndoc_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_ndoc_p.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Direccion:"
        '
        'txt_direccion_p
        '
        Me.txt_direccion_p.Location = New System.Drawing.Point(153, 193)
        Me.txt_direccion_p.MaxLength = 50
        Me.txt_direccion_p.Name = "txt_direccion_p"
        Me.txt_direccion_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_direccion_p.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email:"
        '
        'txtmail_p
        '
        Me.txtmail_p.Location = New System.Drawing.Point(153, 230)
        Me.txtmail_p.MaxLength = 50
        Me.txtmail_p.Name = "txtmail_p"
        Me.txtmail_p.Size = New System.Drawing.Size(100, 20)
        Me.txtmail_p.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Telefono:"
        '
        'txt_tel_p
        '
        Me.txt_tel_p.Location = New System.Drawing.Point(153, 273)
        Me.txt_tel_p.MaxLength = 20
        Me.txt_tel_p.Name = "txt_tel_p"
        Me.txt_tel_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_tel_p.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sexo:"
        '
        'rbmasc_p
        '
        Me.rbmasc_p.AutoSize = True
        Me.rbmasc_p.Location = New System.Drawing.Point(153, 309)
        Me.rbmasc_p.Name = "rbmasc_p"
        Me.rbmasc_p.Size = New System.Drawing.Size(73, 17)
        Me.rbmasc_p.TabIndex = 15
        Me.rbmasc_p.TabStop = True
        Me.rbmasc_p.Text = "Masculino"
        Me.rbmasc_p.UseVisualStyleBackColor = True
        '
        'rbfem_p
        '
        Me.rbfem_p.AutoSize = True
        Me.rbfem_p.Location = New System.Drawing.Point(249, 309)
        Me.rbfem_p.Name = "rbfem_p"
        Me.rbfem_p.Size = New System.Drawing.Size(71, 17)
        Me.rbfem_p.TabIndex = 16
        Me.rbfem_p.TabStop = True
        Me.rbfem_p.Text = "Femenino"
        Me.rbfem_p.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Titulo:"
        '
        'cmbtitulo_p
        '
        Me.cmbtitulo_p.FormattingEnabled = True
        Me.cmbtitulo_p.Location = New System.Drawing.Point(153, 345)
        Me.cmbtitulo_p.Name = "cmbtitulo_p"
        Me.cmbtitulo_p.Size = New System.Drawing.Size(121, 21)
        Me.cmbtitulo_p.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Estado civil:"
        '
        'txtestadocivil_p
        '
        Me.txtestadocivil_p.Location = New System.Drawing.Point(153, 388)
        Me.txtestadocivil_p.MaxLength = 10
        Me.txtestadocivil_p.Name = "txtestadocivil_p"
        Me.txtestadocivil_p.Size = New System.Drawing.Size(100, 20)
        Me.txtestadocivil_p.TabIndex = 20
        '
        'btnalta_p
        '
        Me.btnalta_p.Location = New System.Drawing.Point(164, 469)
        Me.btnalta_p.Name = "btnalta_p"
        Me.btnalta_p.Size = New System.Drawing.Size(75, 23)
        Me.btnalta_p.TabIndex = 21
        Me.btnalta_p.Text = "Alta"
        Me.btnalta_p.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 427)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fecha De Nacimiento: "
        '
        'dtpfnac_p
        '
        Me.dtpfnac_p.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfnac_p.Location = New System.Drawing.Point(153, 427)
        Me.dtpfnac_p.Name = "dtpfnac_p"
        Me.dtpfnac_p.Size = New System.Drawing.Size(121, 20)
        Me.dtpfnac_p.TabIndex = 23
        '
        'btnmodificar_p
        '
        Me.btnmodificar_p.Location = New System.Drawing.Point(244, 469)
        Me.btnmodificar_p.Name = "btnmodificar_p"
        Me.btnmodificar_p.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar_p.TabIndex = 24
        Me.btnmodificar_p.Text = "Modificar"
        Me.btnmodificar_p.UseVisualStyleBackColor = True
        '
        'Alta_Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 504)
        Me.Controls.Add(Me.btnmodificar_p)
        Me.Controls.Add(Me.dtpfnac_p)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnalta_p)
        Me.Controls.Add(Me.txtestadocivil_p)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbtitulo_p)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbfem_p)
        Me.Controls.Add(Me.rbmasc_p)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_tel_p)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmail_p)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_direccion_p)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_ndoc_p)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_tipodoc_p)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_apynom_p)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nlegajo_p)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alta_Profesores"
        Me.Text = "Alta_Profesores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nlegajo_p As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_apynom_p As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipodoc_p As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ndoc_p As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_p As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmail_p As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_tel_p As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbmasc_p As System.Windows.Forms.RadioButton
    Friend WithEvents rbfem_p As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbtitulo_p As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtestadocivil_p As System.Windows.Forms.TextBox
    Friend WithEvents btnalta_p As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpfnac_p As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnmodificar_p As System.Windows.Forms.Button
End Class
