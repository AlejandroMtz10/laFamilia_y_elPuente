Public Class dev_backend
    Dim pregSinResp As Integer
    Public totalDevBackend As Integer
    Public pointsDevBackend As Integer

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        validar_respuestas()
        If pregSinResp = 0 Then
            puntajeDevBackend_avanza()
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

    Public Sub puntajeDevBackend_avanza()
        If rBtnSi1.Checked = True Then
            totalDevBackend += 1
        End If

        If rBtnSi2.Checked = True Then
            totalDevBackend += 1
        End If

        If rBtnSi3.Checked = True Then
            totalDevBackend += 1
        End If

        If rBtnSi4.Checked = True Then
            totalDevBackend += 1
        End If

        If rBtnSi5.Checked = True Then
            totalDevBackend += 1
        End If

        pointsDevBackend = totalDevBackend
        Me.Hide()
        dev_frontend.ShowDialog()
    End Sub
End Class