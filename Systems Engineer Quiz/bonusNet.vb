Public Class bonusNet
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rBtnIT.Checked = False And rBtnDevOps.Checked = False Then
            MsgBox("Selecciona una respuesta para poder continuar con el test.", vbCritical, "Selecciona una respuesta.")
        Else
            Me.Hide()
            If rBtnIT.Checked = True Then
                apartado_IT.pointsIT += 1
                apartado_IT.pointsIT = (apartado_IT.pointsIT / 6) * 100
                points.especialidad = 1
                resultados.ShowDialog()
            ElseIf rBtnDevOps.Checked = True Then
                dev_ops.pointsDevOps += 1
                dev_ops.pointsDevOps = (dev_ops.pointsDevOps / 6) * 100
                points.especialidad = 2
                resultados.ShowDialog()
            End If
        End If
    End Sub

End Class