Public Class Menu_Nivel_Facil

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_de_Opciones.Show()
    End Sub

    Private Sub Btn_Nivel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel1.Click
        Me.Close()
        Nivel_1.Show()
    End Sub

    Private Sub Btn_Nivel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel2.Click
        Me.Close()
        Nivel_2.Show()
    End Sub

    Private Sub Btn_Nivel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel3.Click
        Me.Close()
        Nivel_3.Show()
    End Sub

    Private Sub Btn_Nivel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel4.Click
        Me.Close()
        Nivel_4.Show()
    End Sub

    Private Sub Btn_Nivel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel5.Click
        Me.Close()
        Nivel_5.Show()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Dim punteo As usuario
        punteo = New usuario()
        Dim punteoactual As String
        punteoactual = punteo.comprobarpunteo()
        MsgBox(punteoactual) ' flag para ver punteo que tengo en nivel
        Dim level As usuario
        level = New usuario()
        Dim nivelactual As String
        nivelactual = level.comprobarnivel()

        If nivelactual = 1 Or nivelactual = 2 Then '' aquí vamos a ensenar los labels completado del nivel 1 por si acaso ya está en nivel 2 o 3 y entra de nuevo al 1
            Btn_Nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Label1_nivel1.Show()
            Label2_nivel1.Show()
            Label3_nivel1.Show()
            Label4_nivel1.Show()
            Label5_nivel1.Show()
        Else

            Select Case punteoactual
                Case Is <= 20
                    If (punteoactual = 20) Then
                        Label1_nivel1.Show()
                        Btn_Nivel3.Hide()
                        Btn_Nivel4.Hide()
                        Btn_Nivel5.Hide()
                    Else
                        Btn_Nivel2.Hide()
                        Btn_Nivel3.Hide()
                        Btn_Nivel4.Hide()
                        Btn_Nivel5.Hide()
                    End If


                Case 21 To 39
                    Btn_Nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel1.Show()
                    Btn_Nivel3.Hide()
                    Btn_Nivel4.Hide()
                    Btn_Nivel5.Hide()
                Case 40 To 59
                    Btn_Nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel1.Show()
                    Label2_nivel1.Show()
                    Btn_Nivel4.Hide()
                    Btn_Nivel5.Hide()
                Case 60 To 79
                    Btn_Nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel1.Show()
                    Label2_nivel1.Show()
                    Label3_nivel1.Show()
                    Btn_Nivel5.Show()
                Case 80 To 100
                    Btn_Nivel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel1.Show()
                    Label2_nivel1.Show()
                    Label3_nivel1.Show()
                    Label4_nivel1.Show()
            End Select
        End If

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Menu_Nivel_Facil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class