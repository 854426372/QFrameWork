using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDrag : MonoBehaviour, IDragHandler, IPointerDownHandler
{
	private Vector2 offsetPos;  //临时记录点击点与UI的相对位置

	private float rangeX;
	private float rangeY;
	private RectTransform currentRect;

	private RectTransform canvasRect;
	void Start()
	{
		currentRect = GetComponent<RectTransform>();
		canvasRect = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<RectTransform>();
		Debug.Log(UnityEngine.Screen.width + "宽");
		Debug.Log(UnityEngine.Screen.height + "高");
		rangeX = canvasRect.rect.width / 2 - currentRect.rect.width / 2;
		rangeY = canvasRect.rect.height / 2 - currentRect.rect.height / 2;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.localPosition = eventData.position - offsetPos;
		transform.localPosition = DragRangeLimit(transform.localPosition);
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		offsetPos = eventData.position - (Vector2)transform.localPosition;
	}


	// 限制坐标范围
	Vector3 DragRangeLimit(Vector3 pos)
	{
		pos.x = Mathf.Clamp(pos.x, -rangeX, rangeX);
		pos.y = Mathf.Clamp(pos.y, -rangeY, rangeY);
		return pos;
	}


}
