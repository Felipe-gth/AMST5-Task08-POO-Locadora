public class Car{
        public Car(int id, string model){
            Id = id;
            Model = model;
        } 
        public int Id { get; private set; }
        public string Model { get; private set; }

        public void ShowInfo(){
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Model: {Model}");
        }
}