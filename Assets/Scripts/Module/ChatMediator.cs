using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
using UnityEngine;

public class ChatMediator : Mediator
{
    public const string NAME = "chatMediator";
    public ChatMediator(object viewComponent) : base(NAME, viewComponent)
    {
    }

    public ChatWindow getView()
    {
        return ViewComponent as ChatWindow;
    }

    override public IList<string> ListNotificationInterests()
    {
        return new List<string>()
        { 
            NotiConst.RETURN_SEND_INFO,
            NotiConst.RETURN_PUBLIC_INFO,
        };
    }

    override public void HandleNotification(INotification notification)
    {
        string name = notification.Name;
        object body = notification.Body;
        switch (name)
        {
            case NotiConst.RETURN_SEND_INFO:
                Debug.Log("Mediator接收来自Proxy的服务端返回" + body.ToString());
                getView().returnServerHander(body.ToString());
            break;
            case NotiConst.RETURN_PUBLIC_INFO:
                getView().returnPrivateMsg(body);
            break;
        }
    }
}
