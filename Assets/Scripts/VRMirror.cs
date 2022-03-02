using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{
    public OVRCameraRig camera;

    bool isMatching = false;
    bool isMirroring = false;

    bool rotationTrackingOn = true;
    bool positionTrackingOn = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // pressing the m key once should make the cube match your movements
      if (Input.GetKeyDown(KeyCode.M))
      {
        // once m is pressed once, set isMatching to true
        // once m is pressed twice, set isMatching to false and isMirroring to true

        if (isMatching)
        {
          isMatching = false;
          isMirroring = true;
        }
        else
        {
          isMatching = true;
          isMirroring = false;
        }
      }

      if (isMatching)
      {
          // if isMatching is true, match the camera to the cube
          // this is done by setting the camera's position to the cube's position
          // and the camera's rotation to the cube's rotation
          if (positionTrackingOn)
          {
            // camera.transform.position = transform.position;
          }
          if (rotationTrackingOn)
          {
            // transform.rotation = camera.centerEyeAnchor.transform.rotation;
          }
      }

      if (isMirroring)
      {
          if (positionTrackingOn)
          {
            // camera.transform.position = transform.position;
          }
          if (rotationTrackingOn)
          {
            // transform.rotation = camera.centerEyeAnchor.transform.rotation;
          }
      }
    }

    public void toggleRotationTracking()
    {
      rotationTrackingOn = !rotationTrackingOn;
    }

    public void togglePositionTracking()
    {
      positionTrackingOn = !positionTrackingOn;
    }
}
