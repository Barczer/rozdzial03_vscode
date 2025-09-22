#region Badanie jednoargumentowych
// int a = 3;
// int b = a++;
// WriteLine($"a ma wartość {a}, b ma wartość {b}");
// int c = 3;
// int d = ++c;
// WriteLine($"c ma wartość {c}, d ma wartość {d}");
// int e = 11;
// int f = 3;
// WriteLine($"e + f = {e + f}");
// WriteLine($"e - f = {e - f}");
// WriteLine($"e * f = {e * f}");
// WriteLine($"e / f = {e / f}");
// WriteLine($"e % f = {e % f}");
// double g = 11.0;
// WriteLine($"g ma wartość {g:N1}, f ma wartość {f}");
// WriteLine($"g / f = {g / f}");
// string? nazwiskoAutora = ReadLine();
// int maksDlugosc = nazwiskoAutora?.Length ?? 30;
// nazwiskoAutora ??= "nieznany";

// bool a = true;
// bool b = false;

// // WriteLine($"a | {a ^ b, 50}");
// WriteLine();

// // Pamiętaj, że funkcja ZrobCos zwraca wartość true

// WriteLine($"a & ZrobCos() = {a & ZrobCos()}");

// WriteLine($"b & ZrobCos() = {b & ZrobCos()}");
int x = 10;

int y = 6;

WriteLine($"Wyrażenie | Dziesiętnie | Binarnie");

WriteLine($"----------------------------------");

WriteLine($"x         |  {x,10} | {x:B8}");

WriteLine($"y         |  {y,10} | {y:B8}");

WriteLine($"x & y     |  {x & y,10} | {x & y:B8}");
WriteLine($"x | y     |  {x | y,10} | {x | y:B8}");

WriteLine($"x ^ y     |  {x ^ y,10} | {x ^ y:B8}");




#endregion

static bool ZrobCos()

{

    WriteLine("Wykonuję ciężką pracę.");

    return true;

}