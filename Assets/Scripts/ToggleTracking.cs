using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTracking : MonoBehaviour
{
    // Start is called before the first frame update
    bool rotationTrackingEnabled = true;
    bool positionTrackingEnabled = true;

    public GameObject mainCameraParent, centerEyeAnchor;
    public OVRPlayerController playerController;
    Quaternion rot;

    void Start()
    {
        rot = centerEyeAnchor.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // toggle rotation tracking
            rotationTrackingEnabled = !rotationTrackingEnabled;
            rot = centerEyeAnchor.transform.rotation;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // toggle position tracking
            positionTrackingEnabled = !positionTrackingEnabled;
        }

        if (!rotationTrackingEnabled)
        {
            // if rotation tracking is disabled, disable the rotation tracking
            mainCameraParent.transform.rotation = rot;
            //mainCameraParent.GetChild(1).GetComponent<OVRPlayerController>().EnableRotation = false;
            //playerController.EnableRotation = false;
        }
        else {
            // if rotation tracking is enabled, enable the rotation tracking
            // mainCameraParent.transform.rotation = rot;
            //mainCameraParent.GetChild(0).GetComponent<OVRPlayerController>().EnableRotation = true;
            //playerController.EnableRotation = true;
        }

        if (!positionTrackingEnabled)
        {

        }
    }
}
