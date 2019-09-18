using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            OnPlayerCollect();
    }

    void OnPlayerCollect()
    {
        Animator anim = GetComponent<Animator>();
        anim.Play("Collected");
    }

    void OnCollectedFinish()
    {
        Destroy(gameObject);
    }
}
