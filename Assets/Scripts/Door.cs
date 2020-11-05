using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string DestinationName;

    public bool isLocked;

    private void OnMouseDown()
    {
        if (!isLocked)
        {
            SceneManager.LoadScene(sceneName:DestinationName);
        } else
        {
            Debug.Log("Pong.");
        }
    }
}
