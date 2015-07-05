using UnityEngine;
using System.Collections;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class ChatCommand : SimpleCommand
{
    private ChatProxy proxy;
    public override void Execute(INotification notification)
    {
        object body = notification.Body;
        string name = notification.Name;
        if (proxy == null)
        {
            proxy = Facade.RetrieveProxy(ChatProxy.NAME) as ChatProxy;
        }
        switch (name)
        {
            case FacadeConst.SEND_INFO:
                Debug.Log("Command接收到UI的请求：" + body.ToString());
                proxy.sendChatMsg(body.ToString());
            break;
            case FacadeConst.SEND_PRIVATE_INFO:
            break;
        }
    }
}
