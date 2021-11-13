using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void PlayGame()
    {   
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Game", LoadSceneMode.Single);
        asyncLoad.completed += AsyncLoad_completed;
    }

    private void AsyncLoad_completed(AsyncOperation obj)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Game"));
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
