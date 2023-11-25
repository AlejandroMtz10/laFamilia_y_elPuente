Public Class registros
    Private Sub registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Systems_engineer_quizDataSet.yourprofile' Puede moverla o quitarla según sea necesario.
        Me.YourprofileTableAdapter.Fill(Me.Systems_engineer_quizDataSet.yourprofile)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        Dim matricula As String = txtBuscar.Text
        Select Case e.KeyCode
            Case Keys.Enter
                If matricula = "" Then
                    Me.YourprofileTableAdapter.Fill(Me.Systems_engineer_quizDataSet.yourprofile)
                Else

                    Me.YourprofileTableAdapter.buscarMatricula(Me.Systems_engineer_quizDataSet.yourprofile, matricula)
                End If
        End Select
    End Sub
End Class