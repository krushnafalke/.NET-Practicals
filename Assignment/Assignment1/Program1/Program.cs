using System;

int package_processed=0, quality_check=0, priority_shipment=0, normal_processing=0;

for(int id= 1001; id<1021; id++)
{
    package_processed++;
    if (id % 4==0)
    {
       Console.WriteLine("Package ID: " + id + " :- Quality Check Required"); 
       quality_check++;
    }
    else if (id % 5 == 0)
    {
        Console.WriteLine("Package ID: " + id + " :- Priority Shipment");
        priority_shipment++;
    }
    else
    {
        Console.WriteLine("Package ID: " + id + " :- Normal Processing");
        normal_processing++;
    }
}

Console.WriteLine("Total package processed:"+ package_processed);
Console.WriteLine("Number of packages required quality check:"+ quality_check);
Console.WriteLine("Number of priority shipment:" + priority_shipment);
Console.WriteLine("NUmber of normal packages:" + normal_processing);
