Public Class Nivel_5_1
    Dim txtresp1_nivel5 As String
    Dim txtresp2_nivel5 As String
    Dim txtresp3_nivel5 As String
    Dim txtresp4_nivel5 As String
    Dim txtresp5_nivel5 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String


    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click

        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel5 = "all my brothers are in school" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_5.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel5 = "rome and Paris are the most beautiful cities in the world" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_5.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel5 = "the dogs are running in the garden" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_5.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel5 = "there were a lot of people at the movies last night" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_5.Show()
            End If
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel5 = "apples and oranges are my favourite fruits" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel5 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_5.Show()
            End If
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_6.Show()
        Else
            punteo = 0
        End If
    End Sub






    Private Sub TxtPregunta1_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta1_5_1.TextChanged
        txtresp1_nivel5 = TxtPregunta1_5_1.Text
    End Sub

    Private Sub TxtPregunta2_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta2_5_1.TextChanged
        txtresp2_nivel5 = TxtPregunta2_5_1.Text
    End Sub

    Private Sub TxtPregunta3_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta3_5_1.TextChanged
        txtresp3_nivel5 = TxtPregunta3_5_1.Text
    End Sub

    Private Sub TxtPregunta4_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta4_5_1.TextChanged
        txtresp4_nivel5 = TxtPregunta4_5_1.Text
    End Sub

    Private Sub TxtPregunta5_5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPregunta5_5_1.TextChanged
        txtresp5_nivel5 = TxtPregunta5_5_1.Text

    End Sub
End Class