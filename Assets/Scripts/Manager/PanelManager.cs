using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SimpleFramework.Manager {
    public class PanelManager : BehaviourBase {
        private Transform parent;

        Transform Parent {
            get {
                if (parent == null) {
                    GameObject go = GameObject.FindWithTag("GuiCamera");
                    if (go != null) parent = go.transform;
                }
                return parent;
            }
        }

        /// <summary>
        /// 创建面板，请求资源管理器
        /// </summary>
        /// <param name="type"></param>
        public void CreatePanel(string name) {
            AssetBundle bundle = ResManager.LoadBundle(name);
            StartCoroutine(StartCreatePanel(name, bundle, string.Empty));
            Debug.LogWarning("CreatePanel::>> " + name + " " + bundle);
        }

        /// <summary>
        /// 创建面板
        /// </summary>
        IEnumerator StartCreatePanel(string name, AssetBundle bundle, string text = null) {
            name += "Panel";
            GameObject prefab = Util.LoadAsset(bundle, name);
            yield return new WaitForEndOfFrame();
            if (Parent.FindChild(name) != null || prefab == null) {
                yield break;
            }
            GameObject go = Instantiate(prefab) as GameObject;
            go.name = name;
            go.layer = LayerMask.NameToLayer("Default");
            go.transform.parent = Parent;
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;

            yield return new WaitForEndOfFrame();
            go.AddComponent<LuaBehaviour>().OnInit(bundle);

            Debug.Log("StartCreatePanel------>>>>" + name);
        }
    }
}