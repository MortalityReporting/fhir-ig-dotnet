﻿using GaTech.Chai.Share;
using Hl7.Fhir.Model;

namespace GaTech.Chai.UsCore
{
    /// <summary>
    /// Us Core LabResultObservation Profile
    /// http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab
    /// </summary>
    public class UsCoreLabResultObservation
    {
        readonly Observation observation;

        internal UsCoreLabResultObservation(Observation observation)
        {
            this.observation = observation;
        }

        /// <summary>
        /// Factory for Us Core LabResultObservation Profile
        /// http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab
        /// </summary>
        public static Observation Create()
        {
            var observation = new Observation();
            observation.Category.SetCategory(new Coding("http://terminology.hl7.org/CodeSystem/observation-category", "laboratory", "Laboratory"));

            return observation;
        }

        /// <summary>
        /// The official URL for the Us Core LabResultObservation Profile, used to assert conformance.
        /// </summary>
        public const string ProfileUrl = "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab";

        /// <summary>
        /// Set profile for Us Core LabResultObservation Profile
        /// </summary>
        public void AddProfile()
        {
            this.observation.AddProfile(ProfileUrl);
        }

        /// <summary>
        /// Clear profile for Us Core LabResultObservation Profile
        /// </summary>
        public void RemoveProfile()
        {
            this.observation.RemoveProfile(ProfileUrl);
        }
    }
}
