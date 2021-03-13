Module Module1

    Sub Main()

        Dim numeros(6) As Integer
        Dim suma As Integer

        For i As Integer = 0 To numeros.Length - 1

            Console.WriteLine("Inserta un numero: ")
            numeros(i) = Console.ReadLine()
            suma += numeros(i)

        Next

        Dim m As Double
        m = suma / numeros.Length

        Console.WriteLine("La media es: " & m)
        Console.ReadLine()

    End Sub

End Module
