using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VRC.SDK3.Components;

namespace gay.lvna.common.udon.editor
{
    [CustomEditor(typeof(VRCObjectPool))]
    public class AutoObjectPool : Editor
    {

        public override void OnInspectorGUI()
        {
            VRCObjectPool objectPool = (VRCObjectPool)target;
            if (objectPool == null) return;

            DrawDefaultInspector();
            EditorGUILayout.Separator();
            EditorGUILayout.LabelField("LvnCommon", EditorStyles.boldLabel);
            if (GUILayout.Button("Auto Fill Pool"))
            {


                GameObject[] objects = new GameObject[objectPool.transform.childCount];
                int i = 0;
                foreach (Transform trans in objectPool.transform.GetComponentInChildren<Transform>())
                {
                    if (trans == objectPool.transform) continue;
                    objects[i] = trans.gameObject;
                    i++;
                }

                objectPool.Pool = objects;
            }
        }
    }
}
