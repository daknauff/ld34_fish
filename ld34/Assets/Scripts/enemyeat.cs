using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enemyeat : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "deadly")
		{
			//make bigbang
		}
		else if (col.transform.localScale.x < transform.localScale.x && col.gameObject.tag == "Fish") 
        {
			SceneManager.LoadScene("gameover");
        }
        
    }
}
