﻿using UnityEngine;
using System.Collections;

public class playereat : MonoBehaviour {
	public AudioSource eating;
	void start()
	{
		
	}
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        float newscale = transform.localScale.x;
        if (col.transform.localScale.x <= transform.localScale.x) 
        {

			if (col.gameObject.tag == "Fish")
			{
				Destroy(col.gameObject);
	            newscale++;
				eating.Play();
	            transform.localScale = new Vector3(newscale, newscale, newscale);
			}
        }
    }
}