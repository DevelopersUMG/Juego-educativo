Public Class Nivel_11_1
    Dim txtresp1_nivel1 As String
    Dim txtresp2_nivel1 As String
    Dim txtresp3_nivel1 As String
    Dim txtresp4_nivel1 As String
    Dim txtresp5_nivel1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

    Public Function calificandoonceb()
        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel1 = "red" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel1 = "purple" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)

        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------




        If txtresp3_nivel1 = "black" Then

            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel1 = "yellow" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel1 = "green" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
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
            calificar = calificandoonceb()

            Select Case calificar
                Case 12
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_11.Show()
                Case 16
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Nivel_11.Show()
                Case 20
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(calificar, puntos)
                    Menu_Nivel_Intermedio.Show()

                Case Else
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(0, puntos)
                    Nivel_11.Show()
            End Select
            Me.Close()
        ElseIf (puntos >= 12 And puntos < 20) Then
            calificar = calificandoonceb()
            MsgBox("saco" + calificar.ToString)
            Select Case calificar
                Case (calificar = 4 And puntos = 12)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()
                Case (calificar = 4 And puntos = 16)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)
                    Menu_Nivel_Avanzado.Show()
                Case (calificar = 8 And puntos = 12)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)
                    Menu_Nivel_Avanzado.Show()
                Case (calificar = 8 And puntos = 16)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)

                    Menu_Nivel_Avanzado.Show()
                Case (calificar = 16 And puntos = 16)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(4, puntos)

                    Menu_Nivel_Avanzado.Show()
                Case (calificar = 16 And puntos = 12)
                    puntos = objeto.comprobarpunteo()
                    objeto.sumarpunteo(8, puntos)

                    Menu_Nivel_Avanzado.Show()
           
            End Select
        End If
    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub
End Class