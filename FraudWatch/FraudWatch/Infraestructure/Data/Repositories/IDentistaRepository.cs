using FraudWatch.Domain.Entities;

namespace FraudWatch.Infraestructure.Data.Repositories;

public interface IDentistaRepository
{
    IEnumerable<DentistaEntity> GetAllDentistas();
    DentistaEntity GetDentistaById(int id);
    DentistaEntity GetDentistaByCro(string cro);
    void AddDentista(DentistaEntity entity);
    void UpdateDentista(DentistaEntity entity);
    void DeleteDentistaById(int id);
}
