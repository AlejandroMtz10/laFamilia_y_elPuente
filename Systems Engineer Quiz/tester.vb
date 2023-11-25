Public Class tester
    Dim pregSinResp As Integer = 0
    Public totalTester As Integer = 0
    Public pointsTester As Integer = 0

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        apartado_IT.Close()
        apartado_arq_soft.Close()
        dev_backend.Close()
        dev_frontend.Close()
        dev_fullstack.Close()
        dev_movil.Close()
        dev_web.Close()
        dev_ops.Close()
        dev_IA.Close()
        Me.Close()
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        validar_respuestas()
        If pregSinResp = 0 Then
            puntajeTester_avanza()
        End If
    End Sub

    Public Sub validar_respuestas()
        pregSinResp = 0
        If rBtnNo1.Checked = False And rBtnSi1.Checked = False Then
            pregSinResp += 1
        End If

        If rBtnNo2.Checked = False And rBtnSi2.Checked = False Then
            pregSinResp += 1
        End If

        If rBtnNo3.Checked = False And rBtnSi3.Checked = False Then
            pregSinResp += 1
        End If
        If rBtnNo4.Checked = False And rBtnSi4.Checked = False Then
            pregSinResp += 1
        End If

        If rBtnNo5.Checked = False And rBtnSi5.Checked = False Then
            pregSinResp += 1
        End If

        If pregSinResp >= 1 Then
            MsgBox("Te faltan contestar una o más preguntas del apartado.", vbExclamation, "Preguntas vacías.")
        End If
    End Sub
    Public Sub puntajeTester_avanza()
        If rBtnSi1.Checked = True Then
            totalTester += 1
        End If

        If rBtnSi2.Checked = True Then
            totalTester += 1
        End If

        If rBtnSi3.Checked = True Then
            totalTester += 1
        End If

        If rBtnSi4.Checked = True Then
            totalTester += 1
        End If

        If rBtnSi5.Checked = True Then
            totalTester += 1
        End If

        pointsTester = totalTester
        Me.Hide()
        documentador.ShowDialog()
    End Sub
End Class