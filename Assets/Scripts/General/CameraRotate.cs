using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    float MouseY = 0;
    float RotX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse
        if (!(RotX > 100f) && RotX > 0 && MouseY - Input.mousePosition.y < 0) return;
        if (!(RotX < -100f) && RotX < 0 && MouseY - Input.mousePosition.y > 0) return;
        if (Input.GetMouseButton(1)) transform.Rotate(new Vector3(MouseY - Input.mousePosition.y, 0));
        MouseY = Input.mousePosition.y;
        RotX = transform.rotation.eulerAngles.x - 180;
    }
}
