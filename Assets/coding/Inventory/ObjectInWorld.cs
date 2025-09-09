using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInWorld : MonoBehaviour
{
    public Item item;
    public Inventory inv;

    private void OnMouseDown()
    {
        AddNewItem();
    }

    void AddNewItem()
    {
        if (inv.itemList.Contains(item))
        {
            inv.itemList.Add(item);
        }
        
    }
}
