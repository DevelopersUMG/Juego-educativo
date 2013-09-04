Public Class Nivel_3_1a
    Dim txtresp1_nivel3 As String
    Dim txtresp2_nivel3 As String
    Dim txtresp3_nivel3 As String
    Dim txtresp4_nivel3 As String
    Dim txtresp5_nivel3 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String
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





        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel3 = "my brothers are playing with toys" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel3 = "the computers are in the house" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel3 = "the cats are in the car" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel3 = "the shoes are very expensive" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3.Show()
            End If
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel3 = "the books are in the car" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3.Show()
            End If
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_4.Show()
        Else
            punteo = 0
        End If




    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub
End Class