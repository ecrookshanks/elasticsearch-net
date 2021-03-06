// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Runtime.Serialization;

namespace Nest
{

	public class GetBasicLicenseStatusResponse : ResponseBase
	{
		[DataMember(Name = "eligible_to_start_basic")]
		public bool EligableToStartBasic { get; internal set; }
	}

}
