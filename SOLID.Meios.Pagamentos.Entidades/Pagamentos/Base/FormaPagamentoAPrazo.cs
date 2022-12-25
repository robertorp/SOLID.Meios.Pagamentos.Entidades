namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

public abstract class FormaPagamentoAPrazo : FormaPagamento
{
    private readonly IList<Parcela> _parcelas = new List<Parcela>();

    public IReadOnlyCollection<Parcela> Parcelas => _parcelas.ToArray();

    public void AdicionarParcela(short numero, DateTime vencimento, decimal valor)
    {
        _parcelas.Add(new Parcela(Id, numero, vencimento, valor));
    }

    public bool TemParcelas()
    {
        return _parcelas.Any();
    }
}