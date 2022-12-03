// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

int EnteringCoordinate(string mes)
{
    Console.Write($"Введите координату {mes}: ");
    int coordinate = Convert.ToInt32(Console.ReadLine());
    return coordinate;
}

void DefineDistance(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
    Console.Write($"Расстояние между двумя точками с координатами X1={X1}, Y1={Y1}, Z1={Z1} и X2={X2}, Y2={Y2}, Z2={Z2} равно {distance:0.00}.");
}

int x1 = EnteringCoordinate("X1");
int y1 = EnteringCoordinate("Y1");
int z1 = EnteringCoordinate("Z1");
int x2 = EnteringCoordinate("X2");
int y2 = EnteringCoordinate("Y2");
int z2 = EnteringCoordinate("Y2");

DefineDistance(x1, y1, z1, x2, y2, z2);