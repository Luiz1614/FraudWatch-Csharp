using FraudWatch.Domain.Entities;
using FraudWatch_CadastroUsuarios.Infraestructure.Data.AppData;

namespace FraudWatch.Infraestructure.Data.Repositories;

public class AnalistaRepository : IAnalistaRepository
{
    private readonly ApplicationContext _context;

    public AnalistaRepository(ApplicationContext context)
    {
        _context=context;
    }

    public void AddAnalista(AnalistaEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void DeleteAnalistaById(int id)
    {
        _context.Remove(GetAnalistaById(id));
    }

    public IEnumerable<AnalistaEntity> GetAllAnalistas()
    {
        return _context.Set<AnalistaEntity>().ToList();
    }

    public AnalistaEntity GetAnalistaByDepartamento(string departamento)
    {
        return _context.Analistas.SingleOrDefault(d => d.Departamento == departamento);
    }

    public AnalistaEntity GetAnalistaById(int id)
    {
        return _context.Set<AnalistaEntity>().Find(id);
    }

    public void UpdateAnalista(AnalistaEntity entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}
