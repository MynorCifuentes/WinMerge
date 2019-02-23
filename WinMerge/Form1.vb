Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menu_abrir_Click(sender As Object, e As EventArgs) Handles menu_abrir.Click
        Dim abrirArchivo As OpenFileDialog = New OpenFileDialog()
        'Dim nombreArchivo As String
        'Dim contenidoArchivo As String
        Dim lecturaArchivo As IO.StreamReader
        abrirArchivo.Title = "Abrir Archivo prueba"
        abrirArchivo.InitialDirectory = "C:\Users\mynor\Desktop"
        abrirArchivo.Filter = "lfp files (*.lfp*)|*.lfp*"
        abrirArchivo.RestoreDirectory = True
        If abrirArchivo.ShowDialog() = DialogResult.OK Then
            lecturaArchivo = New IO.StreamReader(abrirArchivo.FileName, True)
            txt_1.Text = lecturaArchivo.ReadToEnd


        End If




    End Sub

    Private Sub menu_salir_Click(sender As Object, e As EventArgs) Handles menu_salir.Click
        Application.Exit()
    End Sub

    Private Sub menu_guardar_Click(sender As Object, e As EventArgs) Handles menu_guardar.Click

    End Sub

    Private Sub menu_guardarc_Click(sender As Object, e As EventArgs) Handles menu_guardarc.Click
        Dim archivoGuardar As New SaveFileDialog
        archivoGuardar.Filter = "LFP File|*.lfp"
        archivoGuardar.Title = "Guardar el archivo prueba modificado"
        If txt_1.Text.Length > 0 Then
            archivoGuardar.ShowDialog()
            File.WriteAllText(archivoGuardar.FileName, txt_1.Text)


        End If
    End Sub

    Private Sub menu_acercade_Click(sender As Object, e As EventArgs) Handles menu_acercade.Click
        MessageBox.Show("Mynor Cifuentes" + vbLf + " LFP 1Sem19 " + vbLf + " 201318644")
    End Sub
End Class
