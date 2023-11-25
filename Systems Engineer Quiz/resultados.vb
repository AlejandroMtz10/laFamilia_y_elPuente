Public Class resultados
    Dim ramaCarrera As Integer
    Dim especializacion As String
    Dim descripcion As String
    Dim temas As String
    Dim maxPoints As Integer
    Dim namePer, lastName, id As String
    Dim semester As Integer
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        close_window()
    End Sub

    Private Sub resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Systems_engineer_quizDataSet.yourprofile' Puede moverla o quitarla según sea necesario.
        Me.YourprofileTableAdapter.Fill(Me.Systems_engineer_quizDataSet.yourprofile)
        Dim opcion As Integer
        opcion = points.especialidad
        Select Case opcion
            'IT
            Case 1
                especializacion = "Tecnologías de la información (IT)."
                maxPoints = apartado_IT.pointsIT
            'DevOps
            Case 2
                especializacion = "DevOps."
                maxPoints = dev_ops.pointsDevOps
            'Backend
            Case 3
                especializacion = "Backend developer."
                maxPoints = dev_backend.pointsDevBackend
            'Frontend
            Case 4
                especializacion = "Frontend Developer."
                maxPoints = dev_frontend.pointsDevFrontend
            'FullStack
            Case 5
                especializacion = "FullStack Developer."
                maxPoints = dev_fullstack.pointsDevFullstack
            'Moviles
            Case 6
                especializacion = "Mobile Developer."
                maxPoints = dev_movil.pointsDevMovil
            'Web
            Case 7
                especializacion = "Web Developer."
                maxPoints = dev_web.pointsDevWeb
            'IA
            Case 8
                especializacion = "Inteligencia Artificial (IA)."
                maxPoints = dev_IA.pointsDevIA
            'Documentador
            Case 9
                especializacion = "Documentador."
                maxPoints = documentador.pointsDoc
            'Tester
            Case 10
                especializacion = "Tester."
                maxPoints = tester.pointsTester
            'Arquitecto De Software
            Case 11
                especializacion = "Arquitecto de Software."
                maxPoints = apartado_arq_soft.pointsArqSoft
        End Select
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        descripcion = EspecialidadTableAdapter.searchDescription(especializacion)
        temas = EspecialidadTableAdapter.searchLearning(especializacion)

        txtEspecialidad.Text = especializacion
        txtPoints.Text = maxPoints
        txtDescription.Text = descripcion
        txtTemas.Text = temas
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        id = mainMenu.matricula
        namePer = mainMenu.nombre
        lastName = mainMenu.apellidos
        semester = mainMenu.semestre
        Me.YourprofileTableAdapter.insertarDatos(id, namePer, lastName, semester, especializacion, descripcion, temas, maxPoints)
        close_window()
    End Sub

    Public Sub close_window()
        ramaCarrera = ramas.rama
        Select Case ramaCarrera
            Case 1
                apartado_IT.Close()
                dev_ops.Close()
            Case 2
                dev_backend.Close()
                dev_frontend.Close()
                dev_fullstack.Close()
                dev_movil.Close()
                dev_web.Close()
                dev_IA.Close()
            Case 3
                tester.Close()
                documentador.Close()
                apartado_arq_soft.Close()
        End Select
        Me.Close()
    End Sub
End Class