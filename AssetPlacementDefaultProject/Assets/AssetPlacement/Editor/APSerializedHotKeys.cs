//This code is generated dynamically. Don't edit here
//Edit at APChoiceSystem.cs line: 195
using UnityEditor; 
using UnityEngine; 

public class APSerializedHotKeys : EditorWindow {
	static void RefreshSelectedKey (KeyCode hotkeyCode) {
		if (hotkeyCode != KeyCode.None) {
			int index = 0;
			foreach (var assetData in APChoiceSystem.instance.assetList) {
				if(APChoiceSystem.instance.getSelectedTab().name == assetData.tab) {
					if (assetData.keyCode == hotkeyCode) {
						EditorPrefs.SetInt (APGlobals.SelectedAssetNumber, index);
						EditorPrefs.SetInt (APGlobals.SelectedKey, (int)hotkeyCode);

						if(APChoiceSystem.instance) {
							APChoiceSystem.instance.OnDrawGizmos();
						}

						return;
					}
				}
			index++;
			}
		}
	}

	[MenuItem( APGlobals.CommandPath + "Hot Keys/Alpha1 &_Alpha1")]
	public static void SelectItemAlpha1() {
		EditorPrefs.SetInt (APGlobals.SelectedKey, (int)KeyCode.Alpha1); 
		EditorPrefs.SetInt (APGlobals.SelectedAssetNumber, APGlobals.HotKeySelectionEnabled);
		RefreshSelectedKey(KeyCode.Alpha1);
	}


	[MenuItem( APGlobals.CommandPath + "Hot Keys/None &_None")]
	public static void SelectItemNone() {
		EditorPrefs.SetInt (APGlobals.SelectedKey, (int)KeyCode.None); 
		EditorPrefs.SetInt (APGlobals.SelectedAssetNumber, APGlobals.HotKeySelectionEnabled);
		RefreshSelectedKey(KeyCode.None);
	}

}