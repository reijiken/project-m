using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemHolder : ScriptableObject
{
    //[SerializeField] private Slot[] slots;
    [SerializeField] List<ItemData> itemDataList = new List<ItemData>();
    [SerializeField] private int occupiedSlot = -1;     //-1 means there's no occupied slots


    public abstract ItemHolder getType();

    public bool HasItem(ItemData itemData)
    {
        if(itemDataList.Contains(itemData))
        {
            return true;
        }
        return false;
    }

    public ItemData GetItemDataAtSlot(int slotIndex)
    {
        return itemDataList[slotIndex];
    }

    public void AddItem(ItemData itemData)
    {
        occupiedSlot++;
        itemDataList.Add(itemData);
        Debug.Log(itemData);
    }

    public void SetItem(ItemData itemData, int slotIndex)
    {
        itemDataList[slotIndex] = itemData;
    }

    public List<ItemData> GetItemList()
    {
        return itemDataList;
    }

    public int GetItemListSize()
    {
        return itemDataList.Count;
    }

    public void ResetHolder()
    {
        //itemList = new Item[];  //Reseting the itemList should use for loop and set all values of the list to null
        occupiedSlot = -1;
    }
}
