public class Time
{ 
    public Time(int inicialInstant, int finalInstant) // Criação do construtor para acessar os atributos privados em outro(s) arquivo(s)
    {
        InicialInstant = inicialInstant;
        FinalInstant = finalInstant;
    }   

    public int InicialInstant { get; private set; } // Declaração dos atributos
    public int FinalInstant { get; private set; }
    public int TotalTime { get; set; }

    public int CalculateTotalTime() // Método para calcular o tempo total da locação
    {
        if (InicialInstant < FinalInstant)
        {
            return TotalTime = FinalInstant - InicialInstant;
        }
        else if (InicialInstant == FinalInstant)
        {
            return TotalTime = 13;
        }
        else
        {
            return TotalTime = 24 - InicialInstant + FinalInstant;
        }
    }
}