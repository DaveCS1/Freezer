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
// Generated by IDLImporter from file nsITabParent.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7615408c-1fb3-4128-8dd5-a3e2f3fa8842")]
	internal interface nsITabParent
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InjectTouchEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] uint[] aIdentifiers, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] int[] aXs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] int[] aYs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] uint[] aRxs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] uint[] aRys, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] float[] aRotationAngles, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=8)] float[] aForces, uint count, int aModifiers);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChildProcessOffset(ref int aCssX, ref int aCssY);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUseAsyncPanZoomAttribute();
		
		/// <summary>
        /// Manages the docshell active state of the remote browser.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDocShellIsActiveAttribute();
		
		/// <summary>
        /// Manages the docshell active state of the remote browser.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocShellIsActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aDocShellIsActive);
		
		/// <summary>
        /// As an optimisation, setting the docshell's active state to
        /// inactive also triggers a layer invalidation to free up some
        /// potentially unhelpful memory usage. This attribute should be
        /// used where callers would like to set the docshell's state
        /// without losing any layer data.
        ///
        /// Otherwise, this does the same as setting the attribute above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocShellIsActiveAndForeground([MarshalAs(UnmanagedType.U1)] bool aIsActive);
		
		/// <summary>
        /// During interactions where painting performance
        /// is more important than scrolling, we may temporarily
        /// suppress the displayport. Each enable called must be matched
        /// with a disable call.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuppressDisplayport([MarshalAs(UnmanagedType.U1)] bool aEnabled);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTabIdAttribute();
		
		/// <summary>
        /// Navigate by key. If aForDocumentNavigation is true, navigate by document.
        /// If aForDocumentNavigation is false, navigate by element.
        ///
        /// If aForward is true, navigate to the first focusable element or document.
        /// If aForward is false, navigate to the last focusable element or document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NavigateByKey([MarshalAs(UnmanagedType.U1)] bool aForward, [MarshalAs(UnmanagedType.U1)] bool aForDocumentNavigation);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasContentOpenerAttribute();
	}
}