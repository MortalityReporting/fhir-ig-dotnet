using System;
using Hl7.Fhir.Model;
using GaTech.Chai.FhirIg.Extensions;
using GaTech.Chai.UsPublicHealth.PatientProfile;
using GaTech.Chai.UsCore.PatientProfile;

namespace GaTech.Chai.UsCbs.PatientProfile
{
    /// <summary>
    /// Case Based Surveillance Patient Profile Extensions
    /// http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-patient
    /// </summary>
    public class UsCbsPatient
    {
        readonly Patient patient;

        internal UsCbsPatient(Patient p)
        {
            this.patient = p;
            p.UsPublicHealthPatient().AddProfile();
        }

        /// <summary>
        /// Factory for Case Based Surveillance Patient Profile
        /// http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-patient
        /// </summary>
        public static Patient Create()
        {
            var patient = new Patient();
            patient.UsCbsPatient().AddProfile();
            return patient;
        }

        /// <summary>
        /// The official URL for the Case Based Surveillance Patient profile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://cbsig.chai.gatech.edu/StructureDefinition/us-cbs-patient";

        /// <summary>
        /// Set the assertion that a patient object conforms to the Case Based Surveillance Patient Profile.
        /// </summary>
        public void AddProfile()
        {
            patient.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear the assertion that a patient object conforms to the Case Based Surveillance Patient Profile.
        /// </summary>
        public void RemoveProfile()
        {
            patient.RemoveProfile(ProfileUrl);
        }

        /// <summary>
        /// Sex (MFU) (2.16.840.1.114222.4.11.1038)
        /// Constrained list of sex codes in use by public health
        /// </summary>
        public static class Sex
        {
            public const string ValueSetOid = "urn:oid:2.16.840.1.114222.4.11.1038";

            public static CodeableConcept Female => Encode("F", "Female");
            public static CodeableConcept Male => Encode("M", "Male");
            public static CodeableConcept Unknown => Encode("U", "Unknown");
            public static CodeableConcept Encode(string value, string display) => new CodeableConcept(ValueSetOid, value, display, null);
        }
    }
}