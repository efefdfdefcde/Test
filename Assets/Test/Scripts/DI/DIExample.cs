﻿using DI;
using System.Collections;
using UnityEngine;

namespace Assets.Test.Scripts.DI
{
    public class MyAwesomeProjectService { }

    public class MySceneService
    {
        private readonly MyAwesomeProjectService _myAwesomeProjectService;
        public MySceneService(MyAwesomeProjectService myAwesomeProjectService)
        {
            _myAwesomeProjectService = myAwesomeProjectService;
        }
    }

    public class MyAwesomeFactory
    {
        public MyAwesomeObject CreateInstance(string id, int par1)
        {
            return new MyAwesomeObject(id, par1);
        }
    }

    public class MyAwesomeObject
    {
        private readonly string _id;
        private readonly int _par1;

        public MyAwesomeObject(string id, int par1)
        {
            _id = id;
            _par1 = par1;
        }
    }

    public class DIExample : MonoBehaviour
    {

        private void Awake()
        {
            var projectContainer = new DIContainer();
            projectContainer.RegisterSingleton(_ => new MyAwesomeProjectService());
            projectContainer.RegisterSingleton("option1",_ => new MyAwesomeProjectService());
            projectContainer.RegisterSingleton("option2", _ => new MyAwesomeProjectService());
        }

    }
}