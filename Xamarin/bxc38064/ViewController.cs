//
// ViewController.cs
//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using AppKit;
using Foundation;

namespace XMDCSJTest
{
	[DataContract]
	public class SomeContract
	{
	}

	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		partial void GoBoomBoom (NSObject sender)
		{
			new DataContractJsonSerializer (typeof(SomeContract))
				.WriteObject (new MemoryStream (), new SomeContract ());
		}
	}
}