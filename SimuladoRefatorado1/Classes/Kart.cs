using SimuladoRefatorado1.Enums;

namespace SimuladoRefatorado1.Classes;

public class Kart : Veiculo
{
    public Kart(string nome, DateTime anoFabricacao, int numero) : base(nome, anoFabricacao)
    {
        TipoVeiculo = TipoVeiculoEnum.Kart;
        Numero = numero;
    }

    public int Numero { get; init; }
    public EquipeEnum Equipe { get; }
    public override void EntrarNaPista() =>
        Console.WriteLine(Equipe);

    public override string ToString() =>
        $"{TipoVeiculo} | Nome: {Nome} | AnoFabricacao: {AnoFabricacao} | PontuacaoMedia: {PontuacaoMedia:f2} | Numero: {Numero} | Equipe: {Equipe}";
}
