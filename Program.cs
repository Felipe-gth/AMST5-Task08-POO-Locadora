using System.Globalization;

// --------------------------------------------------------------------- Declaração de variáveis ----------------------------------------------------------------------

double days = 0;
double totalPrice = 0;
int totalTime = 0;
double preçoTotalHorario = 0;
double simNao = 0;

// ------------------------------------------------------------ Informações a serem digitadas pelo usuário ------------------------------------------------------------

Console.Write("Informe os instantes inicial e final (00 - 23): ");
string[] instants = Console.ReadLine().Split(' ');
int inicialInstant = int.Parse(instants[0]);
int finalInstant = int.Parse(instants[1]);

Console.Write("Informe o preço da hora: ");
double price = double.Parse(Console.ReadLine());

Console.Write("Agora informe o preço do dia: ");
double dayPrice = double.Parse(Console.ReadLine());

Console.Write("Informe o modelo do carro: ");
string model = Console.ReadLine();
Console.Write("Informe o id do carro: ");
int id = int.Parse(Console.ReadLine());

// ------------------------------------------------------ Estrutura de condição para calcular o tempo da locação ------------------------------------------------------

if (inicialInstant < finalInstant){
    totalTime = finalInstant - inicialInstant;

    preçoTotalHorario = totalValue(totalTime, dayPrice, days, price, totalTime, totalPrice, simNao); // Chamada da função para calcular o preço da locação com os dados que o usuário digitou.
}  
else if (inicialInstant == finalInstant){
    totalTime = 13;
    preçoTotalHorario = totalValue(totalTime, dayPrice, days, price, totalTime, totalPrice, simNao);
}                                                                                           
else{
    totalTime = 24 - inicialInstant + finalInstant;

    preçoTotalHorario = totalValue(totalTime, dayPrice, days, price, totalTime, totalPrice, simNao); // Chamada da função para calcular o preço da locação com os dados que o usuário digitou.
}

// ------------------------------------------------ Estrutura de condição para calcular e mostrar o imposto a ser pago ------------------------------------------------

if (preçoTotalHorario > 100){
    Console.WriteLine(""); // Espaçador para formatação no console.

    Console.WriteLine($"O preço sem imposto a ser cobrado sera: R${preçoTotalHorario.ToString("F2")}");    
    Console.WriteLine($"O imposto a ser cobrado será de: R${(preçoTotalHorario * 0.15).ToString("F2")}"); // Mostrar o preço do imposto.
    totalPrice = preçoTotalHorario * 1.15;
    Console.WriteLine($"O preço com imposto ficou: R${totalPrice.ToString("F2")}"); // Mostrar o preço com imposto aplicado.
}
else {
    Console.WriteLine(""); // Espaçador para formatação no console. 

    Console.WriteLine($"O preço sem imposto a ser cobrado sera: R${preçoTotalHorario.ToString("F2")}"); 
    Console.WriteLine($"O imposto a ser cobrado será de: R${(preçoTotalHorario * 0.2).ToString("F2")}"); // Mostrar o preço do imposto.
    totalPrice = preçoTotalHorario * 1.2;
    Console.WriteLine($"O preço com imposto ficou: R${totalPrice.ToString("F2")}"); // Mostrar o preço com imposto aplicado.
}

// ------------------------------------------------------------ Criação de um objeto (instância da classe) ------------------------------------------------------------

Car myCar = new Car(id, model); 
myCar.ShowInfo();

// -------------------------------------------------------- Criação da função para calcular o preço da locação --------------------------------------------------------

static double totalValue(double hour, double a, double b, double c, double d, double total, double yesNo){
    if (hour > 12){
        Console.Write("O locador ficou mais de um dia com o carro (0 = não/1 = sim)? ");
        yesNo = double.Parse(Console.ReadLine());

        if (yesNo == 1){
            Console.Write($"O locador ficou quantos dias com o carro? ");
            b = double.Parse(Console.ReadLine());
            total = a * b;
        }
        else{
            total = a * 1;
        }
    }
    else{
        total = c * d;
    }

    return total;
}