using SimuladoRefatorado1.Enums;

namespace SimuladoRefatorado1.Classes;
public abstract class Veiculo(string nome, DateTime anoFabricacao)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; init; } = nome;
    public int AnoFabricacao { get; init; } = anoFabricacao.Year;
    public decimal PontuacaoMedia { get; private protected set; }
    public TipoVeiculoEnum TipoVeiculo { get; private protected set;}

    public abstract void EntrarNaPista();

    public abstract override string ToString();
}

