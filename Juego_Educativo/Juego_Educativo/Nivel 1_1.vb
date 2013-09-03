Public Class Nivel_1_1
    Dim txtresp1_nivel1 As String
    Dim txtresp2_nivel1 As String
    Dim txtresp3_nivel1 As String
    Dim txtresp4_nivel1 As String
    Dim txtresp5_nivel1 As String
    Dim conta_errores As Integer
    Dim punteo As Integer
    Dim conver As String
    Dim puntos As String

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


        '--------------------------------------   Primer textbox     -----------------------------------------------------

        If txtresp1_nivel1 = "tree" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta 1 (" + txtresp1_nivel1 + ")" + " *** Es incorrecta *** Error No." + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel1 = "table" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp2_nivel1 + "--- Es incorrecto" + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------




        If txtresp3_nivel1 = "chicken" Then

            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp3_nivel1 + "--- Es incorrecto" + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel1 = "orange" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp4_nivel1 + "--- Es incorrecto" + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel1 = "chair" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show(txtresp5_nivel1 + "--- Es incorrecto" + conver)
            If conta_errores > 2 Then
                Me.Close()
                Nivel_1.Show()
            End If
        End If

        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Tu punteo fue " + puntos)
            Me.Close()
            Nivel_2.Show()
        Else
            punteo = 0
        End If



    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub
End Class