using UnityEngine;
using System.Collections;

public class enemyeat : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.localScale.x < transform.localScale.x) 
        {
            Application.LoadLevel("gameover");
        }
        
    }
}
