using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public List<ItemInWorld> items = new List<ItemInWorld>();

    public Text displayArea;
    public GameObject inventoryEntry;
    public GameObject inventoryDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject AddItem(Item item)
    {
        GameObject invTemp = Instantiate(inventoryEntry, GameManager.instance.currentRoom.inventoryDisplay.transform);
        return invTemp;
    }

    public void RemoveItem(GameObject item)
    {
        items.Remove(item.GetComponent<ItemInWorld>());
    }
}
