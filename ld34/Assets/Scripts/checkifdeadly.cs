using UnityEngine;
using System.Collections;

public class checkifdeadly : MonoBehaviour {
    public GameObject explosion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "deadly")
        {
            Debug.Log("hit");
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(this.gameObject,2);
            SimplePool.Despawn(other.gameObject);
            
        }
    }
}
