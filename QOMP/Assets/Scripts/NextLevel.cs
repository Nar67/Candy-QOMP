using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    public string nextSceneName;

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.GetComponent<PolygonCollider2D>());
        yield return new WaitForSeconds(1.0f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
