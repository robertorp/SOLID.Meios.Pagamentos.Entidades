using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos;

public class Pix : FormaPagamento
{
    public Pix(string hashTransacao)
    {
        if (string.IsNullOrWhiteSpace(hashTransacao))
            throw new ArgumentNullException("Preciso da Hash de Transação");

        HashTransacao = hashTransacao;
    }

    public string HashTransacao { get; private set; }
}