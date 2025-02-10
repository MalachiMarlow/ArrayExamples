'header

Option Strict On
Option Explicit On
Option Compare Text

Module arrayExamples

    Sub Main()

        'arrays are cool
        Dim meats(5) As String
        Dim names() As String = {"Alex", "Noah", "Brandon", "Payden"}
        Dim CarrotCounts = New Integer() {0, 2, 4, 8, 16, 32, 64}

        meats(0) = "Steak"
        meats(3) = "Lobster"
        'meats(6) = "Lamb"

        'For i = 0 To 10
        '    Console.WriteLine(names(i))
        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))
        Next


    End Sub

End Module
