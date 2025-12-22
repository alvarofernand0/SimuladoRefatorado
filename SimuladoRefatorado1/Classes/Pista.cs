namespace SimuladoRefatorado1.Classes;
public class Pista(string nome)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; } = nome;
}
