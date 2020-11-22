using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGrav : MonoBehaviour
{
    // Start is called before the first frame update
    public float mass = 0;
    public bool Mojno = false;
    public bool Vniz = false;

    void Start()
    {
        foreach (GameObject item in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            if (item.GetComponent<newGrav>() == null) item.AddComponent<newGrav>();
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        if (Mojno)
        {
            Vector3 pos = transform.position;
            foreach (GameObject item in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                if (item.name != name)
                {
                    Vector3 headness = item.transform.position - transform.position;
                    float ditance = Vector3.Distance(new Vector3(), headness);
                    float sila = (mass * item.GetComponent<newGrav>().mass) / ditance;
                    GetComponent<Rigidbody>().AddForce(headness * 0.001f * sila, ForceMode.Force);
                }
            }
            if (Vniz)
            {
                Vector3 Npos = transform.position;
                transform.position.Set(pos.x, pos.y, pos.z);
                transform.LookAt(Npos);
                transform.position.Set(Npos.x, Npos.y, Npos.z);
            }
        }
    }
}
