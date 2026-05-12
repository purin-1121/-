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

    // シーン遷移
    public void GoToGamePlay()
    {
        SceneManager.LoadScene("GamePlayScene");
    }

    public void OnStartButton()
    {
        //音を鳴らす
        if (audioSource != null && clickSE != null)
        {
            audioSource.PlayOneShot(clickSE);
        }

        // すぐにシーンが変わると音が途切れるので、少しだけ遅らせて移動
        Invoke("GoToGamePlay", 0.5f);
    }
}
