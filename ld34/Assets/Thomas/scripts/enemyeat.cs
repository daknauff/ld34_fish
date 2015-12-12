using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enemyeat : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.localScale.x < transform.localScale.x) 
        {
			SceneManager.LoadScene("gameover");
        }
        
    }
}
