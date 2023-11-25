<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bonusDoc_tester
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
        Me.rBtnDocumentador = New System.Windows.Forms.RadioButton()
        Me.rBtnTester = New System.Windows.Forms.RadioButton()
        Me.rBtnArqSoft = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnDocumentador)
        Me.GroupBox1.Controls.Add(Me.rBtnTester)
        Me.GroupBox1.Controls.Add(Me.rBtnArqSoft)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 596)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "16. Selecciona el tema que más te gusta o te llame la atención aprender"
        '
        'rBtnDocumentador
        '
        Me.rBtnDocumentador.AutoSize = True
        Me.rBtnDocumentador.Location = New System.Drawing.Point(32, 338)
        Me.rBtnDocumentador.Name = "rBtnDocumentador"
        Me.rBtnDocumentador.Size = New System.Drawing.Size(440, 31)
        Me.rBtnDocumentador.TabIndex = 2
        Me.rBtnDocumentador.Text = "Requerimientos funcionales y no funcionales."
        Me.rBtnDocumentador.UseVisualStyleBackColor = True
        Me.rBtnDocumentador.Visible = False
        '
        'rBtnTester
        '
        Me.rBtnTester.AutoSize = True
        Me.rBtnTester.Location = New System.Drawing.Point(32, 251)
        Me.rBtnTester.Name = "rBtnTester"
        Me.rBtnTester.Size = New System.Drawing.Size(375, 31)
        Me.rBtnTester.TabIndex = 1
        Me.rBtnTester.Text = "Pruebas automatizadas con Selenium."
        Me.rBtnTester.UseVisualStyleBackColor = True
        Me.rBtnTester.Visible = False
        '
        'rBtnArqSoft
        '
        Me.rBtnArqSoft.AutoSize = True
        Me.rBtnArqSoft.Location = New System.Drawing.Point(32, 171)
        Me.rBtnArqSoft.Name = "rBtnArqSoft"
        Me.rBtnArqSoft.Size = New System.Drawing.Size(182, 31)
        Me.rBtnArqSoft.TabIndex = 0
        Me.rBtnArqSoft.Text = "Diagramas UML."
        Me.rBtnArqSoft.UseVisualStyleBackColor = True
        Me.rBtnArqSoft.Visible = False
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
        Me.btnNext.TabIndex = 63
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
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'bonusDoc_tester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 777)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bonusDoc_tester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bonus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtnTester As RadioButton
    Friend WithEvents rBtnArqSoft As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents rBtnDocumentador As RadioButton
End Class
