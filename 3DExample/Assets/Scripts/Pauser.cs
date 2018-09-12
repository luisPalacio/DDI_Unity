using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pauser : MonoBehaviour
{
    private bool paused = false;
    public GameObject pausePanel;
    public GameObject pauseMusic;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {

            paused = !paused;
            pausePanel.SetActive(paused);
        }

        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    public void ResetGame()
    {
        Debug.Log("Reiniciar Jugeo");
        SceneManager.LoadScene(0);
    }
    public void ContinueGame()
    {
        Debug.Log("Continuar");
        paused = false;
        pausePanel.SetActive(paused);
    }
    public void MusicGame()
    {
        Debug.Log("Music");


    }
}