Module Module1

    Sub Main()
        Dim saludo As String = "Hola, Ing. Este es nuestro programa"
        Dim nombre_1, nombre_2, nombre_3, nombre_4, apellido_1, apellido_2, apellido_3, apellido_4 As String
        Dim departamento As String = "San Salvador"
        Dim sexo As String = "Masculino"
        Dim CarreraLic As String = "Licenciatura en Computacion"
        Dim CarreraTec As String = "Tecnico en Computacion"
        Dim edad_1, edad_2, Edad_3, edad_4 As Byte
        Dim frase As String = "Al que madruga Dios le ayuda"
        Dim nomc_1, nomc_2, nomc_3, nomc_4 As String
        nombre_1 = "Francisco Salvador"
        apellido_1 = "Moreno Garcia"
        edad_1 = 33
        nombre_2 = "Javier Alexander"
        apellido_2 = "Naranjo Moz"
        edad_2 = 20
        nombre_3 = "Hugo Nelson"
        apellido_3 = "Ramirez Perez"
        Edad_3 = 23
        nombre_4 = "Francisco Andres"
        apellido_4 = "Garcia Mena"
        edad_4 = 21
        Dim frasecam As String
        frasecam = Replace(frase, "madruga", "se levanta temprano")
        Dim prom As Single
        prom = (edad_1 + edad_2 + Edad_3 + edad_4) / 4
        nomc_1 = nombre_1 & " " & apellido_1
        nomc_2 = nombre_2 & " " & apellido_2
        nomc_3 = nombre_3 & " " & apellido_3
        nomc_4 = nombre_4 & " " & apellido_4
        Dim edads_1, edads_2, edads_3, edads_4 As Single
        edads_1 = edad_1 + 2
        edads_2 = edad_2 + 0.5
        edads_3 = Edad_3 + 0.5
        edads_4 = edad_4 + 0.5
        Console.WriteLine("Saludo: " & saludo)
        Console.WriteLine("")
        Console.WriteLine("Alumno 1")
        Console.WriteLine("Nombres: " & nombre_1)
        Console.WriteLine("Apellidos: " & apellido_1)
        Console.WriteLine("Sexo: " & sexo)
        Console.WriteLine("Edad: " & edad_1)
        Console.WriteLine("Departamento: " & departamento)
        Console.WriteLine("Carrera: " & CarreraLic)
        Console.WriteLine("")
        Console.WriteLine("Alumno 2")
        Console.WriteLine("Nombres: " & nombre_2)
        Console.WriteLine("Apellidos: " & apellido_2)
        Console.WriteLine("Sexo: " & sexo)
        Console.WriteLine("Edad: " & edad_2)
        Console.WriteLine("Departamento: " & departamento)
        Console.WriteLine("Carrera: " & CarreraTec)
        Console.WriteLine("")
        Console.WriteLine("Alumno 3")
        Console.WriteLine("Nombres: " & nombre_3)
        Console.WriteLine("Apellidos: " & apellido_3)
        Console.WriteLine("Sexo: " & sexo)
        Console.WriteLine("Edad: " & Edad_3)
        Console.WriteLine("Departamento: " & departamento)
        Console.WriteLine("Carrera: " & CarreraTec)
        Console.WriteLine("")
        Console.WriteLine("Alumno 4")
        Console.WriteLine("Nombres: " & nombre_4)
        Console.WriteLine("Apellidos: " & apellido_4)
        Console.WriteLine("Sexo: " & sexo)
        Console.WriteLine("Edad: " & edad_4)
        Console.WriteLine("Departamento: " & departamento)
        Console.WriteLine("Carrera: " & CarreraTec)
        Console.WriteLine("")
        Console.WriteLine("Frase Original " & frase)
        Console.WriteLine("Frase cambiada " & frasecam)
        Console.WriteLine("")
        Console.WriteLine("El promedio de las edades es: " & prom)
        Console.WriteLine("")
        Console.WriteLine("Nombre completo del 1er alumno:" & nomc_1)
        Console.WriteLine("Nombre completo del 2do alumno:" & nomc_2)
        Console.WriteLine("Nombre completo del 3er alumno:" & nomc_3)
        Console.WriteLine("Nombre completo del 4er alumno:" & nomc_4)
        Console.WriteLine("")
        Console.WriteLine("La edad que tendra el alumno 1 al graduarse sera: " & edads_1)
        Console.WriteLine("La edad que tendra el alumno 2 al graduarse sera: " & edads_2)
        Console.WriteLine("La edad que tendra el alumno 3 al graduarse sera: " & edads_3)
        Console.WriteLine("La edad que tendra el alumno 4 al graduarse sera: " & edads_4)
        Console.ReadLine()

    End Sub

End Module
