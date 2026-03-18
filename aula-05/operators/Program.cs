//criei o projeto do tipo console com nome de operators
//dotnet new console -o operators
using System.Runtime.CompilerServices;

double num1,num2,resultsum,resultsub,resultmult,resultdiv;
//Lembrando que o tipo double poderia aceitar números quebrados.
num1 = 5;
num2 = 1;

resultsum = num1 + num2;
resultsub = num1-num2;
resultmult = num1 * num2;
resultdiv = num1/num2;
double module = num1 % num2;
//Modulo é o resto da divisão,ou seja,oque sobra depois de dividir "a" por "b"
Console.WriteLine(resultsum);
Console.WriteLine(resultsub);
Console.WriteLine(resultmult);
Console.WriteLine(resultdiv);
 Console.WriteLine(module);
if (module == 0)
{
  
    Console.WriteLine("Número Par");
}
else
{
    
    Console.WriteLine("Número Ìmpar");
}