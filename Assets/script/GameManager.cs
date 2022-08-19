using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject restartButton;
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject gameOver;
    public static GameManager intance;
    // Start is called before the first frame update
    void Start()
    {
        intance = this;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dead()
    {
        Time.timeScale = 0;
        restartButton.SetActive(true);
        gameOver.SetActive(true );
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        playButton.SetActive(true);
        restartButton.SetActive(true);
    }
    public void Play()
    {
        Time.timeScale = 1;
        playButton.SetActive(false);
        restartButton.SetActive(false);
    }
    public void Restart()
    {
        EditorSceneManager.LoadScene(0);
    }
}
