using UnityEngine;
using UnityEngine.UI;

using CookingPrototype.Controllers;

using TMPro;

namespace CookingPrototype.UI {
	public sealed class StartWindow : MonoBehaviour {
		//public Image GoalBar = null;
		public TMP_Text GoalText = null;
		public Button StartButton = null;
		public Button CloseButton = null;

		bool _isInit = false;

		void Init() {
			var gc = GameplayController.Instance;

			StartButton.onClick.AddListener(gc.StartBtn);
			CloseButton.onClick.AddListener(gc.StartBtn);
		}

		public void Show() {
			if ( !_isInit ) {
				Init();
			}

			var gc = GameplayController.Instance;

			GoalText.text = $"{gc.OrdersTarget}";

			gameObject.SetActive(true);
		}

		public void Hide() {
			gameObject.SetActive(false);
		}
	}
}
