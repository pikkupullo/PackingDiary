package md5c38085f4321e2a5351e9dbcd497ea332;


public class MainActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_SwitchClick:(Landroid/view/View;)V:__export__\n" +
			"n_SaveClick:(Landroid/view/View;)V:__export__\n" +
			"n_ClearClick:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("PackingDiary.MainActivity, PackingDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("PackingDiary.MainActivity, PackingDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void switchClick (android.view.View p0)
	{
		n_SwitchClick (p0);
	}

	private native void n_SwitchClick (android.view.View p0);


	public void saveClick (android.view.View p0)
	{
		n_SaveClick (p0);
	}

	private native void n_SaveClick (android.view.View p0);


	public void clearClick (android.view.View p0)
	{
		n_ClearClick (p0);
	}

	private native void n_ClearClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
