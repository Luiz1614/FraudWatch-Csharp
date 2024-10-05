using FraudWatch_CadastroUsuarios.Infraestructure.Data.AppData;

namespace FraudWatch_Usuarios.Infraestructure.Data.Repositories;

public abstract class DAL<T> where T : class
{
    private readonly ApplicationContext _context;

    public void Add(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }

    public void Remove(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public IEnumerable<T> ReadAll()
    {
        return _context.Set<T>().ToList();
    }
    


}
