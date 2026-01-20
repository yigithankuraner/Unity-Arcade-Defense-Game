using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenDogSpawns = 0.5f;
    private float canSpawn = 0.0f;
    public float speed = 15.0f;

    public AudioClip barkSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = Time.time + timeBetweenDogSpawns;

            if (playerAudio != null && barkSound != null)
            {
                playerAudio.PlayOneShot(barkSound, 1.0f);
            }
        }
    }
}