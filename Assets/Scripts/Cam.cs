using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cam : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;
    private Vector3 velocityScale = Vector3.zero;
    float smooth = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Cam2").GetComponent<Transform>();
    }

    void Update()
    {   
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);          
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * smooth);
        transform.localScale = Vector3.SmoothDamp(transform.localScale, target.localScale, ref velocityScale, smoothTime);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }
    }
}
