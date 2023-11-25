Public Class dev_frontend
    Dim pregSinResp As Integer = 0
    Public totalDevFrontend As Integer = 0
    Public pointsDevFrontend As Integer = 0

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        apartado_IT.Close()
        apartado_arq_soft.Close()
        dev_backend.Close()
        Me.Close()
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        validar_respuestas()
        If pregSinResp = 0 Then
            puntajeDevFrontend_avanza()
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

    Public Sub puntajeDevFrontend_avanza()
        If rBtnSi1.Checked = True Then
            totalDevFrontend += 1
        End If

        If rBtnSi2.Checked = True Then
            totalDevFrontend += 1
        End If

        If rBtnSi3.Checked = True Then
            totalDevFrontend += 1
        End If

        If rBtnSi4.Checked = True Then
            totalDevFrontend += 1
        End If

        If rBtnSi5.Checked = True Then
            totalDevFrontend += 1
        End If

        pointsDevFrontend = totalDevFrontend
        Me.Hide()
        dev_fullstack.ShowDialog()
    End Sub
End Class