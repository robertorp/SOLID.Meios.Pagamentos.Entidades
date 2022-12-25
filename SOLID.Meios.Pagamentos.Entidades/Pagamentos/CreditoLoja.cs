using SOLID.Meios.Pagamentos.Entidades.Dto;
using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos;

public class CreditoLoja : FormaPagamentoAPrazo
{
    public CreditoLoja(IList<ParcelaDto> parcelas)
    {
        if (parcelas.Any() == false)
            throw new ArgumentException("Está forma de pagamento exige parcelas");
    }
}