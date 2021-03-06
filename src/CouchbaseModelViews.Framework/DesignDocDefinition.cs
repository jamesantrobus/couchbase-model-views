﻿#region [ License information          ]
/* ************************************************************
 * 
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2012 Couchbase, Inc.
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchbaseModelViews.Framework
{
	public class DesignDocDefinition
	{
		/// <summary>
		/// Name of view
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Used for type checking to filter documents
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// When true, include null index/value for given type
		/// </summary>
		public bool ShouldIncludeAllView { get; set; }

		private List<ViewDefinition> _views = new List<ViewDefinition>();

		/// <summary>
		/// List of view names and key properties
		/// </summary>
		public IList<ViewDefinition> Views { get { return _views; } }

		private List<SpatialViewDefinition> _spatialViews = new List<SpatialViewDefinition>();

		/// <summary>
		/// List of spatial view names and coordinate properties
		/// </summary>
		public IList<SpatialViewDefinition> SpatialViews { get { return _spatialViews; } }

		private List<CollatedViewDefinition> _collatedViews = new List<CollatedViewDefinition>();

		/// <summary>
		/// List of spatial view names and coordinate properties
		/// </summary>
		public IList<CollatedViewDefinition> CollatedViews { get { return _collatedViews; } }
	}
}
