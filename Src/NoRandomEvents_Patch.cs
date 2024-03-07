using HarmonyLib;
using Parkitect.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace NoRandomEvents {
	[HarmonyPatch]
	public class NoRandomEvents_Patch_RandomEventManager_triggerNewEvent {
		static MethodBase TargetMethod() => AccessTools.Method(typeof(RandomEventManager), "triggerNewEvent");

		[HarmonyPrefix]
		public static bool Prefix() {
			return false;
		}
	}
}
