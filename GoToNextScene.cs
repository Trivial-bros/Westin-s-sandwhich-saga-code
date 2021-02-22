using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
    public Animator Animator;
    [SerializeField]
    bool movedOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && movedOn == false)
        {
            Animator.SetTrigger("fade in");
            Invoke("loadNextLevel", 1f);
            movedOn = true;
        }
    }

    private void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
