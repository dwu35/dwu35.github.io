using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = true;
    }

    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Space))
        {
            Cursor.lockState = CursorLockMode.None;
        }
            
    }
}
