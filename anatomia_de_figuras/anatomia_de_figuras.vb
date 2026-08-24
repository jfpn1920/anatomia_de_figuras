Imports System
Module anatomia_de_figuras
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim tipos(9) As String
        Dim lados(9) As Integer
        Dim vertices(9) As Integer
        Dim angulos(9) As Integer
        Dim perimetros(9) As Double
        Dim areas(9) As Double
        Dim unidades(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------'
        '--|menu_principal_anatomia_de_figuras|--'
        '----------------------------------------'
        Do
            Console.WriteLine("menu principal anatomia de figuras")
            Console.WriteLine("1) Registrar figura")
            Console.WriteLine("2) Editar figura")
            Console.WriteLine("3) Listar figuras")
            Console.WriteLine("4) Buscar figura")
            Console.WriteLine("5) Eliminar figura")
            Console.WriteLine("6) Mostrar anatomia")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------------------'
                '--|registrar_figura|--'
                '----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas figuras.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre de la figura: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Tipo de figura: ")
                        tipos(cantidad) = Console.ReadLine()
                        Select Case tipos(cantidad).ToLower()
                            Case "triangulo"
                                lados(cantidad) = 3
                                vertices(cantidad) = 3
                                angulos(cantidad) = 3
                                Console.Write("Base: ")
                                Dim baseTriangulo As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Altura: ")
                                Dim alturaTriangulo As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Lado 1: ")
                                Dim lado1 As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Lado 2: ")
                                Dim lado2 As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = baseTriangulo + lado1 + lado2
                                areas(cantidad) = (baseTriangulo * alturaTriangulo) / 2
                            Case "cuadrado"
                                lados(cantidad) = 4
                                vertices(cantidad) = 4
                                angulos(cantidad) = 4
                                Console.Write("Lado: ")
                                Dim ladoCuadrado As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = ladoCuadrado * 4
                                areas(cantidad) = ladoCuadrado * ladoCuadrado
                            Case "rectangulo"
                                lados(cantidad) = 4
                                vertices(cantidad) = 4
                                angulos(cantidad) = 4
                                Console.Write("Base: ")
                                Dim baseRectangulo As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Altura: ")
                                Dim alturaRectangulo As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = (baseRectangulo * 2) + (alturaRectangulo * 2)
                                areas(cantidad) = baseRectangulo * alturaRectangulo
                            Case "pentagono"
                                lados(cantidad) = 5
                                vertices(cantidad) = 5
                                angulos(cantidad) = 5
                                Console.Write("Lado: ")
                                Dim ladoPentagono As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Apotema: ")
                                Dim apotemaPentagono As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = ladoPentagono * 5
                                areas(cantidad) = (perimetros(cantidad) * apotemaPentagono) / 2
                            Case "hexagono"
                                lados(cantidad) = 6
                                vertices(cantidad) = 6
                                angulos(cantidad) = 6
                                Console.Write("Lado: ")
                                Dim ladoHexagono As Double = Convert.ToDouble(Console.ReadLine())
                                Console.Write("Apotema: ")
                                Dim apotemaHexagono As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = ladoHexagono * 6
                                areas(cantidad) = (perimetros(cantidad) * apotemaHexagono) / 2
                            Case "circulo"
                                lados(cantidad) = 0
                                vertices(cantidad) = 0
                                angulos(cantidad) = 0
                                Console.Write("Radio: ")
                                Dim radioCirculo As Double = Convert.ToDouble(Console.ReadLine())
                                perimetros(cantidad) = 2 * Math.PI * radioCirculo
                                areas(cantidad) = Math.PI * radioCirculo * radioCirculo
                            Case Else
                                Console.WriteLine("Tipo de figura no reconocido.")
                        End Select
                        Console.Write("Unidad: ")
                        unidades(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Figura registrada correctamente.")
                    End If
                '-------------------'
                '--|editar_figura|--'
                '-------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen figuras registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo: " & tipos(i) & " | Lados: " & lados(i) & " | Vertices: " & vertices(i) & " | Angulos: " & angulos(i) & " | Perimetro: " & perimetros(i) & " | Area: " & areas(i) & " | Unidad: " & unidades(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la figura a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo de figura: ")
                            tipos(posicion) = Console.ReadLine()
                            Select Case tipos(posicion).ToLower()
                                Case "triangulo"
                                    lados(posicion) = 3
                                    vertices(posicion) = 3
                                    angulos(posicion) = 3
                                    Console.Write("Nueva base: ")
                                    Dim baseTriangulo As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nueva altura: ")
                                    Dim alturaTriangulo As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nuevo lado 1: ")
                                    Dim lado1 As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nuevo lado 2: ")
                                    Dim lado2 As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = baseTriangulo + lado1 + lado2
                                    areas(posicion) = (baseTriangulo * alturaTriangulo) / 2
                                Case "cuadrado"
                                    lados(posicion) = 4
                                    vertices(posicion) = 4
                                    angulos(posicion) = 4
                                    Console.Write("Nuevo lado: ")
                                    Dim ladoCuadrado As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = ladoCuadrado * 4
                                    areas(posicion) = ladoCuadrado * ladoCuadrado
                                Case "rectangulo"
                                    lados(posicion) = 4
                                    vertices(posicion) = 4
                                    angulos(posicion) = 4
                                    Console.Write("Nueva base: ")
                                    Dim baseRectangulo As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nueva altura: ")
                                    Dim alturaRectangulo As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = (baseRectangulo * 2) + (alturaRectangulo * 2)
                                    areas(posicion) = baseRectangulo * alturaRectangulo
                                Case "pentagono"
                                    lados(posicion) = 5
                                    vertices(posicion) = 5
                                    angulos(posicion) = 5
                                    Console.Write("Nuevo lado: ")
                                    Dim ladoPentagono As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nuevo apotema: ")
                                    Dim apotemaPentagono As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = ladoPentagono * 5
                                    areas(posicion) = (perimetros(posicion) * apotemaPentagono) / 2
                                Case "hexagono"
                                    lados(posicion) = 6
                                    vertices(posicion) = 6
                                    angulos(posicion) = 6
                                    Console.Write("Nuevo lado: ")
                                    Dim ladoHexagono As Double = Convert.ToDouble(Console.ReadLine())
                                    Console.Write("Nuevo apotema: ")
                                    Dim apotemaHexagono As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = ladoHexagono * 6
                                    areas(posicion) = (perimetros(posicion) * apotemaHexagono) / 2
                                Case "circulo"
                                    lados(posicion) = 0
                                    vertices(posicion) = 0
                                    angulos(posicion) = 0

                                    Console.Write("Nuevo radio: ")
                                    Dim radioCirculo As Double = Convert.ToDouble(Console.ReadLine())
                                    perimetros(posicion) = 2 * Math.PI * radioCirculo
                                    areas(posicion) = Math.PI * radioCirculo * radioCirculo
                                Case Else
                                    Console.WriteLine("Tipo de figura no reconocido.")
                            End Select
                            Console.Write("Nueva unidad: ")
                            unidades(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Figura actualizada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|listar_figuras|--'
                '--------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen figuras registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo: " & tipos(i) & " | Lados: " & lados(i) & " | Vertices: " & vertices(i) & " | Angulos: " & angulos(i) & " | Perimetro: " & perimetros(i) & " | Area: " & areas(i) & " | Unidad: " & unidades(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '-------------------'
                '--|buscar_figura|--'
                '-------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen figuras registradas.")
                    Else
                        Console.Write("Ingrese el ID de la figura a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Tipo: " & tipos(posicion) & " | Lados: " & lados(posicion) & " | Vertices: " & vertices(posicion) & " | Angulos: " & angulos(posicion) & " | Perimetro: " & perimetros(posicion) & " | Area: " & areas(posicion) & " | Unidad: " & unidades(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|eliminar_figura|--'
                '---------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen figuras registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Tipo: " & tipos(i) & " | Lados: " & lados(i) & " | Vertices: " & vertices(i) & " | Angulos: " & angulos(i) & " | Perimetro: " & perimetros(i) & " | Area: " & areas(i) & " | Unidad: " & unidades(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la figura a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                tipos(i) = tipos(i + 1)
                                lados(i) = lados(i + 1)
                                vertices(i) = vertices(i + 1)
                                angulos(i) = angulos(i + 1)
                                perimetros(i) = perimetros(i + 1)
                                areas(i) = areas(i + 1)
                                unidades(i) = unidades(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Figura eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|mostrar_anatomia|--'
                '----------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen figuras registradas.")
                    Else
                        Dim triangulos As Integer = 0
                        Dim cuadrados As Integer = 0
                        Dim rectangulos As Integer = 0
                        Dim pentagonos As Integer = 0
                        Dim hexagonos As Integer = 0
                        Dim circulos As Integer = 0
                        Dim totalLados As Integer = 0
                        Dim totalVertices As Integer = 0
                        Dim totalAngulos As Integer = 0
                        Dim sumaAreas As Double = 0
                        Dim sumaPerimetros As Double = 0
                        For i As Integer = 0 To cantidad - 1
                            totalLados += lados(i)
                            totalVertices += vertices(i)
                            totalAngulos += angulos(i)
                            sumaAreas += areas(i)
                            sumaPerimetros += perimetros(i)
                            Select Case tipos(i).ToLower()
                                Case "triangulo"
                                    triangulos += 1
                                Case "cuadrado"
                                    cuadrados += 1
                                Case "rectangulo"
                                    rectangulos += 1
                                Case "pentagono"
                                    pentagonos += 1
                                Case "hexagono"
                                    hexagonos += 1
                                Case "circulo"
                                    circulos += 1
                            End Select
                        Next
                        Dim promedioArea As Double = sumaAreas / cantidad
                        Dim promedioPerimetro As Double = sumaPerimetros / cantidad
                        Console.WriteLine("Figuras: " & cantidad & " | Triangulos: " & triangulos & " | Cuadrados: " & cuadrados & " | Rectangulos: " & rectangulos & " | Pentagonos: " & pentagonos & " | Hexagonos: " & hexagonos & " | Circulos: " & circulos & " | Lados: " & totalLados & " | Vertices: " & totalVertices & " | Angulos: " & totalAngulos & " | Promedio area: " & promedioArea & " | Promedio perimetro: " & promedioPerimetro)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Anatomia de Figuras.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module