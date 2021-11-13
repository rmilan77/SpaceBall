using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cam : MonoBehaviour
{
    private const float fX = 7.58f;
    private const float fY = 2.134f;    
    private const float fZ = -12.97f;
    
    private float x = 7f;
    private float y = 2;
    private float z = -120f;

    public Transform target;
    public float smoothTime = 0.9F;
    private Vector3 velocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Transform>();
        target.SetPositionAndRotation(new Vector3(x, y, z), target.rotation);
    }

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = new Vector3(fX, fY, fZ);

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
    }
}
