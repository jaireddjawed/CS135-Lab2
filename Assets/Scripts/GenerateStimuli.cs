using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStimuli : MonoBehaviour
{
    public GameObject blueSphere1, blueSphere2, redSphere;
    public GameObject mainCameraParent;

    bool spheresShown = true;
    float time = 0.0f;

    // default red sphere radius and distance from camera
    // this never changes
    float redSphereRadius = 0.0f;
    float redSphereDistance = 0.0f;

    float blueSphere1Radius = 0.0f;
    float blueSphere2Radius = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        redSphereRadius = redSphere.transform.localScale.x;
        redSphereDistance = Vector3.Distance(redSphere.transform.position, mainCameraParent.transform.position);

        Debug.Log("Red sphere radius: " + redSphereRadius);
        Debug.Log("Red sphere distance: " + redSphereDistance);
        Debug.Log("Blue Sphere distance: " + Vector3.Distance(blueSphere1.transform.position, mainCameraParent.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        // pressing the s key toggles the appearance and disappearance of the three spheres
        if (Input.GetKeyDown(KeyCode.S))
        {
            spheresShown = !spheresShown;
            time = 0.0f;
        }

        if (spheresShown)
        {
            time += Time.deltaTime;
            // show the red sphere immediately
            // show the blue spheres after a delay of 2 seconds
            redSphere.SetActive(true);
            if (time > 2.0f)
            {
                blueSphere1.SetActive(true);
                blueSphere2.SetActive(true);
            }
        }
        else
        {
            blueSphere1Radius = Vector3.Distance(blueSphere1.transform.position, mainCameraParent.transform.position);
        blueSphere2Radius = Vector3.Distance(blueSphere2.transform.position, mainCameraParent.transform.position);

        blueSphere1.transform.localScale = new Vector3((redSphereRadius/redSphereDistance) * blueSphere1Radius,
                                                       (redSphereRadius/redSphereDistance) * blueSphere1Radius,
                                                       (redSphereRadius/redSphereDistance) * blueSphere1Radius);

        Debug.Log("Blue Sphere 1 radius: " + blueSphere1.transform.localScale.x);

        blueSphere2.transform.localScale = new Vector3((redSphereRadius/redSphereDistance) * blueSphere2Radius,
                                                       (redSphereRadius/redSphereDistance) * blueSphere2Radius,
                                                       (redSphereRadius/redSphereDistance) * blueSphere2Radius);
                                                       /*
            time += Time.deltaTime;
            // hide the red sphere immediately
            // hide the blue spheres after a delay of 2 seconds
            redSphere.SetActive(false);
            if (time > 2.0f)
            {
                blueSphere1.SetActive(false);
                blueSphere2.SetActive(false);
            }*/
        }
    }
}
