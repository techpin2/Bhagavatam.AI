
using UnityEngine;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    private Button quitButton;
    private void Awake()
    {
        quitButton= GetComponent<Button>();
        quitButton.onClick.AddListener(OnApplicationQuit);
    }

    private void OnDestroy()
    {
        quitButton.onClick.RemoveListener(OnApplicationQuit);
    }

    private void OnApplicationQuit()
    {
        Application.Quit();
    }


}
