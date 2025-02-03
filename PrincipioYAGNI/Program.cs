
using System.Diagnostics;
using System.Xml.Linq;

public class ProductService
{

    public void AddProduct(string nane, decimal price)
    {
        Console.WriteLine($"product {nane} added with price {price}.");
    }
    public void DeleteProduct(int productId)
    {
        Console.WriteLine($"product {productId} deleted.");            
    }
}


public class Program
{
    public static void Main()
    {
        var productService = new ProductService();

        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Eliminar producto");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                // Agregar producto
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                decimal price = decimal.Parse(Console.ReadLine());

                productService.AddProduct(name, price);
                break;

            case 2:
                // Eliminar producto
                Console.Write("Ingrese el ID del producto: ");
                int productId = int.Parse(Console.ReadLine());

                productService.DeleteProduct(productId);
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
