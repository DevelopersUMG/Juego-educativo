Imports System.Data.SQLite
Imports Juego_Educativo.Principal
Imports Juego_Educativo.clases
Public Class cambiopass

    Private Sub cambiopass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objeto As usuario
        objeto = New usuario()
        Dim pass As Integer
        pass = objeto.comprobarpass()
        Dim viejopass As Integer
        viejopass = Convert.ToInt32(TextBox1.Text)
        Dim nuevopass As Integer
        nuevopass = Convert.ToInt32(TextBox2.Text)
        If (viejopass <> pass) Then
            MsgBox("escriba la contraseña actual correctamente")
            TextBox1.Clear()
        Else
            objeto.cambiarpass(nuevopass)
            MsgBox("contraseña cambiada con éxito")
            Me.Hide()
            Menu_de_Opciones.Show()

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Menu_de_Opciones.Show()
    End Sub
End Class