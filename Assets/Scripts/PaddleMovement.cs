using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {   
            if(transform.position.x >= -8.41)
            transform.Translate(-10f * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x <= 8.61)
            transform.Translate(10f * Time.deltaTime, 0, 0);
        }
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if(contact.thisCollider == gameObject.GetComponent<BoxCollider>())
            {
                float english = contact.point.x - transform.position.x;
                if (english == 0)
                {
                    english += 50f;
                }
                contact.otherCollider.GetComponent<Rigidbody>().AddForce(150f * english,0,0);
            }

        }
    }

}



