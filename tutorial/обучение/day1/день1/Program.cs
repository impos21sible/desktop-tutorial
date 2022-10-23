//n 1)
Console.Write("Введите имя: ");
string? name = Console.ReadLine();                         //string типо строки 

Console.Write("Введите ваш возраст:");
int age = Convert.ToInt32(Console.ReadLine());             // int (age) показывает целое число

Console.Write("Введите ваш рост:");
double height = Convert.ToDouble(Console.ReadLine());      //  double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308

Console.Write("Введите размер вашей заработной платы!:");
decimal salary = Convert.ToDecimal(Console.ReadLine());    // decimal позволяет после целого числа , писать цифры

Console.WriteLine(" Имя: {0}\n Возраст:{1}\n Рост: {2}\n Заработная плата : {3}", name, age, height, salary);

// +
int x = 10;
int z = x + 12;         // Ответ 22

Console.WriteLine(z);

// -
Console.WriteLine(x-12); // Ответ -2

//*
Console.WriteLine(x*2);  // Ответ 20

// (/)
int y = 10;
int u = y / 5; // Ответ 2 

double a = 10;
double b = 3;
double c = a / b; // Ответ 3.3333
Console.WriteLine(c);

double q = 10 / 4; Console.WriteLine(q); // При делении стоит учитывать, что если оба операнда представляют целые числа, то результат также будет округляться до целого числа: 2
// Если хотим дробный ответ нужно //
double o = 10.0 / 4.0; Console.WriteLine(o); // Ответ 2,5

// (%)
double m = 10.0;
double l = m % 4.0; Console.WriteLine(l); // Ответ 2

// ++Операция инкремента
int f = 5;   // Ответ 5
int p = ++f; // Ответ p = 6 , f = 6
Console.WriteLine($"{f} - {p}");

int f2 = 5;
int p2 = f2++; // Ответ p2 = 5; Ответ f2 = 6
Console.WriteLine($"{f2} - {p2}");

// -- Операция декремента или уменьшения значения на единицу.
int x1 = 5;
int y1 = --x1; // Ответ x1 = 4; y1 = 4
Console.WriteLine($"{x1} - {y1}"); // Ответ  4 - 4

// При выполнении сразу нескольких арифметических операций следует учитывать порядок их выполнения. Приоритет операций от наивысшего к низшему:
//Инкремент, декремент
//Умножение, деление, получение остатка
//Сложение, вычитание
//Для изменения порядка следования операций применяются скобки.


// int d1 = (int)(c1---b1*a1); // a=3 b=5 c=39 d1=25
//Console.WriteLine($"a={a1} b={b1} c={c1} d={d1}");
// Сначала идет декремент,вычитание и умножение. 
// Можно поменять порядок и поставить скобки!

int a1 = 3; int b1 = 5; int c1 = 40;

int d = (c1-  (--b1))*a1;
Console.WriteLine($"a = {a1} b={b1} c={c1} d={d}");

//Ассоциативность операторов 
int x2 = 10 / 5 * 2; Console.WriteLine(x2); // Ответ = 4
int x3 = 10 / (5 *2); Console.WriteLine(x3); // Ответ = 1; из-за того что поменяли скобки






