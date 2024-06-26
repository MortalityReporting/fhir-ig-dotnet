﻿using Hl7.Fhir.Model;

namespace GaTech.Chai.UsCore
{
    /// <summary>
    /// Class with Practitioner extensions for US Core Practitioner Profile
    /// http://hl7.org/fhir/us/core/StructureDefinition/us-core-practitioner
    /// </summary>
    public static class UsCorePractitionerExtensions
    {
        public static UsCorePractitioner UsCorePractitioner(this Practitioner practitioner)
        {
            return new UsCorePractitioner(practitioner);
        }
    }
}
