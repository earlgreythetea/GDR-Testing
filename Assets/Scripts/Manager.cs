using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int _score;
    private int _scoreMax;
    [SerializeField] public Text counterLabel;
    [SerializeField] public Button restartButton;
    [SerializeField] public GameObject coinPrefab;
    void Start()
    {
        StartSession();
        
    }
    public void AddScore()
    {
        _score++;
        counterLabel.text = "Score: " + _score + "/" + _scoreMax;
        if (_score >= _scoreMax)
        {
            restartButton.gameObject.SetActive(true);
        }
    }
    void Update()
    {
    }
    void StartSession()
    {
        restartButton.gameObject.SetActive(false);
        _score = 0;
        _scoreMax = Random.Range(3, 6);
        counterLabel.text = "Score: " + _score + "/" + _scoreMax;
        for (int i = 0; i < _scoreMax; i++)
        {
            float coinX = Random.Range(-8f, 8f);
            float coinY = Random.Range(-2f, 4f);
            GameObject coin = Instantiate(coinPrefab, new Vector2(coinX, coinY), Quaternion.identity);
        }
    }
}
