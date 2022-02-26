using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlipper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // flips the camera position 180 degrees if "F" is pressed
        if (Input.GetKeyDown(KeyCode.F)) {
            this.transform.Rotate(0, 180.0f, 0);
        }
    }
}
