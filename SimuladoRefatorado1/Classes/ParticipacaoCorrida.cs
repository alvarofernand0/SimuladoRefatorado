namespace SimuladoRefatorado1.Classes;
public class ParticipacaoCorrida(Veiculo veiculo, Guid idVeiculo, Pista pista, Guid idPista, Corrida corrida, DateTime dataParticipacao)
{
    public Guid Id { get; } = Guid.NewGuid();
    public Veiculo Veiculo { get; } = veiculo;
    public Guid IdVeiculo { get; } = idVeiculo;
    public Pista Pista { get; } = pista;
    public Guid IdPista { get; } = idPista;
    public Corrida Corrida { get; } = corrida;
    public DateTime DataParticipacao { get; } = dataParticipacao;
    public decimal Pontuacao { get; }
    public TimeSpan TempoParticipacao { get; init; } = TimeSpan.Zero; 

    public void EntrarPista()
    {
        Veiculo.EntrarNaPista();
    }
}
