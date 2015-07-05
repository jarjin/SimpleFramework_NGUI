using UnityEngine;
using System.Collections;

public class ChatWindow : MonoBehaviour
{
    public UITextList textList;
    public UIInput mInput;

    void Start()
    {
        AppFacade.Instance.StartUp(); //启动
        AppFacade.Instance.RegisterProxy(new ChatProxy()); //注册聊天委托
        AppFacade.Instance.RegisterMediator(new ChatMediator(this)); //注册Mediator
    }

    public void sendMessageHandler()
    {
        if (textList != null)
        {
            string text = NGUIText.StripSymbols(mInput.value);
            if (!string.IsNullOrEmpty(text))
            {
                mInput.value = "";
                mInput.isSelected = false;
                Debug.Log("UI发送聊天信息：" + text);
                AppFacade.Instance.SendNotification(FacadeConst.SEND_INFO, text);
            }
        }
    }

    public void returnServerHander(string str)
    {
        Debug.Log("来自Mediator的返回，刷新UI界面");
        textList.Add(str);
    }

    public void returnPrivateMsg(object obj)
    {
        Debug.Log(obj);
    }
}
