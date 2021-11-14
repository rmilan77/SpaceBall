using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public static Vector3 startPosition;
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.W) && rb.position.y < 0.2)
        {
            rb.AddForce(Vector3.up * Global.jumpVelocity, ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * Global.moveVelocity, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * Global.moveVelocity, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down, ForceMode.VelocityChange);
        }
    }
}
