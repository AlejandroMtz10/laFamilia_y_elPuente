<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registros
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
        Me.components = New System.ComponentModel.Container()
        Dim RamaFavLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim AprendeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Systems_engineer_quizDataSet = New Systems_Engineer_Quiz.systems_engineer_quizDataSet()
        Me.YourprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YourprofileTableAdapter = New Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.yourprofileTableAdapter()
        Me.TableAdapterManager = New Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.TableAdapterManager()
        Me.YourprofileDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RamaFavTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.AprendeTextBox = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        RamaFavLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        AprendeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Systems_engineer_quizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YourprofileDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RamaFavLabel
        '
        RamaFavLabel.AutoSize = True
        RamaFavLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RamaFavLabel.Location = New System.Drawing.Point(740, 138)
        RamaFavLabel.Name = "RamaFavLabel"
        RamaFavLabel.Size = New System.Drawing.Size(171, 30)
        RamaFavLabel.TabIndex = 1
        RamaFavLabel.Text = "Especialización:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(741, 176)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(136, 30)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripción:"
        '
        'AprendeLabel
        '
        AprendeLabel.AutoSize = True
        AprendeLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AprendeLabel.Location = New System.Drawing.Point(741, 462)
        AprendeLabel.Name = "AprendeLabel"
        AprendeLabel.Size = New System.Drawing.Size(200, 30)
        AprendeLabel.TabIndex = 5
        AprendeLabel.Text = "Temas de interés:"
        '
        'Systems_engineer_quizDataSet
        '
        Me.Systems_engineer_quizDataSet.DataSetName = "systems_engineer_quizDataSet"
        Me.Systems_engineer_quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.especialidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Systems_Engineer_Quiz.systems_engineer_quizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.yourprofileTableAdapter = Me.YourprofileTableAdapter
        '
        'YourprofileDataGridView
        '
        Me.YourprofileDataGridView.AllowUserToAddRows = False
        Me.YourprofileDataGridView.AllowUserToDeleteRows = False
        Me.YourprofileDataGridView.AutoGenerateColumns = False
        Me.YourprofileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.YourprofileDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.YourprofileDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.YourprofileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.YourprofileDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8})
        Me.YourprofileDataGridView.DataSource = Me.YourprofileBindingSource
        Me.YourprofileDataGridView.Location = New System.Drawing.Point(2, 143)
        Me.YourprofileDataGridView.Name = "YourprofileDataGridView"
        Me.YourprofileDataGridView.ReadOnly = True
        Me.YourprofileDataGridView.Size = New System.Drawing.Size(717, 636)
        Me.YourprofileDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "matricula"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 107
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "semestre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Semestre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 109
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "puntaje"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Puntos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 84
        '
        'RamaFavTextBox
        '
        Me.RamaFavTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YourprofileBindingSource, "ramaFav", True))
        Me.RamaFavTextBox.Enabled = False
        Me.RamaFavTextBox.Location = New System.Drawing.Point(929, 140)
        Me.RamaFavTextBox.Name = "RamaFavTextBox"
        Me.RamaFavTextBox.Size = New System.Drawing.Size(333, 30)
        Me.RamaFavTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YourprofileBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(746, 209)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(575, 250)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'AprendeTextBox
        '
        Me.AprendeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YourprofileBindingSource, "aprende", True))
        Me.AprendeTextBox.Enabled = False
        Me.AprendeTextBox.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AprendeTextBox.Location = New System.Drawing.Point(746, 495)
        Me.AprendeTextBox.Multiline = True
        Me.AprendeTextBox.Name = "AprendeTextBox"
        Me.AprendeTextBox.Size = New System.Drawing.Size(575, 284)
        Me.AprendeTextBox.TabIndex = 6
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(281, 94)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(418, 34)
        Me.txtBuscar.TabIndex = 7
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 98)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(258, 30)
        Label1.TabIndex = 8
        Label1.Text = "Búsqueda por matrícula:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(591, 19)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(159, 40)
        Label2.TabIndex = 9
        Label2.Text = "Registros."
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Systems_Engineer_Quiz.My.Resources.Resources.cancelar
        Me.btnSalir.Location = New System.Drawing.Point(1276, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 65
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 800)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(AprendeLabel)
        Me.Controls.Add(Me.AprendeTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(RamaFavLabel)
        Me.Controls.Add(Me.RamaFavTextBox)
        Me.Controls.Add(Me.YourprofileDataGridView)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "registros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registros"
        CType(Me.Systems_engineer_quizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YourprofileDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Systems_engineer_quizDataSet As systems_engineer_quizDataSet
    Friend WithEvents YourprofileBindingSource As BindingSource
    Friend WithEvents YourprofileTableAdapter As systems_engineer_quizDataSetTableAdapters.yourprofileTableAdapter
    Friend WithEvents TableAdapterManager As systems_engineer_quizDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YourprofileDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents RamaFavTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents AprendeTextBox As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnSalir As Button
End Class
