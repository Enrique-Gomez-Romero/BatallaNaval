// See https://aka.ms/new-console-template for more information
int op = 0;
do
{
    float num1 = 0, num2 = 0, r = 0;
    Console.WriteLine("Selecciona una opcion \n 1.- Sumar \n 2.- Resta \n 3.-Multiplicacion \n 4.- Division \n 0.-Salir");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Ingresa El primer dijito");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa El segundo dijito");
            num2 = float.Parse(Console.ReadLine());
            r = num1 + num2;
            Console.WriteLine("El resultado es " + r);
            break;
        case 2:
            Console.WriteLine("Ingresa El primer dijito");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa El Numero que desea Restar");
            num2 = float.Parse(Console.ReadLine());
            r = num1 - num2;
            Console.WriteLine("El resultado es " + r);
            break;
        case 3:
            Console.WriteLine("Ingresa El primer dijito");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa El segundo dijito");
            num2 = float.Parse(Console.ReadLine());
            r = num1 * num2;
            Console.WriteLine("El resultado es " + r);
            break;
        case 4:
            Console.WriteLine("Ingresa El primer dijito");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa El segundo dijito");
            num2 = float.Parse(Console.ReadLine());
            r = num1 / num2;
            Console.WriteLine("El resultado es" + r);
            break;
        default:
            break;
    }


} while (op != 0);
