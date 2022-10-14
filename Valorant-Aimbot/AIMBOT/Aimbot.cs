﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
 
namespace ValorantColorAimbot
{
    class Program
    {
        //SIZE
        const int xSize = 1920;
        const int ySize = 1080;
 
        //FOV in pixels, smaller fov will result in faster update time
        const int maxX = 1920;
        const int maxY = 100; // If it is set below 50 or more than 120, the screen may crash.
 
        // GAME
        const float speed = 1.2f;
        const int msBetweenShots = 200;
        const int closeSize = 10;
        const bool canShoot = true;
 
        // COLOR
        const int color = 0xaf2eaf; //0xb41515 = Red; 0xaf2eaf = purple //#9999FF = Blue 
        const int colorVariation = 20;
 
        const double size = 60;  // DONT CHANGE
        const int maxCount = 5;
 
        static void Main(string[] args)
        {
            Update();
        }
 
        static void Update()
        {
                     string dllPath = string.Empty;
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "Select your cheat (*.dll)|*.dll";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dllPath = fileDialog.FileName;
                }
                else
                {
                    throw new System.ArgumentNullException("No File selected");
                }
            }

            return dllPath;
        }

 
		namespace ValorantSharp
{
		public class ValorantClient : IAsyncDisposable
	{
			internal AuthConfig authConfig;
			internal ValorantRegion region;
			internal string prefix;

			private readonly ValorantLogger _logger;
			private readonly ValorantAPI _apiClient;
			private readonly ValorantXMPP _xmppClient;
			private readonly CommandService _service = new CommandService();
	
				 private void Form1_Load(object sender, EventArgs e { get; internal set; }

				/// <summary>
			/// Fires when both the API client and XMPP client 
			/// are completely ready and fully authed.
			/// </summary>
			public event Func<AuthResponse, Task> Ready;

					/// <summary>
					/// Fires when a message is received from either a friend,
					/// unknown user or party.
					/// </summary>
					public event Func<ValorantMessage, Task> MessageReceived;

					/// <summary>
					/// Fires when an initial or updated presence
					/// is sent to the client.
					/// </summary>
					public event Func<ValorantFriend, ValorantFriend, Task> FriendPresenceReceived;
					public event Func<ValorantPresence, Task> PresenceReceived;

					/// <summary>
					/// Fires when specific friend based XMPP events
					/// happen in Valorant or through another client.
					/// </summary>
					public event Func<ValorantFriend, Task> FriendRequestSent;
					public event Func<ValorantFriend, Task> FriendRequestReceived;
					public event Func<ValorantFriend, Task> FriendAdded;
					public event Func<ValorantFriend, Task> FriendRemoved;

            unsafe {
                for (int y = 0; y < RegionIn_BitmapData.Height; y++) {
                    byte* row = (byte*)RegionIn_BitmapData.Scan0 + (y * RegionIn_BitmapData.Stride);
                    for (int x = 0; x < RegionIn_BitmapData.Width; x++) {
                        if (row[x * 3] >= (Formatted_Color[0] - Shade_Variation) & row[x * 3] <= (Formatted_Color[0] + Shade_Variation)) //blue
                            if (row[(x * 3) + 1] >= (Formatted_Color[1] - Shade_Variation) & row[(x * 3) + 1] <= (Formatted_Color[1] + Shade_Variation)) //green
                                if (row[(x * 3) + 2] >= (Formatted_Color[2] - Shade_Variation) & row[(x * 3) + 2] <= (Formatted_Color[2] + Shade_Variation)) //red
                                    points.Add(new Point(x + rect.X, y + rect.Y));
                    }
                }
            }
            return (Point[])points.ToArray(typeof(Point));
        } 
    }
}
	
	
public static ManagementObject GetResourceAllocationsettingData(ManagementObject vm, UInt16 resourceType, string resourceSubType, string otherResourceType)
        {
            //vm->vmsettings->RASD for IDE controller
            ManagementObject RASD = null;
            ManagementObjectCollection settingDatas = vm.GetRelated("Msvm_VirtualSystemsettingData");
            foreach (ManagementObject settingData in settingDatas)
            {
                //retrieve the rasd
                ManagementObjectCollection RASDs = settingData.GetRelated("Msvm_ResourceAllocationsettingData");
                foreach (ManagementObject rasdInstance in RASDs)
                {
                    if (Convert.ToUInt16(rasdInstance["ResourceType"]) == resourceType)
                    {
                        //found the matching type
                        if (resourceType == ResourceType.Other)
                        {
                            if (rasdInstance["OtherResourceType"].ToString() == otherResourceType)
                            {
                                RASD = rasdInstance;
                                break;
                            }
                        }
                        else
                        {
                            if (rasdInstance["ResourceSubType"].ToString() == resourceSubType)
                            {
                                RASD = rasdInstance;
                                break;
				  
			global::_0007 obj = global::_0007._007E_0019;
			Guna2TrackBar obj2 = ((_0002)(object)global::_0001._0003._0001)._0001;
			if (0 == 0)
			{
				obj(obj2, 68);
			}
			global::_0007._007E_0019(((_0002)(object)global::_0001._0003._0001)._0004, 50);
			global::_0007._007E_0019(((_0002)(object)global::_0001._0003._0001)._0003, 0);
			global::_0007._007E_0019(((_0002)(object)global::_0001._0003._0001)._0002, -4);
			global::_0007._007E_0019(((global::_0006._0003)(object)global::_0001._0003._0001)._0002, 14);
			global::_0007._007E_0019(((global::_0006._0003)(object)global::_0001._0003._0001)._0001, 28);
			global::_0007._007E_0019(((global::_0008._0001)(object)global::_0001._0003._0001)._0002, 80);
			if (2u != 0)
			{
						   Properties.Settings.Default.ToggleChecked = "False";
							     poisonToggle2.Checked = false;
								    Properties.Settings.Default.Save();
			}
			global::_0007._007E_0019(((global::_0002._0001)(object)global::_0001._0003._0001)._0001, 60);
			global::_0007._007E_0019(((global::_0002._0001)(object)global::_0001._0003._0001)._0003, 0);
			global::_0008._0002._0001(global::_0005._0001._000F(224), global::_0006._0001._0001._0005);
		}
                
