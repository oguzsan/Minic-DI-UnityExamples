// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;
using Minic.DI;
using UnityEngine;


public class Example2 : MonoBehaviour
{
    //  MEMBERS
	public GameObject[] InjectionTargetList;
	private Injector _Injector;
	

    //  METHODS
	void Awake ()
	{
        //  Create injector
		_Injector = new Injector(true);

        //  Add bindings
        //  As long as they are all assignable to binding type you exchange between different implementations of classes. 
        //  This gives you easy way to achieve follwing without touching rest of your code.
        //  - test special cases to find spesific errors
        //  - isolate some part of your programs for easy debugging
        //  - change between different implementation for different platforms or plugins

        //  In this example given implemetation of Setting class is always muted and will not be changed with user input
        _Injector.AddBinding<ISettings>().ToType<Settings_AlwaysMuted>();
        _Injector.AddBinding<IReadonlySettings>().ToType<Settings_AlwaysMuted>();

        //  Iterate all object in list
        foreach (GameObject go in InjectionTargetList)
        {
            MonoBehaviour[] scriptlist = go.GetComponents<MonoBehaviour>();

            //  iterate all scripts
            foreach (MonoBehaviour sc in scriptlist)
            {
                //  Perform injections
                _Injector.InjectInto(sc);
            }
        }
	}
}
