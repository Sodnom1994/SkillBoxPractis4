using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwoNumberComparer : MonoBehaviour
{
    [SerializeField] private float _firstNumber;
    [SerializeField] private float _secondNumber;
    [SerializeField] private TMP_Text _answer;

    public TMP_InputField _tmpFirstNumber;
    public TMP_InputField _tmpSecondNumber;
    private void Start()
    {
        _answer.text = "Результат...";
    }
    public void Comparer()
    {
        _firstNumber = float.Parse(_tmpFirstNumber.text);
        _secondNumber = float.Parse(_tmpSecondNumber.text);
        //интересно как сделать проверку на число (в случае если в поле пишутся буквы)
        if(_tmpFirstNumber != null && _tmpSecondNumber != null)
        {
            if (_firstNumber < _secondNumber)
            {
                _answer.text = $"Первое число {_firstNumber} меньше второго {_secondNumber}";
            }
            else if (_firstNumber > _secondNumber)
            {
                _answer.text = $"Первое число {_firstNumber} больше второго {_secondNumber}";

            }
            else if (_firstNumber == _secondNumber)
            {
                _answer.text = $"Числа равны";

            }
        }
    }
}
