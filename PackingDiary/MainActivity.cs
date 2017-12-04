using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace PackingDiary
{
    [Activity(Label = "Pakkaustarkastus", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ///////////////////////////////////////////////////////
        ///
        /// <summary>
        /// OnCreate method.
        /// </summary>
        ///
        ///////////////////////////////////////////////////////
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        ///////////////////////////////////////////////////////
        ///
        /// <summary>
        /// Click handler for all of the switches.
        /// </summary>
        ///
        ///////////////////////////////////////////////////////
        [Java.Interop.Export("switchClick")]
        public void SwitchClick(View view)
        {
            try
            {
                if (FindViewById<Switch>(Resource.Id.switchBagCheck).Checked &&
                    FindViewById<Switch>(Resource.Id.switchHD).Checked &&
                    FindViewById<Switch>(Resource.Id.switchSlider).Checked &&
                    FindViewById<Switch>(Resource.Id.switchLoopCheck).Checked)
                {
                    FindViewById<Button>(Resource.Id.buttonSave).Enabled = true;
                }
                else
                {
                    FindViewById<Button>(Resource.Id.buttonSave).Enabled = false;
                }
            }
            catch (System.Exception x)
            {
                Alert("Switch click failed!", "An exception occurred in the switch click: " + x.ToString());
            }
        }

        ///////////////////////////////////////////////////////
        ///
        /// <summary>
        /// Click handler for all of the switches.
        /// </summary>
        ///
        ///////////////////////////////////////////////////////
        [Java.Interop.Export("saveClick")]
        public void SaveClick(View view)
        {
            try
            {

            }
            catch (System.Exception x)
            {
                Alert("Save click failed!", "An exception occurred in the save click: " + x.ToString());
            }
        }

        ///////////////////////////////////////////////////////
        ///
        /// <summary>
        /// Click handler for all of the switches.
        /// </summary>
        ///
        ///////////////////////////////////////////////////////
        [Java.Interop.Export("clearClick")]
        public void ClearClick(View view)
        {
            try
            {
                FindViewById<Switch>(Resource.Id.switchBagCheck).Checked = false;
                FindViewById<Switch>(Resource.Id.switchHD).Checked = false;
                FindViewById<Switch>(Resource.Id.switchSlider).Checked = false;
                FindViewById<Switch>(Resource.Id.switchLoopCheck).Checked = false;

                FindViewById<Button>(Resource.Id.buttonSave).Enabled = false;
            }
            catch (System.Exception x)
            {
                Alert("Clear click failed!", "An exception occurred in the clear click: " + x.ToString());
            }
        }

        ///////////////////////////////////////////////////////
        ///
        /// <summary>
        /// Alert dialog creator.
        /// </summary>
        ///
        ///////////////////////////////////////////////////////
        private void Alert(string title, string text)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle(title);
            alert.SetMessage(text);
            alert.SetNeutralButton("OK", (senderAlert, args) => {}); // No action needed, lambda is empty.
            Dialog dialog = alert.Create();
            dialog.Show();
        }
    }
}

