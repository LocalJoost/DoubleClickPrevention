using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class SimpleClicker : MonoBehaviour, IInputClickHandler
{
    private TextMesh _textMesh;

    private int _clickCounts = 0;
    protected void Start()
    {
        _textMesh = GetComponentInChildren<TextMesh>();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        UpdateClickCount();
    }

    protected void UpdateClickCount()
    {
        _textMesh.text = string.Format("Clicks {0}", ++_clickCounts);
    }
}
