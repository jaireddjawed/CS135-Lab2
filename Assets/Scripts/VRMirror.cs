using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{
    public OVRCameraRig camera;

    Quaternion originalCameraRotation;

    bool mPressedOnce = false;
    bool mPressedTwice = false;
    bool rotateTime = false;

    // Start is called before the first frame update
    void Start()
    {
      originalCameraRotation = camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      // pressing the m key once should make the cube match your movements
      if (Input.GetKeyDown(KeyCode.M)) {
        mPressedOnce = true;
        rotateTime = true;
      }

      if (mPressedOnce && rotateTime) {
        Debug.Log("Here");
      transform.eulerAngles = new Vector3(
        originalCameraRotation.x,
        originalCameraRotation.y,
        originalCameraRotation.z
      );

      rotateTime = false;
      }

      /*if (mPressedOnce) {
        float positionOffset = Vector3.Distance(Camera.main.transform.position, originalPos);
        transform.position = transform.position + Camera.main.transform.forward * positionOffset * Time.deltaTime;

        Quaternion newRotation = this.transform.rotation;
        newRotation.y = Camera.main.transform.rotation.y;
        this.transform.rotation = newRotation;

        if (Input.GetKeyDown(KeyCode.M)) {
          mPressedOnce = false;
          mPressedTwice = true;
        }
      }

      if (mPressedTwice) {

      }*/
    }
}
