using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public float speed = 0;
    private float x, y;

    private int count;
    public Text countText;
    public Text WinText;
    // Use this for initialization
    void Start()
    {
        count = 0;
        WinText.text = "";
        setCountText();
    }

    // Update is called once per frame
    void Update()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - speed * Time.deltaTime;
            MovePos();
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = x + speed * Time.deltaTime;
            MovePos();
        }
        if (Input.GetKey(KeyCode.S))
        {
            y = y - speed * Time.deltaTime;
            MovePos();
        }
        if (Input.GetKey(KeyCode.W))
        {
            y = y + speed * Time.deltaTime;
            MovePos();
        }
    }
    void MovePos()
    {
        if (x > -3.2f && x < 3.2f)
        {
            if (y > -3.2f && y < 3.2f)
            {
                this.transform.position = new Vector2(x, y);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="food")
        {
            collision.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
        
    }

    void setCountText()
    {
        countText.text = "分数：" + count.ToString();
        if (count == 9)
        {
            WinText.text = "You Win!";
        }
    }
}

