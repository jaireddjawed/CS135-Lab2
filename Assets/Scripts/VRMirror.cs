using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{
    public OVRCameraRig camera;

    bool isMatching = false;
    bool isMirroring = false;

    Vector3 originalCamPos;

    // Start is called before the first frame update
    void Start()
    {
      originalCamPos = camera.centerEyeAnchor.position;
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

          // use offset of player's original position and add it to the face's position
          transform.position += camera.centerEyeAnchor.position - originalCamPos;
          originalCamPos = camera.centerEyeAnchor.position;

          var rot = camera.centerEyeAnchor.transform.rotation;
          // shift rot by 90 degrees on the y axis
          transform.rotation = Quaternion.Euler(rot.eulerAngles.x, rot.eulerAngles.y - 90, rot.eulerAngles.z);
      }

      if (isMirroring)
      {
        transform.position += camera.centerEyeAnchor.position - originalCamPos;
        var rot = camera.centerEyeAnchor.transform.rotation;
        transform.rotation = Quaternion.Euler(rot.eulerAngles.x, rot.eulerAngles.y + 90, rot.eulerAngles.z);
      }
    }
}
