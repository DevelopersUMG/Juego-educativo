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


    Public Function calificandoniveluno()
        '--------------------------------------   Primer textbox     -----------------------------------------------------
        If txtresp1_nivel1 = "house" Then
            ' MessageBox.Show("correcto : " + txtresp1_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 1 ( " + txtresp1_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Seundo textbox ---------------------------------------------

        If txtresp2_nivel1 = "car" Then
            'MessageBox.Show("correcto : " + txtresp2_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 2 ( " + txtresp2_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If

        '------------------------------------------  Tercer textbox    ---------------------------------------------

        If txtresp3_nivel1 = "pencil" Then
            'MessageBox.Show("correcto : " + txtresp3_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 3 ( " + txtresp3_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If
        '------------------------------------------  Cuarto textbox    ---------------------------------------------

        If txtresp4_nivel1 = "apple" Then
            'MessageBox.Show("correcto : " + txtresp4_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 4 ( " + txtresp4_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If




        '------------------------------------------  Quinto textbox    ---------------------------------------------

        If txtresp5_nivel1 = "ball" Then
            'MessageBox.Show("correcto : " + txtresp5_nivel1)
            punteo = punteo + 4
        Else
            conta_errores = conta_errores + 1
            conver = Convert.ToString(conta_errores)
            MessageBox.Show("La respuesta No. 5 ( " + txtresp5_nivel1 + " )" + " *** Es incorrecta ***  Error No." + conver)
        End If
        If punteo >= 12 Then
            puntos = Convert.ToString(punteo)
            MessageBox.Show("Bien Hecho" + " ""Tu punteo fue " + puntos)
        Else
            punteo = 0
        End If
        MsgBox("mandamos :" + punteo.ToString)
        Return punteo
    End Function

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
            If (puntos = 0) Then
                calificar = calificandoniveluno()
                MsgBox("calificamos:" + calificar.ToString)
                Select Case calificar
                    Case 12
                        objeto.sumarpunteo(12, puntos)
                        MsgBox("sumamos flag" + calificar.ToString)
                        Nivel_1_1.Show()
                    Case 16
                        objeto.sumarpunteo(16, puntos)
                        Nivel_1_1.Show()
                    Case 20
                        objeto.sumarpunteo(20, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 4
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                    Case 8
                        MsgBox("vuelva a intentarlo")
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                    Case Else
                        objeto.sumarpunteo(0, puntos)
                        Menu_Nivel_Facil.Show()
                End Select
                Me.Close()
            ElseIf (puntos >= 12 And puntos < 20) Then
                calificar = calificandoniveluno()
                MsgBox("saco" + calificar.ToString)
                Select Case calificar
                    Case (calificar = 4 And puntos = 12)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Nivel_1_1.Show()
                    Case (calificar = 4 And puntos = 16)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()
                    Case (calificar = 8 And puntos = 12)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()
                    Case (calificar = 8 And puntos = 16)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()
                    Case (calificar = 16 And puntos = 16)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(4, puntos)
                        Menu_Nivel_Facil.Show()
                    Case (calificar = 16 And puntos = 12)
                        puntos = objeto.comprobarpunteo()
                        objeto.sumarpunteo(8, puntos)
                        Menu_Nivel_Facil.Show()
                End Select
            ElseIf (puntos = 20) Then
                calificandoniveluno()
                Menu_Nivel_Facil.Show()

        Else
            'no califica------------------------------------------------------------------------------------------------------
            calificandoniveluno()
        End If
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

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class