using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Bone : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound;

    private int count = 0;
    private Collider2D _collider2D;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            AudioSource.PlayClipAtPoint(collectSound, other.transform.position);
            count++;
            Destroy(other.gameObject);
        }
    }

}
