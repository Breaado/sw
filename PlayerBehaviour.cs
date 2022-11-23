using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rigid2D;
    float jumpForce = 400.0f; //force가 너무 커서 점프하면 여러 블럭을 뛰어 넘어버리는 것을 볼 수 있었음.
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    
    void Start() {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }
    
    void Update() {
        // 점프한다.
        if (Input.GetKeyDown(KeyCode.Space)) {
              this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        
        // 좌우 이동
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;
        
        // 플레이어 속도
        float speedx = Math.Abs(this.rigid2D.velocity.x);
        
        // 스피드 제한 
        if(speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        this.animator.speed = speedx / 2.0f; //스피드 추가
     }
  }
        
