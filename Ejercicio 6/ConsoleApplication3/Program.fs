// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b

[<EntryPoint>]
let main argumentos = 
    Console.WriteLine("<---- Operaciones Matematicas ---->")
    Console.WriteLine("Introduzca dos numeros")
    
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    Console.WriteLine("La suma de sus dos numeros es: "+valor3.ToString())

    let num3 = Console.ReadLine()
    let num4 = Console.ReadLine()
    let valor4 = Convert.ToInt32(num3)
    let valor5 = Convert.ToInt32(num4)
    let valor6 = resta valor4 valor5
    Console.WriteLine("La resta de sus dos numeros es: "+valor6.ToString())

    let num5 = Console.ReadLine()
    let num6 = Console.ReadLine()
    let valor7 = Convert.ToInt32(num5)
    let valor8 = Convert.ToInt32(num6)
    let valor9 = multiplicacion valor7 valor8
    Console.WriteLine("La multiplicacion de sus dos numeros es: "+valor9.ToString())

    let num7 = Console.ReadLine()
    let num8 = Console.ReadLine()
    let valor10 = Convert.ToInt32(num7)
    let valor11 = Convert.ToInt32(num8)
    let valor12 = division valor10 valor11
    Console.WriteLine("La division de sus dos numeros es: "+valor12.ToString())

    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
