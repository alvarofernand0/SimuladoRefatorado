namespace SimuladoRefatorado1.Classes;
public class Corrida(string nome, DateTime dataCorrida)
{
    public string Nome { get; } = nome;
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime DataCorrida { get; } = dataCorrida;
}
