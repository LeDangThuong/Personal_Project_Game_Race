using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Debug.Log("You are dead ! Try again");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You are finished !");
    }
}
