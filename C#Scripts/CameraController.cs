using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    GameObject player;
  
    void Start() {
        this.player = GameObject.Find("player");
    }

    void Update() {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
        transform.position.x, playerPos.y, transform.position.z);
    }
}
