namespace H1W2D3ToDoOrNotToDo
{
    /*
 * To do item
 *  Date Created
 *  Date Deadline
 *  Do / Done
 *  Favorite
 *  What to do Text
 *  Repeat
 *  
 *  Create/Read/Update/Delete
 * */
    internal class ToDoItem
    {
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
        public bool IsFavorite { get; set; }
        public string? Todo { get; set; }
        public long Repeat { get; set; } //If repeat > 0 then repeat is on
    }
}
