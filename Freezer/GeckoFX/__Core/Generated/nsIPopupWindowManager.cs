// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIPopupWindowManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// This is the interface to the Popup Window Manager: an object which
    /// maintains popup window permissions by website.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("66386aa9-2088-4bae-82c7-9f58bc02be64")]
	internal interface nsIPopupWindowManager
	{
		
		/// <summary>
        /// Test whether a website has permission to show a popup window.
        /// @param   principal is the principal to be tested
        /// @return  one of the enumerated permission actions defined above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint TestPermission([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal);
	}
	
	/// <summary>nsIPopupWindowManagerConsts </summary>
	internal class nsIPopupWindowManagerConsts
	{
		
		// <summary>
        // These values are returned by the testPermission method
        // </summary>
		public const long ALLOW_POPUP = 1;
		
		// 
		public const long DENY_POPUP = 2;
		
		// 
		public const long ALLOW_POPUP_WITH_PREJUDICE = 3;
	}
}