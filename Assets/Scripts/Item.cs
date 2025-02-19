
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public string itemInfo;
    public int value;
    public Sprite icon;

    public int GetItem()
    { return value; }
  
}
