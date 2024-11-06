using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string message;

    //=======================================For GameObjects==================
    /*private void OnMouseEnter()
    {
        ToolTipManager._instance.SetAndShowToolTip(message);
    }

    private void OnMouseExit()
    {
        ToolTipManager._instance.HideToolTip();
    }*/
    //=======================================For Buttons=========================
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        ToolTipManager._instance.SetAndShowToolTip(message);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        ToolTipManager._instance.HideToolTip();
    }
}
