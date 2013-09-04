Public Class Nivel_3
    Dim txtresp1_nivel3 As String
    Dim txtresp2_nivel3 As String
    Dim txtresp3_nivel3 As String
    Dim txtresp4_nivel3 As String
    Dim txtresp5_nivel3 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String


    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
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


        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel3 = "the children play with the ball" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3_1a.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel3 = "my family is watching t.v" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3_1a.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel3 = "children are eating apple" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3_1a.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel3 = "the dogs are in the house" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel3 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_3_1a.Show()
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
                Nivel_3_1a.Show()
            End If
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
            Me.Close()
            Nivel_2.Show()
        Else
            punteo = 0
        End If




    End Sub
End Class