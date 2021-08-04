using CleanArchitecture1.Core.Entities;
using CleanArchitecture1.SharedKernel;

namespace CleanArchitecture1.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}