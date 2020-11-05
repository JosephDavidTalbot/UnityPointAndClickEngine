using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryEntry : MonoBehaviour
{
    public Item item;
    public Image display;

    // Start is called before the first frame update
    void Start()
    {
        display.sprite = item.GetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectItem()
    {
        PlayerController.instance.currentItem = item;
    }
}
