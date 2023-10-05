Public Class Form1
    '-------Lado derecho------------------------
    'Posicion inicial de la lampara: 793, 394
    'Posicion inicial del papá: 841, 267
    'Posicion inicial de la hija: 912, 261
    'Posicion inicial del hijo: 985, 250
    'Posicion inicial del hijo menor: 1051, 340
    'Posicion inicial de la mamá: 1110, 230

    '-------Lado izquierdo----------------------
    'Posicion inicial de la lampara: 391, 429
    'Posicion inicial del papá: 310, 304
    'Posicion inicial de la hija: 242, 305
    'Posicion inicial del hijo: 193, 314
    'Posicion inicial del hijo menor: 136, 414
    'Posicion inicial de la mamá: 83, 321

    'Variable para contar cuantos personajes se han seleccionado
    Dim marcados As Integer
    Dim tiempo As Integer
    Dim velPapa As Double = 200.5
    Dim velMama As Double = 66.7
    Dim velHija As Double = 33.5
    Dim velHijo As Double = 25.5
    Dim velHijoMenor As Integer = 17
    Dim stateTimer As Boolean = False
    Dim papaPrimero As Boolean = False
    Dim mamaPrimero As Boolean = False
    Dim hijoPrimero As Boolean = False
    Dim hijaPrimero As Boolean = False
    Dim hijoMenorPrimero As Boolean = False

    Dim papaSegundo As Boolean = False
    Dim mamaSegundo As Boolean = False
    Dim hijoSegundo As Boolean = False
    Dim hijaSegundo As Boolean = False
    Dim hijoMenorSegundo As Boolean = False

    Dim linternaIzq As Boolean = False

    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        marcados = 0
        revisarInicio()
    End Sub

    'Metodo para revisar si se cumplen las normas para iniciar el juego
    Private Sub revisarInicio()
        If checkPapa.Checked = True Then
            marcados = marcados + 1
        End If

        If checkMama.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHija.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHijo.Checked = True Then
            marcados = marcados + 1
        End If

        If checkHijoMenor.Checked = True Then
            marcados = marcados + 1
        End If

        If marcados = 0 Then
            MsgBox("Selecciona al menos un personaje marcandolo.", vbCritical, "No ha seleccionado un personaje.")
        ElseIf marcados >= 3 Then
            MsgBox("Seleccionaste más de 2 personajes, desmarca algunos hasta tener solo uno o dos personajes marcados.", vbCritical, "Personajes seleccionados de más.")
        Else
            If tiempo = 0 Then
                tiempo = 60
            End If
            Timer1.Enabled = True
            Timer1.Start()
            stateTimer = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tiempo > 0 Then
            lblTime.ForeColor = Color.White
            tiempo = tiempo - 1

            If marcados = 1 Then
                'El papá avanza
                If checkPapa.Checked = True Then
                    If papa.Visible = True And papaIzq.Visible = False Then
                        If papa.Left >= 441 And papa.Left <= 850 And stateTimer = True Then
                            papa.Left = papa.Left - velPapa
                            imgLinterna.Left = imgLinterna.Left - velPapa
                        End If
                        If papa.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkPapa.Checked = False
                            papa.Visible = False
                            papa.Top = 267
                            papa.Left = 841
                            papaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf papaIzq.Visible = True And papa.Visible = False Then
                        If papaIzq.Left >= 200 And papaIzq.Left <= 680 And stateTimer = True Then
                            papaIzq.Left = papaIzq.Left + velPapa
                            imgLinterna.Left = imgLinterna.Left + velPapa
                        End If
                        If papaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkPapa.Checked = False
                            papaIzq.Visible = False
                            papaIzq.Top = 304
                            papaIzq.Left = 310
                            papa.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'El hijo avanza
                If checkHijo.Checked = True Then
                    If hijo.Visible = True And hijoIzq.Visible = False Then
                        If hijo.Left >= 441 And hijo.Left <= 850 And stateTimer = True Then
                            hijo.Left = hijo.Left - velHijo
                            imgLinterna.Left = imgLinterna.Left - velHijo
                        End If
                        If hijo.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            hijo.Visible = False
                            checkHijo.Checked = False
                            hijo.Top = 250
                            hijo.Left = 985
                            hijoIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijoIzq.Visible = True And hijo.Visible = False Then
                        If hijoIzq.Left >= 200 And hijoIzq.Left <= 680 And stateTimer = True Then
                            hijoIzq.Left = hijoIzq.Left + velHijo
                            imgLinterna.Left = imgLinterna.Left + velHijo
                        End If
                        If hijoIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijo.Checked = False
                            hijoIzq.Visible = False
                            hijoIzq.Top = 314
                            hijoIzq.Left = 193
                            hijo.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If

                'La hija avanza
                If checkHija.Checked = True Then
                    If hija.Visible = True And hijaIzq.Visible = False Then
                        If hija.Left >= 441 And hija.Left <= 850 And stateTimer = True Then
                            hija.Left = hija.Left - velHija
                            imgLinterna.Left = imgLinterna.Left - velHija
                        End If
                        If hija.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            hija.Visible = False
                            hija.Top = 261
                            hija.Left = 912
                            hijaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijaIzq.Visible = True And hija.Visible = False Then
                        If hijaIzq.Left >= 200 And hijaIzq.Left <= 680 And stateTimer = True Then
                            hijaIzq.Left = hijaIzq.Left + velHija
                            imgLinterna.Left = imgLinterna.Left + velHija
                        End If
                        If hijaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHija.Checked = False
                            hijaIzq.Visible = False
                            hijaIzq.Top = 305
                            hijaIzq.Left = 242
                            hija.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If

                'El hijo menor avanza
                If checkHijoMenor.Checked = True Then
                    If hijo2.Visible = True And hijo2Izq.Visible = False Then
                        If hijo2.Left >= 441 And hijo2.Left <= 850 And stateTimer = True Then
                            hijo2.Left = hijo2.Left - velHijoMenor
                            imgLinterna.Left = imgLinterna.Left - velHijoMenor
                        End If
                        If hijo2.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            hijo2.Visible = False
                            hijo2.Top = 261
                            hijo2.Left = 912
                            hijo2Izq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf hijo2Izq.Visible = True And hijo2.Visible = False Then
                        If hijo2Izq.Left >= 200 And hijo2Izq.Left <= 680 And stateTimer = True Then
                            hijo2Izq.Left = hijo2Izq.Left + velHijoMenor
                            imgLinterna.Left = imgLinterna.Left + velHijoMenor
                        End If
                        If hijo2Izq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkHijoMenor.Checked = False
                            hijo2Izq.Visible = False
                            hijo2Izq.Top = 305
                            hijo2Izq.Left = 242
                            hijo2.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
                'La mamá avanza
                If checkMama.Checked = True Then
                    If mama.Visible = True And mamaIzq.Visible = False Then
                        If mama.Left >= 441 And mama.Left <= 850 And stateTimer = True Then
                            mama.Left = mama.Left - velMama
                            imgLinterna.Left = imgLinterna.Left - velMama
                        End If
                        If mama.Left <= 480 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            mama.Visible = False
                            mama.Top = 230
                            mama.Left = 1110
                            mamaIzq.Visible = True
                            If linternaIzq = False Then
                                imgLinterna.Left = 391
                                imgLinterna.Top = 429
                                linternaIzq = True
                            End If
                        End If
                    ElseIf mamaIzq.Visible = True And mama.Visible = False Then
                        If mamaIzq.Left >= 200 And mamaIzq.Left <= 680 And stateTimer = True Then
                            mamaIzq.Left = mamaIzq.Left + velMama
                            imgLinterna.Left = imgLinterna.Left + velMama
                        End If
                        If mamaIzq.Left >= 680 Then
                            Timer1.Stop()
                            stateTimer = False
                            checkMama.Checked = False
                            mamaIzq.Visible = False
                            mamaIzq.Top = 321
                            mamaIzq.Left = 83
                            mama.Visible = True
                            If linternaIzq = True Then
                                linternaIzq = False
                                imgLinterna.Left = 793
                                imgLinterna.Top = 394
                            End If
                        End If
                    End If
                End If
            ElseIf marcados = 2 Then

            End If
        Else
                Timer1.Stop()
            MsgBox("Tiempo agotado")
        End If

        If tiempo > 10 Then
            lblTime.Text = tiempo.ToString
        ElseIf tiempo < 10 Then
            lblTime.Text = "0" + tiempo.ToString
            lblTime.ForeColor = Color.Red
        End If
    End Sub

    Private Sub checkPapa_CheckedChanged(sender As Object, e As EventArgs) Handles checkPapa.CheckedChanged
        If linternaIzq = False And papaIzq.Visible = True And checkPapa.Checked = True Then
            checkPapa.Checked = False
            MsgBox("No se puede seleccionar el papá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And papa.Visible = True And checkPapa.Checked = True Then
            checkPapa.Checked = False
            MsgBox("No se puede seleccionar el papá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And hijaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
                papaPrimero = True
            ElseIf mamaPrimero = True Or hijaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
                papaSegundo = True
            End If

            If checkPapa.Checked = True Then
                If papa.Visible = True And papaIzq.Visible = False Then
                    If papaPrimero = True Then
                        papa.Left = 650
                        papa.Top = 255
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        papa.Left = 721
                        papa.Top = 255
                    End If

                ElseIf papaIzq.Visible = True And papa.Visible = False Then
                    If papaPrimero = True Then
                        papaIzq.Left = 510
                        papaIzq.Top = 255
                        imgLinterna.Left = 565
                        imgLinterna.Top = 400
                    Else
                        papaIzq.Left = 435
                        papaIzq.Top = 255
                    End If

                End If
            End If

            If checkPapa.Checked = False Then
                If (papa.Left = 721 And papa.Top = 255) Or papaPrimero = True Then
                    papa.Top = 267
                    papa.Left = 841
                    imgLinterna.Left = 391
                    imgLinterna.Top = 429
                End If

                If (papaIzq.Left = 435 And papaIzq.Top = 255) Or papaPrimero = True Then
                    papaIzq.Top = 304
                    papaIzq.Left = 310
                    imgLinterna.Left = 793
                    imgLinterna.Top = 394
                End If

                If papaPrimero = True Then
                    papaPrimero = False
                End If

                If papaSegundo = True Then
                    papaSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHija_CheckedChanged(sender As Object, e As EventArgs) Handles checkHija.CheckedChanged
        If linternaIzq = False And hijaIzq.Visible = True And checkHija.Checked = True Then
            checkHija.Checked = False
            MsgBox("No se puede seleccionar a la hija porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hija.Visible = True And checkHija.Checked = True Then
            checkHija.Checked = False
            MsgBox("No se puede seleccionar a la hija porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
            hijaPrimero = True
        ElseIf mamaPrimero = True Or papaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
            hijaSegundo = True
        End If
        If checkHija.Checked = True Then
            If hija.Visible = True And hijaIzq.Visible = False Then
                If hijaPrimero = True Then
                    hija.Left = 651
                    hija.Top = 260
                    imgLinterna.Left = 620
                    imgLinterna.Top = 390
                Else
                    hija.Left = 726
                    hija.Top = 260
                End If

            ElseIf hijaIzq.Visible = True And hija.Visible = False Then
                If hijaPrimero = True Then
                    hijaIzq.Left = 502
                    hijaIzq.Top = 260
                    imgLinterna.Left = 565
                    imgLinterna.Top = 400
                Else
                    hijaIzq.Left = 427
                    hijaIzq.Top = 260
                End If

            End If
        End If

            If checkHija.Checked = False Then
                If hija.Left = 726 And hija.Top = 241 Or hijaPrimero = True Then
                    hija.Left = 912
                    hija.Top = 261
                    imgLinterna.Left = 391
                    imgLinterna.Top = 429
                End If
                If hijaIzq.Left = 427 And hijaIzq.Top = 250 Or hijaPrimero = True Then
                    hijaIzq.Left = 242
                    hijaIzq.Top = 305
                    imgLinterna.Left = 793
                    imgLinterna.Top = 394
                End If
                If hijaPrimero = True Then
                    hijaPrimero = False
                End If
                If hijaSegundo = True Then
                    hijaSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHijo_CheckedChanged(sender As Object, e As EventArgs) Handles checkHijo.CheckedChanged
        If linternaIzq = False And hijoIzq.Visible = True And checkHijo.Checked = True Then
            checkHijo.Checked = False
            MsgBox("No se puede seleccionar al hijo porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hijo.Visible = True And checkHijo.Checked = True Then
            checkHijo.Checked = False
            MsgBox("No se puede seleccionar al hijo porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoMenorPrimero = False And hijaPrimero = False Then
            hijoPrimero = True
        ElseIf mamaPrimero = True Or papaPrimero = True Or hijoMenorPrimero = True Or hijaPrimero = True Then
            hijoSegundo = True
        End If
        If checkHijo.Checked = True Then
            If hijo.Visible = True And hijoIzq.Visible = False Then
                If hijoPrimero = True Then
                    hijo.Left = 651
                    hijo.Top = 260
                    imgLinterna.Left = 620
                    imgLinterna.Top = 390
                Else
                    hijo.Left = 726
                    hijo.Top = 260
                End If

            ElseIf HijoIzq.Visible = True And Hijo.Visible = False Then
                If hijoPrimero = True Then
                    hijoIzq.Left = 502
                    hijoIzq.Top = 260
                    imgLinterna.Left = 565
                    imgLinterna.Top = 400
                Else
                    hijoIzq.Left = 427
                    hijoIzq.Top = 260
                End If

            End If
        End If

            If checkHijo.Checked = False Then
                If hijo.Left = 726 And hijo.Top = 241 Or hijoPrimero = True Then
                    hijo.Left = 985
                    hijo.Top = 250
                    imgLinterna.Left = 391
                    imgLinterna.Top = 429
                End If
                If hijoIzq.Left = 427 And hijoIzq.Top = 250 Or hijoPrimero = True Then
                    hijoIzq.Left = 193
                    hijoIzq.Top = 314
                    imgLinterna.Left = 793
                    imgLinterna.Top = 394
                End If

                If hijoPrimero = True Then
                    hijoPrimero = False
                End If
                If hijoSegundo = True Then
                    hijoSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkHijoMenor_CheckedChanged(sender As Object, e As EventArgs) Handles checkHijoMenor.CheckedChanged
        If linternaIzq = False And hijo2Izq.Visible = True And checkHijoMenor.Checked = True Then
            checkHijoMenor.Checked = False
            MsgBox("No se puede seleccionar al hijo menor porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And hijo2.Visible = True And checkHijoMenor.Checked = True Then
            checkHijoMenor.Checked = False
            MsgBox("No se puede seleccionar al hijo menor porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If mamaPrimero = False And papaPrimero = False And hijoPrimero = False And hijaPrimero = False Then
                hijoMenorPrimero = True
            ElseIf mamaPrimero = True Or papaPrimero = True Or hijoPrimero = True Or hijaPrimero = True Then
                hijoMenorSegundo = True
            End If
            If checkHijoMenor.Checked = True Then
                If hijo2.Visible = True And hijo2Izq.Visible = False Then
                    If hijoMenorPrimero = True Then
                        hijo2.Left = 651
                        hijo2.Top = 352
                        imgLinterna.Left = 620
                        imgLinterna.Top = 390
                    Else
                        hijo2.Left = 726
                        hijo2.Top = 342
                    End If

                ElseIf hijo2Izq.Visible = True And hijo2.Visible = False Then
                    If hijoMenorPrimero = True Then
                        hijo2Izq.Left = 502
                        hijo2Izq.Top = 352
                        imgLinterna.Left = 565
                        imgLinterna.Top = 390
                    Else
                        hijo2Izq.Left = 427
                        hijo2Izq.Top = 342
                    End If

                End If
            End If

            If checkHijoMenor.Checked = False Then
                If hijo2.Left = 726 And hijo2.Top = 241 Or hijoMenorPrimero = True Then
                    hijo2.Left = 1051
                    hijo2.Top = 340
                    imgLinterna.Left = 391
                    imgLinterna.Top = 429
                End If
                If hijo2Izq.Left = 427 And hijo2Izq.Top = 250 Or hijoMenorPrimero = True Then
                    hijo2Izq.Left = 136
                    hijo2Izq.Top = 414
                    imgLinterna.Left = 793
                    imgLinterna.Top = 394
                End If

                If hijoMenorPrimero = True Then
                    hijoMenorPrimero = False
                End If

                If hijoMenorSegundo = True Then
                    hijoMenorSegundo = False
                End If
            End If
        End If
    End Sub

    Private Sub checkMama_CheckedChanged(sender As Object, e As EventArgs) Handles checkMama.CheckedChanged
        If linternaIzq = False And mamaIzq.Visible = True And checkMama.Checked = True Then
            checkMama.Checked = False
            MsgBox("No se puede seleccionar a la mamá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        ElseIf linternaIzq = True And mama.Visible = True And checkMama.Checked = True Then
            checkMama.Checked = False
            MsgBox("No se puede seleccionar a la mamá porque la lampara esta del lado opuesto.", vbExclamation, "No seleccionable.")
        Else
            If papaPrimero = False And hijaPrimero = False And hijoMenorPrimero = False And hijoPrimero = False Then
            mamaPrimero = True
        ElseIf papaPrimero = True Or hijaPrimero = True Or hijoMenorPrimero = True Or hijoPrimero = True Then
            mamaSegundo = True
        End If
        If checkMama.Checked = True Then
            If mama.Visible = True And mamaIzq.Visible = False Then
                If mamaPrimero = True Then
                    mama.Left = 651
                    mama.Top = 255
                    imgLinterna.Left = 620
                    imgLinterna.Top = 390
                Else
                    mama.Left = 726
                    mama.Top = 255
                End If

            ElseIf mamaIzq.Visible = True And mama.Visible = False Then
                If mamaPrimero = True Then
                    mamaIzq.Left = 502
                    mamaIzq.Top = 255
                    imgLinterna.Left = 565
                    imgLinterna.Top = 400
                Else
                    mamaIzq.Left = 427
                    mamaIzq.Top = 255
                End If

            End If
        End If

        If checkMama.Checked = False Then
            If mama.Left = 726 And mama.Top = 241 Or mamaPrimero = True Then
                mama.Left = 1110
                mama.Top = 230
                imgLinterna.Left = 391
                imgLinterna.Top = 429
            End If
            If mamaIzq.Left = 427 And mamaIzq.Top = 250 Or mamaPrimero = True Then
                mamaIzq.Left = 83
                mamaIzq.Top = 321
                imgLinterna.Left = 793
                imgLinterna.Top = 394
            End If

            If mamaPrimero = True Then
                mamaPrimero = False
            End If

            If mamaSegundo = True Then
                mamaSegundo = False
            End If
        End If
        End If
    End Sub
End Class
