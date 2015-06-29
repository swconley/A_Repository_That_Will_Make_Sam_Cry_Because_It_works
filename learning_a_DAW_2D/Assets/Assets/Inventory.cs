using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Inventory : MonoBehaviour,IHasChanged {
	[SerializeField] Transform Slot;
	[SerializeField] Text inventoryText;
	[SerializeField] AudioClip[] g;//
	
	// Use this for initialization
	void Start () {
		HasChanged ();
	}
	
	#region IHasChanged implementation
	public void HasChanged ()
	{
		System.Text.StringBuilder builder = new System.Text.StringBuilder ();
		builder.Append (" ");
		foreach (Transform slotTransform in Slot) {
			GameObject item = slotTransform.GetComponent<Slot>().item;
			if(item){
				builder.Append (item.name);
				builder.Append (" ");
			}
		}
		inventoryText.text = builder.ToString ();
		//if (builder.ToString () == "guitar") {
			int x;
			x = 1;
			PlayNote (x);
			//PlayNote ();
		//}

	}
	#endregion

	void PlayNote(int x){
		AudioSource.PlayClipAtPoint(g[x], transform.position); ////////////
		GetComponent<AudioSource>().Play();
	}
	
}

namespace UnityEngine.EventSystems{
	public interface IHasChanged:IEventSystemHandler{
		void HasChanged();
	}
}
