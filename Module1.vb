Module Module1

    Sub Main()
        Console.WriteLine("what is your name")
        Dim username As String = Console.ReadLine()

        Console.WriteLine("enter your password")
        Dim password As String = Console.ReadLine()

        Console.WriteLine("what is your favourite colour")
        Dim colour As String = Console.ReadLine()

        Console.WriteLine("what is  favourite hobby?")
        Dim hobby As String = Console.ReadLine()

        Console.WriteLine("what is you favourite food?")
        Dim food As String = Console.ReadLine()

        Console.WriteLine("what are your favourite flowers")
        Dim flowers As String = Console.ReadLine()

        If username = "Junior" Then
            Console.WriteLine("welcome Junior")

        End If
        If password = "Angela2004" Then
            Console.WriteLine("you've entered the correct password")
        End If
        If colour = "black" Then
            Console.WriteLine("you have a great taste!")
        End If
        If hobby = "sleeping" Then
            Console.WriteLine("damn boy you are too lazy")
        End If
        If food = "pizza" Then
            Console.WriteLine("eat healthy")
        End If
        If flowers = "Daisies" Then
            Console.WriteLine("they sell good")
        End If
        Console.ReadLine()
        practise()
        Console.ReadLine()


    End Sub

    Private Sub practise()
        Console.WriteLine("What is your favourite song?")
        Dim song As String = Console.ReadLine()

        Console.WriteLine("what is favourite movie")
        Dim movie As String = Console.ReadLine()

        If song = "goodness" Then
            Console.WriteLine("Is it written By CeCe?")
        End If
        If movie = "queen of south" Then
            Console.WriteLine("it is a series not a movie")

        End If
        Console.ReadLine
    End Sub





End Module
