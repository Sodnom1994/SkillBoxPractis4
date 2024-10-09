using System.Collections;
using System.Collections.Generic;
//»спользую TMPro как вы и рекомендовали
using TMPro;
using UnityEngine;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private float _firstNumber;
    [SerializeField] private float _secondNumber;
    [SerializeField] private float _answer;

    public TMP_InputField TMP_InputField_firstNumber;
    public TMP_InputField TMP_InputField_secondNumber;
    public TMP_Text TMP_InputField_answer;
    public TMP_Text TMP_InputField_Operand;

    private void Start()
    {
        TMP_InputField_firstNumber.text = "¬ведите первое число";
        TMP_InputField_secondNumber.text = "¬ведите второе число";
        TMP_InputField_answer.text = "ќтвет...";
    }
    public void ParseNumber()
    {
        _firstNumber = float.Parse(TMP_InputField_firstNumber.text);
        Debug.Log($"_firstNumber = {_firstNumber}");
        _secondNumber = float.Parse(TMP_InputField_secondNumber.text);
        Debug.Log($"_secondNumber = {_secondNumber}");

    }
    public void PlusMethod()
    {
        ParseNumber();
        _answer = _firstNumber + _secondNumber;
        TMP_InputField_Operand.text = " + ";
        TMP_InputField_answer.text = _answer.ToString();
      
    }
    public void MinusMethod()
    {
        ParseNumber();
        _answer = _firstNumber - _secondNumber;
        TMP_InputField_Operand.text = " - ";

        TMP_InputField_answer.text = _answer.ToString();
        
    }
    public void MultiplicationMethod()
    {
        ParseNumber();
        _answer = _firstNumber * _secondNumber;
        TMP_InputField_Operand.text = " * ";

        TMP_InputField_answer.text = _answer.ToString();
        
    }
    public void DivisonMethod()
    {
        ParseNumber();
        _answer = _firstNumber / _secondNumber;
        TMP_InputField_Operand.text = " / ";

        TMP_InputField_answer.text = _answer.ToString();
        
    }
}
