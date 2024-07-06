using ToDoPWA.Domain.Entities;

namespace ToDoPWA.Domain.Interfaces.IServices;

public interface IToDoService
{
    IEnumerable<ToDo> GetToDos();
    ToDo GetToDo(int id);
    void AddToDo(ToDo toDo);
    void UpdateToDo(ToDo toDo);
    void DeleteToDo(ToDo toDo);
}