using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class ClearDirector : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
