using SOLID.Meios.Pagamentos.Entidades.Core.Entidades;

namespace SOLID.Meios.Pagamentos.Entidades.Pagamentos.Base;

public abstract class FormaPagamento : Entidade
{
    public DateTime CriadoEm { get; private set; }
    public string CriadoPorUsuario { get; private set; }
    public decimal Valor { get; private set; }
}