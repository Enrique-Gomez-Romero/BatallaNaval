// See https://aka.ms/new-console-template for more information
int[] tablero1 = new int[6];
int[] tablero2 = new int[6];
int i;
int opcion,j1b1, j1b2, j1b3,j2b1, j2b2, j2b3,t1,t2,suma1,suma2;

Console.WriteLine("Bienvenido a batalla Naval \n" +
    "Tus Barcos Tienen Valor De 1 Casilla \n" +
    "El Tablero es de 1x6 \n" +
    "Cada Jugador Cuenta con 3 barcos. ");


Console.WriteLine("Ingresa 1 para jugar ");
opcion = int.Parse(Console.ReadLine());
if (opcion == 1)
{
    Console.WriteLine("JUGADOR 1 \n" +
        "Donde quiere colocar su Primer Barco.");
    j1b1 = int.Parse(Console.ReadLine());
    tablero1[j1b1] = 1;
    do
    {
        Console.WriteLine("Donde quiere colocar su Segundo Barco");
         j1b2 = int.Parse(Console.ReadLine());
        if (j1b2 != j1b1)
        {
            tablero1[j1b2] = 1;
        }
        else
        {
            Console.WriteLine("Esa casilla ya esta ocupada");
        }
        
    } while (j1b2 == j1b1);

    do
    {
        Console.WriteLine("Donde quiere colocar su tercer Barco");
        j1b3 = int.Parse(Console.ReadLine());
        if (j1b3 != j1b2 && j1b3 != j1b1)
        {
            tablero1[j1b3] = 1;
        }
        else
        {
            Console.WriteLine("Esa casilla ya esta ocupada");
        }

    } while (j1b3 == j1b1 || j1b3 == j1b2);


    Console.WriteLine("JUGADOR 2 \n" +
    "Donde quiere colocar su Primer Barco.");
    j2b1 = int.Parse(Console.ReadLine());
    tablero2[j2b1] = 1;
    do
    {
        Console.WriteLine("Donde quiere colocar su Segundo Barco");
        j2b2 = int.Parse(Console.ReadLine());
        if (j2b2 != j2b1)
        {
            tablero2[j2b2] = 1;
        }
        else
        {
            Console.WriteLine("Esa casilla ya esta ocupada");
        }

    } while (j2b2 == j2b1);

    do
    {
        Console.WriteLine("Donde quiere colocar su tercer Barco");
        j2b3 = int.Parse(Console.ReadLine());
        if (j2b3 != j2b2 && j2b3 != j2b1)
        {
            tablero2[j2b3] = 1;
        }
        else
        {
            Console.WriteLine("Esa casilla ya esta ocupada");
        }

    } while (j2b3 == j2b1 || j2b3 == j2b2);

}

do
{
    Console.WriteLine("Jugador 1 ataca \n " +
        "selecciona que casilla quieres atacar del 0 al 5 ");
    t1 = int.Parse(Console.ReadLine());
    tablero2[t1] = 0;
    Console.WriteLine("Jugador 2 ataca \n " +
        "selecciona que casilla quieres atacar del 0 al 5 ");
    t2 = int.Parse(Console.ReadLine());
    tablero1[t2] = 0;
    suma1 = tablero1.Sum();
    suma2 = tablero2.Sum();

} while (suma1 != 0 && suma2 != 0);

if(suma1 == 0)
{
    Console.WriteLine("Ganador Jugador 2");
}

if(suma2 == 0)
{
    Console.WriteLine("Ganador Jugador 1");
}






