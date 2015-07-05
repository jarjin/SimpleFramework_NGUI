using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class InitProxyCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);
    }
}
