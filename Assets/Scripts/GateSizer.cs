using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}
public class GateSizer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    // »конки увеличение и уменьшени€ ширны
    [SerializeField] GameObject _expandLable;
    [SerializeField] GameObject _shrinkLable;
    // »конки увеличени€ и уменьшени€ высоты
    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLable;

    public void UpdateVisual(DeformationType deformationType, int value)
    {
        string prefix = "";

        if (value >= 0)
        {
            prefix = "+";
            SetColor(_colorPositive);
        }
        else
        {
            SetColor(_colorNegative);
        }

        _text.text = prefix + value.ToString();

        _expandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);

        if (deformationType == DeformationType.Width)
        {
            if (value >=0)
            {
                _expandLable.SetActive(true);

            }
            else
            {
                _shrinkLable.SetActive(true);

            }
        }
        else if (deformationType == DeformationType.Height)
        {
            if (value >= 0)
            {
                _upLable.SetActive(true);

            }
            else
            {
                _downLable.SetActive(true);

            }
        }
    }

    void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.8f);

    }
}
