using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIpoint : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText;

    [SerializeField]
    private int _score;

    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "0/6";
    }

    public void AddScore(int _deposer)
    {
        _score += _deposer;
        _scoreText.text = _score.ToString() + "/6";
        if(_score == 6)
        {
            winText.SetActive(true);
        }
    }
}
