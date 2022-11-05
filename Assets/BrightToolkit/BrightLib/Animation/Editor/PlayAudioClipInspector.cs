using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace BrightLib.Animation
{
    [CustomEditor(typeof(PlayAudioClip))]
    public class PlayAudioClipInspector : Editor 
    {
        public override void OnInspectorGUI () 
        {
            // DrawDefaultInspector();
            var tObject = (target as PlayAudioClip);

            tObject.useMultiple = EditorGUILayout.Toggle("Use Multiple", tObject.useMultiple);
            if(!tObject.useMultiple)
            {
                tObject.clip = (AudioClip)EditorGUILayout.ObjectField("Clip", tObject.clip, typeof(AudioClip));
            }
            else 
            {
                var prop = serializedObject.FindProperty("clips");
                EditorGUILayout.PropertyField(prop, true);
            }

            tObject.delay = EditorGUILayout.FloatField("Delay", tObject.delay);
            tObject.condition = (PlayCondition)EditorGUILayout.EnumPopup("Condition", tObject.condition);
            if(tObject.condition == PlayCondition.OnUpdate)
            {
                EditorGUI.indentLevel++;
                tObject.onUpdateInterval = EditorGUILayout.FloatField("Frequency", tObject.onUpdateInterval);
                EditorGUI.indentLevel--;
            }
            
            serializedObject.ApplyModifiedProperties();
        }
    }
}