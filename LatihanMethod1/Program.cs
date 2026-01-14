static void tambah (int a, int b)
{
    int c = 0;
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

//kurang
static void kurang(int a, int b)
{
    int c = 0;
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

//kali
static void kali(int a, int b)
{
    int c = 0;
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

//bagi
static void bagi(int a, int b)
{
    int c = 0;
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(10,2);
kurang(15,5);
kali(5, 5);
bagi(50,2);