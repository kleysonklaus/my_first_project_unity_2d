using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // prueba de visual studio
    public GameObject Jhon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Jhon != null){
            Vector3 position = transform.position;
            position.x = Jhon.transform.position.x;
            transform.position = position;
        }
        
    }
}
