using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().Sleep();
        Physics.IgnoreCollision(GameObject.Find("NetFull").GetComponent<Collider>(), GetComponent<Collider>());
        startPosition = transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Baller")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody>().useGravity = true;
        }
        else if(other.gameObject.tag == "Finish")
        {
            var x = other.contacts[0].point.x;
            int winner = -1;
            if (x < GameObject.Find("Net").GetComponent<Transform>().position.x)
            {
                Player2.Score += 1;
                winner = 2;
            }
            else
            {
                Player1.Score += 1;
                winner = 1;
            }
            Global.DrawScore();
            Global.ResetScenePosition(winner);


            
        }
    }

}
