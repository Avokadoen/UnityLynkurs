using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterPlaySound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private PlayerInput player;

    // Start is called before the first frame update
    void Start()
    {
        if (!audioSource) {
            audioSource = gameObject.GetComponent<AudioSource>();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player.gameObject) {
            audioSource.Play();
        }
    }
}
