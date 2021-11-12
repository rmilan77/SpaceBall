using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.UpArrow) && rb.position.y < 0.2)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * Global.jumpVelocity, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * Global.moveVelocity, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * Global.moveVelocity, ForceMode.Force);
        }
    }
}
