using UnityEditor;
using UnityEngine;
using System;
using UnityEngine.Events;

[CustomEditor(typeof(MethodCaller))]
public class MethodCallerEditor: Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		MethodCaller methodCaller = target as MethodCaller;

		GUILayout.Box("If you want to call methods at editor time, change the EventCallState to EditorAndRuntime.");

		if( methodCaller.call != null && GUILayout.Button( "Run" , GUILayout.Width(64)) )
		{
			methodCaller.call.Invoke( );
		}
		
		if( GUI.changed )
		{
			EditorUtility.SetDirty( target );
		}

	}
}