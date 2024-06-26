﻿using Hl7.Fhir.Model;

namespace GaTech.Chai.Mdi
{
    /// <summary>
    /// Class with Bundle extensions for BundleMessageToxicologyToMdiProfile
    /// http://hl7.org/fhir/us/mdi/StructureDefinition/Bundle-message-tox-to-mdi
    /// </summary>
    public static class BundleMessageToxicologyToMdiExtensions
    {
        public static BundleMessageToxicologyToMdi BundleMessageToxicologyToMdi(this Bundle bundle)
        {
            return new BundleMessageToxicologyToMdi(bundle);
        }
    }
}
