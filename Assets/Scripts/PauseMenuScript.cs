
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUI;
    public static bool gamePaused = false;
    [SerializeField] GameObject pauseButton;


    private void Start()
    {
        resumeFun();
    }
    public void resumeFun()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void pauseMenu()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void goToMenu()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                resumeFun();

            }
            else
            {
                pauseMenu();
            }
        }
    }
}
