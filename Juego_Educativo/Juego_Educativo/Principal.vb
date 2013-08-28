Imports System.Data.SQLite


Public Class Principal
    Dim conexion As String = "Data Source=database.db;Version=3;"
    Private Sub Btn_Ingresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingresar.Click
        Dim crearcomando As SQLiteCommand
        Dim sqlite_conn As SQLiteConnection
        Dim dr As SQLiteDataReader
        sqlite_conn = New SQLiteConnection(conexion)
        Try
            sqlite_conn.Open()
            Dim query As String = "select * from usuarios where usuario='" + Text_Usuario.Text + "' and contrasena=" + Text_Contraseña.Text
            crearcomando = New SQLiteCommand(query, sqlite_conn)
            crearcomando.ExecuteNonQuery()
            dr = crearcomando.ExecuteReader()
            Dim contador As Integer
            contador = 0
            While (dr.Read())
                contador = contador + 1
            End While
            If (contador = 1) Then
                MsgBox("inicio de sesion exitosa")
                Menu_de_Opciones.Show()
                Me.Visible = False
                sqlite_conn.Close()

            Else
                MsgBox("usuario no encontrado")
                Text_Usuario.Clear()
                Text_Contraseña.Clear()

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Registrarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Registrarse.Click
        Registro.Show()
        Me.Visible = False
    End Sub

    Private Sub Btn_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Salir.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Text_Usuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Usuario.TextChanged

    End Sub
End Class
