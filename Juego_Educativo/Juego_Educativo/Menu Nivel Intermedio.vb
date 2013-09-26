Public Class Menu_Nivel_Intermedio

    Private Sub Btn_RegresaMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegresaMenu.Click
        Me.Close()
        Menu_de_Opciones.Show()
    End Sub

    Private Sub Btn_RegreInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RegreInicio.Click
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Btn_Nivel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel6.Click
        Me.Close()
        Nivel_6.Show()
    End Sub

    Private Sub Btn_Nivel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel7.Click
        Me.Close()
        Nivel_7.Show()
    End Sub

    Private Sub Btn_Nivel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel8.Click
        Me.Close()
        Nivel_8.Show()
    End Sub

    Private Sub Btn_Nivel9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel9.Click
        Me.Close()
        Nivel_9.Show()
    End Sub

    Private Sub Btn_Nivel10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nivel10.Click
        Me.Close()
        Nivel_10.Show()
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

        If nivelactual = 2 Then '' aquí vamos a ensenar los labels completado del nivel 1 por si acaso ya está en nivel 2 o 3 y entra de nuevo al 1
            Btn_Nivel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Btn_Nivel10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Label1_nivel2.Show()
            Label2_nivel2.Show()
            Label3_nivel2.Show()
            Label4_nivel2.Show()
            Label5_nivel2.Show()
        Else

            Select Case punteoactual
                Case Is <= 20
                    If (punteoactual = 20) Then
                        Label1_nivel2.Show()
                        Btn_Nivel8.Hide()
                        Btn_Nivel9.Hide()
                        Btn_Nivel10.Hide()
                    ElseIf (punteoactual < 20) Then
                        Btn_Nivel7.Hide()
                        Btn_Nivel8.Hide()
                        Btn_Nivel9.Hide()
                        Btn_Nivel10.Hide()
                    End If


                Case 21 To 39
                    Btn_Nivel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel2.Show()
                    Btn_Nivel8.Hide()
                    Btn_Nivel9.Hide()
                    Btn_Nivel10.Hide()
                Case 40 To 59
                    Btn_Nivel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel2.Show()
                    Label2_nivel2.Show()
                    Btn_Nivel9.Hide()
                    Btn_Nivel10.Hide()
                Case 60 To 79
                    Btn_Nivel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel2.Show()
                    Label2_nivel2.Show()
                    Label3_nivel2.Show()
                    Btn_Nivel10.Hide()
                Case 80 To 100
                    Btn_Nivel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Btn_Nivel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    Label1_nivel2.Show()
                    Label2_nivel2.Show()
                    Label3_nivel2.Show()
                    Label4_nivel2.Show()
            End Select
        End If

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Menu_Nivel_Intermedio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class