using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns;

public class AppFacade : Facade
{
    private static AppFacade _instance;

    public AppFacade() : base()
    {
    }

    public static AppFacade Instance
    {
        get{
            if (_instance == null) {
                _instance = new AppFacade();
            }
            return _instance;
        }
    }

    public void StartUp()
    {
        SendNotification(FacadeConst.START_UP);
    }

    public void RegisterMultiCommand(SimpleCommand commandClassRef, params string[] notificationName)
    {
        int count = notificationName.Length;
        for (int i = 0; i < count; i++)
        {
            RegisterCommand(notificationName[i], commandClassRef.GetType());
        }
    }

    public void RegisterMultiCommand(System.Type commandType, params string[] notificationName)
    {
        int count = notificationName.Length;
        for (int i = 0; i < count; i++)
        {
            RegisterCommand(notificationName[i], commandType);
        }
    }

    public void RemoveMultiCommand(params string[] notificationName)
    {
        int count = notificationName.Length;
        for (int i = 0; i < count; i++)
        {
            RemoveCommand(notificationName[i]);
        }
    }

    override protected void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(FacadeConst.START_UP, typeof(StartUpCommand));
        RegisterMultiCommand(new ChatCommand(), FacadeConst.SEND_INFO, FacadeConst.SEND_PUBLIC_INFO);
    }
}

