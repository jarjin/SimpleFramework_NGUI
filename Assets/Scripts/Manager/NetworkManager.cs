using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;

namespace SimpleFramework.Manager {
    public class NetworkManager : BehaviourBase {
        private static Queue<KeyValuePair<int, ByteBuffer>> sEvents = new Queue<KeyValuePair<int, ByteBuffer>>();

        void Awake() {
            Init();
        }

        void Init() {
            Util.Add<SocketClient>(gameObject);
        }

        public void OnInit() {
            CallMethod("Start");
        }

        public void Unload() {
            CallMethod("Unload");
        }

        /// <summary>
        /// 执行Lua方法
        /// </summary>
        public object[] CallMethod(string func, params object[] args) {
            return Util.CallMethod("Network", func, args);
        }

        ///------------------------------------------------------------------------------------
        public static void AddEvent(int _event, ByteBuffer data) {
            sEvents.Enqueue(new KeyValuePair<int, ByteBuffer>(_event, data));
        }

        void Update() {
            if (sEvents.Count > 0) {
                while (sEvents.Count > 0) {
                    KeyValuePair<int, ByteBuffer> _event = sEvents.Dequeue();
                    switch (_event.Key) {
                        default: CallMethod("OnSocket", _event.Key, _event.Value); break;
                    }
                }
            }
        }

        /// <summary>
        /// 发送链接请求
        /// </summary>
        public void SendConnect() {
            SocketClient.SendConnect();
        }

        /// <summary>
        /// 发送SOCKET消息
        /// </summary>
        public void SendMessage(ByteBuffer buffer) {
            SocketClient.SendMessage(buffer);
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        new void OnDestroy() {
            Debug.Log("~NetworkManager was destroy");
        }
    }
}