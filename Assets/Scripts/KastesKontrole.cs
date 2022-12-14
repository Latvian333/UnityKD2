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
    void FixedUpdate()
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

        }else if(Input.GetKey(KeyCode.Q)){
            
            rotation = Vector3.up;

        }else if(Input.GetKey(KeyCode.E)){

            rotation = Vector3.down;

        }
        else
        {
            rotation = Vector3.zero;
        }

        transform.Rotate(rotation * speed * Time.deltaTime);

    }
}
