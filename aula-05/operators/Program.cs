//criei o projeto do tipo console com nome de operators
//dotnet new console -o operators
using System.Reflection.Metadata;
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
// Attribuition Operators

      double a = 2;
        int b = 3;
        Console.WriteLine(a);
        a = a + 2;
        Console.WriteLine(a);
        Console.WriteLine(b);
        b += 2; 
        Console.WriteLine(b);
        b *= 5;
          Console.WriteLine(b);
          b/= 3;
            Console.WriteLine(b);
            b++;//Incremento,adiciona 1 ao valor da variável;
            Console.WriteLine(b);
            b-- ;//Decremento remove 1 do valor da variável;
           Console.WriteLine(b);

//Comparation Operators
// == Equal tp
//!= Different to
// > Greatter than
// < Less than
// >= Greatter than or equal to
// <= Less than or equal to
int x = 5;
int y = 2;

bool comparation = x==y;//Comparation operators return a boolean value(True or false);
Console.WriteLine(comparation);
if(comparation == true)
{
    Console.WriteLine("The numbes are equal");
}
else
{
    Console.WriteLine("Different numbers");
}
bool secondComparation = x>=2;
Console.WriteLine(secondComparation);

//Logical Operators
//&& "e"
//  || "ou"
//! "não"

int v1 = 5 ;
int v2 = 5 ;

bool verif = v1 == v2 && v1 > 6 ;
Console.WriteLine(verif);

bool verif2 = v1 == v2 && v2 > 4  ;
Console.WriteLine(verif2);

bool verif3 =  v1 != v2 ;
Console.WriteLine(verif3);

//Other form most intersting to use this operators is in:

bool verif4 = verif1 && verif2;
  
