///SWITCH CASE 

Console.WriteLine("digite um número de 1 a 7 para saber qual o dia correspondente : ");
string input = Console.ReadLine();

switch (input)
{
    case "1":
    Console.WriteLine("Domingo");
    break;
    case "2":
    Console.WriteLine("Segunda");
    break;

case "3":
    Console.WriteLine("Terça");
    break;
    case "4":
    Console.WriteLine("Quarta");
    break;
    case "5":
    Console.WriteLine("Quinta");
    break;
    case "6":
    Console.WriteLine("Sexta");
    break;
    case "2":
    Console.WriteLine("Sabado");
    break;
    default:
    Console.WriteLine("Digite um número valido de 1 a 7");
    break;

}
