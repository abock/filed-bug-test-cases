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
		[DataMember]
		public Guid Guid { get; set; }
	}

	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		partial void GoBoomBoom (NSObject sender)
		{
			var expected = new SomeContract { Guid = Guid.NewGuid () };

			var stream = new MemoryStream ();
			var serializer = new DataContractJsonSerializer (expected.GetType ());

			serializer.WriteObject (stream, expected);
			stream.Position = 0;
			var actual = (SomeContract)serializer.ReadObject (stream);

			if (expected.Guid != actual.Guid)
				throw new Exception (
					$"actual SomeContract.Guid ({actual.Guid}) does " +
					$"not equal expected ({expected.Guid})");

			((NSButton)sender).Title = "😃 IT WORKS 😃";
		}
	}
}