using System.Collections;
using HoloToolkit.Unity.InputModule;
using HoloToolkitExtensions.Utilities;
using UnityEngine;

public class GuardedClicker : MonoBehaviour, IInputClickHandler
{
    private DoubleClickPreventer _doubleClickPreventer;

    private TextMesh _textMesh;

    private int _clickCounts = 0;
    protected virtual void Start()
    {
        _textMesh = GetComponentInChildren<TextMesh>();
        _doubleClickPreventer = new DoubleClickPreventer(0.5f);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        UpdateClickCount();
    }

    protected virtual void UpdateClickCount()
    {
        if (_doubleClickPreventer.CanClick())
        {
            _textMesh.text = string.Format("Clicks {0}", ++_clickCounts);
        }
    }
}
