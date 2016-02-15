//
// HttpResponseMessageProperty.cs
//
// Author: Atsushi Enomoto (atsushi@ximian.com)
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Net;
using System.ServiceModel;

namespace System.ServiceModel.Channels
{
	public sealed class HttpResponseMessageProperty
		: IMessageProperty
	{
		public static string Name {
			get { return "httpResponse"; }
		}

		WebHeaderCollection headers = new WebHeaderCollection ();
		string status_desc;
		HttpStatusCode status_code;
		bool suppress_entity;

		public HttpResponseMessageProperty ()
		{
		}

		public WebHeaderCollection Headers {
			get { return headers; }
		}

		public HttpStatusCode StatusCode {
			get { return status_code; }
			set { status_code = value; }
		}

		public string StatusDescription {
			get { return status_desc; }
			set { status_desc = value; }
		}

		public bool SuppressEntityBody {
			get { return suppress_entity; }
			set { suppress_entity = value; }
		}

		[MonoTODO]
		public bool SuppressPreamble {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
		
		IMessageProperty IMessageProperty.CreateCopy ()
		{
			var copy = new HttpResponseMessageProperty ();
			// FIXME: Clone headers?
			copy.headers = headers;
			copy.status_desc = status_desc;
			copy.status_code = status_code;
			copy.suppress_entity = suppress_entity;
			return copy;
		}
	}
}
