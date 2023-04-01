using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button restart;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        restart.GetComponent<Button>().onClick.AddListener(TaskOnClickRestart);
        exit.GetComponent<Button>().onClick.AddListener(TaskOnClickExit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClickRestart()
    {
        SceneManager.LoadScene(sceneName: "MainGame");
    }

    void TaskOnClickExit()
    {
        Application.Quit();
    }
}
