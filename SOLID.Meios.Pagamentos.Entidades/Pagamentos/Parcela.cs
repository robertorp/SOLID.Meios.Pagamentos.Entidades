using SOLID.Meios.Pagamentos.Entidades.Core.Entidades;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos;

public class Parcela : Entidade
{
    public Parcela(Guid formaPagamentoAPrazoId, short numero, DateTime vencimento, decimal valor)
    {
        FormaPagamentoAPrazoId = formaPagamentoAPrazoId;
        Numero = numero;
        Vencimento = vencimento;
        Valor = valor;
    }

    public Guid FormaPagamentoAPrazoId { get; private set; }
    public short Numero { get; private set; }
    public DateTime Vencimento { get; private set; }
    public decimal Valor { get; private set; }
}