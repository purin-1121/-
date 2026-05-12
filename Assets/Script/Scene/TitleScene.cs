using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public AudioClip clickSE;
    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void GoToGamePlay()
    {
        SceneManager.LoadScene("GamePlayScene");
    }

    public void OnStartButton()
    {
        //‰¹‚ğ–Â‚ç‚·
        if (audioSource != null && clickSE != null)
        {
            audioSource.PlayOneShot(clickSE);
        }

        // ‚·‚®‚ÉƒV[ƒ“‚ª•Ï‚í‚é‚Æ‰¹‚ª“rØ‚ê‚é‚Ì‚ÅA­‚µ‚¾‚¯’x‚ç‚¹‚ÄˆÚ“®
        Invoke("GoToGamePlay", 0.5f);
    }
}
