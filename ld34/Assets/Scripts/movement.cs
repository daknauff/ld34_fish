using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    public float speed = 1.5f;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float Translate = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, Translate, 0);
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(transform.position.y, -4, 4);
        transform.position = pos;
	}
}
