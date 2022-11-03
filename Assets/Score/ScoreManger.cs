using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class starCalculate
{
    public int star1;
    public int star2;
    public int star3;

    public int calculateStar(int score)
    {
        int star = 0;

        if (score >= star1)
        {
            star = 1;
        }

        if (score >= star2)
        {
            star = 2;
        }

        if (score >= star3)
        {
            star = 3;
        }

        return star;
    }
}

public class ScoreManger : MonoBehaviour
{
    #region singaton
    public static ScoreManger Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    [SerializeField]
    private bool isCollectPassGate = false;
    public bool isCanPass { get { return isCollectPassGate; } }

    [Header("Displaying")]
    public GameObject resultPanel;
    public TextMeshProUGUI resultText;
    [Space]
    public float popUpDuration = 1.2f;
    public LeanTweenType ease = LeanTweenType.easeOutSine;

    [Header("Star Display")]
    public GameObject[] stars;
    public float starPopDuration = 0.4f;
    public float popDelay = 0.6f;
    public LeanTweenType starEase = LeanTweenType.easeOutSine;

    [Header("Score")]
    public starCalculate starCalculator;

    private void Start()
    {
        resultPanel.transform.localScale = Vector3.zero;

        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].transform.localScale = Vector3.zero;
        }
    }

    public void collectPassGate()
    {
        isCollectPassGate = true;
    }

    public void showResultPanel()
    {
        LeanTween.scale(resultPanel, Vector3.one, popUpDuration).setEase(ease);

        if (!isCanPass)
        {
            resultText.text = "Lose!!";
            return;
        }

        //scoreText.text = starCalculator.calculateStar(myTurnManager.Instance.CurrentTurn).ToString();
        LeanTween.delayedCall(0.3f, () =>
        {
            StartCoroutine("showStar");
        });
    }

    private IEnumerator showStar()
    {
        for (int i = 0; i < starCalculator.calculateStar(myTurnManager.Instance.CurrentTurn); i++)
        {
            yield return new WaitForSeconds(popDelay);
            LeanTween.scale(stars[i], Vector3.one, starPopDuration).setEase(ease);
        }
    }
}
