using FraudWatch.Domain.Entities;
using FraudWatch_CadastroUsuarios.Infraestructure.Data.AppData;

namespace FraudWatch.Infraestructure.Data.Repositories;

public class DentistaRepository : IDentistaRepository
{
    private readonly ApplicationContext _context;

    public DentistaRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IEnumerable<DentistaEntity> GetAllDentistas()
    {
        return _context.Set<DentistaEntity>().ToList();
    }

    public DentistaEntity GetDentistaById(int id)
    {
        return _context.Set<DentistaEntity>().Find(id);
    }

    public DentistaEntity GetDentistaByCro(string cro)
    {
        return _context.Set<DentistaEntity>().FirstOrDefault(d => d.CRO == cro);
    }

    public void AddDentista(DentistaEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void UpdateDentista(DentistaEntity entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }

    public void DeleteDentistaById(int id)
    {
        var entity = _context.Set<DentistaEntity>().Find(id);
        if (entity != null)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
