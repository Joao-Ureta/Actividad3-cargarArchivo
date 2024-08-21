Public Class Form1

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        'Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath "carga.txt")
        'C:\Users\Joao\source\repos\Actividad3-cargarArchivo

        Dim rutaArchivo As String = "C:\Users\Joao\source\joaoUreta.txt"
        Try
            If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                Dim contenido As String = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                txtMostrar.Text = contenido
                MessageBox.Show("Archivo cargado con exito")

            Else
                MessageBox.Show("El archivo no fue encontrado")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar el archivo")
        End Try

    End Sub
End Class
