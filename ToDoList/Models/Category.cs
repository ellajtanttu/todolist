using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Item> Items { get; set; }

    public Category(string categoryName)
    {
      Name = categoryName; // assigned as an argument for constructor
      _instances.Add(this); // assigned automatically
      Id = _instances.Count;// assigned automatically
      Items = new List<Item>{};// assigned automatically
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Category> GetAll()
    {
      return _instances;
    }

    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddItem(Item item) //accepts an Item object and then use built-in List Add() method to save the item intot he Items property of a specific category. 
    {
      Items.Add(item);
    }
  }
}