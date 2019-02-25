Imports System.IO
Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menu_abrir_Click(sender As Object, e As EventArgs) Handles menu_abrir.Click





    End Sub

    Private Sub menu_salir_Click(sender As Object, e As EventArgs) Handles menu_salir.Click
        Application.Exit()
    End Sub
    Dim guardarArchivo As New SaveFileDialog
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

    Private Sub menu_agregart_Click(sender As Object, e As EventArgs) Handles menu_agregart.Click
        Dim cadena As String
        cadena = txt_1.Text
        txt_2.Text = cadena

    End Sub


    Dim abrirArchivo As OpenFileDialog = New OpenFileDialog()
    Dim contenidoArchivo As String
    Dim lecturaArchivo As IO.StreamReader
    Dim posicion As Integer


    Private Sub menu_abrir1_Click(sender As Object, e As EventArgs) Handles menu_abrir1.Click

        'Dim nombreArchivo As String

        abrirArchivo.Title = "Abrir Archivo 1"
        abrirArchivo.InitialDirectory = "C:\Users\mynor\Desktop"
        abrirArchivo.Filter = "lfp files (*.lfp*)|*.lfp*"
        abrirArchivo.RestoreDirectory = True
        If abrirArchivo.ShowDialog() = DialogResult.OK Then
            lecturaArchivo = New IO.StreamReader(abrirArchivo.FileName, True)
            txt_1.Text = lecturaArchivo.ReadToEnd

            contenidoArchivo = lecturaArchivo.ReadToEnd
            Dim arreglo1 As Char()
            arreglo1 = contenidoArchivo.ToCharArray
            'Dim charArray() As Char = contenidoArchivo.ToCharArray

        End If

    End Sub


    Private Sub menu_abrir2_Click(sender As Object, e As EventArgs) Handles menu_abrir2.Click
        abrirArchivo.Title = "Abirir Archivo 2"
        abrirArchivo.InitialDirectory = "C:\Users\mynor\Desktop"
        abrirArchivo.Filter = "lfp files (*.lfp*)|*.lfp*"
        abrirArchivo.RestoreDirectory = True
        If abrirArchivo.ShowDialog() = DialogResult.OK Then
            lecturaArchivo = New IO.StreamReader(abrirArchivo.FileName, True)
            txt_2.Text = lecturaArchivo.ReadToEnd
            contenidoArchivo = lecturaArchivo.ReadToEnd
            Dim arreglo2 As Char()
            arreglo2 = contenidoArchivo.ToCharArray
            'Dim charArray() As Char = contenidoArchivo.ToCharArray

        End If
    End Sub
End Class
