using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public int Points;
    public TextMeshProUGUI PointsText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreasePoints(int value)
    {
        Points += value;
        PointsText.text = $"Points:{Points}";
    }
}
