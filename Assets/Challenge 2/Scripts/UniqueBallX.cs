using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueBallX : MonoBehaviour
{
    public float speed = 15.0f;

    private float zigzagSpeed = 5.0f;
    private float zigzagStrength = 10.0f;

    void Update()
    {
        if (gameObject.name.Contains("2"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            float wave = Mathf.Sin(Time.time * zigzagSpeed) * zigzagStrength;
            transform.Translate(Vector3.right * wave * Time.deltaTime);
        }
        else if (gameObject.name.Contains("3"))
        {
            transform.Translate(Vector3.forward * (speed * 0.8f) * Time.deltaTime);
            transform.Rotate(0, 0, 200 * Time.deltaTime);
        }
        else if (gameObject.CompareTag("PowerUp"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            float pulsedSpeed = speed + (Mathf.Sin(Time.time * 5.0f) * 10.0f);
            transform.Translate(Vector3.forward * pulsedSpeed * Time.deltaTime);
        }
    }
}