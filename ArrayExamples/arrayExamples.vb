'header

Option Strict On
Option Explicit On
Option Compare Text

Module arrayExamples

    Sub Main()

        multiDimentionalArrays()


    End Sub

    'Sub simpleArrays()
    '    'arrays are cool
    '    Dim meats(5) As String
    '    Dim names() As String = {"Alex", "Noah", "Brandon", "Payden"}
    '    Dim CarrotCounts = New Integer() {0, 2, 4, 8, 16, 32, 64}

    '    meats(0) = "Steak"
    '    meats(3) = "Lobster"
    '    'meats(6) = "Lamb"

    '    'For i = 0 To 10
    '    '    Console.WriteLine(names(i))
    '    'Next

    '    For i = LBound(names) To UBound(names)
    '        Console.WriteLine(names(i))
    '    Next
    'End Sub

    Sub multiDimentionalArrays()
        Dim students(14, 2) As Single


        students(5, 2) = 52
        students(5, 1) = 68
        students(5, 0) = 100


        Console.WriteLine()
    End Sub

End Module
