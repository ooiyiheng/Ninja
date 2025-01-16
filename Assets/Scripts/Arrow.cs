using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject gameManager;
    //bool IsIncreaseScore = false;   // 是否加過分

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManger");
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.y < -6.5 && IsIncreaseScore == false)
        //{
        //    // 加分
        //    gameManager.GetComponent<GameManager>().IncreaseScore();
        //    IsIncreaseScore = true;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Increase Score")
        {
            gameManager.GetComponent<GameManager>().IncreaseScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
