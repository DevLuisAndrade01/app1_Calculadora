Public Class Form1
    Dim activo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sumar.Click

        Dim numero1 As Double = Double.Parse(TextBox1.Text)
        Dim numero2 As Double = Double.Parse(TextBox2.Text)

        Dim resultado As Double = numero1 + numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles restar.Click
        Dim numero1 As Double = Double.Parse(TextBox1.Text)
        Dim numero2 As Double = Double.Parse(TextBox2.Text)

        Dim resultado As Double = numero1 - numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles multi.Click
        Dim numero1 As Double = Double.Parse(TextBox1.Text)
        Dim numero2 As Double = Double.Parse(TextBox2.Text)

        Dim resultado As Double = numero1 * numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles divi.Click

        Dim resultado

        Dim numero1 As Double = Double.Parse(TextBox1.Text)
        Dim numero2 As Double = Double.Parse(TextBox2.Text)

        If numero2 > 0 Then
            resultado = numero1 / numero2
        Else
            Resultado = "No se puede"
        End If
        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        activo.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TextBox2
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        activo.Text = activo.Text & "."
    End Sub
End Class
