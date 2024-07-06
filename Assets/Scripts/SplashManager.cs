using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitForSceneLoad());
    }

    IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Krishna's Melodies", LoadSceneMode.Single);
    }
}
