public class Time
{
    public static int CalculateTotalTime(int inicialInstant, int finalInstant) // Método para calcular o tempo total da locação
    {
        if (inicialInstant < finalInstant)
        {
            return finalInstant - inicialInstant;
        }
        else if (inicialInstant == finalInstant)
        {
            return 24;
        }
        else
        {
            return 24 - inicialInstant + finalInstant;
        }
    }
}