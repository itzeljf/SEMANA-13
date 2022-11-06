// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using T12_ITJF_1146422;

Console.WriteLine("EQUIPOS");
int CantidadDeEQUIPOS = 8;
EQUIPO[] equipos = new EQUIPO[CantidadDeEQUIPOS];
Random rand = new Random();

int seleccionarGanador(int i, int j)
{
int x = rand.Next(0, 100);
if (x > 50)
{
return j;
}

return i;
}

{
    int i = 0;
    int j = CantidadDeEQUIPOS - 1;
    Console.WriteLine("============================================");

    while (i < CantidadDeEQUIPOS / 2)
    {
        Console.WriteLine(equipos[i].nombre + "vs" + equipos[j].nombre);

        int x = seleccionarGanador(i, j);

        EQUIPO aux = equipos[i];
        equipos[i] = equipos[x];
        equipos[x] = aux;

        Console.WriteLine("Gano: " + equipos[i].nombre);

        i++;
        j++;

        Console.WriteLine("-----------------------------------------");
    }
}

void sortearEquipos(Random random)
{

for (int i = 0; i < CantidadDeEQUIPOS; i++)
    {
        int x = random.Next(0, CantidadDeEQUIPOS);
        EQUIPO aux = equipos[i];
        equipos[i] = equipos[x];
        equipos[x] = aux;
    } 
        
}


{
    for (int i= 0; i < equipos.Length; i++)
    {
        equipos[i] = new EQUIPO();
        equipos[i].nombre = "Equipo" + i;
    }
}
