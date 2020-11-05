using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Scriptable Objects/Create Item")]
public class Item : ScriptableObject
{
    public Sprite itemSprite;
    public string itemDisplayName;
    public string itemID;

    public GameObject inWorldObject;

    public Sprite GetSprite()
    {
        return itemSprite;
    }

    public void MoveToPlayer()
    {
        GameManager.instance.currentRoom.RemoveItem(inWorldObject);
        PlayerController.instance.AddItem(this);
    }
}
