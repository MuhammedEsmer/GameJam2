using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject dialogimage;
    public Item Item;
    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        FindObjectOfType<InventoryManager>().ListItems();
        gameObject.SetActive(false);
        dialogimage.SetActive(false);
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
