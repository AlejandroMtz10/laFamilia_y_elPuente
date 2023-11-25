Public Class bonusDoc_tester
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rBtnArqSoft.Checked = False And rBtnDocumentador.Checked = False And rBtnTester.Checked = False Then
            MsgBox("Te faltan contestar una o más preguntas del apartado.", vbExclamation, "Preguntas vacías.")
        Else
            If rBtnArqSoft.Checked = True Then
                apartado_arq_soft.pointsArqSoft += 1
                apartado_arq_soft.pointsArqSoft = (apartado_arq_soft.pointsArqSoft / 6) * 100
                points.especialidad = 11
            ElseIf rBtnDocumentador.Checked = True Then
                documentador.pointsDoc += 1
                documentador.pointsDoc = (documentador.pointsDoc / 6) * 100
                points.especialidad = 9
            ElseIf rBtnTester.Checked = True Then
                tester.pointsTester += 1
                tester.pointsTester = (tester.pointsTester / 6) * 100
                points.especialidad = 10
            End If
            resultados.ShowDialog()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        tester.Close()
        documentador.Close()
        apartado_arq_soft.Close()
        Me.Close()
    End Sub
End Class