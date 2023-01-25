using System.Collections.Generic;

namespace H1W2D3ToDoOrNotToDo
{
    internal class Menu
    {
        List<ToDoItem> todoList = new();


        //Constructor that runs when object is instantiated (with new keyword).
        public Menu()
        {
            while (true)
            {
                MainMenu();
            }
        }
        //Start menu
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1) Add new\n(2) Show List \n(3) Update \n(4) Delete");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    CreateItem();
                    break;
                case '2':
                    ShowList();
                    break;
                case '3':
                    Update();
                    break;
                case '4':
                    Delete();
                    break;
                default:
                    break;
            }
        }

        //Show TodoList shows TodoItems
        void ShowList()
        {

            foreach (ToDoItem item in todoList)
            {
                ShowItem(item);
            }

        }

        //Create Item
        private void CreateItem()
        {
            ToDoItem newItem = new ToDoItem();
            newItem.Created = DateTime.Now;

            Console.WriteLine("What to do?");
            newItem.Todo = Console.ReadLine();

            Console.WriteLine("When to do it?");
            string dl = Console.ReadLine();
            //TODO Get different input regarding dates and times
            newItem.Deadline = DateTime.Parse(dl);
            newItem.IsDone = false;

            Console.WriteLine("Is it important?");
            newItem.IsFavorite = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;

            todoList.Add(newItem);
        }

        //Read TodoItem
        private void ShowItem(ToDoItem toDoItem)
        {
           
                Console.WriteLine($"{todoList.IndexOf(toDoItem)}. What: {toDoItem.Todo} When: {toDoItem.Deadline} isDone: {toDoItem.IsDone}");
    

            //Console.WriteLine("What: {0} When: {1} isDone: {2}", toDoItem.Todo, toDoItem.Deadline, toDoItem.IsDone);
            //Console.WriteLine("What: " + toDoItem.Todo + "When: " + toDoItem.Deadline + "isDone: " + toDoItem.IsDone);
        }


        //Update Item
        public void Update()
        {
            

            Console.WriteLine("Update");
            ShowList();
            Console.Write("Enter task number to Update: ");
            int tasknum = int.Parse(Console.ReadLine());
            todoList.RemoveAt(tasknum);
            Console.Write("New Task");
            Console.ReadLine();
            CreateItem();

        }

        //Delete Item

        public void Delete()
        {
            Console.WriteLine("Delete");
            ShowList();
            Console.Write("Enter task number to delete: ");
            int taskNum = Convert.ToInt32(Console.ReadLine());
            todoList.RemoveAt(taskNum);
          
            Console.WriteLine("Task deleted!");
            Console.ReadLine();
        }


    }
}
