using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    private int count;
   
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector2(0, 90)*Time.deltaTime);
	}
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Destroy(this.gameObject);
    }
}