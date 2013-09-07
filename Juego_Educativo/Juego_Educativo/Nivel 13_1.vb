Public Class Nivel_13_1
    Dim txtresp1_nivel3 As String
    Dim txtresp2_nivel3 As String
    Dim txtresp3_nivel3 As String
    Dim txtresp4_nivel3 As String
    Dim txtresp5_nivel3 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandotreceb()
        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel3 = "the woman drinks water" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel3 = "i eat an apple and she eats bread" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel3 = "i eat an apple and she eats bread" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel3 = "i drink water" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel3 = "she drinks water" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
        Else
            punteo = 0
        End If


        Return punteo
    End Function


    Private Sub txtpregunta1_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta1_3_1a.TextChanged
        txtresp1_nivel3 = txtpregunta1_3_1a.Text
    End Sub

    Private Sub txtpregunta2_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta2_3_1a.TextChanged
        txtresp2_nivel3 = txtpregunta2_3_1a.Text
    End Sub

    Private Sub txtpregunta3_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta3_3_1a.TextChanged
        txtresp3_nivel3 = txtpregunta3_3_1a.Text
    End Sub

    Private Sub txtpregunta4_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta4_3_1a.TextChanged
        txtresp4_nivel3 = txtpregunta4_3_1a.Text
    End Sub

    Private Sub txtpregunta5_3_1a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta5_3_1a.TextChanged
        txtresp5_nivel3 = txtpregunta5_3_1a.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 40) Then
            calificar = calificandotreceb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_13.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_13.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Nivel_13.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 52 And puntos < 60) Then
            calificar = calificandotreceb()
            Select Case calificar

                Case 4 And puntos = 52 ' si tiene 1 respuesta buena y tiene 12 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 4 And puntos = 56     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()



                Case 8 And puntos = 52      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 8 And puntos = 56   ' si tiene 2 respuesta buena y tiene 16 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()



                Case 12 And puntos = 52
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 12 And puntos = 52
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 12 And puntos = 56
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()


                Case 16 And puntos = 52
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 16 And puntos = 56
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()


            End Select




            'no califica------------------------------------------------------------------------------------------------------
            'calificandonivelunob()
        End If
        Me.Close()
    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Private Sub pregunta2Nivel3_1a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pregunta2Nivel3_1a.Click

    End Sub

    Private Sub Nivel_13_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class