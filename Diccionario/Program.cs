Dictionary<string, object> datosInventario = new Dictionary<string, object>
{
    { "Nombre", "Laptop HP Envy" },
    { "Precio", 850.99m },
    { "Cantidad", 15 }
};

var columns = string.Join(", ", datosInventario.Keys);
var placeholders = "@" + string.Join(", @", datosInventario.Keys);

string sql = $"INSERT INTO productos ({columns}) VALUES ({placeholders})";

Console.WriteLine($"La cadena sql del INSERT es: {sql}");


Dictionary<string, object> datosActualizar = new Dictionary<string, object>
{
    { "Nombre", "Laptop HP Envy x360" },
    { "Precio", 799.99m },
    { "Cantidad", 10 }
};

var asignaciones = string.Join(", ", datosActualizar.Keys.Select(k => $"{k} = @{k}"));


string sqlUpdate = $"UPDATE productos SET {asignaciones} WHERE Id = @Id";

Console.WriteLine($"La cadena sql del UPDATE es: {sqlUpdate}");


Console.WriteLine("Parámetros del UPDATE:");
foreach (var par in datosActualizar)
{
    Console.WriteLine($"  @{par.Key} = {par.Value}");
}
Console.WriteLine("  @Id = 1");