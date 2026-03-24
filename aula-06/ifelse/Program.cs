int age = 15;

if (age <= 0)
{
     Console.WriteLine("Idade invalida");
}
else if(age < 18 ){
     Console.WriteLine("Acesso negado");
}else
{
    Console.WriteLine("Acesso permitido");
}

//Estrutura quando combinada com else if deve seguir sempre a seguinte estruturaa:
//if
//else if
// else (Deve sempre ser a última estrutura)


int idade = 18;
bool permissaodospais = false;

if (idade <= 0)
{
    Console.WriteLine("Idade inválida");
}else if (idade >= 18)
{
    Console.WriteLine("Acesso permitido pois você é maior de idade");
}
else
{
    if(!permissaodospais )
    {
        Console.WriteLine("Acesso negado pois voce é menor de idade");
    }
    else
    {
        Console.WriteLine("Acesso permitido");
    }
}