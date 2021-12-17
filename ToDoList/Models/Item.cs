//using System; // directive - tells it what code it needs in order to function.
using System.Collections.Generic; // if using list objects

namespace ToDoList.Models
{
  public class Item//class
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {};
    public Item(string description) // this is a constructor
    {
      Description = description;
      _instances.Add(this); //New code.
      Id = _instances.Count;
    }

      public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}