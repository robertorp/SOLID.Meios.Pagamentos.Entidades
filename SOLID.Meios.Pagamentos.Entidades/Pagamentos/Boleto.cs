using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos;

public class Boleto : FormaPagamentoAPrazo
{

    public Boleto(string banco)
    {
        if (string.IsNullOrWhiteSpace(banco))
            throw new ArgumentNullException("Preciso de banco");

        Banco = banco;
    }
    public string Banco { get; private set; }
}