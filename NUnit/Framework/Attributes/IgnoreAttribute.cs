// Copyright (C) 2014 dot42
//
// Original filename: IgnoreAttribute.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ****************************************************************
// This is free software licensed under the NUnit license. You
// may obtain a copy of the license as well as information regarding
// copyright ownership at http://nunit.org.
// ****************************************************************

namespace NUnit.Framework
{
	using System;

	/// <summary>
	/// Attribute used to mark a test that is to be ignored.
	/// Ignored tests result in a warning message when the
	/// tests are run.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method|AttributeTargets.Class|AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
	public class IgnoreAttribute : Attribute
	{
		private string reason;

		/// <summary>
		/// Constructs the attribute without giving a reason 
		/// for ignoring the test.
		/// </summary>
		public IgnoreAttribute()
		{
			this.reason = "";
		}

		/// <summary>
		/// Constructs the attribute giving a reason for ignoring the test
		/// </summary>
		/// <param name="reason">The reason for ignoring the test</param>
		public IgnoreAttribute(string reason)
		{
			this.reason = reason;
		}

		/// <summary>
		/// The reason for ignoring a test
		/// </summary>
		public string Reason
		{
			get { return reason; }
		}
	}
}
