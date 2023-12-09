int a = 5;
int b = 6;

Add(a, b);
Add(10, 100);

Multiply(a, b);
Multiply(10, 100);

Divison(a,b);
Divison(10, 100);

Substract(a, b);
Substract(10, 100);



static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}


static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Divison(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}