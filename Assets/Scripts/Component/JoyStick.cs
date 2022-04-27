using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    /* ------------------------------------------ */

    public Image ImgJoyStickBG, ImgJoyStick;

    /* ------------------------------------------ */

    private Vector2 _posInput;

    /* ------------------------------------------ */

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            ImgJoyStickBG.rectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out _posInput
            )) 
        {
            _posInput.x /= ImgJoyStickBG.rectTransform.sizeDelta.x;
            _posInput.y /= ImgJoyStickBG.rectTransform.sizeDelta.y;

            if (_posInput.magnitude > 1.0f) 
            {
                _posInput = _posInput.normalized;
            }

            ImgJoyStick.rectTransform.anchoredPosition =
                new Vector2
                (
                    _posInput.x * ImgJoyStickBG.rectTransform.sizeDelta.x * 0.5f,
                    _posInput.y * ImgJoyStickBG.rectTransform.sizeDelta.y * 0.5f
                );
            Debug.Log(_posInput.x + " /  " + _posInput.y);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ImgJoyStick.rectTransform.anchoredPosition = Vector2.zero;
    }

    /* ------------------------------------------ */

    public float InputHorizontal() 
    {
        if (_posInput.x != 0)
        {
            return _posInput.x;
        }
        else 
        {
            return Input.GetAxis("Horizontal");
        }
    }

    public float InputVertical() 
    {
        if (_posInput.y != 0)
        {
            return _posInput.y;
        }
        else
        {
            return Input.GetAxis("Vertical");
        }
    }

    /* ------------------------------------------ */

}
