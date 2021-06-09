using UnityEngine;
using UnityEngine.EventSystems;

namespace DVJ02.Semana10
{
	public class UISpecialButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler
	{
		public GameObject tooltip;
		public bool isOver;

		public Vector3 mainOffset = new Vector2(0, -10);

		void Start()
		{
			//GetComponent<RectTransform>();
		}

		// Update is called once per frame
		private void Update()
		{
			if (!isOver)
				return;

			Vector3 offset = Input.mousePosition - transform.position;

			tooltip.transform.position = transform.position + offset + mainOffset;
			//Debug.Log(Input.mousePosition);
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			tooltip.SetActive(true);
			isOver = true;
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			isOver = false;
			tooltip.SetActive(false);
		}

	    public void OnBeginDrag(PointerEventData eventData)
	    {
	        //throw new System.NotImplementedException();
	    }
	}
}
