using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private Transform cam;
    private Vector3 lastCameraPosition;
    [SerializeField] private float parallaxEffect;
    private void Start()
    {
        cam = Camera.main.transform;
        lastCameraPosition = cam.position;
    }

    private void FixedUpdate()
    {
        Vector3 deltaMovement = cam.position - lastCameraPosition;
        
        transform.position += deltaMovement * parallaxEffect;

        lastCameraPosition = cam.position;
    }


}
