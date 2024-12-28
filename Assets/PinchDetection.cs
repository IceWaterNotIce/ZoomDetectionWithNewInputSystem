using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchDetection : MonoBehaviour
{
    // Start is called before the first frame update

    private TouchControl controls;

    private Coroutine zoomCoroutine;

    public Transform cameraTransform;
    private void Awake()
    {
        controls = new TouchControl();
       
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    void Start()
    {
        controls.Touch.SecondaryTouchContact.started += ctx => ZoomStart();
        controls.Touch.SecondaryTouchContact.canceled += ctx => ZoomEnd();

    }

    void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetection());
    }

    void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
    }

    IEnumerator ZoomDetection()
    {
       float previousDistance = 0f, distance = 0f;
        while (true)
        {
            distance = Vector2.Distance(controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(), controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            // Zoom out
            if(distance != previousDistance)
            {
                if(distance > previousDistance)
                {
                    Debug.Log("Zoom out");
                    Vector3 targetPosition = cameraTransform.position;
                    targetPosition.z -= 1;
                    cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime);
                }
                // Zoom in
                else
                {
                    Debug.Log("Zoom in");
                    Vector3 targetPosition = cameraTransform.position;
                    targetPosition.z += 1;
                    cameraTransform.position = Vector3.Slerp(cameraTransform.position, targetPosition, Time.deltaTime);

                }
            }
            previousDistance = distance;
            yield return null;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
