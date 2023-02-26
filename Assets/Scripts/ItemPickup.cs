using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        FindObjectOfType<InventoryManager>().ListItems();
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
