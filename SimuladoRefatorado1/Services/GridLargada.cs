using SimuladoRefatorado1.Classes;

namespace SimuladoRefatorado1.Services;
public class GridLargada
{
    public readonly List<ParticipacaoCorrida> participacoes = new();

    public void AdicionarParticipacao(ParticipacaoCorrida participacao)
    {
        participacoes.Add(participacao);
    }

    public void RemoverParticipacao(Guid idParticipacao)
    {
        var buscarParticipacaoId = participacoes.FirstOrDefault(p => p.Id == idParticipacao);
        participacoes.Remove(buscarParticipacaoId);
    }

    public void ListarParticipacoes(ParticipacaoCorrida participacao)
    {
        var listaDeParticipantes = participacoes.OrderByDescending(p => p.Veiculo.AnoFabricacao).ToList();
        listaDeParticipantes.ForEach(p => p.ToString());
    }
}
