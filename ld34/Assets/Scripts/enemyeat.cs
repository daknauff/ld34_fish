using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enemyeat : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Player" && col.gameObject.transform.localScale.x < this.gameObject.transform.localScale.x)
		{
            Playerscale.resetall();
            SceneManager.LoadScene("gameover");
		}

        
    }
}
