using System.Collections.Generic;
using UnityEngine;

public abstract class Bag
{
    private List<IItem> _items;

    public virtual void ShowItem()
    {
        Debug.Log($"Для тебя есть {_items[0].Name}");
    }

    protected void MakeFill(IItem item)
    {
        _items = new List<IItem> { item };
    }
}
