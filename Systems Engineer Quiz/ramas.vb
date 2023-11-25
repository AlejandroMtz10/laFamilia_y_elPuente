Public Class ramas
    Public rama As Integer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rBtnRedes.Checked = False And rBtnProgramacion.Checked = False And rBtnDocumentacion.Checked = False Then
            MsgBox("Selecciona una respuesta para poder continuar con el test.", vbCritical, "Selecciona una respuesta.")
        Else
            Me.Hide()
            If rBtnRedes.Checked = True Then
                rama = 1
                apartado_IT.ShowDialog()
            ElseIf rBtnProgramacion.Checked = True Then
                rama = 2
                dev_backend.ShowDialog()
            ElseIf rBtnDocumentacion.Checked = True Then
                rama = 3
                apartado_arq_soft.ShowDialog()
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class