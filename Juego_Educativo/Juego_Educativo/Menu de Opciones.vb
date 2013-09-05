Imports Juego_Educativo.Principal
Public Class Menu_de_Opciones

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_Facil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Facil.Click
        Me.Close()
        Menu_Nivel_Facil.Show()
    End Sub

    Private Sub Btn_Medio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Medio.Click
        Me.Close()
        Menu_Nivel_Intermedio.Show()
    End Sub

    Private Sub Btn_Dificil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Dificil.Click
        Me.Close()
        Menu_Nivel_Avanzado.Show()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Dim level As usuario
        level = New usuario()
        Dim nivelactual As String
        nivelactual = level.comprobarnivel()
        MsgBox(nivelactual)
        Select Case nivelactual
            Case 0
                Btn_Medio.Hide()
                Btn_Dificil.Hide()
            Case 1
                Btn_Facil.Hide()
                Btn_Dificil.Hide()
            Case 2
                Btn_Facil.Hide()
                Btn_Medio.Hide()
        End Select
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class