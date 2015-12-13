using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("w"))
        {
            Playerscale.reset();
            SceneManager.LoadScene("thoScene");
        }
	}
}
