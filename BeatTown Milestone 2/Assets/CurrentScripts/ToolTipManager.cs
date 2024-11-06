using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolTipManager : MonoBehaviour
{

    public static ToolTipManager _instance; // Singleton instance of the tooltip manager

    public TextMeshProUGUI textComponent; // The text component of the tooltip (drag in text box for relevant tooltip)

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowToolTip(string messsage)
    {
        gameObject.SetActive(true);
        textComponent.text = messsage;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}
