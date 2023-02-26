using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    public GameObject item;
    private void OnMouseOver()
    {
        item.SetActive(false);
    }
}
