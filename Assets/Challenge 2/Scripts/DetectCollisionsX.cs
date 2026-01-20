using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    public AudioClip catchSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dog"))
        {
            if (explosionParticle != null)
            {
                Instantiate(explosionParticle, transform.position, transform.rotation);
            }

            if (catchSound != null)
            {
                AudioSource.PlayClipAtPoint(catchSound, transform.position, 1.0f);
            }

            if (gameObject.CompareTag("PowerUp"))
            {
                GameManagerX.Instance.ActivatePowerUp();
            }

            GameManagerX.Instance.AddScore(10);

            Destroy(gameObject);
        }
    }
}