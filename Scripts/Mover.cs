using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 0;
    [serilaziFileld] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        floatzMove = Input.GetAxis("Vertical");
        
        transform.Translate(xMove, 0, zMove);
    }
}
