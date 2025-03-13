using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    private InstanceVariables instanceGeneral;

    public Button buttonTurnOffMusic;
    public Button buttonTurnOnMusic;
    public Button buttonTurnOffSound;
    public Button buttonTurnOnSound;

    public AudioSource audioMusic;

    private bool previousMusicState;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instanceGeneral = FindAnyObjectByType<InstanceVariables>();
        if (instanceGeneral.music)
        {
            buttonTurnOnMusic.gameObject.SetActive(true);
            buttonTurnOffMusic.gameObject.SetActive(false);
        }
        if (!instanceGeneral.music)
        {
            buttonTurnOnMusic.gameObject.SetActive(false);
            buttonTurnOffMusic.gameObject.SetActive(true);
        }
        if (instanceGeneral.sound)
        {
            buttonTurnOnSound.gameObject.SetActive(true);
            buttonTurnOffSound.gameObject.SetActive(false);
        }
        if (!instanceGeneral.sound)
        {
            buttonTurnOnSound.gameObject.SetActive(false);
            buttonTurnOffSound.gameObject.SetActive(true);
        }

        previousMusicState = instanceGeneral.music;

        if (instanceGeneral.music)
        {
            audioMusic.Play();
        }
        else
        {
            audioMusic.Pause();
        }
    }

    void Update()
    {
        if (instanceGeneral.music != previousMusicState) // Chỉ thay đổi khi music thay đổi
        {
            if (instanceGeneral.music)
            {
                audioMusic.Play();
            }
            else
            {
                audioMusic.Pause();
            }
            previousMusicState = instanceGeneral.music; // Cập nhật trạng thái
        }
    }
}
