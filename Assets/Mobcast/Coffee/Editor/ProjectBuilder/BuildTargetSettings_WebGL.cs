﻿using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Mobcast.Coffee.Build;
using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;


namespace Mobcast.Coffee.Build
{
	[System.Serializable]
	public class BuildTargetSettings_WebGL : IBuildTargetSettings
	{
		public BuildTarget buildTarget{get{ return BuildTarget.WebGL;}}

		public Texture icon{get{ return EditorGUIUtility.FindTexture("BuildSettings.WebGL.Small");}}

		public void Reset(){}

		public void ApplySettings(ProjectBuilder builder){}

		public void DrawSetting(SerializedObject serializedObject){}
	}
}