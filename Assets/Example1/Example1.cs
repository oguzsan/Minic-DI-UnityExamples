using System;
using Minic.DI;
using UnityEngine;


public class Example1 : MonoBehaviour
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

        //  Usage 1 : Bind to type; all bindings to same type will receive same instance when injected.
        //  You can use this when you want the object to be instantiated when it is first needed.
        _Injector.AddBinding<ISettings>().ToType<Settings>();
        _Injector.AddBinding<IReadonlySettings>().ToType<Settings>();

        //  Usage 2 : Bind to value; all bindings to same value will receive this instance when injected.
        //  You can use this when you want to use an already instantiated object.
        //Settings settings = new Settings();
        //settings.SetSoundVolume(0.2f);
        //settings.ToggleMusic();
        //_Injector.AddBinding<ISettings>().ToValue(settings);
        //_Injector.AddBinding<IReadonlySettings>().ToValue(settings);

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
