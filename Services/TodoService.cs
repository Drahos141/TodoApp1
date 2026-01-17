using TodoApp.Models;

namespace TodoApp.Services;

public class TodoService
{
    private List<TodoItem> _todos = new();
    private int _nextId = 1;

    public event Action? OnChange;

    public IEnumerable<TodoItem> GetTodos() => _todos;

    public void AddTodo(string title)
    {
        if (string.IsNullOrWhiteSpace(title)) return;

        _todos.Add(new TodoItem
        {
            Id = _nextId++,
            Title = title.Trim(),
            IsCompleted = false,
            CreatedAt = DateTime.Now
        });
        
        NotifyStateChanged();
    }

    public void ToggleTodo(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            todo.IsCompleted = !todo.IsCompleted;
            NotifyStateChanged();
        }
    }

    public void DeleteTodo(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            _todos.Remove(todo);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
