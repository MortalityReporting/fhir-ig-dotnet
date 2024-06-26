﻿using System;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Share
{
    /// <summary>
    /// DataAbsentReason extension for Address
    /// </summary>
    public static class FhirAddressDataAbsentReasonExtensions
    {
        public static void AddDataAbsentReason(this Address address, Code code)
        {
            address.Extension.AddOrUpdateExtension(
                    "http://hl7.org/fhir/StructureDefinition/data-absent-reason", code);
        }

        public static Code GetDataAbsentReason(this Address address)
        {
            return address.GetExtension("http://hl7.org/fhir/StructureDefinition/data-absent-reason")?.Value as Code;
        }
    }
}
