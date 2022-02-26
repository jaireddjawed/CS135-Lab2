using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{
    public Camera camera;
    Vector3 originalPos;
    Quaternion originalRotation;
    bool mPressedOnce = false;

    // Start is called before the first frame update
    void Start()
    {
      originalPos = Camera.main.transform.position;
      originalRotation = Camera.main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      //Vector3 offset = camera.position - originalPos;
      //this.position = this.position + offset;

      // pressing the m key once should make the cube match your movements
      if (Input.GetKeyDown(KeyCode.M)) {
        mPressedOnce = true;
      }

      if (mPressedOnce) {
        //Vector3 cameraOffset = camera.position - originalPos;
        //this.position = this.position + cameraOffset;
      }
    }
}
