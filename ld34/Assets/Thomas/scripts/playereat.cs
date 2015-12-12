using UnityEngine;
using System.Collections;

public class playereat : MonoBehaviour {
	void start()
	{
		
	}
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        float newscale = transform.localScale.x;
        if (col.transform.localScale.x <= transform.localScale.x) 
        {

            Destroy(col.gameObject);
            newscale++;
            transform.localScale = new Vector3(newscale, newscale, newscale);
		
        }
    }
}
