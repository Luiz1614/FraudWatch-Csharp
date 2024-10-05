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

    public void AddDentista(DentistaEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void DeleteDentistaById(int id)
    {
        _context.Remove(GetDentistaById(id));
        _context.SaveChanges();
    }

    public IEnumerable<DentistaEntity> GetAllDentistas()
    {
        return _context.Set<DentistaEntity>().ToList();
    }

    public DentistaEntity GetDentistaByCro(string cro)
    {
        return _context.Dentistas.SingleOrDefault(d => d.CRO == cro);
    }

    public DentistaEntity GetDentistaById(int id)
    {
        return _context.Set<DentistaEntity>().Find(id);
    }

    public void UpdateDentista(DentistaEntity entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}
