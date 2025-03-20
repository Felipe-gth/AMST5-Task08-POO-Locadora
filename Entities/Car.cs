public class Car{

// -------------------- Criação do construtor para ter acesso aos valores --------------------

        public Car(int id, string model){
            Id = id;
            Model = model;
        } 

// --------------------------------- Declaração dos atributos --------------------------------

        public int Id { get; private set; }
        public string Model { get; private set; }

// ---------------------- Criação do método para mostrar as informações ----------------------

        public void ShowInfo(){
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Model: {Model}");
        }
}