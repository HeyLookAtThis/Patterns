using System.Collections.Generic;
using UnityEngine;

public abstract class Bag
{
    private List<IItem> _items;

    protected Bag(IItem item)
    {
        _items = new List<IItem> { item };
    }

    public void ShowItem()
    {
        Debug.Log($"��� ���� ���� {_items[0].Name}");
    }

    public void RefuseToShowItem()
    {
        Debug.Log($"��� ������ ���� ����������");
    }
}
