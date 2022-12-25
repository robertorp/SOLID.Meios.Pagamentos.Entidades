namespace SOLID.Meios.Pagamentos.Entidades.Core.Entidades;

public abstract class Entidade
{
    public Entidade()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}