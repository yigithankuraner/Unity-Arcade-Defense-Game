using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    public AudioClip dropSound;
    public ParticleSystem hitGroundParticle;

    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < bottomLimit)
        {
            if (dropSound != null)
            {
                AudioSource.PlayClipAtPoint(dropSound, transform.position, 1.0f);
            }

            if (hitGroundParticle != null)
            {
                Vector3 spawnPos = new Vector3(transform.position.x, 0.1f, transform.position.z);
                Instantiate(hitGroundParticle, spawnPos, hitGroundParticle.transform.rotation);
            }

            Destroy(gameObject);
        }
    }
}