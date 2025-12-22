using SimuladoRefatorado1.Enums;

namespace SimuladoRefatorado1.Classes;

public class Carro : Veiculo
{
    public Carro(string nome, FabricanteEnum fabricante, CategoriaEnum categoria, DateTime anoFabricacao) : base(nome, anoFabricacao)
    {
        TipoVeiculo = TipoVeiculoEnum.Carro;
        Fabricante = fabricante;
        Categoria = categoria;
    }

    public FabricanteEnum Fabricante { get; }
    public CategoriaEnum Categoria { get; }

    public override void EntrarNaPista() =>
        Console.WriteLine(Fabricante);

    public override string ToString() =>
        $"{TipoVeiculo} | Nome: {Nome} | AnoFabricacao: {AnoFabricacao} | PontuacaoMedia: {PontuacaoMedia:f2} | Categoria: {Categoria} | Fabricante: {Fabricante}";
}
