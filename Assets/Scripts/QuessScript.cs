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
    //Было сложно разобраться в этим TMP переменных
    public TextMeshProUGUI hiddenNumber;
    public TMP_InputField inputNumber;

    private void Start()
    {
        //TextMeshPro относится к компоненту Unity и имеет связь 
        //с GameObject и может отображать текст на экране
        //Sting это тип данных не имеет такую привязку
        //и так же не отображает текст
        
        //взаимодействие через .text
        hiddenNumber.text = "Больше или Меньше?";
        _randomNumber = Random.Range(_minValue, _maxValue);
        Debug.Log($"_randomNumber = {_randomNumber}");
    }


    public void CheckYourNumber()
    {
        //Были проблемы с парс методом этот "костыль" можно и без локальной
        //переменной setNumber напрямую выводить 
        //int inputNumberInt = int.Parse(inputNumber.text);
        string setNumber = inputNumber.text;
        int inputNumberInt = int.Parse(setNumber);
        if (inputNumber.text == "")
        {
            //Проверка поля для ввода что введенно что либо
            hiddenNumber.text = "Введите число!";
            //можно добавить проверку на цифры или текст введены в inputbox
        }
        else
        {
            //Проверка числа
            if (inputNumberInt < _randomNumber)
            {
                hiddenNumber.text = "Введенное число меньше загаданного!";
            }
            else if (inputNumberInt > _randomNumber)
            {
                hiddenNumber.text = "Введенное число больше загаданного!";
            }
            else if (inputNumberInt == _randomNumber)
            {
                hiddenNumber.text = "Вы угадали!";
            }
        }
    }
}

