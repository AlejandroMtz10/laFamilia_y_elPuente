<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.papa = New System.Windows.Forms.PictureBox()
        Me.hija = New System.Windows.Forms.PictureBox()
        Me.hijo = New System.Windows.Forms.PictureBox()
        Me.hijo2 = New System.Windows.Forms.PictureBox()
        Me.mama = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.papaIzq = New System.Windows.Forms.PictureBox()
        Me.hijaIzq = New System.Windows.Forms.PictureBox()
        Me.hijoIzq = New System.Windows.Forms.PictureBox()
        Me.hijo2Izq = New System.Windows.Forms.PictureBox()
        Me.mamaIzq = New System.Windows.Forms.PictureBox()
        Me.checkPapa = New System.Windows.Forms.CheckBox()
        Me.checkHijo = New System.Windows.Forms.CheckBox()
        Me.checkHija = New System.Windows.Forms.CheckBox()
        Me.checkHijoMenor = New System.Windows.Forms.CheckBox()
        Me.checkMama = New System.Windows.Forms.CheckBox()
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.imgLinterna = New System.Windows.Forms.PictureBox()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.papa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hija, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hijo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.papaIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hijaIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hijoIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hijo2Izq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mamaIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLinterna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.reloj
        Me.PictureBox1.Location = New System.Drawing.Point(733, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(760, 47)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(72, 55)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "30"
        '
        'papa
        '
        Me.papa.BackColor = System.Drawing.Color.Transparent
        Me.papa.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.papá
        Me.papa.Location = New System.Drawing.Point(841, 267)
        Me.papa.Name = "papa"
        Me.papa.Size = New System.Drawing.Size(75, 200)
        Me.papa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.papa.TabIndex = 2
        Me.papa.TabStop = False
        '
        'hija
        '
        Me.hija.BackColor = System.Drawing.Color.Transparent
        Me.hija.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hija
        Me.hija.Location = New System.Drawing.Point(912, 261)
        Me.hija.Name = "hija"
        Me.hija.Size = New System.Drawing.Size(75, 200)
        Me.hija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hija.TabIndex = 3
        Me.hija.TabStop = False
        '
        'hijo
        '
        Me.hijo.BackColor = System.Drawing.Color.Transparent
        Me.hijo.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hijo
        Me.hijo.Location = New System.Drawing.Point(985, 250)
        Me.hijo.Name = "hijo"
        Me.hijo.Size = New System.Drawing.Size(75, 200)
        Me.hijo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hijo.TabIndex = 4
        Me.hijo.TabStop = False
        '
        'hijo2
        '
        Me.hijo2.BackColor = System.Drawing.Color.Transparent
        Me.hijo2.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hijo2
        Me.hijo2.Location = New System.Drawing.Point(1051, 340)
        Me.hijo2.Name = "hijo2"
        Me.hijo2.Size = New System.Drawing.Size(75, 100)
        Me.hijo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hijo2.TabIndex = 5
        Me.hijo2.TabStop = False
        '
        'mama
        '
        Me.mama.BackColor = System.Drawing.Color.Transparent
        Me.mama.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.mamá
        Me.mama.Location = New System.Drawing.Point(1110, 230)
        Me.mama.Name = "mama"
        Me.mama.Size = New System.Drawing.Size(75, 200)
        Me.mama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mama.TabIndex = 6
        Me.mama.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'papaIzq
        '
        Me.papaIzq.BackColor = System.Drawing.Color.Transparent
        Me.papaIzq.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.papáIzq
        Me.papaIzq.Location = New System.Drawing.Point(310, 304)
        Me.papaIzq.Name = "papaIzq"
        Me.papaIzq.Size = New System.Drawing.Size(75, 200)
        Me.papaIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.papaIzq.TabIndex = 7
        Me.papaIzq.TabStop = False
        Me.papaIzq.Visible = False
        '
        'hijaIzq
        '
        Me.hijaIzq.BackColor = System.Drawing.Color.Transparent
        Me.hijaIzq.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hijaIzq
        Me.hijaIzq.Location = New System.Drawing.Point(242, 305)
        Me.hijaIzq.Name = "hijaIzq"
        Me.hijaIzq.Size = New System.Drawing.Size(75, 200)
        Me.hijaIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hijaIzq.TabIndex = 8
        Me.hijaIzq.TabStop = False
        Me.hijaIzq.Visible = False
        '
        'hijoIzq
        '
        Me.hijoIzq.BackColor = System.Drawing.Color.Transparent
        Me.hijoIzq.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hijoIzq
        Me.hijoIzq.Location = New System.Drawing.Point(193, 314)
        Me.hijoIzq.Name = "hijoIzq"
        Me.hijoIzq.Size = New System.Drawing.Size(75, 200)
        Me.hijoIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hijoIzq.TabIndex = 9
        Me.hijoIzq.TabStop = False
        Me.hijoIzq.Visible = False
        '
        'hijo2Izq
        '
        Me.hijo2Izq.BackColor = System.Drawing.Color.Transparent
        Me.hijo2Izq.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.hijo2Izq
        Me.hijo2Izq.Location = New System.Drawing.Point(136, 414)
        Me.hijo2Izq.Name = "hijo2Izq"
        Me.hijo2Izq.Size = New System.Drawing.Size(75, 100)
        Me.hijo2Izq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hijo2Izq.TabIndex = 10
        Me.hijo2Izq.TabStop = False
        Me.hijo2Izq.Visible = False
        '
        'mamaIzq
        '
        Me.mamaIzq.BackColor = System.Drawing.Color.Transparent
        Me.mamaIzq.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.mamáIzq
        Me.mamaIzq.Location = New System.Drawing.Point(83, 321)
        Me.mamaIzq.Name = "mamaIzq"
        Me.mamaIzq.Size = New System.Drawing.Size(75, 200)
        Me.mamaIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mamaIzq.TabIndex = 11
        Me.mamaIzq.TabStop = False
        Me.mamaIzq.Visible = False
        '
        'checkPapa
        '
        Me.checkPapa.AutoSize = True
        Me.checkPapa.BackColor = System.Drawing.Color.Transparent
        Me.checkPapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPapa.ForeColor = System.Drawing.Color.RoyalBlue
        Me.checkPapa.Location = New System.Drawing.Point(34, 115)
        Me.checkPapa.Name = "checkPapa"
        Me.checkPapa.Size = New System.Drawing.Size(15, 14)
        Me.checkPapa.TabIndex = 12
        Me.checkPapa.UseVisualStyleBackColor = False
        '
        'checkHijo
        '
        Me.checkHijo.AutoSize = True
        Me.checkHijo.BackColor = System.Drawing.Color.Transparent
        Me.checkHijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkHijo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.checkHijo.Location = New System.Drawing.Point(118, 115)
        Me.checkHijo.Name = "checkHijo"
        Me.checkHijo.Size = New System.Drawing.Size(15, 14)
        Me.checkHijo.TabIndex = 13
        Me.checkHijo.UseVisualStyleBackColor = False
        '
        'checkHija
        '
        Me.checkHija.AutoSize = True
        Me.checkHija.BackColor = System.Drawing.Color.Transparent
        Me.checkHija.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkHija.ForeColor = System.Drawing.Color.RoyalBlue
        Me.checkHija.Location = New System.Drawing.Point(206, 115)
        Me.checkHija.Name = "checkHija"
        Me.checkHija.Size = New System.Drawing.Size(15, 14)
        Me.checkHija.TabIndex = 14
        Me.checkHija.UseVisualStyleBackColor = False
        '
        'checkHijoMenor
        '
        Me.checkHijoMenor.AutoSize = True
        Me.checkHijoMenor.BackColor = System.Drawing.Color.Transparent
        Me.checkHijoMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkHijoMenor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.checkHijoMenor.Location = New System.Drawing.Point(290, 115)
        Me.checkHijoMenor.Name = "checkHijoMenor"
        Me.checkHijoMenor.Size = New System.Drawing.Size(15, 14)
        Me.checkHijoMenor.TabIndex = 15
        Me.checkHijoMenor.UseVisualStyleBackColor = False
        '
        'checkMama
        '
        Me.checkMama.AutoSize = True
        Me.checkMama.BackColor = System.Drawing.Color.Transparent
        Me.checkMama.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkMama.ForeColor = System.Drawing.Color.RoyalBlue
        Me.checkMama.Location = New System.Drawing.Point(379, 115)
        Me.checkMama.Name = "checkMama"
        Me.checkMama.Size = New System.Drawing.Size(15, 14)
        Me.checkMama.TabIndex = 16
        Me.checkMama.UseVisualStyleBackColor = False
        '
        'btnEmpezar
        '
        Me.btnEmpezar.BackColor = System.Drawing.Color.LightGreen
        Me.btnEmpezar.BackgroundImage = Global.laFamilia_y_elPuente.My.Resources.Resources.icons8_play_96
        Me.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpezar.FlatAppearance.BorderSize = 0
        Me.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpezar.Location = New System.Drawing.Point(605, 44)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(75, 75)
        Me.btnEmpezar.TabIndex = 17
        Me.btnEmpezar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.caraPapa
        Me.PictureBox2.Location = New System.Drawing.Point(9, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.caraHijo
        Me.PictureBox3.Location = New System.Drawing.Point(93, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.caraHija
        Me.PictureBox4.Location = New System.Drawing.Point(177, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.caraHijo2
        Me.PictureBox5.Location = New System.Drawing.Point(261, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.caraMamá
        Me.PictureBox6.Location = New System.Drawing.Point(344, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'imgLinterna
        '
        Me.imgLinterna.BackColor = System.Drawing.Color.Transparent
        Me.imgLinterna.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.lampara
        Me.imgLinterna.Location = New System.Drawing.Point(793, 394)
        Me.imgLinterna.Name = "imgLinterna"
        Me.imgLinterna.Size = New System.Drawing.Size(50, 75)
        Me.imgLinterna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLinterna.TabIndex = 23
        Me.imgLinterna.TabStop = False
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.White
        Me.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReiniciar.FlatAppearance.BorderSize = 0
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciar.Image = Global.laFamilia_y_elPuente.My.Resources.Resources.reinicio
        Me.btnReiniciar.Location = New System.Drawing.Point(521, 45)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(75, 75)
        Me.btnReiniciar.TabIndex = 24
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.laFamilia_y_elPuente.My.Resources.Resources.escenario
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.imgLinterna)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEmpezar)
        Me.Controls.Add(Me.checkMama)
        Me.Controls.Add(Me.checkHijoMenor)
        Me.Controls.Add(Me.checkHija)
        Me.Controls.Add(Me.checkHijo)
        Me.Controls.Add(Me.checkPapa)
        Me.Controls.Add(Me.hijo2Izq)
        Me.Controls.Add(Me.mamaIzq)
        Me.Controls.Add(Me.hijoIzq)
        Me.Controls.Add(Me.hijaIzq)
        Me.Controls.Add(Me.papaIzq)
        Me.Controls.Add(Me.hijo2)
        Me.Controls.Add(Me.mama)
        Me.Controls.Add(Me.hijo)
        Me.Controls.Add(Me.hija)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.papa)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "La familia y el puente."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.papa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hija, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hijo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.papaIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hijaIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hijoIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hijo2Izq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mamaIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLinterna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents papa As PictureBox
    Friend WithEvents hija As PictureBox
    Friend WithEvents hijo As PictureBox
    Friend WithEvents hijo2 As PictureBox
    Friend WithEvents mama As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents papaIzq As PictureBox
    Friend WithEvents hijaIzq As PictureBox
    Friend WithEvents hijoIzq As PictureBox
    Friend WithEvents hijo2Izq As PictureBox
    Friend WithEvents mamaIzq As PictureBox
    Friend WithEvents checkPapa As CheckBox
    Friend WithEvents checkHijo As CheckBox
    Friend WithEvents checkHija As CheckBox
    Friend WithEvents checkHijoMenor As CheckBox
    Friend WithEvents checkMama As CheckBox
    Friend WithEvents btnEmpezar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents imgLinterna As PictureBox
    Friend WithEvents btnReiniciar As Button
End Class
