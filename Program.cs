// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Condicional
var flag = 25;

if(flag > 50) {
    Console.WriteLine("Maior");
} else if(flag == 50) {
    Console.WriteLine("Igual");
} else {
    Console.WriteLine("Não é Maior");
}

if(flag == 50) {
    Console.WriteLine("Valor igual 50");
} else if(flag == 25) {
    Console.WriteLine("Valor igual 25");
} else if(flag == 15) {
    Console.WriteLine("Valor igual 15");
} else {
    Console.WriteLine("Não é igual aos valores");
}

switch (flag) {
    case 50:
        Console.WriteLine("Valor igual 50");
    break;
    case 25:
        Console.WriteLine("Valor igual 25");
    break;
    case 15:
        Console.WriteLine("Valor igual 15");
    break;
    default :
        Console.WriteLine("Não é igual aos valores");
    break;
}

estruturas_csharp.EstruturasDeRepeticao.executar();