using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //por si esta en bool
        //if (Mathf.Abs(y) > 0.1f)
        //{
        //    anim.SetBool("SPeed", true);
        //}
        //else
        //{
        //    anim.SetBool("SPeed", false);
        //}

        anim.SetFloat("Speed", Mathf.Abs(y));

        transform.Translate(Vector3.forward * y * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * x * rotationSpeed * Time.deltaTime);

        //para usar trigger
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    anim.SetTrigger(" el nomrbe ");
        //}
    }
}
