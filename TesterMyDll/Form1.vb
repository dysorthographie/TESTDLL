Public Class Form1
    Dim MyDll As TESTDLL.TESTDLL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Object = MyDll.Formulaire1
        f.show
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDll = New TESTDLL.TESTDLL
    End Sub
End Class
