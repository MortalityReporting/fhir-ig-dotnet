﻿using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Cbs.Extensions
{
    public static class FhirProfile
    {
        /// <summary>
        /// Set the assertion that a resource object conforms to the given profile.
        /// </summary>
        public static void AddProfile(this Resource resource, string profileUrl)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            if (resource.Meta == null)
            {
                resource.Meta = new Meta();
            }

            if ((resource.Meta.Profile == null) || (!resource.Meta.Profile.Any()))
            {
                resource.Meta.Profile = new List<string>()
                    {
                      profileUrl,
                    };
                return;
            }

            if (resource.Meta.Profile.Contains(profileUrl))
            {
                return;
            }

            resource.Meta.Profile = resource.Meta.Profile.Append(profileUrl);
        }


        /// <summary>
        /// Clear the assertion that a patient object conforms to the US Core Patient Profile.
        /// </summary>
        public static void RemoveProfile(this Resource resource, string profileUrl)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            if (resource.Meta == null)
            {
                return;
            }

            // set last updated so that meta is never empty
            resource.Meta.LastUpdated = DateTimeOffset.Now;

            if ((resource.Meta.Profile == null) || (!resource.Meta.Profile.Any()))
            {
                return;
            }

            if (resource.Meta.Profile.Contains(profileUrl))
            {
                int index = 0;
                foreach (var profile in resource.Meta.Profile)
                {
                    if (profile.Equals(profileUrl, StringComparison.Ordinal))
                    {
                        break;
                    }

                    index++;
                }

                resource.Meta.ProfileElement.RemoveAt(index);
            }
        }

        public static void AddOrUpdateExtension(this List<Extension> extensions, Extension extension)
        {
            var ext = extensions.Find(e => e.Url == extension.Url);
            if (ext != null)
                extensions.Remove(ext);

            extensions.Add(extension);
        }

        public static void AddOrUpdateExtension(this List<Extension> extensions, string url, DataType value)
        {
            extensions.AddOrUpdateExtension(new Extension(url, value));
        }
    }
}