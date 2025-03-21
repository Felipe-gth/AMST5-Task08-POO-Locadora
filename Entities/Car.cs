public class Car{
    public Car(int id, string model){ // Criação do construtor para acessar os atributos privados em outro(s) arquivo(s)
        Id = id;
        Model = model;
    }    

    public int Id { get; private set; } // Declaração dos atributos
    public string Model { get; private set; }

    public void ShowInfo(){ // Método para mostrar as informações do carro
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Model: {Model}");
    }
}