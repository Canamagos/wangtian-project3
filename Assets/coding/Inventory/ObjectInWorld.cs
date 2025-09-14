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
        //print(11111);
        if (!inv.itemList.Contains(item))
        {
            inv.itemList.Add(item);
            InventoryManager.CreateNewItem(item);
            print(11111);
        }
        
    }
}
