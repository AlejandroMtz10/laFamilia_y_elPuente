<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ramas
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
        Me.rBtnDocumentacion = New System.Windows.Forms.RadioButton()
        Me.rBtnProgramacion = New System.Windows.Forms.RadioButton()
        Me.rBtnRedes = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnDocumentacion)
        Me.GroupBox1.Controls.Add(Me.rBtnProgramacion)
        Me.GroupBox1.Controls.Add(Me.rBtnRedes)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 596)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A mi me gusta..."
        '
        'rBtnDocumentacion
        '
        Me.rBtnDocumentacion.AutoSize = True
        Me.rBtnDocumentacion.Location = New System.Drawing.Point(33, 325)
        Me.rBtnDocumentacion.Name = "rBtnDocumentacion"
        Me.rBtnDocumentacion.Size = New System.Drawing.Size(378, 31)
        Me.rBtnDocumentacion.TabIndex = 2
        Me.rBtnDocumentacion.Text = "La creación y manejo de documentos."
        Me.rBtnDocumentacion.UseVisualStyleBackColor = True
        '
        'rBtnProgramacion
        '
        Me.rBtnProgramacion.AutoSize = True
        Me.rBtnProgramacion.Location = New System.Drawing.Point(33, 222)
        Me.rBtnProgramacion.Name = "rBtnProgramacion"
        Me.rBtnProgramacion.Size = New System.Drawing.Size(187, 31)
        Me.rBtnProgramacion.TabIndex = 1
        Me.rBtnProgramacion.Text = "La programación."
        Me.rBtnProgramacion.UseVisualStyleBackColor = True
        '
        'rBtnRedes
        '
        Me.rBtnRedes.AutoSize = True
        Me.rBtnRedes.Location = New System.Drawing.Point(33, 114)
        Me.rBtnRedes.Name = "rBtnRedes"
        Me.rBtnRedes.Size = New System.Drawing.Size(492, 31)
        Me.rBtnRedes.TabIndex = 0
        Me.rBtnRedes.Text = "La administración de redes y sistemas operativos."
        Me.rBtnRedes.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnNext.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.next_50px
        Me.btnNext.Location = New System.Drawing.Point(349, 705)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 60)
        Me.btnNext.TabIndex = 65
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
        Me.btnSalir.Location = New System.Drawing.Point(496, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 64
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 777)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ramas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ramas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rBtnDocumentacion As RadioButton
    Friend WithEvents rBtnProgramacion As RadioButton
    Friend WithEvents rBtnRedes As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSalir As Button
End Class
