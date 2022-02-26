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
        if (Input.GetKeyDown(KeyCode.Tab)) {
            this.transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.F)) {
            this.transform.Rotate(0, 180.0f, 0);
        }

        // todo: pressing m key should make a certain cube either mirror or follow the user's movements

        /*if (Input.GetKeyDown(KeyCode.M)) {
            GameObject cube = GameObject.Find("Cube");
            if (cube.GetComponent<Mirror>().enabled) {
                cube.GetComponent<Mirror>().enabled = false;
            } else {
                cube.GetComponent<Mirror>().enabled = true;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Escape)) {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
