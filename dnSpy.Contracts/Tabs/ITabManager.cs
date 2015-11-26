﻿/*
    Copyright (C) 2014-2015 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using dnSpy.Contracts.Menus;

namespace dnSpy.Contracts.Tabs {
	/// <summary>
	/// Creates <see cref="ITabGroupManager"/> instances
	/// </summary>
	public interface ITabManager {
		/// <summary>
		/// Gets all <see cref="ITabGroupManager"/> instances
		/// </summary>
		IEnumerable<ITabGroupManager> TabGroupManagers { get; }

		/// <summary>
		/// Creates a new <see cref="ITabGroupManager"/> instance
		/// </summary>
		/// <param name="tabGroupGuid"><see cref="ITabGroup"/> guid, eg. <see cref="MenuConstants.GUIDOBJ_FILES_TABCONTROL_GUID"/></param>
		/// <returns></returns>
		ITabGroupManager Create(Guid tabGroupGuid);

		/// <summary>
		/// Removes a <see cref="ITabGroupManager"/> instance
		/// </summary>
		/// <param name="mgr">Instance to remove</param>
		void Remove(ITabGroupManager mgr);
	}
}