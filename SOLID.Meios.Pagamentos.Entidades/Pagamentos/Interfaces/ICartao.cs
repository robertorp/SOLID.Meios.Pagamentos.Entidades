namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos.Interfaces;

public interface ICartao
{
    public string Bandeira { get; set; }
    public string CodigoAutorizacao { get; set; }
}