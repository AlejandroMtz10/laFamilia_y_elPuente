<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resultados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnResultados = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.txtTemas = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Systems_engineer_quizDataSet = New Systems_Engineer_Quiz.systems_engineer_quizDataSet()
        Me.EspecialidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecialidadTableAdapter = New Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.especialidadTableAdapter()
        Me.TableAdapterManager = New Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.TableAdapterManager()
        Me.YourprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YourprofileTableAdapter = New Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.yourprofileTableAdapter()
        CType(Me.Systems_engineer_quizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 35)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Especialidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 35)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(695, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 35)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Temas de interés:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(695, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 35)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Puntuación:"
        '
        'btnResultados
        '
        Me.btnResultados.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResultados.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultados.ForeColor = System.Drawing.Color.White
        Me.btnResultados.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.resultadosWhite
        Me.btnResultados.Location = New System.Drawing.Point(846, 648)
        Me.btnResultados.Name = "btnResultados"
        Me.btnResultados.Size = New System.Drawing.Size(200, 60)
        Me.btnResultados.TabIndex = 71
        Me.btnResultados.Text = " Resultados"
        Me.btnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResultados.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.aceptar_white
        Me.btnNext.Location = New System.Drawing.Point(1068, 648)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(200, 60)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = " Aceptar"
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
        Me.btnSalir.Location = New System.Drawing.Point(1215, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 65
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Enabled = False
        Me.txtEspecialidad.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialidad.Location = New System.Drawing.Point(34, 202)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(628, 37)
        Me.txtEspecialidad.TabIndex = 72
        '
        'txtPoints
        '
        Me.txtPoints.Enabled = False
        Me.txtPoints.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(701, 202)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(213, 37)
        Me.txtPoints.TabIndex = 73
        '
        'txtTemas
        '
        Me.txtTemas.Enabled = False
        Me.txtTemas.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemas.Location = New System.Drawing.Point(701, 317)
        Me.txtTemas.Multiline = True
        Me.txtTemas.Name = "txtTemas"
        Me.txtTemas.Size = New System.Drawing.Size(550, 301)
        Me.txtTemas.TabIndex = 74
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(34, 317)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(628, 301)
        Me.txtDescription.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(531, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 51)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Resultados."
        '
        'Systems_engineer_quizDataSet
        '
        Me.Systems_engineer_quizDataSet.DataSetName = "systems_engineer_quizDataSet"
        Me.Systems_engineer_quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EspecialidadBindingSource1
        '
        Me.EspecialidadBindingSource1.DataMember = "especialidad"
        Me.EspecialidadBindingSource1.DataSource = Me.Systems_engineer_quizDataSet
        '
        'EspecialidadTableAdapter
        '
        Me.EspecialidadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.especialidadTableAdapter = Me.EspecialidadTableAdapter
        Me.TableAdapterManager.UpdateOrder = Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.yourprofileTableAdapter = Nothing
        '
        'YourprofileBindingSource
        '
        Me.YourprofileBindingSource.DataMember = "yourprofile"
        Me.YourprofileBindingSource.DataSource = Me.Systems_engineer_quizDataSet
        '
        'YourprofileTableAdapter
        '
        Me.YourprofileTableAdapter.ClearBeforeFill = True
        '
        'resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 728)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTemas)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.txtEspecialidad)
        Me.Controls.Add(Me.btnResultados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "resultados"
        CType(Me.Systems_engineer_quizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents EspecialidadBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnResultados As Button
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents txtTemas As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EspecialidadBindingSource1 As BindingSource
    Friend WithEvents YourprofileBindingSource As BindingSource
    Friend WithEvents Systems_engineer_quizDataSet As Systems_Engineer_Quiz.systems_engineer_quizDataSet
    Friend WithEvents EspecialidadTableAdapter As Systems_engineer_quiz.systems_engineer_quizDataSetTableAdapters.especialidadTableAdapter
    Friend WithEvents TableAdapterManager As Systems_engineer_quiz.systems_engineer_quizDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YourprofileTableAdapter As systems_engineer_quizDataSetTableAdapters.yourprofileTableAdapter
End Class
