public class Prices
{
    public Prices(double hourPrice, double dayPrice) // Criação do construtor para acessar os atributos privados em outro(s) arquivo(s)
    {
        HourPrice = hourPrice;
        DayPrice = dayPrice;
    }

    public double HourPrice { get; private set; } // Declaração dos atributos
    public double DayPrice { get; private set; }
    public double Days { get; private set; }
    public double TotalPrice { get; private set; }

    public void CalculatePrice(int totalTime){ // Método para calcular o preço da locação
        if (totalTime > 12) { // Estutura condicional para verificar se o locador ficou mais de 12 horas com o carro
            Console.WriteLine("");

            TotalPrice = DayPrice * 1; // Caso o locador tenha ficado mais de 12 horas com o carro, o programa calcula o preço de acordo com a quantidade de dias
        }
        else {
            TotalPrice = HourPrice * totalTime; // Caso o locador tenha ficado menos de 12 horas com o carro, o programa calcula o preço de acordo com a quantidade de horas
        }
    }

    override public string ToString(){ // Método para retornar o preço da locação
        if (TotalPrice > 100) {
            return $"Preço sem imposto: {TotalPrice.ToString("F2")} \n" +
                $"Preço do imposto: {(TotalPrice * 0.15).ToString("F2")} \n" +
                $"Preço com imposto: {(TotalPrice * 1.15).ToString("F2")}";
        }
        else {
            return $"Preço sem imposto: {TotalPrice.ToString("F2")} \n" +
                $"Preço do imposto: {(TotalPrice * 0.2).ToString("F2")} \n" +
                $"Preço com imposto: {(TotalPrice * 1.2).ToString("F2")}";
        }
    }
}  