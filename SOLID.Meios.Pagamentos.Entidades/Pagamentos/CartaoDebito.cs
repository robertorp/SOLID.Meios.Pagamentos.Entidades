using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;
using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Interfaces;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos;

public class CartaoDebito : FormaPagamento, ICartao
{
    public CartaoDebito(string bandeira, string codigoAutorizacao)
    {
        this.Validar();

        Bandeira = bandeira;
        CodigoAutorizacao = codigoAutorizacao;
    }

    public string Bandeira { get; set; }
    public string CodigoAutorizacao { get; set; }
}