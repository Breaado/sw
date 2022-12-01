using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour {
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("GameScene");
        }
    }
}
