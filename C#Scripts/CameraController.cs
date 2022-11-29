using UnityEngine;
using System.Collections;

public class CameraController : MonoBehavior {

    GameObject player;
  
    void Start() {
        this player = GameObject.Find("cat");
    }

    void Update() {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
        transform.position.x, playerPos.y, transform.position.z);
    }
}
