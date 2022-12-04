using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{

    public CoinManager eventSystem; // 코인 먹으면 없어지도

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 3.0f;
    float maxWalkSpeed = 0.01f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        eventSystem = GameObject.Find("Coin_Text").GetComponent<CoinManager>();
        gameObject.tag = "player";
    }

    void Update()
    {
        // 점프한다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도
        float speedx = Math.Abs(this.rigid2D.velocity.x);

        // 스피드 제한 
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        this.animator.speed = speedx / 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            eventSystem.Add_coin();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
