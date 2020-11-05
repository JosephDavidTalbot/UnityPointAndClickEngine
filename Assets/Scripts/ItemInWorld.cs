using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInWorld : MonoBehaviour
{
    public Item item;
    public SpriteRenderer spriteRenderer;
    public bool isLocked;

    // Start is called before the first frame update
    void Start()
    {
        item.inWorldObject = this.gameObject;
        spriteRenderer.sprite = item.GetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!isLocked)
        {
            item.MoveToPlayer();
            Destroy(gameObject);
        }
    }
}
