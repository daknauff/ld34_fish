using UnityEngine;
using System.Collections;

public class playereat : MonoBehaviour {
    public AudioClip gulp;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        float newscale = transform.localScale.x;
        if (col.transform.localScale.x <= transform.localScale.x) 
        {
            audio.PlayOneShot(gulp, 10F);
            Destroy(col.gameObject);
            newscale++;
            transform.localScale = new Vector3(newscale, newscale, newscale);
        }
    }
}
