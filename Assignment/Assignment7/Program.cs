using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        Console.WriteLine("Enter Employee Name : ");
        string  name = Console.ReadLine();

        Console.WriteLine("Enter Employee ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWelcome " + name);

        while (true)
        {
            Console.WriteLine("\n====================");
            Console.WriteLine("ABC MOTORS");
            Console.WriteLine("Vehicle Management System");
            Console.WriteLine("====================");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View All Vehicle");
            Console.WriteLine("3. Search Vehicle");
            Console.WriteLine("4. Update Vehicle Price");
            Console.WriteLine("5. Delete Vehicle");
            Console.WriteLine("6. Calculate Discount");
            Console.WriteLine("7. Show Vehicle Details");
            Console.WriteLine("8. Exit");
            
            Console.WriteLine("Enter Choice from 1 to 8 : ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                      Console.WriteLine("Enter Vehicle ID :");
                      int Id = Convert.ToInt32(Console.ReadLine());

                      Console.WriteLine("Enter vehicle name : ");
                      string Name = Console.ReadLine();

                      Console.WriteLine("Enter vehicle type : ");
                      string Type = Console.ReadLine();

                      Console.WriteLine("Enter brand name : ");
                      string Brand = Console.ReadLine();

                      Console.WriteLine("Enter price : ");
                      double Price = Convert.ToDouble(Console.ReadLine());

                      Console.WriteLine("Enter Manufacturing year : ");
                      double Year = Convert.ToDouble(Console.ReadLine());

                      Vehicle vehicle = new Vehicle(Id, Name, Type, Brand, Price, Year);
                      vehicles.Add(vehicle);

                      Console.WriteLine("Vehicle Added Succesfully");
                      break;

                    case 2:
                       
                            if (vehicles.Count == 0)
                            {
                                Console.WriteLine("No Vehicles Available.");
                                return;
                            }

                            Console.WriteLine("\n-------------------------------------------------------------");
                            Console.WriteLine("ID\tName\tBrand\tType\tPrice\t\tYear");
                            Console.WriteLine("-------------------------------------------------------------");

                            foreach (Vehicle v in vehicles)
                            {
                                Console.WriteLine(v.Vehicle_Id + "\t" +
                                                v.Vehicle_Name + "\t" +
                                                v.Brand + "\t" +
                                                v.Vehicle_Type + "\t" +
                                                v.Price + "\t" +
                                                v.Manufacturing_Year);
                            }

                            Console.WriteLine("-------------------------------------------------------------");
                        
                        break;

                    case 3:
                       Console.WriteLine("-----Search Vehicle------");
                       Console.WriteLine("Enter Vehicle ID : ");
                       int search = Convert.ToInt32(Console.ReadLine());

                       bool found = false;

                       foreach(Vehicle v in vehicles)
                        {
                            if (v.Vehicle_Id == search)
                            {
                                v.Display();
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Vehicle Not Found");
                        }
                        break;

                    case 4:
                        Console.WriteLine("-----Update price-----");

                        Console.WriteLine("Enter Vehicle ID : ");
                        int Uid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter new price : ");
                        double Uprice = Convert.ToInt32(Console.ReadLine());

                        bool Id_found = false;

                        foreach(Vehicle v in vehicles)
                        {
                            if(v.Vehicle_Id == Uid)
                            {
                                v.Price = Uprice;
                                Id_found = true;
                                break;

                            }
                        }
                        if (!Id_found)
                        {
                            Console.WriteLine("Vehicle ID does not found");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter Vehicle ID : ");
                        int D_id = Convert.ToInt32(Console.ReadLine());

                        bool D_found = false;

                        foreach(Vehicle v in vehicles)
                        {
                            if(v.Vehicle_Id == D_id)
                            {
                                vehicles.Remove(v);
                                D_found = true;
                                break;
                            }
                        }
                        if (!D_found)
                        {
                            Console.WriteLine("vehicle not available");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter Vehicle ID : ");
                        int Cal_id = Convert.ToInt32(Console.ReadLine());


                        bool Cal_found = false;

                        foreach(Vehicle v in vehicles)
                        {
                            if(v.Vehicle_Id == Cal_id)
                            {
                                double discount = 0;

                                if (v.Vehicle_Type.Equals("Car", StringComparison.OrdinalIgnoreCase))
                                {
                                    discount = v.Price * 0.10;
                                }
                                else if (v.Vehicle_Type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                                {
                                    discount = v.Price * 0.05;
                                }
                                else if (v.Vehicle_Type.Equals("Truck", StringComparison.OrdinalIgnoreCase))
                                {
                                    discount = v.Price * 0.12;
                                }
                                Cal_found = true;

                                double finalPrice = v.Price - discount;

                                Console.WriteLine("\nVehicle Price : " + v.Price);
                                Console.WriteLine("Discount      : " + discount);
                                Console.WriteLine("Final Price   : " + finalPrice);

                                break;
                            }
                        }
                        break;

                    case 7:
                        Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
                        string type = Console.ReadLine();

                        switch (type.ToLower())
                        {
                            case "car":
                                Console.WriteLine("\nCar is a four wheeler.");
                                Console.WriteLine("Suitable for family.");
                                break;

                            case "bike":
                                Console.WriteLine("\nBike is fuel efficient.");
                                Console.WriteLine("Suitable for city rides.");
                                break;

                            case "truck":
                                Console.WriteLine("\nTruck is used for transportation.");
                                Console.WriteLine("Heavy load vehicle.");
                                break;

                            default:
                                Console.WriteLine("\nInvalid Vehicle Type.");
                                break;
                        }
                        break;

                    case 8:
                        return;

                      
                    default:
                      Console.WriteLine("Invalid Choice ");
                      break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter number only");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       


    }
}
