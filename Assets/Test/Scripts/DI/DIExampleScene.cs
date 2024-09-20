using DI;
using System.Collections;
using UnityEngine;

namespace Assets.Test.Scripts.DI
{
    public class DIExampleScene : MonoBehaviour
    {

        public void Init(DIContainer projectContainer)
        {
            var serviceWithoutTag = projectContainer.Resolve<MyAwesomeProjectService>();
            var service1 = projectContainer.Resolve<MyAwesomeProjectService>("options1");
            var service2 = projectContainer.Resolve<MyAwesomeProjectService>("options2");

            var sceneRoot = FindObjectOfType<DIExampleScene>();
            sceneRoot.Init(projectContainer);
        }
    }
}