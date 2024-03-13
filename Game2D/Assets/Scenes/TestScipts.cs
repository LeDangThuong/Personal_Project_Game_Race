using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScipts : MonoBehaviour
{
    [SerializeField] float steerspeed = 1f;
    [SerializeField] float movespeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Vertical") * steerspeed;
        float movement = Input.GetAxis("Horizontal") * movespeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, movement, 0);
      
    }
}
