Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a >= b And a >= c Then
            GoTo a_mayor
        Else
            If b >= a And b >= c Then
                GoTo b_mayor
            Else
                If c >= a And c >= b Then
                    GoTo c_mayor
                End If
            End If
        End If

menor:
        If a <= b And a <= c Then
            GoTo a_menor
        Else
            If b <= a And b <= c Then
                GoTo b_menor
            Else
                If c <= a And c <= b Then
                    GoTo c_menor
                End If
            End If
        End If
        GoTo final

medio:
        If a >= b And a <= c Or a <= b And a >= c Then
            GoTo a_medio
        Else
            If b >= a And b <= c Or b <= a And b >= c Then
                GoTo b_medio
            Else
                If c >= a And c <= b Or c <= a And c >= b Then
                    GoTo c_medio
                End If
            End If
        End If
        GoTo final

a_mayor:
        TextBox6.Text = a.ToString()
        GoTo menor

b_mayor:
        TextBox6.Text = b.ToString()
        GoTo menor

c_mayor:
        TextBox6.Text = c.ToString()
        GoTo menor

a_menor:
        TextBox4.Text = a.ToString()
        GoTo medio

b_menor:
        TextBox4.Text = b.ToString()
        GoTo medio

c_menor:
        TextBox4.Text = c.ToString()
        GoTo medio

a_medio:
        TextBox5.Text = a.ToString()
        GoTo final

b_medio:
        TextBox5.Text = b.ToString()
        GoTo final

c_medio:
        TextBox5.Text = c.ToString()
        GoTo final


final:
    End Sub
End Class
