Console.Write("Informe os instantes inicial e final (00 - 23): "); // Solicita ao usuário os instantes inicial e final
string[] instants = Console.ReadLine().Split(' ');
int inicialInstant = int.Parse(instants[0]);
int finalInstant = int.Parse(instants[1]);

int totalTimeime = Time.CalculateTotalTime(inicialInstant, finalInstant); // Criação da variável para armazenar o valor retornado pelo método CalculateTotalTime


Console.Write("Informe o preço da hora: "); // Solicita ao usuário o preço da hora
double hourPrice = double.Parse(Console.ReadLine());

Console.Write("Agora informe o preço do dia: "); // Solicita ao usuário o preço do dia
double dayPrice = double.Parse(Console.ReadLine());

Prices Price = new Prices(hourPrice, dayPrice); // Criação de uma instância (objeto) da classe Prices
Price.CalculatePrice(totalTimeime); // Chamada do método para calcular o preço da locação. time = parametro de entrada do metodo que tem o valor de Time, que é a instancia da classe Time


Console.WriteLine(""); // Pula uma linha 


Console.Write("Informe o modelo do carro: "); // Solicita ao usuário o modelo do carro
string model = Console.ReadLine();
Console.Write("Informe o id do carro: ");// Solicita ao usuário o id do carro
int id = int.Parse(Console.ReadLine());

Car myCar = new Car(id, model); // Criação de uma instância (objeto) da classe Car
myCar.ShowInfo(); // Chamada do método para mostrar as informações do carro

Console.WriteLine(""); // Pula uma linha

Console.WriteLine("O preço a ser cobrado é: "); // Mostra ao usuário o preço a ser cobrado
Console.WriteLine(Price.ToString()); // Chamada do método para retornar o preço da locação