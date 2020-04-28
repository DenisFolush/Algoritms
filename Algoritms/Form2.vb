Imports System.Math
Public Class Form2
    Public A As Integer
    Public B As Integer
    Public C As Integer
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A = Abs(Val(TextBox1.Text))
        B = Abs(Val(TextBox2.Text))
        Try
            Try
                A = Integer.Parse(TextBox1.Text)
            Catch ex As FormatException
                MessageBox.Show("Неверно введено число")
                Throw ex

            End Try
            Try
                B = Integer.Parse(TextBox1.Text)
            Catch ex As FormatException
                MessageBox.Show("Неверно введено число")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        Do While A <> 0 And B <> 0
            If A > B Then
                A = A Mod B
            Else
                B = B Mod A
            End If


        Loop
        C = A + B
        TextBox3.Text = C.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class