using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float _speed;
    [SerializeField]
    private GameObject Kamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalnput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalnput,0,0) * _speed * Time.deltaTime);
       Kamera.transform.Translate(new Vector3(horizontalnput, 0, 0) * _speed * Time.deltaTime);
        float vertical_Input = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, vertical_Input) * _speed * Time.deltaTime);


    
    }
}
