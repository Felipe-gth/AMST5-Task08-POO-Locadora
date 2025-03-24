public class Time
{ 
    public Time(int inicialInstant, int finalInstant) // Criação do construtor para acessar os atributos privados em outro(s) arquivo(s)
    {
        InicialInstant = inicialInstant;
        FinalInstant = finalInstant;
    }   

    public static int InicialInstant { get; private set; } // Declaração dos atributos
    public static int FinalInstant { get; private set; }

    public static int CalculateTotalTime(int inicialInstant, int finalInstant) // Método para calcular o tempo total da locação
    {
        if (InicialInstant < FinalInstant)
        {
            return FinalInstant - InicialInstant;
        }
        else if (InicialInstant == FinalInstant)
        {
            return 24;
        }
        else
        {
            return 24 - InicialInstant + FinalInstant;
        }
    }
}