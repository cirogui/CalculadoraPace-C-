
using Microsoft.VisualBasic;
using System.Diagnostics;

Console.WriteLine("Selecione uma das opções:");
Console.WriteLine("1 - Calcular Pace");
Console.WriteLine("2 - Calcular tempo decorrido");
Console.WriteLine("3 - Calcular distância");
Console.WriteLine("4 - Sair");
int Opt = int.Parse(Console.ReadLine());


switch (Opt)
{
    case 1:
        Console.WriteLine("Digite a distância em km");
        double dist = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tempo decorrido no seguinte formato (HH:MM:SS):");
        string td = Console.ReadLine();
        int hour = int.Parse(td.Substring(0, 2));
        int minute = int.Parse(td.Substring(3, 2));
        int second = int.Parse(td.Substring(6, 2));
        TimeSpan temp = new TimeSpan(hour, minute, second);
        double vm = Math.Round(dist/temp.TotalHours, 2);
        double pc= temp.TotalMinutes / dist;
        TimeSpan pace = TimeSpan.FromMinutes(pc);
        string pacestring = pace.ToString().Substring(3, 2) + ":" + pace.ToString().Substring(6,2);
        Console.WriteLine("Resultado:");
        Console.WriteLine("Velocidade média: " + vm + "km/h");
        Console.WriteLine("Pace: " + pacestring);
        break;

    case 2:
        Console.WriteLine("Digite a distância em km:");
        double dist2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a velocidade média (km/h) :");
        double vm2 = double.Parse(Console.ReadLine());
        double temp2 = dist2 / vm2;
        TimeSpan tempoDecorrido = TimeSpan.FromHours(temp2);
        Console.WriteLine("Resultado: ");
        Console.WriteLine(tempoDecorrido);
        break;

    case 3:
        Console.WriteLine("Digite o tempo decorrido no seguinte formato (HH:MM:SS): ");
        string td3 = Console.ReadLine();
        int hour3 = int.Parse(td3.Substring(0, 2));
        int minute3 = int.Parse(td3.Substring(3, 2));
        int second3 = int.Parse(td3.Substring(6, 2));
        TimeSpan temp3 = new TimeSpan(hour3, minute3, second3);
        Console.WriteLine("Digite a velocidade média (km/h):");
        double vm3 = double.Parse(Console.ReadLine());
        double distresult = Math.Round(temp3.TotalHours * vm3, 2);
        Console.WriteLine("Resultado: ");
        Console.WriteLine("Distância: " + distresult + "km");
        break;

    case 4:
        break;

    default: 
        Console.WriteLine("Opção inválida");
        break;
}
