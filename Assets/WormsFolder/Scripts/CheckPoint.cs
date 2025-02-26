using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject spawnPoint;

    [Header("Bools")]
    public bool isUsed;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip checkPointSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spawnPoint = GameObject.Find("SpawnPoint").gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            spawnPoint.gameObject.transform.position = transform.position;
            if(!isUsed)
            {
                isUsed = true;
                audioSource.PlayOneShot(checkPointSound);
            }
        }
    }
}
