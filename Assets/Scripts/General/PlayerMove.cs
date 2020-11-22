using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed { get; set; }
    int jumpes = 2;
    int Ticks = 20;
    float mouseX = 0;

    // Start is called before the first frame update
    void Start()
    {

        speed = 2.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
        if (Input.GetKey(KeyCode.A)) transform.Translate(-new Vector3( Time.deltaTime * speed,0));
        if (Input.GetKey(KeyCode.S)) transform.Translate(-new Vector3(0, 0, Time.deltaTime * speed));
        if (Input.GetKey(KeyCode.D)) transform.Translate(new Vector3(Time.deltaTime * speed,0));
        if (Input.GetKeyDown(KeyCode.Space) && jumpes >0) {
            GetComponent<Rigidbody>().rotation = transform.rotation;
            GetComponent<Rigidbody>().AddForce(new Vector3(0,150));
            jumpes -= 1;
        }
        if(Input.GetMouseButton(1)) transform.Rotate(new Vector3(0,Input.mousePosition.x - mouseX));
        mouseX = Input.mousePosition.x;
    }
    public void OnCollisionStay(Collision collision)
    {
        if (jumpes < 2 && Ticks % 20 == 0) {
            jumpes=2;
        }
        Ticks++;

    }
}
