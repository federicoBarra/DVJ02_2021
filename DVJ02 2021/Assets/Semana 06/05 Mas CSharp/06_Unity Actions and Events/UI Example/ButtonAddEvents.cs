using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Semana06
{
	public class ButtonAddEvents : MonoBehaviour
	{
		public Button button;

		void Start()
		{
			button.onClick.AddListener(ButtonClicked);
			button.onClick.AddListener(() => ButtonClickedParam(5)); //caso aceptable de uso de lambda exp o métodos anónimos.
		}

		public void ButtonClicked()
		{
			Debug.Log("ButtonClickedd");
		}

		public void ButtonClickedParam(int i)
		{
			Debug.Log("ButtonClickedd " + i);
		}
	}
}