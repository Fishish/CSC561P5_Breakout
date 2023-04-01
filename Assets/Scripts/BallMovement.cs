using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using static Global;

public class BallMovement : MonoBehaviour
{
    public float gravity = 9.8f;
    public TMP_Text scoreText;
    public int scoreNumber;
    public GameObject scoreObject;
    public Canvas GameOver;
    private float previousVelX = 0;
    private float previousVelY = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        Rigidbody rigidbody = GetComponent<Rigidbody>(); ;
        rigidbody.AddForce(20f, -300f, 0);
        //rigidbody.AddForce(100f, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {



        scoreText.text = scoreObject.GetComponent<Global>().score + "";

        //Debug.Log(GetComponent<Rigidbody>().velocity);
        //Debug.Log("magenisqr" + GetComponent<Rigidbody>().velocity.magnitude);
        if (GetComponent<Rigidbody>().velocity.magnitude < 6)
        {
            //Debug.Log("detected" + GetComponent<Rigidbody>().velocity.magnitude);
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x * 1.5f, GetComponent<Rigidbody>().velocity.y * 1.5f, 0);
        }
        if (transform.position.y <= -1)
        {
            scoreObject.GetComponent<Global>().score -= 1;
            transform.position = new Vector3(-0.37f, 4f, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-6f, 6f), Random.Range(-6f, 6f), 0);
            //GetComponent<Rigidbody>().AddForce(abc, Random.Range(0, 150), 0);
        }
        //theBall.transform.position+= new Vector3(0, gravity,0);
        previousVelX = GetComponent<Rigidbody>().velocity.x;
        previousVelY = GetComponent<Rigidbody>().velocity.y;

    }

    void OnCollisionEnter(Collision collision)
    {




        if (collision.gameObject.tag.Equals("Bricks"))
        {
            Destroy(collision.gameObject);
            scoreObject.GetComponent<Global>().score += 1;
            //global.GetComponent<Global>().socre += 1;
            if (scoreObject.GetComponent<Global>().cheatMode == 1)
            {
                Debug.Log(scoreObject.GetComponent<Global>().cheatMode);
                GameObject go = GameObject.Instantiate(this.gameObject);
                go.transform.position = transform.position;
            }
        }

        if (GameObject.FindWithTag("Bricks") == null)
        {
            GameOver.gameObject.SetActive(true);

        }

        //       if (GetComponent<Rigidbody>().velocity.x.Equals(-previousVelX) || GetComponent<Rigidbody>().velocity.y.Equals(-previousVelY))
        //       {
        //            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x + Random.Range(-3f, 3f), GetComponent<Rigidbody>().velocity.y + Random.Range(-3f, 3f), 0);
        //        }
        if (scoreObject.GetComponent<Global>().randomBounce == 1)
        {
            if (Random.Range(0, 100) >= 60)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-6f, 6f), Random.Range(-6f, 6f), 0);

            }
        }
        else
        {
            if (GetComponent<Rigidbody>().velocity.x <= 7f && GetComponent<Rigidbody>().velocity.x >= 6f)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, Random.Range(-2f, 2f), 0);
            }
            if (GetComponent<Rigidbody>().velocity.x >= -7f && GetComponent<Rigidbody>().velocity.x <= -6f)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, Random.Range(-2f, 2f), 0);
            }
        }



        //       if (scoreObject.GetComponent<Global>().numOfObject >= 103 || Input.GetKeyDown(KeyCode.Space))
        //       {
        //           SceneManager.LoadScene(sceneName: "GameOver");
        //        }
    }

}
