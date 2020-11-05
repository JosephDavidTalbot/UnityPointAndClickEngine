using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fixture : MonoBehaviour
{
    public Item key;

    public string successText;
    public string failureText;
    public string lockedText;
    public string unlockedText;

    public bool isLocked;
    public bool hideOnUnlock;

    public List<GameObject> activateOnUnlock = new List<GameObject>();
    public List<Fixture> fixtureUnlockOnUnlock = new List<Fixture>();
    public List<Door> doorUnlockOnUnlock = new List<Door>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Ping!");
        if(isLocked && PlayerController.instance.currentItem == key)
        {
            isLocked = false;
            GameManager.instance.currentRoom.displayArea.text = successText;
            PlayerController.instance.currentItem = null;
            foreach(GameObject g in activateOnUnlock)
            {
                g.SetActive(true);
            }
            foreach(Fixture f in fixtureUnlockOnUnlock)
            {
                f.isLocked = false;
            }
            foreach(Door d in doorUnlockOnUnlock)
            {
                d.isLocked = false;
            }
            if (hideOnUnlock)
            {
                gameObject.SetActive(false);
            }
        } else if (isLocked && PlayerController.instance.currentItem == null)
        {
            GameManager.instance.currentRoom.displayArea.text = lockedText;
        } else if (isLocked && PlayerController.instance.currentItem != key)
        {
            GameManager.instance.currentRoom.displayArea.text = failureText;
            PlayerController.instance.currentItem = null;
        } else
        {
            GameManager.instance.currentRoom.displayArea.text = unlockedText;
        }
    }
}
