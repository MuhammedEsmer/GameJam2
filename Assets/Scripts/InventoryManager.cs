using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;
    public int point;
    int points;
    [SerializeField] TextMeshProUGUI tmpscore;
    public float timeRemaining = 10;


    private void Awake()
    {
        Instance = this;
   
      
        
    }
    public void Add(Item item)
    {
        Items.Add(item);   
    }

    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        points = 0;
        foreach(var item in Items)
        {
           
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            point = item.value;
            points += point  ;
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            
        }
        

        tmpscore.SetText("Toplam puan :"+Convert.ToString(points));

    }
    private void Update()
    {
        if (points > 4)
        {

            timeRemaining -= Time.deltaTime;
            if
        }
    }



}
