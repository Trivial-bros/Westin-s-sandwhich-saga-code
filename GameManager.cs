using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public playerHealth playerHealth;
    public Audio_Manager Audio_Manager;
    public GameObject pauseMenuUI;
    public AudioMixer AudioMixer;
    bool gameIsPaused = false;
    public enemyHealth enemyHealth;
    public Animator animator;
    bool gameHasEnded = false;

    private void Update()
    {
        Pause();
        if(playerHealth.currentHealth == 0)
        {
            Invoke("die", 0.2f);
        }

        if (enemyHealth.currentHealth <= 0 && gameHasEnded == false)
        {
            animator.SetTrigger("fade in");
            Invoke("EndGame", 1f);
            gameHasEnded = true;
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused == false)
            {
                pause();
            }
            else
            {
                resume();
            }
        }
    }

    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    void resume()
    {
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Setvolume (float volume)
    {
        AudioMixer.SetFloat("Volume", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    


}
