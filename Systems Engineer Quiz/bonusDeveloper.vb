Public Class bonusDeveloper

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rBtnBackend.Checked = False And rBtnFrontend.Checked = False And rBtnFullStack.Checked = False And rBtnMovil.Checked = False And rBtnWeb.Checked = False And rBtnIA.Checked = False Then
            MsgBox("Selecciona una respuesta para poder continuar con el test.", vbCritical, "Selecciona una respuesta.")
        Else
            If rBtnBackend.Checked = True Then
                dev_backend.pointsDevBackend += 1
                dev_backend.pointsDevBackend = (dev_backend.pointsDevBackend / 6) * 100
                points.especialidad = 3
            ElseIf rBtnFrontend.Checked = True Then
                dev_frontend.pointsDevFrontend += 1
                dev_frontend.pointsDevFrontend = (dev_frontend.pointsDevFrontend / 6) * 100
                points.especialidad = 4
            ElseIf rBtnFullStack.Checked = True Then
                dev_fullstack.pointsDevFullstack += 1
                dev_fullstack.pointsDevFullstack = (dev_fullstack.pointsDevFullstack / 6) * 100
                points.especialidad = 5
            ElseIf rBtnMovil.Checked = True Then
                dev_movil.pointsDevMovil += 1
                dev_movil.pointsDevMovil = (dev_movil.pointsDevMovil / 6) * 100
                points.especialidad = 6
            ElseIf rBtnWeb.Checked = True Then
                dev_web.pointsDevWeb += 1
                dev_web.pointsDevWeb = (dev_web.pointsDevWeb / 6) * 100
                points.especialidad = 7
            ElseIf rBtnIA.Checked = True Then
                dev_IA.pointsDevIA += 1
                dev_IA.pointsDevIA = (dev_IA.pointsDevIA / 6) * 100
                points.especialidad = 8
            End If
            Me.Hide()
            resultados.ShowDialog()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        dev_backend.Close()
        dev_frontend.Close()
        dev_fullstack.Close()
        dev_movil.Close()
        dev_web.Close()
        dev_IA.Close()
        Me.Close()
    End Sub

    Private Sub bonusDeveloper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        ' Marcar el radio button correspondiente
        If points.developer(0) = points.maxValor Then
            rBtnBackend.Visible = True
        End If
        If points.developer(1) = points.maxValor Then
            rBtnFrontend.Visible = True
        End If
        If points.developer(2) = points.maxValor Then
            rBtnFullStack.Visible = True
        End If
        If points.developer(3) = points.maxValor Then
            rBtnMovil.Visible = True
        End If
        If points.developer(4) = points.maxValor Then
            rBtnWeb.Visible = True
        End If
        If points.developer(5) = points.maxValor Then
            rBtnIA.Visible = True
        End If
    End Sub
End Class