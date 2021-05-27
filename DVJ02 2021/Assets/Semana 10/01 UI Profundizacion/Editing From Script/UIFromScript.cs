using UnityEngine;

namespace DVJ02.Semana10
{
	public class UIFromScript : MonoBehaviour
	{
		public Transform enemy;
		public RectTransform thisRT;

		// Start is called before the first frame update
		private void Start()
		{
			thisRT = GetComponent<RectTransform>();
		}

		// Update is called once per frame
		private void Update()
		{
			//https://docs.unity3d.com/ScriptReference/RectTransform.html
			thisRT.position = Camera.main.WorldToScreenPoint(enemy.position);
		}
	}
}