Module points
    Public puntosDevOps As Integer
    Public puntosIT As Integer
    Public puntosBack As Integer
    Public puntosFront As Integer
    Public puntosFullStack As Integer
    Public puntosMovil As Integer
    Public puntosWeb As Integer
    Public puntosIA As Integer
    Public puntosTester As Integer
    Public puntosDocumentador As Integer
    Public puntosArqSoft As Integer
    Public developer As Integer()
    Public maxValor As Integer
    Public especialidad As Integer
    Public Sub points_networks()
        puntosIT = apartado_IT.pointsIT
        puntosDevOps = dev_ops.pointsDevOps
        dev_ops.Hide()
        If puntosIT = puntosDevOps Then
            bonusNet.ShowDialog()
        ElseIf puntosIT > puntosDevOps Then
            especialidad = 1
            resultados.ShowDialog()
        ElseIf puntosDevOps > puntosIT Then
            especialidad = 2
            resultados.ShowDialog()
        End If
    End Sub

    Public Sub points_developer()
        ' Encontrar todas las variables que tienen el valor máximo
        Dim variablesConMaxValor As New List(Of Integer)
        puntosBack = dev_backend.pointsDevBackend
        puntosFront = dev_frontend.pointsDevFrontend
        puntosFullStack = dev_fullstack.pointsDevFullstack
        puntosMovil = dev_movil.pointsDevMovil
        puntosWeb = dev_web.pointsDevWeb
        puntosIA = dev_IA.pointsDevIA
        developer = {puntosBack, puntosFront, puntosFullStack, puntosMovil, puntosWeb, puntosIA}
        maxValor = developer.Max()

        For Each i As Integer In developer
            If developer(i) = maxValor Then
                variablesConMaxValor.Add(i)
            End If
        Next

        If variablesConMaxValor.Count() = 1 Then
            If maxValor = puntosBack Then
                especialidad = 3
            ElseIf maxValor = puntosFront Then
                especialidad = 4
            ElseIf maxValor = puntosFullStack Then
                especialidad = 5
            ElseIf maxValor = puntosMovil Then
                especialidad = 6
            ElseIf maxValor = puntosWeb Then
                especialidad = 7
            ElseIf maxValor = puntosIA Then
                especialidad = 8
            End If
            resultados.ShowDialog()
        Else
            dev_IA.Hide()
            bonusDeveloper.ShowDialog()
        End If
    End Sub

    Public Sub calidad_documetador()
        puntosDocumentador = documentador.pointsDoc
        puntosTester = tester.pointsTester
        puntosArqSoft = apartado_arq_soft.pointsArqSoft

        If puntosDocumentador > puntosTester And puntosDocumentador > puntosArqSoft Then
            resultados.ShowDialog()
            especialidad = 9
        ElseIf puntosTester > puntosDocumentador And puntosTester > puntosArqSoft Then
            resultados.ShowDialog()
            especialidad = 10
        ElseIf puntosArqSoft > puntosDocumentador And puntosArqSoft > puntosTester Then
            resultados.ShowDialog()
            especialidad = 11
        ElseIf puntosDocumentador = puntosTester And puntosDocumentador > puntosArqSoft Then
            bonusDoc_tester.rBtnTester.Visible = True
            bonusDoc_tester.rBtnDocumentador.Visible = True
            bonusDoc_tester.ShowDialog()
        ElseIf puntosArqSoft = puntosDocumentador And puntosArqSoft > puntosTester Then
            bonusDoc_tester.rBtnArqSoft.Visible = True
            bonusDoc_tester.rBtnDocumentador.Visible = True
            bonusDoc_tester.ShowDialog()
        ElseIf puntosArqSoft = puntosTester And puntosArqSoft > puntosDocumentador Then
            bonusDoc_tester.rBtnArqSoft.Visible = True
            bonusDoc_tester.rBtnTester.Visible = True
            bonusDoc_tester.ShowDialog()
        ElseIf puntosArqSoft = puntosTester And puntosArqSoft = puntosDocumentador Then
            bonusDoc_tester.rBtnArqSoft.Visible = True
            bonusDoc_tester.rBtnTester.Visible = True
            bonusDoc_tester.rBtnDocumentador.Visible = True
            bonusDoc_tester.ShowDialog()
        End If
    End Sub
End Module