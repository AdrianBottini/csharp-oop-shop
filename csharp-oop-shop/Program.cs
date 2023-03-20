using csharp_oop_shop;

var product1 = new Product("Computer", "gioco qualsiasi per bambino qualsiasi", 224.95);
var product2 = new Product("Videogame", "gioco qualsiasi per bambino qualsiasi", 50.90);
var product3 = new Product("Cuffie", "gioco qualsiasi per bambino qualsiasi", 78.75);
var line = Environment.NewLine;

Console.WriteLine($"Prodotto: {product1.ExtendedName() + line}" + $"Descrizione: {line + product1.Description + line}" + $"Prezzo senza iva: {product1.Price + line} " + $"Prezzo con iva: {product1.TotalPrice()} ");
Console.WriteLine("");
Console.WriteLine($"Prodotto: {product2.ExtendedName() + line}" + $"Descrizione: {line + product2.Description + line}" + $"Prezzo senza iva: {product2.Price + line} " + $"Prezzo con iva: {product2.TotalPrice()} ");
Console.WriteLine("");
Console.WriteLine($"Prodotto: {product3.ExtendedName() + line}" + $"Descrizione: {line + product3.Description + line}" + $"Prezzo senza iva: {product3.Price + line} " + $"Prezzo con iva: {product3.TotalPrice()} ");