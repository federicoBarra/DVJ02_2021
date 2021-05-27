using UnityEngine;
using UnityEngine.EventSystems;

namespace DVJ02.Semana10
{
	public class UIDraggableImage : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
	{
		//https://docs.unity3d.com/ScriptReference/EventSystems.PointerEventData.html
		public void OnBeginDrag(PointerEventData eventData)
		{
			//https://docs.unity3d.com/ScriptReference/EventSystems.PointerEventData-position.html
			Debug.Log("OnBeginDrag: " + eventData.position);
		}

		public void OnEndDrag(PointerEventData eventData)
		{
			Debug.Log("OnEndDrag: " + eventData.position);
		}

		public void OnDrag(PointerEventData eventData)
		{
			Debug.Log("OnDrag: " + eventData.delta);
		}
	}
}
