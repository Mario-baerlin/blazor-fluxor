﻿namespace Blazor.Fluxor.Routing
{
	/// <summary>
	/// Dispatching this action will navigate the browser to the specified URL
	/// </summary>
	/// <seealso cref="Microsoft.AspNetCore.Blazor.Services.IUriHelper"/>
	public class Go: IAction
	{
		/// <summary>
		/// The new address to navigate to
		/// </summary>
		public string NewUri { get; private set; }

		/// <summary>
		/// Creates a new instance of the action
		/// </summary>
		/// <param name="newUri"></param>
		public Go(string newUri)
		{
			NewUri = newUri;
		}
	}
}
