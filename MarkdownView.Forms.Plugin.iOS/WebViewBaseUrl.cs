﻿using Foundation;
using ViewMarkdown.Forms.Plugin.Abstractions;
using ViewMarkdown.Forms.Plugin.iOS;
using Xamarin.Forms;

namespace ViewMarkdown.Forms.Plugin.iOS
{


	public class WebViewBaseUrl : IWebViewBaseUrl
	{
		#region IWebViewBaseUrl implementation
		public string Url {
			get {
				return Foundation.NSBundle.MainBundle.BundlePath + "/";
			}
		}
		#endregion
	}
}

