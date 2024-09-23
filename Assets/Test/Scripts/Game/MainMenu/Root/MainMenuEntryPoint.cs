using Assets.Test.Scripts.Game.GameRoot;
using Assets.Test.Scripts.Game.MainMenu.Root.View;
using System;
using UnityEngine;

namespace Assets.Test.Scripts.Game.MainMenu.Root
{
    public class MainMenuEntryPoint : MonoBehaviour
    {
        public event Action GoToGameplayScene;

        [SerializeField] private UIMainMenuRootBinder _sceneUIRootPrefab;

        public void Run(UIRootView uiRoot)
        {
            var uiScene = Instantiate(_sceneUIRootPrefab);
            uiRoot.AttachSceneUI(uiScene.gameObject);

            uiScene.GoToGameplayButtonClicked += () =>
            {
                GoToGameplayScene?.Invoke();

            };
        }
    }
}