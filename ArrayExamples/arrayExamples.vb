'header

Option Strict On
Option Explicit On
Option Compare Text

Module arrayExamples

    Sub Main()

        'multiDimentionalArrays()
        testRandomness()


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
        'Dim students(14, 2) As Single
        'Dim classes() As String = {"Math", "History", "Science"}
        'Dim coolStuff(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        'Dim ThreeDArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}


        'students(5, 2) = 52
        'students(5, 1) = 68
        'students(5, 0) = 100


        'Console.WriteLine()
    End Sub

    Sub testRandomness()
        Dim beanCounter(20) As Integer

        For i = 1 To 10000
            beanCounter(randomNumberBetween(10, 3)) += 1

        Next

        For i = LBound(beanCounter) To UBound(beanCounter)

            Console.WriteLine($"{CStr(i).PadLeft(4)} hit {CStr(beanCounter(i)).PadLeft(4)} times!")
        Next

    End Sub

    Function randomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single

        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function

End Module
