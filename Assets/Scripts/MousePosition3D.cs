using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    public GameObject item;
    string itemname;
    string iteminfo;
    private void OnMouseOver()
    {
        iteminfo = FindObjectOfType<Item>().itemdesc();
        itemname = FindObjectOfType<Item>().iname();
        Debug.Log(iteminfo);
        Debug.Log(itemname);
    }
}
