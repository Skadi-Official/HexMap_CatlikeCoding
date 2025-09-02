using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HexMapEditor : MonoBehaviour
{
    public Color[] colors;

    public HexGrid hexGrid;

    private Color activeColor;

    private void Awake()
    {
        SelectColor(0);
    }

    private void Update()
    {
        // 按下鼠标且检测鼠标没有在 UI 元素上
        if (Input.GetMouseButton(0) && 
            !EventSystem.current.IsPointerOverGameObject())
        {
            HandleInput();
        }
    }

    void HandleInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            hexGrid.ColorCell(hit.point, activeColor);
        }
    }

    public void SelectColor(int index)
    {
        activeColor = colors[index];
    }
}
