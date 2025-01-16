using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; //�m��Prefab�����}�ܼ�
    float span = 1.0f;             //�ɶ����j
    float delta = 0;               //�{�b�w�g�ֿn���ɶ�
    public GameObject hpGauge;
    public Text ScoreText;
    int Score = 0;                 // ����

    void Start()
    {
        ScoreText.text = $"���ơG{Score}";
        //ScoreText.text = "���ơG" + Score.ToString();
    }

    void Update()
    {
        delta += Time.deltaTime;  // �ֿn�ɶ���delta
        if (delta > span) // �p�Gdelta�ɶ��ֿn�j��span�ɶ����j
        {
            delta = 0; // delta�ɶ��k�s            
            int px = Random.Range(-6, 7); // �H�����ͤ@��-6��6���������
            // ���ͷs�b�Y�A�åB�]�w�s�b�Y����m
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
        }
    }

    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // �[������k
    public void IncreaseScore()
    {
        Score += 100;
        ScoreText.text = $"���ơG{Score}";
    }
}
