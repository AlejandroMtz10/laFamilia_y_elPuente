Public Class mainMenu
    Public matricula, nombre, apellidos As String

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click
        registros.ShowDialog()
    End Sub

    Public semestre As Integer
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If txtMatricula.Text = "" Then
            MsgBox("Error en la matricula no lo dejes vacío.", vbCritical, "Error.")
            txtMatricula.Focus()
        ElseIf txtName.Text = "" Or IsNumeric(txtName.Text) Then
            MsgBox("Error en el campo nombre no lo dejes vacío o ingresa un nombre valido", vbCritical, "Error.")
            txtName.Focus()
        ElseIf txtApellidos.Text = "" Or IsNumeric(txtApellidos.Text) Then
            MsgBox("Error en el campo apellidos no lo dejes vacío o ingresa los apellidos validos", vbCritical, "Error.")
            txtApellidos.Focus()
        ElseIf txtSemester.Text = "" Or Not (IsNumeric(txtSemester.Text)) Or Val(txtSemester.Text) <= 0 Then
            MsgBox("Error en el campo semestre no lo dejes vacío o ingresa el semestre valido", vbCritical, "Error.")
            txtSemester.Focus()
        Else
            matricula = txtMatricula.Text
            nombre = txtName.Text
            apellidos = txtApellidos.Text
            semestre = Val(txtSemester.Text)
            ramas.ShowDialog()
        End If
    End Sub
End Class
