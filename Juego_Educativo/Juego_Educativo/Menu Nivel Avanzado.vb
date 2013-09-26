Public Class Menu_Nivel_Avanzado

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_de_Opciones.Show()
    End Sub

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_Nivel11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel11.Click
        Me.Close()
        Nivel_11.Show()
    End Sub

    Private Sub Btn_Nivel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel12.Click
        Me.Close()
        Nivel_12.Show()
    End Sub

    Private Sub Btn_Nivel13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel13.Click
        Me.Close()
        Nivel_13.Show()
    End Sub

    Private Sub Btn_Nivel14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel14.Click
        Me.Close()
        Nivel_14_1.Show()
    End Sub

    Private Sub Btn_Nivel15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel15.Click
        Me.Close()
        Nivel_15.Show()
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
        If nivelactual = 3 Then '' aquí vamos a ensenar los labels completado del nivel 1 por si acaso ya está en nivel 2 o 3 y entra de nuevo al 1
            Btn_Nivel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Label1_nivel3.Show()
            Label2_nivel3.Show()
            Label3_nivel3.Show()
            Label4_nivel3.Show()
            Label5_nivel3.Show()
        Else
            Select Case punteoactual
                Case Is <= 20
                    If (punteoactual = 20) Then
                        Label1_nivel3.Show()
                        Btn_Nivel13.Hide()
                        Btn_Nivel14.Hide()
                        Btn_Nivel15.Hide()
                    ElseIf (punteoactual < 20) Then
                        Btn_Nivel12.Hide()
                        Btn_Nivel13.Hide()
                        Btn_Nivel14.Hide()
                        Btn_Nivel15.Hide()
                    End If


                Case 21 To 39
                    Btn_Nivel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel3.Show()
                    Btn_Nivel13.Hide()
                    Btn_Nivel14.Hide()
                    Btn_Nivel15.Hide()
                Case 40 To 59
                    Btn_Nivel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel3.Show()
                    Label2_nivel3.Show()
                    Btn_Nivel14.Hide()
                    Btn_Nivel15.Hide()
                Case 60 To 79
                    Btn_Nivel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel3.Show()
                    Label2_nivel3.Show()
                    Label3_nivel3.Show()
                    Btn_Nivel15.Hide()
                Case 80 To 100
                    Btn_Nivel11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel3.Show()
                    Label2_nivel3.Show()
                    Label3_nivel3.Show()
                    Label4_nivel3.Show()
            End Select
        End If

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class