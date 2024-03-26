﻿using System;
using Hl7.Fhir.Model;

namespace GaTech.Chai.Vrcl.PatientVrProfile
{
	public static class PatientVrExtensions
	{
		public static PatientVr PatientVr(this Patient patient)
		{
			return new PatientVr(patient);
		}
	}
}

