Module Module1
    Sub Main()

        Console.WriteLine("Hola mundo")
        'Tarea realizada en visual studio 2022

        Console.WriteLine("-------Menú----")
        Console.WriteLine("Elija una opción")
        Console.WriteLine("1. Determinar si una persona es menor o mayor de edad")
        Console.WriteLine("2. Determinar si un número es positivo o negativo")
        Console.WriteLine("3. Calcular total de una compra")
        Console.WriteLine("4. Calcular la suma de n números")
        Console.WriteLine("5. Tabla de multiplicar")
        Console.WriteLine("-------------------------")

        Dim continuar As String
        Console.WriteLine("-------------------------")
        Console.WriteLine("Desea continuar 'si/no' ")
        continuar = Console.ReadLine()

        While (continuar = "si" Or continuar = "SI")
            Dim opcion As Integer
            Console.WriteLine("Ingrese una opcion")
            opcion = Integer.Parse(Console.ReadLine())
            Console.WriteLine("-------------------------")
            If (opcion > 0 And opcion <= 5) Then
                Select Case opcion
                    Case 1
                        esMayorMenorEdad()
                    Case 2
                        encontrarPositivoNegativo()
                    Case 3
                        calcularCompra()
                    Case 4
                        calcularSumaNumeros()
                    Case 5
                        calcularTablaMultiplicar()
                End Select
            Else
                Console.WriteLine("Ingrese una opción válida")
            End If

            Console.WriteLine("-------------------------")
            Console.WriteLine("Desea continuar 'si/no' ")
            continuar = Console.ReadLine()
        End While
        Console.WriteLine("Cerrando programa")
        Console.ReadLine()
    End Sub


    'Ejercicio1
    'Escriba un programa que solicite la edad de una persona y determine si es menor o
    'mayor de edad, deberá mostrar un mensaje. 
    Sub esMayorMenorEdad()
        Console.WriteLine("Determinar si una persona es menor o mayor de edad")
        Console.WriteLine("Ingrese su edad")
        Dim age As Integer = Integer.Parse(Console.ReadLine())
        If (age >= 18) Then
            Console.WriteLine("Usted es MAYOR de edad")
        Else
            Console.WriteLine("Usted es MENOR de edad")
        End If
    End Sub

    'Ejercicio 2
    'Escriba un programa que determine si un número es positivo o negativo. 
    Sub encontrarPositivoNegativo()
        Dim number As Double
        Console.WriteLine("Determinar si un número es positivo o negativo")
        Console.WriteLine("Ingrese un número")
        number = Double.Parse(Console.ReadLine())
        If (number > 0) Then
            Console.WriteLine("El numero {0} es POSITIVO", number)
        Else
            Console.WriteLine("El numero {0} es NEGATIVO", number)
        End If
    End Sub


    'Ejercicio 3
    'Elabore un programa que de acuerdo con un monto de compra muestre el descuento
    'aplicado y total a pagar. 

    'Monto compra                   Descuento
    '$ 1000.00                      30%
    '$ 500.00                       20%
    '$ 250.00                       10%
    'Otra Cantidad                  5%

    Sub calcularCompra()
        Dim cantidad As Integer
        Dim precio As Double
        Dim nombreProducto As String
        Dim descuento As Double
        Dim subTotal As Double
        Dim totalAPagar As Double
        'Elabore un programa que de acuerdo con un monto de compra muestre el descuento
        'aplicado y total a pagar. 
        Console.WriteLine("Calcular el monto de la compra y su respectivo descuento")
        Console.WriteLine("Ingrese la cantidad del producto")
        cantidad = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Ingrese el precio")
        precio = Double.Parse(Console.ReadLine())
        Console.WriteLine("Ingrese nombre del producto")
        nombreProducto = Console.ReadLine()

        subTotal = cantidad * precio
        If (subTotal = 1000) Then
            descuento = subTotal * (30 / 100)
            totalAPagar = subTotal - descuento
            Console.WriteLine("----------------------------------")
            Console.WriteLine("Nombre producto: {0}", nombreProducto)
            Console.WriteLine("Descuento: ${0}", descuento)
            Console.WriteLine("Total a pagar: ${0}", totalAPagar)
        ElseIf (subTotal = 500) Then
            descuento = subTotal * (20 / 100)
            totalAPagar = subTotal - descuento
            Console.WriteLine("----------------------------------")
            Console.WriteLine("Nombre producto: {0}", nombreProducto)
            Console.WriteLine("Descuento: ${0}", descuento)
            Console.WriteLine("Total a pagar: ${0}", totalAPagar)
        ElseIf (subTotal = 250) Then
            descuento = subTotal * (10 / 100)
            totalAPagar = subTotal - descuento
            Console.WriteLine("----------------------------------")
            Console.WriteLine("Nombre producto: {0}", nombreProducto)
            Console.WriteLine("Descuento: ${0}", descuento)
            Console.WriteLine("Total a pagar: ${0}", totalAPagar)
        Else
            descuento = subTotal * (5 / 100)
            totalAPagar = subTotal - descuento
            Console.WriteLine("----------------------------------")
            Console.WriteLine("Nombre producto: {0}", nombreProducto)
            Console.WriteLine("Descuento: ${0}", descuento)
            Console.WriteLine("Total a pagar: ${0}", totalAPagar)
        End If
    End Sub



    'Ejercicio 4
    'Calcule la suma de los números naturales desde 1 hasta n. Ejemplo: 1+2+3+4+5=15
    Sub calcularSumaNumeros()
        Dim suma As Double = 0
        Dim numero As Double
        Console.WriteLine("''Calcular la suma de x números''")
        Console.WriteLine("Ingrese el número hasta el que desea sumar")
        numero = Double.Parse(Console.ReadLine())
        Dim index As Integer
        For index = 1 To numero Step 1
            suma = suma + index
        Next
        Console.WriteLine("El total de la suma es: {0}", suma)
    End Sub

    'Ejercicio 5
    'Escriba un programa que escriba la tabla de multiplicar de x número ingresado por el usuario. 
    Sub calcularTablaMultiplicar()
        Dim numeroTabla As Integer
        Console.WriteLine("Número de la tabla de multiplicar")
        numeroTabla = Integer.Parse(Console.ReadLine())
        Dim index As Integer
        For index = 1 To 10 Step 1
            Console.WriteLine("{0} * {1} = {2} ", numeroTabla, index, numeroTabla * index)
        Next

    End Sub

End Module

