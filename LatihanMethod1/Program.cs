static void tambah()
{
    int a = 10, b = 2, c = 0;
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

//kurang
static void kurang()
{
    int a = 10, b = 2, c = 0;
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

//kali
static void kali()
{
    int a = 10, b = 2, c = 0;
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

//bagi
static void bagi()
{
    int a = 10, b = 2, c = 0;
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah();
kurang();
kali();
bagi();