namespace SimuladoRefatorado1.Classes;
public class Piloto(string nome, DateTime dataInicioCarreira)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; init;} = nome;
    public DateTime DataInicioCarreira { get; init; } = dataInicioCarreira;
}
