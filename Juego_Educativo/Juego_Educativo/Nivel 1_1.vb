Public Class Nivel_1_1
    Dim txtresp1_nivel1 As String
    Dim txtresp2_nivel1 As String
    Dim txtresp3_nivel1 As String
    Dim txtresp4_nivel1 As String
    Dim txtresp5_nivel1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandonivelunob()
        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel1 = "tree" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel1 = "table" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------




        If txtresp3_nivel1 = "chicken" Then

            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel1 = "orange" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel1 = "chair" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
        Else
            punteo = 0
        End If
        Return punteo
    End Function

    Private Sub txtImagen1_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1_1.TextChanged
        txtresp1_nivel1 = txtImagen1_1.Text
    End Sub

    Private Sub txtImagen2_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2_1.TextChanged
        txtresp2_nivel1 = txtImagen2_1.Text
    End Sub

    Private Sub txtImagen3_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3_1.TextChanged
        txtresp3_nivel1 = txtImagen3_1.Text
    End Sub

    Private Sub txtImagen4_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4_1.TextChanged
        txtresp4_nivel1 = txtImagen4_1.Text
    End Sub

    Private Sub txtImagen5_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5_1.TextChanged
        txtresp5_nivel1 = txtImagen5_1.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 0) Then
            calificar = calificandonivelunob()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_1.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_1.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Facil.Show()
                Case 4, 8
                    Nivel_1.Show()
            End Select
            Me.Close()
        ElseIf (puntos >= 12) Then
            calificar = calificandonivelunob()
            Select Case calificar
                Case 4
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                Case Is >= 8
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Facil.Show()
            End Select
            Me.Close()
        End If


    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        MsgBox(puntos.ToString)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class