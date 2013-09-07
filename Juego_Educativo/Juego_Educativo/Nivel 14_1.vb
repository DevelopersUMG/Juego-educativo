Public Class Nivel_14_1
    Dim txtresp1_nivel4 As String
    Dim txtresp2_nivel4 As String
    Dim txtresp3_nivel4 As String
    Dim txtresp4_nivel4 As String
    Dim txtresp5_nivel4 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandocatorceb()
        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel4 = "boy" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel4 = "apple" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel4 = "man" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel4 = "banana" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel4 = "old man" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel4 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)

        Else
            punteo = 0
        End If
        Return punteo
    End Function


    Private Sub txtImagen1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1_4.TextChanged
        txtresp1_nivel4 = txtImagen1_4.Text
    End Sub

    Private Sub txtImagen2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2_4.TextChanged
        txtresp2_nivel4 = txtImagen2_4.Text
    End Sub

    Private Sub txtImagen3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3_4.TextChanged
        txtresp3_nivel4 = txtImagen3_4.Text
    End Sub

    Private Sub txtImagen4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4_4.TextChanged
        txtresp4_nivel4 = txtImagen4_4.Text
    End Sub

    Private Sub txtImagen5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5_4.TextChanged
        txtresp5_nivel4 = txtImagen5_4.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim puntos As Integer
        puntos = objeto.comprobarpunteo()
        Dim calificar As Integer
        If (puntos = 60) Then
            calificar = calificandocatorceb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_14.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_14.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Nivel_14.Show()
            End Select
            Me.Close()

        ElseIf (puntos >= 72 And puntos < 80) Then
            calificar = calificandocatorceb()
            Select Case calificar

                Case 4 And puntos = 72 ' si tiene 1 respuesta buena y tiene 12 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 4 And puntos = 76     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 8 And puntos = 72      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Facil.Show()

                Case 8 And puntos = 76   ' si tiene 2 respuesta buena y tiene 16 de puntos
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()


                Case 12 And puntos = 72
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 12 And puntos = 72
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 12 And puntos = 76
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()


                Case 16 And puntos = 72
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()

                Case 16 And puntos = 76
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

    Private Sub imagen1Nivel4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagen1Nivel4_1.Click

    End Sub

    Private Sub imagen3Nivel4_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagen3Nivel4_1.Click

    End Sub
End Class