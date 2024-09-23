using System;
using System.Collections;
using UnityEngine;

namespace Assets.Test.Scripts.Game.MainMenu.Root.View
{
    public class UIMainMenuRootBinder : MonoBehaviour
    {

        public event Action GoToGameplayButtonClicked;

        public void HandleGoToGameplayButtonClick()
        {
            GoToGameplayButtonClicked?.Invoke();
        }
    }
}