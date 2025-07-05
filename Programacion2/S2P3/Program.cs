Console.Write("Peso en la tierra (kg): ");
double.TryParse(Console.ReadLine(), out double pesoTierra);

const double CONVERSION_PESO_LUNAR = 0.17;

var pesoLuna = pesoTierra * CONVERSION_PESO_LUNAR;

Console.WriteLine("El peso es la Luna es {1:f0} y en la Tierra es {0:0.00}", 
    pesoLuna, pesoTierra);
