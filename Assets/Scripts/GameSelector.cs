using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelector : MonoBehaviour
{
    [SerializeField] PlayerProfile playerData;
    [SerializeField] TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        if (playerData != null)
        {
            text.text = "You Must have a Gun to play. Go to the Shop and purchase one.";
            StartCoroutine(backToMenu());
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    IEnumerator backToMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
