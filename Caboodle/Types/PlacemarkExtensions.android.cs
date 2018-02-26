﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Caboodle
{
	public static partial class PlacemarkExtensions
	{

		internal static IEnumerable<Placemark> ToPlacemarks(this IEnumerable<Android.Locations.Address> addresses)
		{
			return addresses.Select(address => new Placemark
			{
				Location = address.ToLocation(),
				FeatureName = address.FeatureName,
				PostalCode = address.PostalCode,
				SubLocality = address.SubLocality,
				CountryCode = address.CountryCode,
				CountryName = address.CountryName,
				Thoroughfare = address.Thoroughfare,
				SubThoroughfare = address.SubThoroughfare,
				Locality = address.Locality,
				AdminArea = address.AdminArea,
				SubAdminArea = address.SubAdminArea
			});
		}
	}
}
