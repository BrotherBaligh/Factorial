Imports System.Console

Module Program
    Sub Main(args As String())
        Dim num, answer As Integer
        answer = 1

        WriteLine("Enter the number you want a factorial of.")
        num = ReadLine()

        For i = 1 To num
            answer = answer * i
        Next

        WriteLine("The factorial of " & num & " is " & answer & ".")
    End Sub
End Module
