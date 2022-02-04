using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetPlacement : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    GameObject my_object;
    void Start ()
    {
        my_object = GameObject.FindWithTag("Placement");
    }

    //void update()
    //{

        public void Up() //void Update ()
        {
        //if (Input.GetKey(KeyCode.UpArrow))
            my_object.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        public void Down()
        {
        //if (Input.GetKey(KeyCode.DownArrow))
            my_object.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
         }
        public void Left()
        {
        //if (Input.GetKey(KeyCode.LeftArrow))
            my_object.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
         }
        public void Right()
        {
        //if (Input.GetKey(KeyCode.RightArrow))
            my_object.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
         }
        /*
        if (Input.GetKey("escape"))
                Application.Quit();
        */
    //}
}
