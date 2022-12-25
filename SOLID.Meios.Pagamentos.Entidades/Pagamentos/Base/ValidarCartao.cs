using SOLID.Meios.Pagamentos.Entidades.Pagamentos.Interfaces;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

public static class ValidarCartao
{
    public static void Validar(this ICartao cartao)
    {
        if (string.IsNullOrEmpty(cartao.Bandeira))
            throw new ArgumentNullException("Preciso de bandeira");

        if (string.IsNullOrEmpty(cartao.CodigoAutorizacao))
            throw new ArgumentNullException("Preciso de codigo autorização");
    }
}