<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bonusDeveloper
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rBtnIA = New System.Windows.Forms.RadioButton()
        Me.rBtnWeb = New System.Windows.Forms.RadioButton()
        Me.rBtnMovil = New System.Windows.Forms.RadioButton()
        Me.rBtnFullStack = New System.Windows.Forms.RadioButton()
        Me.rBtnFrontend = New System.Windows.Forms.RadioButton()
        Me.rBtnBackend = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnIA)
        Me.GroupBox1.Controls.Add(Me.rBtnWeb)
        Me.GroupBox1.Controls.Add(Me.rBtnMovil)
        Me.GroupBox1.Controls.Add(Me.rBtnFullStack)
        Me.GroupBox1.Controls.Add(Me.rBtnFrontend)
        Me.GroupBox1.Controls.Add(Me.rBtnBackend)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 596)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "31. Selecciona el tema que más te gusta o te llame la atención aprender"
        '
        'rBtnIA
        '
        Me.rBtnIA.AutoSize = True
        Me.rBtnIA.Location = New System.Drawing.Point(22, 391)
        Me.rBtnIA.Name = "rBtnIA"
        Me.rBtnIA.Size = New System.Drawing.Size(192, 31)
        Me.rBtnIA.TabIndex = 5
        Me.rBtnIA.Text = "Machine learning."
        Me.rBtnIA.UseVisualStyleBackColor = True
        Me.rBtnIA.Visible = False
        '
        'rBtnWeb
        '
        Me.rBtnWeb.AutoSize = True
        Me.rBtnWeb.Location = New System.Drawing.Point(22, 347)
        Me.rBtnWeb.Name = "rBtnWeb"
        Me.rBtnWeb.Size = New System.Drawing.Size(491, 31)
        Me.rBtnWeb.TabIndex = 4
        Me.rBtnWeb.Text = "Programación con JavaScript, PHP, HTML y CSS."
        Me.rBtnWeb.UseVisualStyleBackColor = True
        Me.rBtnWeb.Visible = False
        '
        'rBtnMovil
        '
        Me.rBtnMovil.AutoSize = True
        Me.rBtnMovil.Location = New System.Drawing.Point(22, 303)
        Me.rBtnMovil.Name = "rBtnMovil"
        Me.rBtnMovil.Size = New System.Drawing.Size(391, 31)
        Me.rBtnMovil.TabIndex = 3
        Me.rBtnMovil.Text = "Programación con Kotlin, Java o Swift."
        Me.rBtnMovil.UseVisualStyleBackColor = True
        Me.rBtnMovil.Visible = False
        '
        'rBtnFullStack
        '
        Me.rBtnFullStack.AutoSize = True
        Me.rBtnFullStack.Location = New System.Drawing.Point(22, 259)
        Me.rBtnFullStack.Name = "rBtnFullStack"
        Me.rBtnFullStack.Size = New System.Drawing.Size(514, 31)
        Me.rBtnFullStack.TabIndex = 2
        Me.rBtnFullStack.Text = "Programación, bases de datos y uso de frameworks."
        Me.rBtnFullStack.UseVisualStyleBackColor = True
        Me.rBtnFullStack.Visible = False
        '
        'rBtnFrontend
        '
        Me.rBtnFrontend.AutoSize = True
        Me.rBtnFrontend.Location = New System.Drawing.Point(22, 215)
        Me.rBtnFrontend.Name = "rBtnFrontend"
        Me.rBtnFrontend.Size = New System.Drawing.Size(167, 31)
        Me.rBtnFrontend.TabIndex = 1
        Me.rBtnFrontend.Text = "Diseño UI/UX."
        Me.rBtnFrontend.UseVisualStyleBackColor = True
        Me.rBtnFrontend.Visible = False
        '
        'rBtnBackend
        '
        Me.rBtnBackend.AutoSize = True
        Me.rBtnBackend.Location = New System.Drawing.Point(25, 171)
        Me.rBtnBackend.Name = "rBtnBackend"
        Me.rBtnBackend.Size = New System.Drawing.Size(418, 31)
        Me.rBtnBackend.TabIndex = 0
        Me.rBtnBackend.Text = "Lógica de programación y bases de datos."
        Me.rBtnBackend.UseVisualStyleBackColor = True
        Me.rBtnBackend.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNext.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.next_50px
        Me.btnNext.Location = New System.Drawing.Point(361, 705)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 60)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = " Continuar"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.cancelar
        Me.btnSalir.Location = New System.Drawing.Point(508, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 64
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'bonusDeveloper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 777)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bonusDeveloper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bonusDeveloper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtnIA As RadioButton
    Friend WithEvents rBtnWeb As RadioButton
    Friend WithEvents rBtnMovil As RadioButton
    Friend WithEvents rBtnFullStack As RadioButton
    Friend WithEvents rBtnFrontend As RadioButton
    Friend WithEvents rBtnBackend As RadioButton
    Friend WithEvents btnSalir As Button
End Class
