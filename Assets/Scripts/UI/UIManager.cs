using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

    public void LevelFour()
    {
        SceneManager.LoadScene(4);
    }

    public void tutorialLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
