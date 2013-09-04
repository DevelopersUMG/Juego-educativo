Public Class Nivel_1
    Dim txtresp1_nivel1 As String
    Dim txtresp2_nivel1 As String
    Dim txtresp3_nivel1 As String
    Dim txtresp4_nivel1 As String
    Dim txtresp5_nivel1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String



    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagen3Nivel1.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen2.TextChanged
        txtresp2_nivel1 = txtImagen2.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen5.TextChanged
        txtresp5_nivel1 = txtImagen5.Text
    End Sub

    Private Sub imagen2Nivel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagen2Nivel1.Click

    End Sub

    Private Sub Btn_Calificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calificar.Click

        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel1 = "house" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores >= 2 Then
                Me.Close()
                Nivel_1_1.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel1 = "car" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1_1.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel1 = "pencil" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel1 = "apple" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1_1.Show()
            End If
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel1 = "ball" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1_1.Show()
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

    Private Sub txtImagen1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen1.TextChanged
        txtresp1_nivel1 = txtImagen1.Text
    End Sub

    Private Sub txtImagen3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen3.TextChanged
        txtresp3_nivel1 = txtImagen3.Text
    End Sub

    Private Sub txtImagen4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagen4.TextChanged
        txtresp4_nivel1 = txtImagen4.Text
    End Sub

    Private Sub imagen1Nivel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imagen1Nivel1.Click

    End Sub

    Private Sub Nivel_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class