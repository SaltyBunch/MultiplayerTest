using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rgd;


    private Vector3 _dir;

    // Use this for initialization
    void Start()
    {
        _rgd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = (Input.GetAxis("Horizontal") * Vector3.right + Input.GetAxis("Vertical") * Vector3.forward).normalized;
    }

    private void FixedUpdate()
    {
        _rgd.velocity = _dir;
    }
}