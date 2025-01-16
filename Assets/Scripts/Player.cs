using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameManager;
    public AudioClip WalkSound;
    public AudioClip HurtShound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().clip = WalkSound;
            GetComponent<AudioSource>().Play();
            transform.Translate(3, 0, 0);
            //transform.position += new Vector3(3, 0, 0); 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<AudioSource>().clip = WalkSound;
            GetComponent<AudioSource>().Play();
            transform.Translate(-3, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().clip = HurtShound;
        GetComponent<AudioSource>().Play();
        gameManager.GetComponent<GameManager>().DecreaseHP();
    }

    // 當玩家按下畫面左按鍵時，貓咪往左移動「3」
    public void LButtonDown()
    {
        GetComponent<AudioSource>().clip = WalkSound;
        GetComponent<AudioSource>().Play();
        transform.Translate(-3, 0, 0);
    }

    // 當玩家按下畫面右按鍵時，貓咪往右移動「3」
    public void RButtonDown()
    {
        GetComponent<AudioSource>().clip = WalkSound;
        GetComponent<AudioSource>().Play();
        transform.Translate(3, 0, 0);
    }

}
