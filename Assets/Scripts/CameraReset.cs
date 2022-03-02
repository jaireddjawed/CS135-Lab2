using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // resets the camera position to the origin if the "tab" key is pressed
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            this.transform.position = new Vector3(0, 0, 0);
        }

        // pressing the escape key quits the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
