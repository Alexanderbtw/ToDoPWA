namespace ToDoPWA.Domain.Interfaces.IRepositories;

public interface ICrudRepository<T>
{
    IEnumerable<T> ReadAll();

    T Create(T entity);
    T Read(int id);
    T Update(T entity);
    T Delete(int id);
}