using System;

class Program
{    
    static void Main(string[] args)
    {                
        List<Product> products1 = new List<Product>
        {
            new Product("Hydro-Force, Viper Stone Perfect","203960",36.27,4),
            new Product("Carpet Cleaning, Zone Perfect","121765",51.24,12),
            new Product("Carpet Cleaning, Bio Break W/Citrus Solv","176452",50.81,6)
        };

        List<Product> products2 = new List<Product>
        {
            new Product("Extraction Rinse, Fab-Set","70266",27.32,8),
            new Product("Extraction Rinse, End Zone","121767",40.23,24),
            new Product("Carpet Protector, Maxim Advanced","121818",309.38,5)
        };

        Address address1 = new Address("Street 130 #9-87 tower 37 apartment 201", "Barranquilla", "Atlantico", "Colombia");
        Address address2 = new Address("Aramsco 7074 Convoy Ct San Diego, CA 92111-1017", "San Diego", "California", "USA");

        Customer customer1 = new Customer("Luis Andrade", address1);
        Customer customer2 = new Customer("Jesse Crockett", address2);

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);                    

        DisplayOrder(order1);
        DisplayOrder(order2);
    }    
    private static void DisplayOrder(Order order)
    {    
        double totalCostOfProducts = order.CalculateTotalProductsCost();
        double shippingCost = order.GetShippingCost();
        double totalCostOfOrder = totalCostOfProducts + shippingCost;
        Console.WriteLine("\n\nOrder \nI®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®I");            
        order.DisplayPackingLabel();
        order.DisplayShippingLabel();
        Console.WriteLine($"Total Products Cost: {totalCostOfProducts}");
        Console.WriteLine($"Shipping Cost: {shippingCost}");
        Console.WriteLine($"Total Order Cost: {totalCostOfOrder}");
        Console.WriteLine("I®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®¯®I¼");
    }    
}