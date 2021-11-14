using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    public const float jumpVelocity = 8;
    public const float moveVelocity = 12;

    public static void DrawScore()
    {
        var t = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        t.SetText("Score: " + Player1.Score + ":" + Player2.Score);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
