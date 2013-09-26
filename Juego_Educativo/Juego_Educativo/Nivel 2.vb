Public Class Nivel_2
    Dim txtresp1_nivel2 As String
    Dim txtresp2_nivel2 As String
    Dim txtresp3_nivel2 As String
    Dim txtresp4_nivel2 As String
    Dim txtresp5_nivel2 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String
    Public Function calificandoniveldos()

        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel2 = "family" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel2 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel2 = "books" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel2 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel2 = "childrens" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel2 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel2 = "dogs" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel2 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel2 = "televisions" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel2 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
        Else
            punteo = 0
        End If

        Return punteo
    End Function

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub


    Private Sub txtImagen1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1.TextChanged
        txtresp1_nivel2 = txtImagen1.Text
    End Sub

    Private Sub txtImagen2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2.TextChanged
        txtresp2_nivel2 = txtImagen2.Text
    End Sub

    Private Sub txtImagen3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3.TextChanged
        txtresp3_nivel2 = txtImagen3.Text
    End Sub

    Private Sub txtImagen4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4.TextChanged
        txtresp4_nivel2 = txtImagen4.Text
    End Sub

    Private Sub txtImagen5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5.TextChanged
        txtresp5_nivel2 = txtImagen5.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim nivelactual As Integer
        Dim calificar As Integer
        Dim puntos As Integer
        nivelactual = objeto.comprobarnivel() ''llamada a comprobar nivel
        MsgBox("nivel actual" + nivelactual.ToString)
        If nivelactual = 0 Then
            puntos = objeto.comprobarpunteo()
            MsgBox("Tiene" + puntos.ToString)
            If (puntos = 20) Then
                calificar = calificandoniveldos()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_2_1.Show()
                    Case 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Nivel_2_1.Show()
                    Case 20
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(calificar, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 4
                        puntos = objeto.comprobarpunteo()
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 8
                        puntos = objeto.comprobarpunteo()
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                    Case Else
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                End Select
                Me.Close()
            ElseIf (puntos >= 32 And puntos < 40) Then
                calificar = calificandoniveldos()
                Select Case calificar

                    Case 4 And puntos = 12 ' si tiene 1 respuesta buena y tiene 12 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()

                    Case 4 And puntos = 16     ' si tiene 1 respuesta buena y tiene 16 de puntos 
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()


                    Case 8 And puntos = 12      ' si tiene 2 respuesta buena y tiene 12 de puntos (da clavo)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()

                    Case 8 And puntos = 16   ' si tiene 2 respuesta buena y tiene 16 de puntos
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()



                    Case 12 And puntos = 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 12 And puntos = 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 12 And puntos = 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()

                    Case 16 And puntos = 12
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()

                    Case 16 And puntos = 16
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()


                End Select



                Me.Close()
            ElseIf (puntos = 20) Then
                calificandoniveldos()
                Menu_Nivel_Facil.Show()
            End If

        Else

            'no califica------------------------------------------------------------------------------------------------------
            calificandoniveldos()
        End If



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class