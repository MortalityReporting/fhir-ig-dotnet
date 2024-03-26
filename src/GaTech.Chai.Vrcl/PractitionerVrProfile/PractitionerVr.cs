﻿using System;
using GaTech.Chai.Share.Extensions;
using GaTech.Chai.UsCore.PractitionerProfile;
using GaTech.Chai.Vrcl.Extensions;
using GaTech.Chai.Vrcl.PatientVrProfile;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Vrcl.PractitionerVrProfile
{
	public class PractitionerVr
	{
		readonly Practitioner practitioner;

		internal PractitionerVr(Practitioner practitioner)
		{
			this.practitioner = practitioner;
		}

        public static Practitioner Create()
        {
            var practitioner = new Practitioner();
            practitioner.PractitionerVr().AddProfile();

            return practitioner;
        }

        public const string ProfileUrl = "http://hl7.org/fhir/us/vr-common-library/StructureDefinition/Practitioner-vr";

        public void AddProfile()
        {
            this.practitioner.AddProfile(ProfileUrl);
        }

        public void RemoveProfile()
        {
            this.practitioner.RemoveProfile(ProfileUrl);
        }

        public string NPI
        {
            set
            {
                this.practitioner.UsCorePractitioner().NPI = value;
            }

            get
            {
                return this.practitioner.UsCorePractitioner().NPI;
            }
        }

        public string NameText
        {
            set
            {
                if (this.practitioner.Name.Count > 0)
                {
                    this.practitioner.Name[0].Text = value;
                }
                else
                {
                    this.practitioner.Name.Add(new HumanName() { Text = value });
                }
            }

            get
            {
                if (this.practitioner.Name.Count > 0)
                {
                    return this.practitioner.Name[0].Text;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

