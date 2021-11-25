// See https://aka.ms/new-console-template for more information
using System.Collections;
int opcion = 0;
int dinero = 0;
int r = 0;
do
{
    Console.WriteLine("Bienvenido Al Gas \n 1.- Para hacer una venta de Gas \n 2.- Checar ventas \n 3.- Para Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1: 
            Console.WriteLine("Cunatos Litros Quiere \n el litro tiene un costo de $ 13");
            int l = int.Parse(Console.ReadLine());
            dinero = vender(l);
            r = r + dinero;
            break;

        case 2:
            Console.WriteLine("Dinero de hoy "+r);
            break;

    }

} while( opcion != 3);



static int vender (int litro)
{
    ArrayList tanque = new ArrayList();
    tanque.Add(litro);
    int r = litro * 13;
    var v =+ r;
    foreach(int i in tanque)
    {
        Console.WriteLine("As vendido litro: "+i+"con precio de "+r);
    }
    return v;
}



