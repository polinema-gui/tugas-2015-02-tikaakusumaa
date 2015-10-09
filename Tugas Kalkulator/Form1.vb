Public Class Form1
    Dim a As String
    Dim samadengan As String
    Dim inputSatu As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        If (a = "0") Then
            a = "0"
        Else
            a &= "0"
        End If
        TextBox1.Text = a
    End Sub

    Private Sub satu_Click(sender As Object, e As EventArgs) Handles satu.Click
        If (a = "0") Then
            a = "1"
        Else
            a &= "1"
        End If
        TextBox1.Text = a

    End Sub

    Private Sub dua_Click(sender As Object, e As EventArgs) Handles dua.Click
        If (a = "0") Then
            a = "2"
        Else
            a &= "2"
        End If
        TextBox1.Text = a
    End Sub

    Private Sub tiga_Click(sender As Object, e As EventArgs) Handles tiga.Click
        If (a = "0") Then
            a = "3"
        Else
            a &= "3"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub empat_Click(sender As Object, e As EventArgs) Handles empat.Click
        If (a = "0") Then
            a = "4"
        Else
            a &= "4"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub lima_Click(sender As Object, e As EventArgs) Handles lima.Click
        If (a = "0") Then
            a = "5"
        Else
            a &= "5"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub enam_Click(sender As Object, e As EventArgs) Handles enam.Click
        If (a = "0") Then
            a = "6"
        Else
            a &= "6"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub tujuh_Click(sender As Object, e As EventArgs) Handles tujuh.Click
        If (a = "0") Then
            a = "7"
        Else
            a &= "7"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub delapan_Click(sender As Object, e As EventArgs) Handles delapan.Click
        If (a = "0") Then
            a = "8"
        Else
            a &= "8"
        End If
        TextBox1.Text = a
    End Sub


    Private Sub sembilan_Click(sender As Object, e As EventArgs) Handles sembilan.Click
        If (a = "0") Then
            a = "9"
        Else
            a &= "9"
        End If
        TextBox1.Text = a
    End Sub



    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = "0"
        a = Nothing
    End Sub


    Private Sub hasil_Click(sender As Object, e As EventArgs) Handles hasil.Click
        Select Case Me.samadengan
            Case "c"
                TextBox1.Text = Convert.ToString(inputSatu + TextBox1.Text)
            Case "d"
                TextBox1.Text = Convert.ToString(inputSatu + TextBox1.Text)
        End Select
    End Sub


    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Me.samadengan = "c"
        Me.inputSatu = TextBox1.Text
        a = Nothing
    End Sub


    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        Me.samadengan = "d"
        Me.inputSatu = TextBox1.Text
        a = Nothing
    End Sub
End Class
 