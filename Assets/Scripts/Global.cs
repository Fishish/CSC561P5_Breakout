using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    public int score = 0;
    public int numOfObject = 0;
    public int cheatMode = 0;
    public TMP_InputField cheatInput;
    public Button sumbitCheat;
    public TMP_Text cheatModeText;
    public int randomBounce = 0;
    public TMP_Text bounceString;

    void Start()
    {
        sumbitCheat.GetComponent<Button>().onClick.AddListener(submitCode);
    }


    void Update()
    {
        Debug.Log(randomBounce);
        if (Input.GetKeyDown(KeyCode.R) && randomBounce == 0)
        {
            randomBounce = 1;
            bounceString.text = "Random Bouncing: On";
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            randomBounce = 0;
            bounceString.text = "Random Bouncing: Off";
        }
    }

    void submitCode()
    {
        if (cheatInput.text.Equals("iLoveCSC561"))
        {
            cheatMode = 1;
            cheatInput.text = "";
            cheatModeText.gameObject.SetActive(true);
        }
    }
}
