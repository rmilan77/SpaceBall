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

    private const float frX = 0f;
    private const float frY = -3.2f;
    private const float frZ = -0f;    

    public Transform target;
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;

    float smooth = 0.5f;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {   
        Vector3 targetPosition = new Vector3(fX, fY, fZ);        
        Vector3 targetR = new Vector3(frX, frY, frZ);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);        

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion targetRotation = Quaternion.Euler(targetR);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * smooth);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
    }
}
