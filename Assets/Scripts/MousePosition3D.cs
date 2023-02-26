using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    public Item item;
    string itemname;
    string iteminfo;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public GameObject dialogimage;
    private void OnMouseOver()
    {
        dialogimage.SetActive(true);
        iteminfo = item.itemInfo;
        itemname = item.itemName;
        textComponent.text= itemname + iteminfo;
    }
 
  
}
