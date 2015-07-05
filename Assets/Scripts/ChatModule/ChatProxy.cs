using PureMVC.Patterns;
using UnityEngine;
using System.Collections.Generic;

public class ChatProxy : Proxy
{
    public static string NAME = "ChatProxy";
    public static ChatProxy instances;
    public ChatProxy() : base(NAME)
    {
        instances = this;
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~发送信息~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public void sendChatMsg(string str)
    {
        Debug.Log("Proxy接收到Command的消息：" + str);
        Debug.Log("发送消息给服务器");   //模拟
        Debug.Log("等待服务器返回");
        Debug.Log("服务器返回信息啦");
        returnSendMsg("Server:" + str);
    }

    /// <summary>
    /// 发送私聊信息
    /// </summary>
    /// <param name="obj"></param>
    public void returnSendMsg(string str)
    {
        Debug.Log("Proxy发送服务端返回信息：" + str);
        SendNotification(FacadeConst.RETURN_SEND_INFO, str);
    }
}
