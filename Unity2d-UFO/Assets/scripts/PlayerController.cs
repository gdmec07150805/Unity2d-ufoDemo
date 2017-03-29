using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private float moveHorizontal;
	private float moveVertical;
	public float speed=5f;
	private Rigidbody rb;

	public Text countText;
	public Text winText;
	private int count;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		count = 0;
		winText.text = "";
		setCountText ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		moveHorizontal=Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		rb.AddForce (new Vector3(moveHorizontal,0,moveVertical)*speed);
	}
	void OnTriggerEnter(Collider other){
		if (other.CompareTag("food")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText ();
		}
	}
	void setCountText(){
		countText.text="分数："+count.ToString();
		if (count == 10) {
			winText.text = "You Win !";
		}
	}
}
