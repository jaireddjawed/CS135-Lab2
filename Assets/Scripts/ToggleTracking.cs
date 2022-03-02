using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTracking : MonoBehaviour
{
    public VRMirror mirror;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // toggle rotation tracking
            mirror.toggleRotationTracking();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // toggle position tracking
            mirror.togglePositionTracking();
        }
    }
}
