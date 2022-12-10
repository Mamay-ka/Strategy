using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectableValue;

    private OutlineSelector [] _outlineSelectors;
    private ISelectable _currentSelectable;

    void Start()
    {
        _selectableValue.OnSelected += OnSelected;
    }

    private void OnSelected(ISelectable selectable)
    {
        if(_currentSelectable == selectable)
        {
            return; 
        }

        SetSelected(_outlineSelectors, false);
        _outlineSelectors = null;

        if(selectable != null)
        {
            _outlineSelectors = (selectable as Component).GetComponentsInParent<OutlineSelector>();
            SetSelected(_outlineSelectors, true);
        }
        else
        {
            if(_outlineSelectors != null)
            {
                SetSelected(_outlineSelectors, false);
            }
        }

        _currentSelectable = selectable;

        static void SetSelected(OutlineSelector[] selectors, bool value)
        {
            if(selectors != null)
            {
                for(int i = 0; i < selectors.Length; i++)
                {
                    selectors[i].SetSelected(value);
                }
            }
        }
    }
}
