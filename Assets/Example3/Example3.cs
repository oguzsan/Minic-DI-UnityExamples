// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;
using Minic.DI;
using Minic.DI.Error;
using UnityEngine;


public class Example3 : MonoBehaviour
{
    //  MEMBERS
	public GameObject[] InjectionTargetList;
	private Injector _Injector;
	

    //  METHODS
	void Awake ()
    {
        //  Create injector
        //  When an error occures injector creates an error data stores it in a list and optionally thorws an exception with this error.
        //  Only parameter in constructor indicates if injector should throw this exceptions.
        //  You can alternatively disable exceptions and individually check for errors after every binding and injection
        _Injector = new Injector(true);

        try
        {
            //  Add bindings
            //  Wrong binding: object does not implement ISettings interface
            _Injector.AddBinding<ISettings>().ToValue( new object());
            //  Missing binding: IReadonlySettings is never bind

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
        catch (InjectionException e)
        {
            Debug.Log(e.Message);
            Debug.Break();
        }

    }
    
}
