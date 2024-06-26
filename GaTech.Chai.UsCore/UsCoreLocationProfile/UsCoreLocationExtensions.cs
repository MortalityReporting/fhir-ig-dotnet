﻿using Hl7.Fhir.Model;

namespace GaTech.Chai.UsCore
{
    /// <summary>
    /// Class with Location extensions for Us Core Location profile.
    /// http://hl7.org/fhir/us/core/StructureDefinition/us-core-practitioner
    /// </summary>
    public static class UsCoreLocationExtensions
    {
        public static UsCoreLocation UsCoreLocation(this Location location)
        {
            return new UsCoreLocation(location);
        }
    }
}
