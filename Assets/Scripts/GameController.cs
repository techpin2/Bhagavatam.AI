using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Button changeFluitButton;
    [SerializeField] BGAudioData scriptableData;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Image backgroundImage;

    private int currentIndex = 0;

    private void Awake()
    {
        changeFluitButton.onClick.AddListener(OnChangeFluit);

        SetAudioAndImage();
    }
    private void OnDestroy()
    {
        changeFluitButton.onClick.RemoveListener(OnChangeFluit);
    }

    private void OnChangeFluit()
    {
        // Increment index and loop back if necessary
        currentIndex = (currentIndex + 1) % scriptableData.datas.Count;

        // Set audio clip and background image based on the new index
        SetAudioAndImage();
    }

    private void SetAudioAndImage()
    {
        if (scriptableData != null && scriptableData.datas.Count > 0)
        {
            //// Change background image
            //backgroundImage.sprite = scriptableData.datas[currentIndex].BackgroundImage;
            //Debug.Log("Background Image Changed: " + scriptableData.datas[currentIndex].BackgroundImage.name);

            // Change background color
            backgroundImage.color = scriptableData.datas[currentIndex].BackgroundColor;

            // Change audio
            audioSource.clip = scriptableData.datas[currentIndex].FluitAudio;
            audioSource.Play();
            Debug.Log("Audio Clip Changed: " + scriptableData.datas[currentIndex].FluitAudio.name);
        }
    }
}

