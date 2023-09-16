using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyTimeButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private int _index;

    public int Index
    {
        get => _index;
        set => _index = value;
    }

    private int _timer;

    private void OnValidate()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        SetDataWithIndex();

        _button?.onClick.AddListener(OnClickButton);
    }

    private void SetDataWithIndex()
    {
        switch (_index)
        {
            case 0:
                _text.SetText("1 day");
                _timer = 0;
                break;
            case 1:
                _text.SetText("7 days");
                _timer = 0;
                break;
            case 2:
                _text.SetText("30 days");
                _timer = 0;
                break;
            case 3:
                _text.SetText("3 months");
                _timer = 0;
                break;
            case 4:
                _text.SetText("6 months");
                _timer = 0;
                break;
        }
    }

    private void OnClickButton()
    {
        //todo: 
        switch (_index)
        {

        }
    }

    private void AddTime(int time)
    {
        GameManager.SetRegisterTime.Invoke(time);
    }
}