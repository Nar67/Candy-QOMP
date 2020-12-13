using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public string nextSceneName;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
