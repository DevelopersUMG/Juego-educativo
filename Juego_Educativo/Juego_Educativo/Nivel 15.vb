﻿Public Class Nivel_15
    Dim txtresp1_nivel5 As String
    Dim txtresp2_nivel5 As String
    Dim txtresp3_nivel5 As String
    Dim txtresp4_nivel5 As String
    Dim txtresp5_nivel5 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandoquince()

        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel5 = "i read" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel5 = "we drink water" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel5 = "the women drink" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel5 = "the boys drink water" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel5 = "woman and girls" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)

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

    Private Sub TxtPregunta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta1.TextChanged
        txtresp1_nivel5 = TxtPregunta1.Text
    End Sub

    Private Sub TxtPregunta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta2.TextChanged
        txtresp2_nivel5 = TxtPregunta2.Text
    End Sub

    Private Sub TxtPregunta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta3.TextChanged
        txtresp3_nivel5 = TxtPregunta3.Text
    End Sub

    Private Sub TxtPregunta4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta4.TextChanged
        txtresp4_nivel5 = TxtPregunta4.Text
    End Sub

    Private Sub TxtPregunta5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5.TextChanged
        txtresp5_nivel5 = TxtPregunta5.Text
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
            If (puntos = 80) Then
                calificar = calificandoquince()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        objeto.sumarpunteo(12, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_15_1.Show()
                    Case 16
                        objeto.sumarpunteo(16, puntos)
                        Nivel_15_1.Show()
                    Case 20
                        objeto.sumarpunteo(20, puntos)
                        objeto.modificarnivel(nivelactual, 1)
                        objeto.regresarpunteo()
                        fin.Show()
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
                        Menu_Nivel_Avanzado.Show()
                End Select
            ElseIf (puntos >= 92 And puntos < 100) Then
                calificar = calificandoquince()
                MsgBox("saco" + calificar.ToString)
                Select Case calificar
                    Case (calificar = 4 And puntos = 92)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Nivel_15_1.Show()
                    Case (calificar = 4 And puntos = 96)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        objeto.regresarpunteo()
                        objeto.modificarnivel(nivelactual, 1)
                        fin.Show()
                    Case (calificar = 8 And puntos = 92)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        objeto.regresarpunteo()
                        objeto.modificarnivel(nivelactual, 1)
                        fin.Show()
                    Case (calificar = 8 And puntos = 96)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        objeto.regresarpunteo()
                        objeto.modificarnivel(nivelactual, 1)
                        fin.Show()
                    Case (calificar = 16 And puntos = 96)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        objeto.regresarpunteo()
                        objeto.modificarnivel(nivelactual, 1)
                        fin.Show()
                    Case (calificar = 16 And puntos = 92)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        objeto.regresarpunteo()
                        objeto.modificarnivel(nivelactual, 1)
                        fin.Show()
                End Select
            ElseIf (puntos = 100) Then
                calificandoquince()
                fin.Show()
            ElseIf (puntos > 100) Then
                calificandoquince()
                fin.Show()
            End If
        Else
            'no califica------------------------------------------------------------------------------------------------------
            calificandoquince()
        End If
    End Sub
End Class