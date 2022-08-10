using Task_1.Data;
using Task_1.Models;
using Microsoft.EntityFrameworkCore;

using TaskContext context = new TaskContext();

//MyTask task1 = new MyTask() { Name = "Clean the kitchen", Description = "..." };
//MyTask task2 = new MyTask() { Name = "Buy products", Description = "..." };
//MyTask task3 = new MyTask() { Name = "Plant a tree", Description = "..." };
//MyTask task4 = new MyTask() { Name = "Clean the bedroom", Description = "..." };
//context.MyTasks.AddRange(new List<MyTask> { task1, task2, task3, task4 });

//Category category1 = new Category() { Name = "Cleaning", Importance = "Average" };
//Category category2 = new Category() { Name = "Household", Importance = "Average" };
//Category category3 = new Category() { Name = "Shopping", Importance = "Low" };
//context.Categories.AddRange(new List<Category> { category1, category2, category3 });
//context.SaveChanges();

//task1.CategoryTasks.Add(new CategoryTask { MyTaskId = 1, CategoryId = 1 });
//task2.CategoryTasks.Add(new CategoryTask { MyTaskId = 2, CategoryId = 3 });
//task3.CategoryTasks.Add(new CategoryTask { MyTaskId = 3, CategoryId = 2 });
//task4.CategoryTasks.Add(new CategoryTask { MyTaskId = 4, CategoryId = 1 });
//context.SaveChanges();


var tasks = context.Categories
    .Include(c => c.CategoryTasks)
    .ThenInclude(ct => ct.MyTask)
    .ToList();

foreach (var category in tasks)
{
    Console.WriteLine($"Category - {category.Name}:");
    var task = category.CategoryTasks.Select(ct => ct.MyTask).ToList();

    foreach (var myTask in task)
    {
        Console.WriteLine($"Task - {myTask.Name} ({myTask.Description}).");
    }
    Console.WriteLine();
}




