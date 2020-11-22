using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postranslate : MonoBehaviour
{
    public bool Role = true;
    static Vector3 pos;
    static Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Role)
        {
            pos += transform.localPosition;
            transform.localPosition = new Vector3();
        }
        else {
            transform.position += pos;
            pos = new Vector3();

        }
    }
}
