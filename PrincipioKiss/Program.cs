
public class RestaurantBill2
{

    public decimal CalculateTotal(decimal[] prices, decimal? tipPercentage = null)
    {
        decimal total = prices.Sum(); // Suma todos los precios directamente
        decimal tip = tipPercentage ?? 10; // Usa el porcentaje de propina proporcionado o 10% por defecto
        return total + total * (tip / 100); // Calcula el total con la propina
    }

}

class Program
{
    static void Main()
    {
        // Crear una instancia de RestaurantBill2
        var billCalculator = new RestaurantBill2();

        // Asignar valores a las variables
        decimal[] prices = { 200, 150, 300 }; // Precios de los platos
        decimal? tipPercentage = 10; // Propina del 15% (puedes cambiar a null para usar 10% por defecto)

        // Llamar al método y obtener el total
        decimal total = billCalculator.CalculateTotal(prices, tipPercentage);

        // Mostrar el resultado
        Console.WriteLine($"Total de la cuenta: {total}");
    }
}