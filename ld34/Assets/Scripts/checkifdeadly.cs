using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class checkifdeadly : MonoBehaviour {
    public GameObject explosion;
	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Renderer>().enabled=true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "deadly")
        {

            //GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(this.gameObject,2);  //destroy player
            this.gameObject.GetComponent<Renderer>().enabled = false;
            SimplePool.Despawn(other.gameObject);  //despawn bomb
            Invoke("restart", 2);

        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "deadly")
        {
            
            //GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			Instantiate(explosion, transform.position, Quaternion.identity);
            //Destroy(this.gameObject,2);  //destroy player
			this.gameObject.GetComponent<Renderer>().enabled=false;
			SimplePool.Despawn(other.gameObject);  //despawn bomb
			Invoke("restart",2);
            
        }
    }
	void restart()
	{
        Playerscale.resetall();
		SceneManager.LoadScene("gameover");
	}
}
