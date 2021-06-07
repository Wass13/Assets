using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 6;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * speed ;
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        
        transform.Translate(xMove, 0, zMove);
    }
}
