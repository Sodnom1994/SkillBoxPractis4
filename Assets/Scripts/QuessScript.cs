using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuessScript : MonoBehaviour
{
    private int _randomNumber;
    private int _maxValue = 101;
    private int _minValue = 0;
    //���� ������ ����������� � ���� TMP ����������
    public TextMeshProUGUI hiddenNumber;
    public TMP_InputField inputNumber;

    private void Start()
    {
        //TextMeshPro ��������� � ���������� Unity � ����� ����� 
        //� GameObject � ����� ���������� ����� �� ������
        //Sting ��� ��� ������ �� ����� ����� ��������
        //� ��� �� �� ���������� �����
        
        //�������������� ����� .text
        hiddenNumber.text = "������ ��� ������?";
        _randomNumber = Random.Range(_minValue, _maxValue);
        Debug.Log($"_randomNumber = {_randomNumber}");
    }


    public void CheckYourNumber()
    {
        //���� �������� � ���� ������� ���� "�������" ����� � ��� ���������
        //���������� setNumber �������� �������� 
        //int inputNumberInt = int.Parse(inputNumber.text);
        string setNumber = inputNumber.text;
        int inputNumberInt = int.Parse(setNumber);
        if (inputNumber.text == "")
        {
            //�������� ���� ��� ����� ��� �������� ��� ����
            hiddenNumber.text = "������� �����!";
            //����� �������� �������� �� ����� ��� ����� ������� � inputbox
        }
        else
        {
            //�������� �����
            if (inputNumberInt < _randomNumber)
            {
                hiddenNumber.text = "��������� ����� ������ �����������!";
            }
            else if (inputNumberInt > _randomNumber)
            {
                hiddenNumber.text = "��������� ����� ������ �����������!";
            }
            else if (inputNumberInt == _randomNumber)
            {
                hiddenNumber.text = "�� �������!";
            }
        }
    }
}

