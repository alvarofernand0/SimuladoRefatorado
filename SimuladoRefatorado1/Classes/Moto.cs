using SimuladoRefatorado1.Enums;
using SimuladoRefatorado1.Interfaces;

namespace SimuladoRefatorado1.Classes;

public class Moto : Veiculo, IExperiencia
{

    public Moto(string nome, DateTime anoFabricacao, int cilindrada, Piloto piloto) : base(nome, anoFabricacao)
    {
        TipoVeiculo = TipoVeiculoEnum.Moto;
        Cilindrada = cilindrada;
        Piloto = piloto;
    }

    public int Cilindrada { get; }
    public Piloto Piloto { get; }
    public TimeSpan TempoMinimoExperiencia { get; } = TimeSpan.Zero;

    public bool ExperienciaMinima(TimeSpan tempoExperiencia)
    {
        if(DateTime.Today - Piloto.DataInicioCarreira >= TempoMinimoExperiencia)
            return true;
        return false;
    }
    public override void EntrarNaPista()
    {
        string pilotoApto = ExperienciaMinima(TempoMinimoExperiencia) ?
        $"{Piloto.Nome} Apto para pilotar este veiculo {Nome}" :
        $"{Piloto.Nome} NÃO apto para pilotar este veiculo {Nome}";
        Console.WriteLine(pilotoApto);
    }

    public override string ToString() =>
        $"{TipoVeiculo} | Nome: {Nome} | AnoFabricacao: {AnoFabricacao} | PontuacaoMedia: {PontuacaoMedia:f2} | Piloto: {EntrarNaPista} | Cilindrada: {Cilindrada}cc";

}
