// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Random rnd = new Random();

int a_x = rnd.Next(1,10);
int a_y = rnd.Next(1,10);
int a_z = rnd.Next(1,10);

int b_x = rnd.Next(1,10);
int b_y = rnd.Next(1,10);
int b_z = rnd.Next(1,10);

Console.WriteLine("Точка А -" + a_x + ":" + a_y+ ":" + a_z);
Console.WriteLine("Точка B -" + b_x + ":" + b_y+ ":" + b_z);

double rasst = Math.Sqrt((a_x - b_x)*(a_x - b_x)+(a_y - b_y)*(a_y - b_y)+(a_z-b_z)*(a_z-b_z));
Console.WriteLine("Расстояние между точкой А и точкой Б = " + rasst);