using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer  render;
    Rigidbody rigidBody;
    [SerializeField] float WaitingTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        render.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > WaitingTime)
        {
            StartDrop();
        }
    }

    void StartDrop()
    {
        render.enabled = true;
        rigidBody.useGravity = true;
    }
}
