using System;

int total_power=0, maintenance = 0, normal = 0, efficient = 0;

for(int s_light=1; s_light<=30; s_light++)
{
    int power = 80 + (s_light*5);
    total_power = total_power + power;
    
    Console.Write("Street Light " + s_light + " - Power: " + power + " W -> ");

    if (power > 180)
    {
        Console.WriteLine( " Maintanance Required");
        maintenance++;

    }
    else if(power>=140 && power <= 180)
    {
        Console.WriteLine(" Normal Operation");
        normal++;

    }
    else
    {
        Console.WriteLine(" Energy Efficient");
        efficient++;

    }
}
double averagePower = (double)total_power / 30;


Console.WriteLine("Total Power Consumed: " + total_power + " W");
Console.WriteLine("Average Power Consumption: " + averagePower + " W");
Console.WriteLine("Maintenance Required Lights: " + maintenance);
Console.WriteLine("Normal Operation Lights: " + normal);
Console.WriteLine("Energy Efficient Lights: " + efficient);