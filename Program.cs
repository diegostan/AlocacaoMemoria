// Value Types -> Stack
int ladoA = 5;
int ladoB = 10;
int areaQuadrado = CalcularAreaQuadrado(ref ladoA);

Console.WriteLine(ladoA);
Console.WriteLine(ladoB);
Console.WriteLine(areaQuadrado + "\n");


//Reference Types -> Heap
var ret1 = new Retangulo();
var ret2 = new Retangulo();
ret1.LadoA = 100;
ret1.LadoB = 200;

ret2.LadoA = 300;
ret2.LadoB = 400;

ret1 = ret2; // 
ret2.LadoA = 1 ;

Console.WriteLine(ret1.LadoA);
Console.WriteLine(ret1.LadoB);

Console.WriteLine(ret2.LadoA);
Console.WriteLine(ret2.LadoB);


int CalcularAreaQuadrado(ref int lado)
{
    lado = lado * lado;
    return lado;
}

class Retangulo // 
{
    public int LadoA { get; set; }
    public int LadoB { get; set; }
}