Public Class Nivel_13
    Dim txtresp1_nivel3 As String
    Dim txtresp2_nivel3 As String
    Dim txtresp3_nivel3 As String
    Dim txtresp4_nivel3 As String
    Dim txtresp5_nivel3 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String


    Public Function calificandotrece()

        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel3 = "she eats" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel3 = "the woman" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel3 = "i drink" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel3 = "the man drinks" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel3 = "the boy eats bread" Then
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

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Avanzado.Show()
    End Sub

    Private Sub txtpregunta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta1.TextChanged
        txtresp1_nivel3 = txtpregunta1.Text
    End Sub

    Private Sub txtpregunta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta2.TextChanged
        txtresp2_nivel3 = txtpregunta2.Text
    End Sub

    Private Sub txtpregunta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta3.TextChanged
        txtresp3_nivel3 = txtpregunta3.Text
    End Sub

    Private Sub txtpregunta4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta4.TextChanged
        txtresp4_nivel3 = txtpregunta4.Text
    End Sub

    Private Sub txtpregunta5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpregunta5.TextChanged
        txtresp5_nivel3 = txtpregunta5.Text
    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim nivelactual As Integer
        Dim calificar As Integer
        Dim puntos As Integer
        nivelactual = objeto.comprobarnivel() ''llamada a comprobar nivel
        MsgBox("nivel actual" + nivelactual.ToString)
        If nivelactual = 2 Then
            puntos = objeto.comprobarpunteo()
            MsgBox("Tiene" + puntos.ToString)
            If (puntos = 40) Then
                calificar = calificandotrece()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        objeto.sumarpunteo(12, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_13_1.Show()
                    Case 16
                        objeto.sumarpunteo(16, puntos)
                        Nivel_13_1.Show()
                    Case 20
                        objeto.sumarpunteo(20, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case 4
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case 8
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case Else
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                End Select
            ElseIf (puntos >= 32 And puntos < 40) Then
                calificar = calificandotrece()
                MsgBox("saco" + calificar.ToString)
                Select Case calificar
                    Case (calificar = 4 And puntos = 32)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Nivel_13_1.Show()
                    Case (calificar = 4 And puntos = 36)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case (calificar = 8 And puntos = 32)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case (calificar = 8 And puntos = 36)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case (calificar = 16 And puntos = 36)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Avanzado.Show()
                    Case (calificar = 16 And puntos = 32)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Avanzado.Show()
                End Select
            ElseIf (puntos = 40) Then
                calificandotrece()
                Menu_Nivel_Avanzado.Show()
            ElseIf (puntos > 40) Then
                calificandotrece()
                Menu_Nivel_Avanzado.Show()
            End If
        Else
            'no califica------------------------------------------------------------------------------------------------------
            calificandotrece()
        End If
    End Sub
End Class