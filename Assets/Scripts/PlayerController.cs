using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public List<Item> inventory;
    public List<InventoryEntry> inventoryEntries;
    
    public Item currentItem;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;

            inventory = new List<Item>();
            inventoryEntries = new List<InventoryEntry>();
            currentItem = null;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Item item)
    {
        inventory.Add(item);
        inventoryEntries.Add(GameManager.instance.currentRoom.AddItem(item).GetComponent<InventoryEntry>());
        inventoryEntries[inventoryEntries.Count - 1].item = item;
    }
}
