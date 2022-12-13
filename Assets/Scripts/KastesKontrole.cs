using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    
    private Vector3 rotation;
    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         rotation = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.A))
        {
            rotation = Vector3.forward;
        }else if (Input.GetKey(KeyCode.D))
        {
            rotation = Vector3.back;
        }
        else if(Input.GetKey(KeyCode.W)){

            rotation = Vector3.left;

        }else if(Input.GetKey(KeyCode.S)){

            rotation = Vector3.right;

        }
        else
        {
            rotation = Vector3.zero;
        }

        transform.Rotate(rotation * speed * Time.deltaTime);

    }
}
