using ToDoPWA.Domain.Entities;

namespace ToDoPWA.Domain.Interfaces.IRepositories;

public interface IToDoRepository : ICrudRepository<ToDo>;